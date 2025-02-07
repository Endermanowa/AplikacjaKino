namespace AplikacjaKino.UserControls
{
    partial class WidokLokalizacjeUser
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
            listViewLokalizacje = new ListView();
            SuspendLayout();
            // 
            // listViewLokalizacje
            // 
            listViewLokalizacje.Dock = DockStyle.Fill;
            listViewLokalizacje.FullRowSelect = true;
            listViewLokalizacje.Location = new Point(0, 0);
            listViewLokalizacje.MultiSelect = false;
            listViewLokalizacje.Name = "listViewLokalizacje";
            listViewLokalizacje.Size = new Size(533, 379);
            listViewLokalizacje.TabIndex = 1;
            listViewLokalizacje.UseCompatibleStateImageBehavior = false;
            listViewLokalizacje.View = View.Details;
            // 
            // WidokLokalizacjeUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewLokalizacje);
            Name = "WidokLokalizacjeUser";
            Size = new Size(533, 379);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewLokalizacje;
    }
}
