namespace AplikacjaKino
{
    partial class OknoLogowanie
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
            buttonLogin = new Button();
            label1 = new Label();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBoxImię = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxTelefon = new TextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DeepSkyBlue;
            buttonLogin.Dock = DockStyle.Bottom;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogin.Location = new Point(0, 117);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(312, 53);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Zaloguj się";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(259, 81);
            label1.Name = "label1";
            label1.Size = new Size(283, 39);
            label1.TabIndex = 2;
            label1.Text = "Wprowadź dane";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(244, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 170);
            panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBoxImię);
            flowLayoutPanel1.Controls.Add(textBoxNazwisko);
            flowLayoutPanel1.Controls.Add(textBoxTelefon);
            flowLayoutPanel1.Location = new Point(11, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(291, 104);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // textBoxImię
            // 
            textBoxImię.BackColor = SystemColors.GradientActiveCaption;
            textBoxImię.Location = new Point(3, 3);
            textBoxImię.Name = "textBoxImię";
            textBoxImię.PlaceholderText = "Imię";
            textBoxImię.Size = new Size(284, 27);
            textBoxImię.TabIndex = 5;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.BackColor = SystemColors.GradientActiveCaption;
            textBoxNazwisko.Location = new Point(3, 36);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.PlaceholderText = "Nazwisko";
            textBoxNazwisko.Size = new Size(284, 27);
            textBoxNazwisko.TabIndex = 6;
            // 
            // textBoxTelefon
            // 
            textBoxTelefon.BackColor = SystemColors.GradientActiveCaption;
            textBoxTelefon.Location = new Point(3, 69);
            textBoxTelefon.Name = "textBoxTelefon";
            textBoxTelefon.PlaceholderText = "Numer telefonu";
            textBoxTelefon.Size = new Size(284, 27);
            textBoxTelefon.TabIndex = 7;
            // 
            // OknoLogowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "OknoLogowanie";
            Text = "Logowanie";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxImię;
        private TextBox textBoxNazwisko;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBoxTelefon;
    }
}
