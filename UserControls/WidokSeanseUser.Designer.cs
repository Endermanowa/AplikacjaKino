namespace AplikacjaKino.UserControls
{
    partial class WidokSeanseUser
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
            listViewSeanse = new ListView();
            SuspendLayout();
            // 
            // listViewSeanse
            // 
            listViewSeanse.Dock = DockStyle.Fill;
            listViewSeanse.FullRowSelect = true;
            listViewSeanse.Location = new Point(0, 0);
            listViewSeanse.MultiSelect = false;
            listViewSeanse.Name = "listViewSeanse";
            listViewSeanse.Size = new Size(467, 322);
            listViewSeanse.TabIndex = 1;
            listViewSeanse.UseCompatibleStateImageBehavior = false;
            listViewSeanse.View = View.Details;
            // 
            // WidokSeanseUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewSeanse);
            Name = "WidokSeanseUser";
            Size = new Size(467, 322);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewSeanse;
    }
}
