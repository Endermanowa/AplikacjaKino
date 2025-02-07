namespace AplikacjaKino.UserControls
{
    partial class WidokRezerwacjeUser
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
            listViewRezerwacje = new ListView();
            splitContainer1 = new SplitContainer();
            panelButtons = new FlowLayoutPanel();
            buttonAddRezerwacja = new Button();
            buttonDeleteRezerwacja = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // listViewRezerwacje
            // 
            listViewRezerwacje.Dock = DockStyle.Fill;
            listViewRezerwacje.FullRowSelect = true;
            listViewRezerwacje.Location = new Point(0, 0);
            listViewRezerwacje.MultiSelect = false;
            listViewRezerwacje.Name = "listViewRezerwacje";
            listViewRezerwacje.Size = new Size(590, 386);
            listViewRezerwacje.TabIndex = 0;
            listViewRezerwacje.UseCompatibleStateImageBehavior = false;
            listViewRezerwacje.View = View.Details;
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
            splitContainer1.Panel1.Controls.Add(listViewRezerwacje);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelButtons);
            splitContainer1.Size = new Size(740, 386);
            splitContainer1.SplitterDistance = 590;
            splitContainer1.TabIndex = 4;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonAddRezerwacja);
            panelButtons.Controls.Add(buttonDeleteRezerwacja);
            panelButtons.Location = new Point(0, 108);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(146, 171);
            panelButtons.TabIndex = 1;
            // 
            // buttonAddRezerwacja
            // 
            buttonAddRezerwacja.Anchor = AnchorStyles.Bottom;
            buttonAddRezerwacja.Font = new Font("Segoe UI", 12F);
            buttonAddRezerwacja.Location = new Point(3, 3);
            buttonAddRezerwacja.MaximumSize = new Size(140, 80);
            buttonAddRezerwacja.MinimumSize = new Size(140, 80);
            buttonAddRezerwacja.Name = "buttonAddRezerwacja";
            buttonAddRezerwacja.Size = new Size(140, 80);
            buttonAddRezerwacja.TabIndex = 0;
            buttonAddRezerwacja.Text = "Dodaj rezerwację";
            buttonAddRezerwacja.UseVisualStyleBackColor = true;
            buttonAddRezerwacja.Click += buttonAddRezerwacja_Click;
            // 
            // buttonDeleteRezerwacja
            // 
            buttonDeleteRezerwacja.Anchor = AnchorStyles.Bottom;
            buttonDeleteRezerwacja.Font = new Font("Segoe UI", 12F);
            buttonDeleteRezerwacja.Location = new Point(3, 89);
            buttonDeleteRezerwacja.MaximumSize = new Size(140, 80);
            buttonDeleteRezerwacja.MinimumSize = new Size(140, 80);
            buttonDeleteRezerwacja.Name = "buttonDeleteRezerwacja";
            buttonDeleteRezerwacja.Size = new Size(140, 80);
            buttonDeleteRezerwacja.TabIndex = 2;
            buttonDeleteRezerwacja.Text = "Usuń rezerwację";
            buttonDeleteRezerwacja.UseVisualStyleBackColor = true;
            buttonDeleteRezerwacja.Click += buttonDeleteRezerwacja_Click;
            // 
            // WidokRezerwacjeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "WidokRezerwacjeUser";
            Size = new Size(740, 386);
            Resize += WidokRezerwacjeUser_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewRezerwacje;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel panelButtons;
        private Button buttonAddRezerwacja;
        private Button buttonDeleteRezerwacja;
    }
}
