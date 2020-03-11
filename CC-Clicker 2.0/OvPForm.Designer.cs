namespace CC_Clicker_2._0
{
    partial class OvPForm
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
            this.SuspendLayout();
            // 
            // OvPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))),
                ((int) (((byte) (0)))));
            this.ClientSize = new System.Drawing.Size(35, 35);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OvPForm";
            this.Text = "OvPForm";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))),
                ((int) (((byte) (0)))));
            this.Load += new System.EventHandler(this.OvPForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OvPForm_Paint);
            this.ResumeLayout(false);
        }

        #endregion
    }
}