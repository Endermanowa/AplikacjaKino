namespace AplikacjaKino.UserControls
{
    partial class WidokFilmyAdmin
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
            listViewFilmy = new ListView();
            splitContainer1 = new SplitContainer();
            buttonViewSeanse = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewFilmy
            // 
            listViewFilmy.Dock = DockStyle.Fill;
            listViewFilmy.FullRowSelect = true;
            listViewFilmy.Location = new Point(0, 0);
            listViewFilmy.MultiSelect = false;
            listViewFilmy.Name = "listViewFilmy";
            listViewFilmy.Size = new Size(632, 423);
            listViewFilmy.TabIndex = 0;
            listViewFilmy.UseCompatibleStateImageBehavior = false;
            listViewFilmy.View = View.Details;
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
            splitContainer1.Panel1.Controls.Add(listViewFilmy);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonViewSeanse);
            splitContainer1.Size = new Size(778, 423);
            splitContainer1.SplitterDistance = 632;
            splitContainer1.TabIndex = 1;
            // 
            // buttonViewSeanse
            // 
            buttonViewSeanse.Anchor = AnchorStyles.Bottom;
            buttonViewSeanse.Font = new Font("Segoe UI", 12F);
            buttonViewSeanse.Location = new Point(2, 161);
            buttonViewSeanse.MaximumSize = new Size(140, 100);
            buttonViewSeanse.MinimumSize = new Size(140, 100);
            buttonViewSeanse.Name = "buttonViewSeanse";
            buttonViewSeanse.Size = new Size(140, 100);
            buttonViewSeanse.TabIndex = 0;
            buttonViewSeanse.Text = "Wyświetl seanse";
            buttonViewSeanse.UseVisualStyleBackColor = true;
            buttonViewSeanse.Click += buttonViewSeanse_Click;
            // 
            // WidokFilmy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WidokFilmy";
            Size = new Size(778, 423);
            Resize += WidokFilmy_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewFilmy;
        private SplitContainer splitContainer1;
        private Button buttonViewSeanse;
    }
}
