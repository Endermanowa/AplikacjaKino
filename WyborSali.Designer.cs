namespace AplikacjaKino
{
    partial class WyborSali
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitContainer4 = new SplitContainer();
            label1 = new Label();
            splitContainer2 = new SplitContainer();
            listViewLokalizacje = new ListView();
            buttonSelectLokalizacja = new Button();
            splitContainer5 = new SplitContainer();
            label2 = new Label();
            splitContainer1 = new SplitContainer();
            listViewSale = new ListView();
            buttonSelectSala = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(splitContainer4);
            flowLayoutPanel1.Controls.Add(splitContainer5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(797, 583);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Location = new Point(3, 3);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer2);
            splitContainer4.Size = new Size(442, 572);
            splitContainer4.SplitterDistance = 76;
            splitContainer4.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(154, 21);
            label1.Name = "label1";
            label1.Size = new Size(134, 35);
            label1.TabIndex = 0;
            label1.Text = "Lokalizacje";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listViewLokalizacje);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonSelectLokalizacja);
            splitContainer2.Size = new Size(442, 492);
            splitContainer2.SplitterDistance = 424;
            splitContainer2.TabIndex = 3;
            // 
            // listViewLokalizacje
            // 
            listViewLokalizacje.Dock = DockStyle.Fill;
            listViewLokalizacje.FullRowSelect = true;
            listViewLokalizacje.Location = new Point(0, 0);
            listViewLokalizacje.MultiSelect = false;
            listViewLokalizacje.Name = "listViewLokalizacje";
            listViewLokalizacje.Size = new Size(442, 424);
            listViewLokalizacje.TabIndex = 2;
            listViewLokalizacje.UseCompatibleStateImageBehavior = false;
            listViewLokalizacje.View = View.Details;
            // 
            // buttonSelectLokalizacja
            // 
            buttonSelectLokalizacja.Anchor = AnchorStyles.Bottom;
            buttonSelectLokalizacja.Font = new Font("Segoe UI", 10F);
            buttonSelectLokalizacja.Location = new Point(166, 13);
            buttonSelectLokalizacja.MaximumSize = new Size(140, 80);
            buttonSelectLokalizacja.Name = "buttonSelectLokalizacja";
            buttonSelectLokalizacja.Size = new Size(111, 39);
            buttonSelectLokalizacja.TabIndex = 2;
            buttonSelectLokalizacja.Text = "Wybierz";
            buttonSelectLokalizacja.UseVisualStyleBackColor = true;
            buttonSelectLokalizacja.Click += buttonSelectLokalizacja_Click;
            // 
            // splitContainer5
            // 
            splitContainer5.Location = new Point(451, 3);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label2);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer1);
            splitContainer5.Size = new Size(337, 572);
            splitContainer5.SplitterDistance = 76;
            splitContainer5.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(138, 21);
            label2.Name = "label2";
            label2.Size = new Size(60, 35);
            label2.TabIndex = 1;
            label2.Text = "Sale";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewSale);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonSelectSala);
            splitContainer1.Size = new Size(337, 492);
            splitContainer1.SplitterDistance = 423;
            splitContainer1.TabIndex = 4;
            // 
            // listViewSale
            // 
            listViewSale.Dock = DockStyle.Fill;
            listViewSale.FullRowSelect = true;
            listViewSale.Location = new Point(0, 0);
            listViewSale.MultiSelect = false;
            listViewSale.Name = "listViewSale";
            listViewSale.Size = new Size(337, 423);
            listViewSale.TabIndex = 2;
            listViewSale.UseCompatibleStateImageBehavior = false;
            listViewSale.View = View.Details;
            // 
            // buttonSelectSala
            // 
            buttonSelectSala.Anchor = AnchorStyles.Bottom;
            buttonSelectSala.BackColor = Color.PaleGreen;
            buttonSelectSala.FlatAppearance.BorderColor = Color.Black;
            buttonSelectSala.FlatAppearance.BorderSize = 5;
            buttonSelectSala.Font = new Font("Segoe UI", 12F);
            buttonSelectSala.Location = new Point(81, 8);
            buttonSelectSala.Name = "buttonSelectSala";
            buttonSelectSala.Size = new Size(174, 49);
            buttonSelectSala.TabIndex = 2;
            buttonSelectSala.Text = "Zatwierdź wybór";
            buttonSelectSala.UseVisualStyleBackColor = false;
            buttonSelectSala.Click += buttonSelectSala_Click;
            // 
            // WyborSali
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 583);
            Controls.Add(flowLayoutPanel1);
            Name = "WyborSali";
            Text = "WyborSali";
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer4;
        private Label label1;
        private SplitContainer splitContainer2;
        private ListView listViewLokalizacje;
        private Button buttonSelectLokalizacja;
        private SplitContainer splitContainer5;
        private Label label2;
        private SplitContainer splitContainer1;
        private ListView listViewSale;
        private Button buttonSelectSala;
    }
}