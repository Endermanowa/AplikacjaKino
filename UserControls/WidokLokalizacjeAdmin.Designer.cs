namespace AplikacjaKino.UserControls
{
    partial class WidokLokalizacjeAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            listViewLokalizacje = new ListView();
            buttonViewSale = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(buttonViewSale);
            splitContainer1.Size = new Size(808, 444);
            splitContainer1.SplitterDistance = 662;
            splitContainer1.TabIndex = 2;
            // 
            // listViewLokalizacje
            // 
            listViewLokalizacje.Dock = DockStyle.Fill;
            listViewLokalizacje.FullRowSelect = true;
            listViewLokalizacje.Location = new Point(0, 0);
            listViewLokalizacje.MultiSelect = false;
            listViewLokalizacje.Name = "listViewLokalizacje";
            listViewLokalizacje.Size = new Size(662, 444);
            listViewLokalizacje.TabIndex = 0;
            listViewLokalizacje.UseCompatibleStateImageBehavior = false;
            listViewLokalizacje.View = View.Details;
            // 
            // buttonViewSale
            // 
            buttonViewSale.Anchor = AnchorStyles.Bottom;
            buttonViewSale.Font = new Font("Segoe UI", 12F);
            buttonViewSale.Location = new Point(-1, 182);
            buttonViewSale.MaximumSize = new Size(140, 80);
            buttonViewSale.MinimumSize = new Size(140, 80);
            buttonViewSale.Name = "buttonViewSale";
            buttonViewSale.Size = new Size(140, 80);
            buttonViewSale.TabIndex = 0;
            buttonViewSale.Text = "Wyświetl sale";
            buttonViewSale.UseVisualStyleBackColor = true;
            buttonViewSale.Click += buttonViewSale_Click;
            // 
            // WidokLokalizacje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WidokLokalizacje";
            Size = new Size(808, 444);
            Resize += WidokLokalizacje_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView listViewLokalizacje;
        private Button buttonViewSale;
    }
}
