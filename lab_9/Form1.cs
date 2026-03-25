using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace lab_9
{
    public partial class Form1 : Form
    {
        private const decimal BusFare = 8.00m;
        private const decimal TrolleybusFare = 7.00m;
        private const decimal MetroFare = 6.00m;
        private const decimal PrivilegedDiscount = 0.5m; // 50% off

        private readonly string DataFilePath = Path.Combine(Application.StartupPath, "data.json");

        public Form1()
        {
            InitializeComponent();
            SetInputMode(useFile: chkUseFile.Checked);
        }

        private void chkUseFile_CheckedChanged(object sender, EventArgs e)
        {
            SetInputMode(useFile: chkUseFile.Checked);
        }

        private void SetInputMode(bool useFile)
        {
            groupBoxTransport.Visible = useFile;
            radioBus.Checked = false;
            radioTrolley.Checked = false;
            radioMetro.Checked = false;

            lblTransportManual.Visible = !useFile;
            txtTransport.Visible = !useFile;
            chkPrivilegedManual.Visible = !useFile;

            chkPrivileged.Visible = useFile;
            chkPrivileged.Enabled = useFile;
            chkPrivileged.Checked = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string transportInput;
            bool privileged;

            if (chkUseFile.Checked)
            {
                if (!radioBus.Checked && !radioTrolley.Checked && !radioMetro.Checked)
                {
                    MessageBox.Show("Будь ласка, виберіть тип транспорту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!File.Exists(DataFilePath))
                {
                    MessageBox.Show("Файл з даними не знайдено: " + DataFilePath, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ReadFromJsonFile(GetSelectedTransportName(), out transportInput, out privileged);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося прочитати файл: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                transportInput = (txtTransport.Text ?? string.Empty).Trim();
                privileged = chkPrivilegedManual.Checked;

                if (string.IsNullOrWhiteSpace(transportInput))
                {
                    MessageBox.Show("Будь ласка, введіть тип транспорту у текстове поле.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            TransportType? transportType = ParseTransport(transportInput);
            if (!transportType.HasValue)
            {
                MessageBox.Show("Невідомий тип транспорту: " + transportInput + Environment.NewLine + "Дозволені значення: Bus, Trolleybus, Metro", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fare = GetFareByType(transportType.Value);
            if (privileged)
            {
                fare = fare * (1 - PrivilegedDiscount);
            }

            var dataItem = new FareData
            {
                Transport = transportType.Value.ToString(),
                Privileged = privileged,
                CalculatedFare = Math.Round(fare, 2)
            };

            try
            {
                SaveDataToJson(dataItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалося записати файл: " + ex.Message, "Помилка запису", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblResult.Text = $"Результат: {dataItem.CalculatedFare:F2} UAH (Transport: {dataItem.Transport}, Privileged: {dataItem.Privileged})";

            try
            {
                string json = File.ReadAllText(DataFilePath);
                MessageBox.Show("Дані збережено у файл:\n" + DataFilePath + "\n\n" + json, "Збережено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        private enum TransportType
        {
            Bus,
            Trolleybus,
            Metro
        }

        private TransportType? ParseTransport(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            string s = input.Trim().ToLowerInvariant();
            switch (s)
            {
                case "bus":
                case "автобус":
                    return TransportType.Bus;
                case "trolleybus":
                case "trolley":
                case "тролейбус":
                    return TransportType.Trolleybus;
                case "metro":
                case "метро":
                    return TransportType.Metro;
                default:
                    return null;
            }
        }

        private decimal GetFareByType(TransportType t)
        {
            switch (t)
            {
                case TransportType.Bus: return BusFare;
                case TransportType.Trolleybus: return TrolleybusFare;
                case TransportType.Metro: return MetroFare;
                default: return BusFare;
            }
        }

        private string GetSelectedTransportName()
        {
            if (radioBus.Checked) return "Bus";
            if (radioTrolley.Checked) return "Trolleybus";
            if (radioMetro.Checked) return "Metro";
            return "Unknown";
        }

        private void ReadFromJsonFile(string selectedTransport, out string transport, out bool privileged)
        {
            transport = selectedTransport;
            privileged = false;

            string json = File.ReadAllText(DataFilePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            VehiclesContainer container = JsonSerializer.Deserialize<VehiclesContainer>(json, options) ?? new VehiclesContainer();

            if (container.vehicles != null)
            {
                foreach (var v in container.vehicles)
                {
                    if (string.Equals(v.Transport, selectedTransport, StringComparison.OrdinalIgnoreCase))
                    {
                        transport = v.Transport;
                        privileged = v.Privileged;
                        return;
                    }
                }
            }
        }

        private void SaveDataToJson(FareData item)
        {
            VehiclesContainer container = null;
            var options = new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true };

            if (File.Exists(DataFilePath))
            {
                try
                {
                    string existingJson = File.ReadAllText(DataFilePath);
                    container = JsonSerializer.Deserialize<VehiclesContainer>(existingJson, options);
                }
                catch
                {
                    container = null;
                }
            }

            if (container == null)
                container = new VehiclesContainer();

            if (container.vehicles == null)
                container.vehicles = new List<FareData>();

            bool updated = false;
            for (int i = 0; i < container.vehicles.Count; i++)
            {
                if (string.Equals(container.vehicles[i].Transport, item.Transport, StringComparison.OrdinalIgnoreCase))
                {
                    container.vehicles[i].Privileged = item.Privileged;
                    container.vehicles[i].CalculatedFare = item.CalculatedFare;
                    updated = true;
                    break;
                }
            }
            if (!updated)
                container.vehicles.Add(item);

            EnsureTransportExists(container, TransportType.Bus, BusFare);
            EnsureTransportExists(container, TransportType.Trolleybus, TrolleybusFare);
            EnsureTransportExists(container, TransportType.Metro, MetroFare);

            string outJson = JsonSerializer.Serialize(container, options);
            File.WriteAllText(DataFilePath, outJson);
        }

        private void EnsureTransportExists(VehiclesContainer container, TransportType type, decimal baseFare)
        {
            string name = type.ToString();
            foreach (var v in container.vehicles)
            {
                if (string.Equals(v.Transport, name, StringComparison.OrdinalIgnoreCase))
                    return;
            }

            container.vehicles.Add(new FareData
            {
                Transport = name,
                Privileged = false,
                CalculatedFare = Math.Round(baseFare, 2)
            });
        }

        private class VehiclesContainer
        {
            public List<FareData> vehicles { get; set; }
        }

        private class FareData
        {
            public string Transport { get; set; }
            public bool Privileged { get; set; }
            public decimal CalculatedFare { get; set; }
        }
    }
}
