namespace lab_9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResult = new System.Windows.Forms.Label();
            this.chkPrivileged = new System.Windows.Forms.CheckBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBus = new System.Windows.Forms.RadioButton();
            this.radioTrolley = new System.Windows.Forms.RadioButton();
            this.radioMetro = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(155, 258);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 16);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Результат:";
            // 
            // chkPrivileged
            // 
            this.chkPrivileged.AutoSize = true;
            this.chkPrivileged.Location = new System.Drawing.Point(105, 162);
            this.chkPrivileged.Name = "chkPrivileged";
            this.chkPrivileged.Size = new System.Drawing.Size(231, 20);
            this.chkPrivileged.TabIndex = 1;
            this.chkPrivileged.Text = "Пільговий квиток (50% знижка)";
            this.chkPrivileged.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 188);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 44);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Розрахувати вартість";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioMetro);
            this.groupBox1.Controls.Add(this.radioTrolley);
            this.groupBox1.Controls.Add(this.radioBus);
            this.groupBox1.Location = new System.Drawing.Point(105, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оберіть транспорт:";
            // 
            // radioBus
            // 
            this.radioBus.AutoSize = true;
            this.radioBus.Location = new System.Drawing.Point(6, 21);
            this.radioBus.Name = "radioBus";
            this.radioBus.Size = new System.Drawing.Size(83, 20);
            this.radioBus.TabIndex = 4;
            this.radioBus.TabStop = true;
            this.radioBus.Text = "Автобус";
            this.radioBus.UseVisualStyleBackColor = true;
            // 
            // radioTrolley
            // 
            this.radioTrolley.AutoSize = true;
            this.radioTrolley.Location = new System.Drawing.Point(6, 40);
            this.radioTrolley.Name = "radioTrolley";
            this.radioTrolley.Size = new System.Drawing.Size(100, 20);
            this.radioTrolley.TabIndex = 5;
            this.radioTrolley.TabStop = true;
            this.radioTrolley.Text = "Тролейбус";
            this.radioTrolley.UseVisualStyleBackColor = true;
            // 
            // radioMetro
            // 
            this.radioMetro.AutoSize = true;
            this.radioMetro.Location = new System.Drawing.Point(6, 62);
            this.radioMetro.Name = "radioMetro";
            this.radioMetro.Size = new System.Drawing.Size(70, 20);
            this.radioMetro.TabIndex = 6;
            this.radioMetro.TabStop = true;
            this.radioMetro.Text = "Метро";
            this.radioMetro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 347);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.chkPrivileged);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Сервіс розрахунку проїзду";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkPrivileged;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioMetro;
        private System.Windows.Forms.RadioButton radioTrolley;
        private System.Windows.Forms.RadioButton radioBus;
    }
}

