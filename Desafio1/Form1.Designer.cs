namespace Desafio1
{
    partial class FormWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerWelcome = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // timerWelcome
            // 
            timerWelcome.Enabled = true;
            timerWelcome.Interval = 15000;
            timerWelcome.Tick += timerWelcome_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(265, 112);
            label2.Name = "label2";
            label2.Size = new Size(615, 32);
            label2.TabIndex = 3;
            label2.Text = "ESPERE UN MOMENTO MIENTRAS CARGAN LOS RECURSOS⏳";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(418, 23);
            label1.Name = "label1";
            label1.Size = new Size(322, 67);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 28, 65);
            BackgroundImage = Properties.Resources.C_;
            ClientSize = new Size(1136, 604);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "FormWelcome";
            Text = "FormWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerWelcome;
        private Label label2;
        private Label label1;
    }
}