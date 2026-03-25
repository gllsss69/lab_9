namespace lab_9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.CheckBox chkUseFile;
        private System.Windows.Forms.GroupBox groupBoxTransport;
        private System.Windows.Forms.RadioButton radioBus;
        private System.Windows.Forms.RadioButton radioTrolley;
        private System.Windows.Forms.RadioButton radioMetro;
        private System.Windows.Forms.Label lblTransportManual;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.CheckBox chkPrivilegedManual;
        private System.Windows.Forms.CheckBox chkPrivileged;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chkUseFile = new System.Windows.Forms.CheckBox();
            this.groupBoxTransport = new System.Windows.Forms.GroupBox();
            this.radioMetro = new System.Windows.Forms.RadioButton();
            this.radioTrolley = new System.Windows.Forms.RadioButton();
            this.radioBus = new System.Windows.Forms.RadioButton();
            this.lblTransportManual = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.chkPrivilegedManual = new System.Windows.Forms.CheckBox();
            this.chkPrivileged = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBoxTransport.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUseFile
            // 
            this.chkUseFile.AutoSize = true;
            this.chkUseFile.Location = new System.Drawing.Point(12, 12);
            this.chkUseFile.Name = "chkUseFile";
            this.chkUseFile.Size = new System.Drawing.Size(100, 17);
            this.chkUseFile.TabIndex = 0;
            this.chkUseFile.Text = "Читати з файлу";
            this.chkUseFile.UseVisualStyleBackColor = true;
            this.chkUseFile.CheckedChanged += new System.EventHandler(this.chkUseFile_CheckedChanged);
            // 
            // groupBoxTransport
            // 
            this.groupBoxTransport.Controls.Add(this.radioMetro);
            this.groupBoxTransport.Controls.Add(this.radioTrolley);
            this.groupBoxTransport.Controls.Add(this.radioBus);
            this.groupBoxTransport.Location = new System.Drawing.Point(12, 40);
            this.groupBoxTransport.Name = "groupBoxTransport";
            this.groupBoxTransport.Size = new System.Drawing.Size(384, 160);
            this.groupBoxTransport.TabIndex = 1;
            this.groupBoxTransport.TabStop = false;
            this.groupBoxTransport.Text = "Тип транспорту";
            this.groupBoxTransport.Visible = false;
            // 
            // radioMetro
            // 
            this.radioMetro.AutoSize = true;
            this.radioMetro.Location = new System.Drawing.Point(16, 120);
            this.radioMetro.Name = "radioMetro";
            this.radioMetro.Size = new System.Drawing.Size(58, 17);
            this.radioMetro.TabIndex = 2;
            this.radioMetro.TabStop = true;
            this.radioMetro.Text = "Metro";
            this.radioMetro.UseVisualStyleBackColor = true;
            // 
            // radioTrolley
            // 
            this.radioTrolley.AutoSize = true;
            this.radioTrolley.Location = new System.Drawing.Point(16, 80);
            this.radioTrolley.Name = "radioTrolley";
            this.radioTrolley.Size = new System.Drawing.Size(84, 17);
            this.radioTrolley.TabIndex = 1;
            this.radioTrolley.TabStop = true;
            this.radioTrolley.Text = "Trolleybus";
            this.radioTrolley.UseVisualStyleBackColor = true;
            // 
            // radioBus
            // 
            this.radioBus.AutoSize = true;
            this.radioBus.Location = new System.Drawing.Point(16, 40);
            this.radioBus.Name = "radioBus";
            this.radioBus.Size = new System.Drawing.Size(46, 17);
            this.radioBus.TabIndex = 0;
            this.radioBus.TabStop = true;
            this.radioBus.Text = "Bus";
            this.radioBus.UseVisualStyleBackColor = true;
            // 
            // lblTransportManual
            // 
            this.lblTransportManual.AutoSize = true;
            this.lblTransportManual.Location = new System.Drawing.Point(12, 40);
            this.lblTransportManual.Name = "lblTransportManual";
            this.lblTransportManual.Size = new System.Drawing.Size(92, 13);
            this.lblTransportManual.TabIndex = 2;
            this.lblTransportManual.Text = "Тип транспорту:";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(110, 37);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(286, 20);
            this.txtTransport.TabIndex = 3;
            // 
            // chkPrivilegedManual
            // 
            this.chkPrivilegedManual.AutoSize = true;
            this.chkPrivilegedManual.Location = new System.Drawing.Point(12, 65);
            this.chkPrivilegedManual.Name = "chkPrivilegedManual";
            this.chkPrivilegedManual.Size = new System.Drawing.Size(143, 17);
            this.chkPrivilegedManual.TabIndex = 4;
            this.chkPrivilegedManual.Text = "Пільговий квиток (50%)";
            this.chkPrivilegedManual.UseVisualStyleBackColor = true;
            // 
            // chkPrivileged
            // 
            this.chkPrivileged.AutoSize = true;
            this.chkPrivileged.Location = new System.Drawing.Point(12, 212);
            this.chkPrivileged.Name = "chkPrivileged";
            this.chkPrivileged.Size = new System.Drawing.Size(143, 17);
            this.chkPrivileged.TabIndex = 5;
            this.chkPrivileged.Text = "Пільговий квиток (50%)";
            this.chkPrivileged.UseVisualStyleBackColor = true;
            this.chkPrivileged.Visible = false;
            this.chkPrivileged.Enabled = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 210);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(384, 36);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Розрахувати вартість";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(12, 256);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(384, 88);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Результат: ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 360);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkPrivileged);
            this.Controls.Add(this.chkPrivilegedManual);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.lblTransportManual);
            this.Controls.Add(this.groupBoxTransport);
            this.Controls.Add(this.chkUseFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.Name = "Form1";
            this.Text = "Сервіс розрахунку проїзду";
            this.groupBoxTransport.ResumeLayout(false);
            this.groupBoxTransport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

