namespace AplikacjaKino.UserControls
{
    partial class WidokRezerwacjeAdmin
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
            SuspendLayout();
            // 
            // listViewRezerwacje
            // 
            listViewRezerwacje.Dock = DockStyle.Fill;
            listViewRezerwacje.FullRowSelect = true;
            listViewRezerwacje.Location = new Point(0, 0);
            listViewRezerwacje.Name = "listViewRezerwacje";
            listViewRezerwacje.Size = new Size(816, 602);
            listViewRezerwacje.TabIndex = 2;
            listViewRezerwacje.UseCompatibleStateImageBehavior = false;
            listViewRezerwacje.View = View.Details;
            // 
            // WidokRezerwacjeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewRezerwacje);
            Name = "WidokRezerwacjeAdmin";
            Size = new Size(816, 602);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewRezerwacje;
    }
}
