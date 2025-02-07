namespace AplikacjaKino
{
    partial class WyborLokalizacji
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
            buttonSelect = new Button();
            listViewLokalizacje = new ListView();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSelect
            // 
            buttonSelect.Anchor = AnchorStyles.Bottom;
            buttonSelect.Font = new Font("Segoe UI", 12F);
            buttonSelect.Location = new Point(3, 185);
            buttonSelect.MaximumSize = new Size(140, 80);
            buttonSelect.MinimumSize = new Size(140, 80);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(140, 80);
            buttonSelect.TabIndex = 0;
            buttonSelect.Text = "Potwierdź wybór";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // listViewLokalizacje
            // 
            listViewLokalizacje.Dock = DockStyle.Fill;
            listViewLokalizacje.FullRowSelect = true;
            listViewLokalizacje.Location = new Point(0, 0);
            listViewLokalizacje.MultiSelect = false;
            listViewLokalizacje.Name = "listViewLokalizacje";
            listViewLokalizacje.Size = new Size(649, 450);
            listViewLokalizacje.TabIndex = 0;
            listViewLokalizacje.UseCompatibleStateImageBehavior = false;
            listViewLokalizacje.View = View.Details;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listViewLokalizacje);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonSelect);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 649;
            splitContainer1.TabIndex = 3;
            // 
            // WyborLokalizacji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "WyborLokalizacji";
            Text = "Wybór lokalizacji";
            Resize += WyborLokalizacji_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSelect;
        private ListView listViewLokalizacje;
        private SplitContainer splitContainer1;
    }
}