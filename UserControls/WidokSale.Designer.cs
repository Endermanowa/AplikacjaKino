namespace AplikacjaKino.UserControls
{
    partial class WidokSale
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
            listViewSale = new ListView();
            SuspendLayout();
            // 
            // listViewSale
            // 
            listViewSale.Dock = DockStyle.Fill;
            listViewSale.FullRowSelect = true;
            listViewSale.Location = new Point(0, 0);
            listViewSale.Name = "listViewSale";
            listViewSale.Size = new Size(915, 652);
            listViewSale.TabIndex = 1;
            listViewSale.UseCompatibleStateImageBehavior = false;
            listViewSale.View = View.Details;
            // 
            // WidokSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listViewSale);
            Name = "WidokSale";
            Size = new Size(915, 652);
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewSale;
    }
}
