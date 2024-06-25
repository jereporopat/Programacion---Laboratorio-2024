namespace FormAvisameSiCambia
{
    partial class Form1
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
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.lbl_NombreCompleto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(132, 43);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 0;
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.Location = new System.Drawing.Point(132, 109);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(100, 23);
            this.txb_Apellido.TabIndex = 1;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nombre.Location = new System.Drawing.Point(25, 45);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(68, 21);
            this.lbl_Nombre.TabIndex = 2;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Apellido.Location = new System.Drawing.Point(25, 107);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(67, 21);
            this.lbl_Apellido.TabIndex = 3;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(38, 185);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(194, 23);
            this.btn_Crear.TabIndex = 5;
            this.btn_Crear.Text = "Crear";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // lbl_NombreCompleto
            // 
            this.lbl_NombreCompleto.AutoSize = true;
            this.lbl_NombreCompleto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NombreCompleto.Location = new System.Drawing.Point(76, 249);
            this.lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            this.lbl_NombreCompleto.Size = new System.Drawing.Size(139, 21);
            this.lbl_NombreCompleto.TabIndex = 6;
            this.lbl_NombreCompleto.Text = "Nombre y apellido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.lbl_NombreCompleto);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_Nombre);
            this.Name = "Form1";
            this.Text = "El Avisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txb_Nombre;
        private TextBox txb_Apellido;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Button btn_Crear;
        private Label lbl_NombreCompleto;
    }
}