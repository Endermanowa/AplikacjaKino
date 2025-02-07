namespace AplikacjaKino
{
    partial class NowySeans
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
            panel2 = new Panel();
            buttonSelectFilm = new Button();
            panel3 = new Panel();
            label1 = new Label();
            textFilm = new TextBox();
            panel1 = new Panel();
            buttonSelectSala = new Button();
            panel9 = new Panel();
            label8 = new Label();
            textSala = new TextBox();
            panel8 = new Panel();
            label6 = new Label();
            textGodzina = new DateTimePicker();
            panel6 = new Panel();
            label7 = new Label();
            textData = new DateTimePicker();
            panel5 = new Panel();
            label5 = new Label();
            textTyp = new TextBox();
            panel4 = new Panel();
            label4 = new Label();
            textJęzyk = new TextBox();
            buttonAdd = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(buttonSelectFilm);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(171, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(353, 31);
            panel2.TabIndex = 40;
            // 
            // buttonSelectFilm
            // 
            buttonSelectFilm.Dock = DockStyle.Right;
            buttonSelectFilm.Font = new Font("Segoe UI", 10F);
            buttonSelectFilm.Location = new Point(201, 0);
            buttonSelectFilm.Name = "buttonSelectFilm";
            buttonSelectFilm.Size = new Size(152, 31);
            buttonSelectFilm.TabIndex = 26;
            buttonSelectFilm.Text = "Wybierz film";
            buttonSelectFilm.UseVisualStyleBackColor = true;
            buttonSelectFilm.Click += buttonSelectFilm_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textFilm);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 31);
            panel3.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 28);
            label1.TabIndex = 12;
            label1.Text = "Film:";
            // 
            // textFilm
            // 
            textFilm.Dock = DockStyle.Right;
            textFilm.Location = new Point(57, 0);
            textFilm.Name = "textFilm";
            textFilm.ReadOnly = true;
            textFilm.Size = new Size(134, 27);
            textFilm.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(buttonSelectSala);
            panel1.Controls.Add(panel9);
            panel1.Location = new Point(171, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 31);
            panel1.TabIndex = 39;
            // 
            // buttonSelectSala
            // 
            buttonSelectSala.Dock = DockStyle.Right;
            buttonSelectSala.Font = new Font("Segoe UI", 10F);
            buttonSelectSala.Location = new Point(201, 0);
            buttonSelectSala.Name = "buttonSelectSala";
            buttonSelectSala.Size = new Size(152, 31);
            buttonSelectSala.TabIndex = 26;
            buttonSelectSala.Text = "Wybierz salę";
            buttonSelectSala.UseVisualStyleBackColor = true;
            buttonSelectSala.Click += buttonSelectSala_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(label8);
            panel9.Controls.Add(textSala);
            panel9.Dock = DockStyle.Left;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(191, 31);
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
            label8.Size = new Size(52, 28);
            label8.TabIndex = 12;
            label8.Text = "Sala:";
            // 
            // textSala
            // 
            textSala.Dock = DockStyle.Right;
            textSala.Location = new Point(57, 0);
            textSala.Name = "textSala";
            textSala.ReadOnly = true;
            textSala.Size = new Size(134, 27);
            textSala.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.Controls.Add(label6);
            panel8.Controls.Add(textGodzina);
            panel8.Location = new Point(375, 196);
            panel8.Name = "panel8";
            panel8.Size = new Size(178, 29);
            panel8.TabIndex = 44;
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
            // textGodzina
            // 
            textGodzina.CustomFormat = "HH:mm";
            textGodzina.Dock = DockStyle.Right;
            textGodzina.Format = DateTimePickerFormat.Custom;
            textGodzina.Location = new Point(92, 0);
            textGodzina.Name = "textGodzina";
            textGodzina.ShowUpDown = true;
            textGodzina.Size = new Size(86, 27);
            textGodzina.TabIndex = 4;
            textGodzina.Value = new DateTime(2024, 6, 14, 0, 0, 0, 0);
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textData);
            panel6.Location = new Point(142, 196);
            panel6.Name = "panel6";
            panel6.Size = new Size(204, 31);
            panel6.TabIndex = 43;
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
            // textData
            // 
            textData.Dock = DockStyle.Right;
            textData.Format = DateTimePickerFormat.Custom;
            textData.Location = new Point(58, 0);
            textData.Name = "textData";
            textData.Size = new Size(146, 27);
            textData.TabIndex = 1;
            textData.Value = new DateTime(2024, 6, 14, 0, 0, 0, 0);
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textTyp);
            panel5.Location = new Point(188, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(104, 30);
            panel5.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(47, 28);
            label5.TabIndex = 8;
            label5.Text = "Typ:";
            // 
            // textTyp
            // 
            textTyp.Dock = DockStyle.Right;
            textTyp.Location = new Point(47, 0);
            textTyp.Name = "textTyp";
            textTyp.PlaceholderText = "2D, 3D";
            textTyp.Size = new Size(57, 27);
            textTyp.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textJęzyk);
            panel4.Location = new Point(314, 260);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 27);
            panel4.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 28);
            label4.TabIndex = 7;
            label4.Text = "Język:";
            // 
            // textJęzyk
            // 
            textJęzyk.Dock = DockStyle.Right;
            textJęzyk.Location = new Point(62, 0);
            textJęzyk.Name = "textJęzyk";
            textJęzyk.PlaceholderText = "DUBBING, NAPISY";
            textJęzyk.Size = new Size(130, 27);
            textJęzyk.TabIndex = 3;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Font = new Font("Segoe UI", 10F);
            buttonAdd.Location = new Point(300, 354);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 45;
            buttonAdd.Text = "Potwierdź";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // NowySeans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 450);
            Controls.Add(buttonAdd);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NowySeans";
            Text = "Nowy seans";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button buttonSelectFilm;
        private Panel panel3;
        private Label label1;
        private TextBox textFilm;
        private Panel panel1;
        private Button buttonSelectSala;
        private Panel panel9;
        private Label label8;
        private TextBox textSala;
        private Panel panel8;
        private Label label6;
        private DateTimePicker textGodzina;
        private Panel panel6;
        private Label label7;
        private DateTimePicker textData;
        private Panel panel5;
        private Label label5;
        private TextBox textTyp;
        private Panel panel4;
        private Label label4;
        private TextBox textJęzyk;
        private Button buttonAdd;
    }
}