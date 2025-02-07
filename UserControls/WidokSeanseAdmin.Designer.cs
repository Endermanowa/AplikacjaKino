namespace AplikacjaKino.UserControls
{
    partial class WidokSeanseAdmin
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
            listViewSeanse = new ListView();
            panelButtons = new FlowLayoutPanel();
            buttonAddSeans = new Button();
            buttonEditSeans = new Button();
            buttonDeleteSeans = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelButtons.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(listViewSeanse);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelButtons);
            splitContainer1.Size = new Size(902, 409);
            splitContainer1.SplitterDistance = 756;
            splitContainer1.TabIndex = 3;
            // 
            // listViewSeanse
            // 
            listViewSeanse.Dock = DockStyle.Fill;
            listViewSeanse.FullRowSelect = true;
            listViewSeanse.Location = new Point(0, 0);
            listViewSeanse.MultiSelect = false;
            listViewSeanse.Name = "listViewSeanse";
            listViewSeanse.Size = new Size(756, 409);
            listViewSeanse.TabIndex = 0;
            listViewSeanse.UseCompatibleStateImageBehavior = false;
            listViewSeanse.View = View.Details;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAddSeans);
            panelButtons.Controls.Add(buttonEditSeans);
            panelButtons.Controls.Add(buttonDeleteSeans);
            panelButtons.Location = new Point(-2, 105);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(146, 198);
            panelButtons.TabIndex = 1;
            // 
            // buttonAddSeans
            // 
            buttonAddSeans.Anchor = AnchorStyles.Bottom;
            buttonAddSeans.Font = new Font("Segoe UI", 12F);
            buttonAddSeans.Location = new Point(3, 3);
            buttonAddSeans.MaximumSize = new Size(140, 60);
            buttonAddSeans.MinimumSize = new Size(140, 60);
            buttonAddSeans.Name = "buttonAddSeans";
            buttonAddSeans.Size = new Size(140, 60);
            buttonAddSeans.TabIndex = 0;
            buttonAddSeans.Text = "Dodaj seans";
            buttonAddSeans.UseVisualStyleBackColor = true;
            buttonAddSeans.Click += buttonAddSeans_Click;
            // 
            // buttonEditSeans
            // 
            buttonEditSeans.Anchor = AnchorStyles.Bottom;
            buttonEditSeans.Font = new Font("Segoe UI", 12F);
            buttonEditSeans.Location = new Point(3, 69);
            buttonEditSeans.MaximumSize = new Size(140, 60);
            buttonEditSeans.MinimumSize = new Size(140, 60);
            buttonEditSeans.Name = "buttonEditSeans";
            buttonEditSeans.Size = new Size(140, 60);
            buttonEditSeans.TabIndex = 1;
            buttonEditSeans.Text = "Edytuj seans";
            buttonEditSeans.UseVisualStyleBackColor = true;
            buttonEditSeans.Click += buttonEditSeans_Click;
            // 
            // buttonDeleteSeans
            // 
            buttonDeleteSeans.Anchor = AnchorStyles.Bottom;
            buttonDeleteSeans.Font = new Font("Segoe UI", 12F);
            buttonDeleteSeans.Location = new Point(3, 135);
            buttonDeleteSeans.MaximumSize = new Size(140, 60);
            buttonDeleteSeans.MinimumSize = new Size(140, 60);
            buttonDeleteSeans.Name = "buttonDeleteSeans";
            buttonDeleteSeans.Size = new Size(140, 60);
            buttonDeleteSeans.TabIndex = 2;
            buttonDeleteSeans.Text = "Usuń seans";
            buttonDeleteSeans.UseVisualStyleBackColor = true;
            buttonDeleteSeans.Click += buttonDeleteSeans_Click;
            // 
            // WidokSeanseAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WidokSeanseAdmin";
            Size = new Size(902, 409);
            Resize += WidokSeanseAdmin_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView listViewSeanse;
        private FlowLayoutPanel panelButtons;
        private Button buttonAddSeans;
        private Button buttonEditSeans;
        private Button buttonDeleteSeans;
    }
}
