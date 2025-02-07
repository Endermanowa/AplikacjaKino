namespace AplikacjaKino
{
    partial class OknoUżytkownik
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
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Lokalizacje";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "Filmy";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 6;
            tabPage3.Text = "Rezerwacje";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // OknoUżytkownik
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "OknoUżytkownik";
            Text = "Użytkownik";
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private Button buttonCancel;
        private TextBox cancelResNum;
        private Panel panel1;
        private Panel panel2;
        private TextBox printResNum;
        private Button buttonPrint;
        private Label label2;
        private Button buttonAdd;
        private TextBox newFilm;
        private TextBox newKino;
        private TextBox editResNum;
        private Label label3;
        private Panel panel3;
        private Button buttonEditStart;
        private DateTimePicker newGodzina;
        private DateTimePicker newData;
        private NumericUpDown newLiczbaBiletow;
        private TextBox newMiejsca;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label10;
        private TextBox editMiejsca;
        private Panel panel11;
        private Label label11;
        private DateTimePicker editGodzina;
        private Panel panel12;
        private NumericUpDown editLiczbaBiletow;
        private Label label12;
        private Panel panel13;
        private Label label13;
        private DateTimePicker editData;
        private Panel panel14;
        private Label label14;
        private TextBox editKino;
        private Panel panel15;
        private Label label15;
        private TextBox editFilm;
        private Button buttonEditEnd;
    }
}