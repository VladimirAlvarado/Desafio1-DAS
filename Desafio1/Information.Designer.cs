namespace Desafio1
{
    partial class FormInformation
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
            tabControlInfo = new TabControl();
            tabPage1 = new TabPage();
            lblEpisodios = new Label();
            lblTemporada = new Label();
            lblOrigen = new Label();
            lblCountry = new Label();
            lblSocialNum = new Label();
            lblSocial = new Label();
            pictureBoxSocial = new PictureBox();
            tabPage2 = new TabPage();
            lblEpisod = new Label();
            lblTemp = new Label();
            lblOrigen2 = new Label();
            lblP = new Label();
            lblnumS = new Label();
            lblStreaming = new Label();
            pictureBoxStreming = new PictureBox();
            tabPage3 = new TabPage();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControlInfo.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSocial).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreming).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControlInfo
            // 
            tabControlInfo.Controls.Add(tabPage1);
            tabControlInfo.Controls.Add(tabPage2);
            tabControlInfo.Controls.Add(tabPage3);
            tabControlInfo.Location = new Point(12, 26);
            tabControlInfo.Name = "tabControlInfo";
            tabControlInfo.SelectedIndex = 0;
            tabControlInfo.Size = new Size(927, 521);
            tabControlInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblEpisodios);
            tabPage1.Controls.Add(lblTemporada);
            tabPage1.Controls.Add(lblOrigen);
            tabPage1.Controls.Add(lblCountry);
            tabPage1.Controls.Add(lblSocialNum);
            tabPage1.Controls.Add(lblSocial);
            tabPage1.Controls.Add(pictureBoxSocial);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(919, 493);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblEpisodios
            // 
            lblEpisodios.AutoSize = true;
            lblEpisodios.BackColor = Color.Transparent;
            lblEpisodios.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEpisodios.Location = new Point(21, 340);
            lblEpisodios.Name = "lblEpisodios";
            lblEpisodios.Size = new Size(157, 45);
            lblEpisodios.TabIndex = 6;
            lblEpisodios.Text = "episodios";
            // 
            // lblTemporada
            // 
            lblTemporada.AutoSize = true;
            lblTemporada.BackColor = Color.Transparent;
            lblTemporada.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemporada.Location = new Point(21, 271);
            lblTemporada.Name = "lblTemporada";
            lblTemporada.Size = new Size(194, 45);
            lblTemporada.TabIndex = 5;
            lblTemporada.Text = "temporadas";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BackColor = Color.Transparent;
            lblOrigen.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrigen.Location = new Point(21, 201);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(226, 45);
            lblOrigen.TabIndex = 4;
            lblOrigen.Text = "pais de origen";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.BackColor = Color.Transparent;
            lblCountry.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblCountry.Location = new Point(21, 138);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(187, 45);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "creado por:";
            // 
            // lblSocialNum
            // 
            lblSocialNum.AutoSize = true;
            lblSocialNum.BackColor = Color.Transparent;
            lblSocialNum.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocialNum.Location = new Point(21, 73);
            lblSocialNum.Name = "lblSocialNum";
            lblSocialNum.Size = new Size(265, 45);
            lblSocialNum.TabIndex = 2;
            lblSocialNum.Text = "titulo en español";
            lblSocialNum.Click += lblSocialNum_Click;
            // 
            // lblSocial
            // 
            lblSocial.AutoSize = true;
            lblSocial.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSocial.Location = new Point(380, 5);
            lblSocial.Name = "lblSocial";
            lblSocial.Size = new Size(118, 37);
            lblSocial.TabIndex = 0;
            lblSocial.Text = "nombre";
            // 
            // pictureBoxSocial
            // 
            pictureBoxSocial.Location = new Point(6, 45);
            pictureBoxSocial.Name = "pictureBoxSocial";
            pictureBoxSocial.Size = new Size(907, 442);
            pictureBoxSocial.TabIndex = 1;
            pictureBoxSocial.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblEpisod);
            tabPage2.Controls.Add(lblTemp);
            tabPage2.Controls.Add(lblOrigen2);
            tabPage2.Controls.Add(lblP);
            tabPage2.Controls.Add(lblnumS);
            tabPage2.Controls.Add(lblStreaming);
            tabPage2.Controls.Add(pictureBoxStreming);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(919, 493);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // lblEpisod
            // 
            lblEpisod.AutoSize = true;
            lblEpisod.BackColor = Color.Transparent;
            lblEpisod.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblEpisod.Location = new Point(18, 334);
            lblEpisod.Name = "lblEpisod";
            lblEpisod.Size = new Size(157, 45);
            lblEpisod.TabIndex = 10;
            lblEpisod.Text = "Episodios";
            lblEpisod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.BackColor = Color.Transparent;
            lblTemp.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTemp.Location = new Point(18, 266);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(197, 45);
            lblTemp.TabIndex = 9;
            lblTemp.Text = "Temporadas";
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.BackColor = Color.Transparent;
            lblOrigen2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrigen2.Location = new Point(18, 197);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(226, 45);
            lblOrigen2.TabIndex = 8;
            lblOrigen2.Text = "pais de origen";
            // 
            // lblP
            // 
            lblP.AutoSize = true;
            lblP.BackColor = Color.Transparent;
            lblP.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblP.Location = new Point(18, 128);
            lblP.Name = "lblP";
            lblP.Size = new Size(178, 45);
            lblP.TabIndex = 7;
            lblP.Text = "creado por";
            lblP.Click += lblP_Click;
            // 
            // lblnumS
            // 
            lblnumS.AutoSize = true;
            lblnumS.BackColor = Color.Transparent;
            lblnumS.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblnumS.Location = new Point(18, 64);
            lblnumS.Name = "lblnumS";
            lblnumS.Size = new Size(265, 45);
            lblnumS.TabIndex = 6;
            lblnumS.Text = "titulo en español";
            // 
            // lblStreaming
            // 
            lblStreaming.AutoSize = true;
            lblStreaming.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStreaming.Location = new Point(393, 3);
            lblStreaming.Name = "lblStreaming";
            lblStreaming.Size = new Size(118, 37);
            lblStreaming.TabIndex = 4;
            lblStreaming.Text = "nombre";
            // 
            // pictureBoxStreming
            // 
            pictureBoxStreming.Location = new Point(0, 43);
            pictureBoxStreming.Name = "pictureBoxStreming";
            pictureBoxStreming.Size = new Size(919, 450);
            pictureBoxStreming.TabIndex = 5;
            pictureBoxStreming.TabStop = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(pictureBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(919, 493);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(289, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 1;
            label1.Text = "DATOS ESTADISTICOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(139, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 428);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 28, 65);
            ClientSize = new Size(991, 623);
            Controls.Add(tabControlInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            Load += FormInformation_Load;
            tabControlInfo.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSocial).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStreming).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlInfo;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label lblSocialNum;
        private PictureBox pictureBoxSocial;
        private Label lblSocial;
        private Label lblCountry;
        private Label lblP;
        private Label lblnumS;
        private Label lblStreaming;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblOrigen;
        private Label lblEpisodios;
        private Label lblTemporada;
        private Label lblOrigen2;
        private Label lblEpisod;
        private Label lblTemp;
        private PictureBox pictureBoxStreming;
    }
}