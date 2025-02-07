namespace AplikacjaKino
{
    partial class WyborSeansu
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
            splitContainer1 = new SplitContainer();
            listViewLokalizacje = new ListView();
            buttonSelectLokalizacja = new Button();
            splitContainer5 = new SplitContainer();
            label2 = new Label();
            splitContainer2 = new SplitContainer();
            listViewSeanse = new ListView();
            buttonSelectSeans = new Button();
            splitContainer6 = new SplitContainer();
            label3 = new Label();
            splitContainer3 = new SplitContainer();
            listViewFilmy = new ListView();
            buttonSelectFilm = new Button();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(splitContainer4);
            flowLayoutPanel1.Controls.Add(splitContainer5);
            flowLayoutPanel1.Controls.Add(splitContainer6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1083, 541);
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
            splitContainer4.Panel2.Controls.Add(splitContainer1);
            splitContainer4.Size = new Size(367, 535);
            splitContainer4.SplitterDistance = 72;
            splitContainer4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(116, 19);
            label1.Name = "label1";
            label1.Size = new Size(134, 35);
            label1.TabIndex = 0;
            label1.Text = "Lokalizacje";
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
            splitContainer1.Panel1.Controls.Add(listViewLokalizacje);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonSelectLokalizacja);
            splitContainer1.Size = new Size(367, 459);
            splitContainer1.SplitterDistance = 396;
            splitContainer1.TabIndex = 3;
            // 
            // listViewLokalizacje
            // 
            listViewLokalizacje.Dock = DockStyle.Fill;
            listViewLokalizacje.FullRowSelect = true;
            listViewLokalizacje.Location = new Point(0, 0);
            listViewLokalizacje.MultiSelect = false;
            listViewLokalizacje.Name = "listViewLokalizacje";
            listViewLokalizacje.Size = new Size(367, 396);
            listViewLokalizacje.TabIndex = 2;
            listViewLokalizacje.UseCompatibleStateImageBehavior = false;
            listViewLokalizacje.View = View.Details;
            // 
            // buttonSelectLokalizacja
            // 
            buttonSelectLokalizacja.Anchor = AnchorStyles.Bottom;
            buttonSelectLokalizacja.Font = new Font("Segoe UI", 10F);
            buttonSelectLokalizacja.Location = new Point(128, 11);
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
            splitContainer5.Location = new Point(376, 3);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(label2);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer2);
            splitContainer5.Size = new Size(330, 535);
            splitContainer5.SplitterDistance = 72;
            splitContainer5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(119, 19);
            label2.Name = "label2";
            label2.Size = new Size(92, 35);
            label2.TabIndex = 1;
            label2.Text = "Seanse";
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
            splitContainer2.Panel1.Controls.Add(listViewSeanse);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(buttonSelectSeans);
            splitContainer2.Size = new Size(330, 459);
            splitContainer2.SplitterDistance = 395;
            splitContainer2.TabIndex = 4;
            // 
            // listViewSeanse
            // 
            listViewSeanse.Dock = DockStyle.Fill;
            listViewSeanse.FullRowSelect = true;
            listViewSeanse.Location = new Point(0, 0);
            listViewSeanse.MultiSelect = false;
            listViewSeanse.Name = "listViewSeanse";
            listViewSeanse.Size = new Size(330, 395);
            listViewSeanse.TabIndex = 2;
            listViewSeanse.UseCompatibleStateImageBehavior = false;
            listViewSeanse.View = View.Details;
            // 
            // buttonSelectSeans
            // 
            buttonSelectSeans.Anchor = AnchorStyles.Bottom;
            buttonSelectSeans.BackColor = Color.PaleGreen;
            buttonSelectSeans.FlatAppearance.BorderColor = Color.Black;
            buttonSelectSeans.FlatAppearance.BorderSize = 5;
            buttonSelectSeans.Font = new Font("Segoe UI", 12F);
            buttonSelectSeans.Location = new Point(78, 7);
            buttonSelectSeans.Name = "buttonSelectSeans";
            buttonSelectSeans.Size = new Size(174, 49);
            buttonSelectSeans.TabIndex = 2;
            buttonSelectSeans.Text = "Zatwierdź wybór";
            buttonSelectSeans.UseVisualStyleBackColor = false;
            buttonSelectSeans.Click += buttonSelectSeans_Click;
            // 
            // splitContainer6
            // 
            splitContainer6.Location = new Point(712, 3);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(label3);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(splitContainer3);
            splitContainer6.Size = new Size(367, 535);
            splitContainer6.SplitterDistance = 72;
            splitContainer6.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(147, 19);
            label3.Name = "label3";
            label3.Size = new Size(73, 35);
            label3.TabIndex = 1;
            label3.Text = "Filmy";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(listViewFilmy);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(buttonSelectFilm);
            splitContainer3.Size = new Size(367, 459);
            splitContainer3.SplitterDistance = 395;
            splitContainer3.TabIndex = 5;
            // 
            // listViewFilmy
            // 
            listViewFilmy.Dock = DockStyle.Fill;
            listViewFilmy.FullRowSelect = true;
            listViewFilmy.Location = new Point(0, 0);
            listViewFilmy.MultiSelect = false;
            listViewFilmy.Name = "listViewFilmy";
            listViewFilmy.Size = new Size(367, 395);
            listViewFilmy.TabIndex = 2;
            listViewFilmy.UseCompatibleStateImageBehavior = false;
            listViewFilmy.View = View.Details;
            // 
            // buttonSelectFilm
            // 
            buttonSelectFilm.Anchor = AnchorStyles.Bottom;
            buttonSelectFilm.Font = new Font("Segoe UI", 10F);
            buttonSelectFilm.Location = new Point(128, 12);
            buttonSelectFilm.MaximumSize = new Size(140, 80);
            buttonSelectFilm.Name = "buttonSelectFilm";
            buttonSelectFilm.Size = new Size(111, 39);
            buttonSelectFilm.TabIndex = 3;
            buttonSelectFilm.Text = "Wybierz";
            buttonSelectFilm.UseVisualStyleBackColor = true;
            buttonSelectFilm.Click += buttonSelectFilm_Click;
            // 
            // WyborSeansu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 541);
            Controls.Add(flowLayoutPanel1);
            Name = "WyborSeansu";
            Text = "Wybór seansu";
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel1.PerformLayout();
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ListView listViewLokalizacje;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListView listViewSeanse;
        private SplitContainer splitContainer3;
        private ListView listViewFilmy;
        private Button buttonSelectLokalizacja;
        private Button buttonSelectSeans;
        private Button buttonSelectFilm;
        private SplitContainer splitContainer4;
        private SplitContainer splitContainer5;
        private SplitContainer splitContainer6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}