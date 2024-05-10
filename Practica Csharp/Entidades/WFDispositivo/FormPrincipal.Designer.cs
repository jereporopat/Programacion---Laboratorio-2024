namespace WFDispositivo
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAppInstaladas = new System.Windows.Forms.RichTextBox();
            this.rtbAppNoInstaladas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAppInstaladas
            // 
            this.rtbAppInstaladas.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbAppInstaladas.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbAppInstaladas.Location = new System.Drawing.Point(12, 12);
            this.rtbAppInstaladas.Name = "rtbAppInstaladas";
            this.rtbAppInstaladas.Size = new System.Drawing.Size(257, 401);
            this.rtbAppInstaladas.TabIndex = 0;
            this.rtbAppInstaladas.Text = "";
            // 
            // rtbAppNoInstaladas
            // 
            this.rtbAppNoInstaladas.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtbAppNoInstaladas.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbAppNoInstaladas.Location = new System.Drawing.Point(315, 12);
            this.rtbAppNoInstaladas.Name = "rtbAppNoInstaladas";
            this.rtbAppNoInstaladas.Size = new System.Drawing.Size(257, 401);
            this.rtbAppNoInstaladas.TabIndex = 1;
            this.rtbAppNoInstaladas.Text = "";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.rtbAppNoInstaladas);
            this.Controls.Add(this.rtbAppInstaladas);
            this.Name = "FormPrincipal";
            this.Text = "RPP.Poropat";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbAppInstaladas;
        private RichTextBox rtbAppNoInstaladas;
    }
}