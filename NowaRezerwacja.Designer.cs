namespace AplikacjaKino
{
    partial class NowaRezerwacja
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
            buttonSelectSeans = new Button();
            panel1 = new Panel();
            buttonSelectMiejsca = new Button();
            panel9 = new Panel();
            label8 = new Label();
            textMiejsca = new TextBox();
            panel8 = new Panel();
            textGodzina = new TextBox();
            label6 = new Label();
            panel7 = new Panel();
            textLiczbaBiletow = new NumericUpDown();
            label9 = new Label();
            panel6 = new Panel();
            textData = new TextBox();
            label7 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            textKino = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            textFilm = new TextBox();
            buttonAdd = new Button();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textLiczbaBiletow).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSelectSeans
            // 
            buttonSelectSeans.Anchor = AnchorStyles.None;
            buttonSelectSeans.Font = new Font("Segoe UI", 13F);
            buttonSelectSeans.Location = new Point(284, 15);
            buttonSelectSeans.Name = "buttonSelectSeans";
            buttonSelectSeans.Size = new Size(205, 45);
            buttonSelectSeans.TabIndex = 35;
            buttonSelectSeans.Text = "Wybierz seans";
            buttonSelectSeans.UseVisualStyleBackColor = true;
            buttonSelectSeans.Click += buttonSelectSeans_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(buttonSelectMiejsca);
            panel1.Controls.Add(panel9);
            panel1.Location = new Point(150, 332);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 31);
            panel1.TabIndex = 34;
            // 
            // buttonSelectMiejsca
            // 
            buttonSelectMiejsca.Dock = DockStyle.Right;
            buttonSelectMiejsca.Font = new Font("Segoe UI", 10F);
            buttonSelectMiejsca.Location = new Point(348, 0);
            buttonSelectMiejsca.Name = "buttonSelectMiejsca";
            buttonSelectMiejsca.Size = new Size(152, 31);
            buttonSelectMiejsca.TabIndex = 26;
            buttonSelectMiejsca.Text = "Wybierz miejsca";
            buttonSelectMiejsca.UseVisualStyleBackColor = true;
            buttonSelectMiejsca.Click += buttonSelectMiejsca_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Controls.Add(textMiejsca);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(325, 31);
            panel9.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Dock = DockStyle.Left;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 28);
            label8.TabIndex = 12;
            label8.Text = "Miejsca na sali:";
            // 
            // textMiejsca
            // 
            textMiejsca.Dock = DockStyle.Right;
            textMiejsca.Location = new Point(146, 0);
            textMiejsca.Name = "textMiejsca";
            textMiejsca.ReadOnly = true;
            textMiejsca.Size = new Size(179, 27);
            textMiejsca.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.Controls.Add(textGodzina);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(416, 164);
            panel8.Name = "panel8";
            panel8.Size = new Size(178, 29);
            panel8.TabIndex = 33;
            // 
            // textGodzina
            // 
            textGodzina.Dock = DockStyle.Right;
            textGodzina.Location = new Point(95, 0);
            textGodzina.Name = "textGodzina";
            textGodzina.ReadOnly = true;
            textGodzina.Size = new Size(83, 27);
            textGodzina.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 28);
            label6.TabIndex = 9;
            label6.Text = "Godzina:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.Controls.Add(textLiczbaBiletow);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(302, 251);
            panel7.Name = "panel7";
            panel7.Size = new Size(196, 35);
            panel7.TabIndex = 32;
            // 
            // textLiczbaBiletow
            // 
            textLiczbaBiletow.Dock = DockStyle.Fill;
            textLiczbaBiletow.Location = new Point(140, 0);
            textLiczbaBiletow.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            textLiczbaBiletow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            textLiczbaBiletow.Name = "textLiczbaBiletow";
            textLiczbaBiletow.Size = new Size(56, 27);
            textLiczbaBiletow.TabIndex = 5;
            textLiczbaBiletow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            textLiczbaBiletow.ValueChanged += textLiczbaBiletow_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(140, 28);
            label9.TabIndex = 13;
            label9.Text = "Liczba biletów:";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(textData);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(206, 165);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 31);
            panel6.TabIndex = 31;
            // 
            // textData
            // 
            textData.Dock = DockStyle.Right;
            textData.Location = new Point(63, 0);
            textData.Name = "textData";
            textData.ReadOnly = true;
            textData.Size = new Size(141, 27);
            textData.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Dock = DockStyle.Left;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 28);
            label7.TabIndex = 11;
            label7.Text = "Data:";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textKino);
            panel5.Location = new Point(46, 110);
            panel5.Name = "panel5";
            panel5.Size = new Size(314, 30);
            panel5.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 8;
            label5.Text = "Kino:";
            // 
            // textKino
            // 
            textKino.Dock = DockStyle.Right;
            textKino.Location = new Point(62, 0);
            textKino.Name = "textKino";
            textKino.ReadOnly = true;
            textKino.Size = new Size(252, 27);
            textKino.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textFilm);
            panel4.Location = new Point(386, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 27);
            panel4.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 7;
            label4.Text = "Tytuł filmu:";
            // 
            // textFilm
            // 
            textFilm.Dock = DockStyle.Right;
            textFilm.Location = new Point(113, 0);
            textFilm.Name = "textFilm";
            textFilm.ReadOnly = true;
            textFilm.Size = new Size(256, 27);
            textFilm.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.Location = new Point(353, 406);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 28;
            buttonAdd.Text = "Potwierdź";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // NowaRezerwacja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSelectSeans);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(buttonAdd);
            Name = "NowaRezerwacja";
            Text = "Nowa rezerwacja";
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textLiczbaBiletow).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSelectSeans;
        private Panel panel1;
        private Button buttonSelectMiejsca;
        private Panel panel9;
        private Label label8;
        private TextBox textMiejsca;
        private Panel panel8;
        private TextBox textGodzina;
        private Label label6;
        private Panel panel7;
        private NumericUpDown textLiczbaBiletow;
        private Label label9;
        private Panel panel6;
        private TextBox textData;
        private Label label7;
        private Panel panel5;
        private Label label5;
        private TextBox textKino;
        private Panel panel4;
        private Label label4;
        private TextBox textFilm;
        private Button buttonAdd;
    }
}