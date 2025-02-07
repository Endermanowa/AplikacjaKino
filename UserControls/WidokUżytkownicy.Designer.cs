namespace AplikacjaKino.UserControls
{
    partial class WidokUżytkownicy
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
            listViewUżytkownicy = new ListView();
            panelButtons = new FlowLayoutPanel();
            buttonViewRezerwacje = new Button();
            buttonDelete = new Button();
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
            splitContainer1.Panel1.Controls.Add(listViewUżytkownicy);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelButtons);
            splitContainer1.Size = new Size(896, 563);
            splitContainer1.SplitterDistance = 750;
            splitContainer1.TabIndex = 2;
            // 
            // listViewUżytkownicy
            // 
            listViewUżytkownicy.Dock = DockStyle.Fill;
            listViewUżytkownicy.FullRowSelect = true;
            listViewUżytkownicy.Location = new Point(0, 0);
            listViewUżytkownicy.MultiSelect = false;
            listViewUżytkownicy.Name = "listViewUżytkownicy";
            listViewUżytkownicy.Size = new Size(750, 563);
            listViewUżytkownicy.TabIndex = 0;
            listViewUżytkownicy.UseCompatibleStateImageBehavior = false;
            listViewUżytkownicy.View = View.Details;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonViewRezerwacje);
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Location = new Point(-2, 174);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(146, 214);
            panelButtons.TabIndex = 1;
            // 
            // buttonViewRezerwacje
            // 
            buttonViewRezerwacje.Anchor = AnchorStyles.Bottom;
            buttonViewRezerwacje.Font = new Font("Segoe UI", 12F);
            buttonViewRezerwacje.Location = new Point(3, 3);
            buttonViewRezerwacje.MaximumSize = new Size(140, 100);
            buttonViewRezerwacje.MinimumSize = new Size(140, 100);
            buttonViewRezerwacje.Name = "buttonViewRezerwacje";
            buttonViewRezerwacje.Size = new Size(140, 100);
            buttonViewRezerwacje.TabIndex = 0;
            buttonViewRezerwacje.Text = "Wyświetl rezerwacje";
            buttonViewRezerwacje.UseVisualStyleBackColor = true;
            buttonViewRezerwacje.Click += buttonViewRezerwacje_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom;
            buttonDelete.Font = new Font("Segoe UI", 12F);
            buttonDelete.Location = new Point(3, 109);
            buttonDelete.MaximumSize = new Size(140, 100);
            buttonDelete.MinimumSize = new Size(140, 100);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 100);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Usuń użytkownika";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // WidokUżytkownicy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WidokUżytkownicy";
            Size = new Size(896, 563);
            Resize += WidokUżytkownicy_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView listViewUżytkownicy;
        private Button buttonDelete;
        private Button buttonViewRezerwacje;
        private FlowLayoutPanel panelButtons;
    }
}
