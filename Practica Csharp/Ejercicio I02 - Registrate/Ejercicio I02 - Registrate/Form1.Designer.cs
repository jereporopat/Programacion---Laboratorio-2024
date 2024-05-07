namespace Ejercicio_I02___Registrate
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
            this.gpb_Detalles = new System.Windows.Forms.GroupBox();
            this.nup_Edad = new System.Windows.Forms.NumericUpDown();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.gpb_Genero = new System.Windows.Forms.GroupBox();
            this.gpb_Cursos = new System.Windows.Forms.GroupBox();
            this.rb_Masculino = new System.Windows.Forms.RadioButton();
            this.rb_Femenino = new System.Windows.Forms.RadioButton();
            this.rb_NoBinario = new System.Windows.Forms.RadioButton();
            this.cb_Csharp = new System.Windows.Forms.CheckBox();
            this.cb_cmas = new System.Windows.Forms.CheckBox();
            this.cb_Javascript = new System.Windows.Forms.CheckBox();
            this.lstb_Paises = new System.Windows.Forms.ListBox();
            this.gpb_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Edad)).BeginInit();
            this.gpb_Genero.SuspendLayout();
            this.gpb_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_Detalles
            // 
            this.gpb_Detalles.Controls.Add(this.nup_Edad);
            this.gpb_Detalles.Controls.Add(this.txt_Nombre);
            this.gpb_Detalles.Controls.Add(this.txt_direccion);
            this.gpb_Detalles.Controls.Add(this.lbl_Edad);
            this.gpb_Detalles.Controls.Add(this.lbl_direccion);
            this.gpb_Detalles.Controls.Add(this.lbl_Nombre);
            this.gpb_Detalles.Location = new System.Drawing.Point(12, 12);
            this.gpb_Detalles.Name = "gpb_Detalles";
            this.gpb_Detalles.Size = new System.Drawing.Size(228, 103);
            this.gpb_Detalles.TabIndex = 0;
            this.gpb_Detalles.TabStop = false;
            this.gpb_Detalles.Text = "Detalles de usuario";
            // 
            // nup_Edad
            // 
            this.nup_Edad.Location = new System.Drawing.Point(102, 74);
            this.nup_Edad.Name = "nup_Edad";
            this.nup_Edad.Size = new System.Drawing.Size(103, 23);
            this.nup_Edad.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(105, 16);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(105, 45);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(100, 23);
            this.txt_direccion.TabIndex = 1;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(6, 68);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(6, 43);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.TabIndex = 1;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 19);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(680, 371);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(108, 53);
            this.btn_Ingresar.TabIndex = 1;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // gpb_Genero
            // 
            this.gpb_Genero.Controls.Add(this.rb_NoBinario);
            this.gpb_Genero.Controls.Add(this.rb_Femenino);
            this.gpb_Genero.Controls.Add(this.rb_Masculino);
            this.gpb_Genero.Location = new System.Drawing.Point(275, 15);
            this.gpb_Genero.Name = "gpb_Genero";
            this.gpb_Genero.Size = new System.Drawing.Size(200, 141);
            this.gpb_Genero.TabIndex = 2;
            this.gpb_Genero.TabStop = false;
            this.gpb_Genero.Text = "Genero";
            // 
            // gpb_Cursos
            // 
            this.gpb_Cursos.Controls.Add(this.cb_Javascript);
            this.gpb_Cursos.Controls.Add(this.cb_cmas);
            this.gpb_Cursos.Controls.Add(this.cb_Csharp);
            this.gpb_Cursos.Location = new System.Drawing.Point(275, 180);
            this.gpb_Cursos.Name = "gpb_Cursos";
            this.gpb_Cursos.Size = new System.Drawing.Size(200, 136);
            this.gpb_Cursos.TabIndex = 3;
            this.gpb_Cursos.TabStop = false;
            this.gpb_Cursos.Text = "Cursos";
            // 
            // rb_Masculino
            // 
            this.rb_Masculino.AutoSize = true;
            this.rb_Masculino.Location = new System.Drawing.Point(17, 22);
            this.rb_Masculino.Name = "rb_Masculino";
            this.rb_Masculino.Size = new System.Drawing.Size(80, 19);
            this.rb_Masculino.TabIndex = 4;
            this.rb_Masculino.TabStop = true;
            this.rb_Masculino.Text = "Masculino";
            this.rb_Masculino.UseVisualStyleBackColor = true;
            // 
            // rb_Femenino
            // 
            this.rb_Femenino.AutoSize = true;
            this.rb_Femenino.Location = new System.Drawing.Point(17, 61);
            this.rb_Femenino.Name = "rb_Femenino";
            this.rb_Femenino.Size = new System.Drawing.Size(78, 19);
            this.rb_Femenino.TabIndex = 5;
            this.rb_Femenino.TabStop = true;
            this.rb_Femenino.Text = "Femenino";
            this.rb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rb_NoBinario
            // 
            this.rb_NoBinario.AutoSize = true;
            this.rb_NoBinario.Location = new System.Drawing.Point(17, 100);
            this.rb_NoBinario.Name = "rb_NoBinario";
            this.rb_NoBinario.Size = new System.Drawing.Size(81, 19);
            this.rb_NoBinario.TabIndex = 6;
            this.rb_NoBinario.TabStop = true;
            this.rb_NoBinario.Text = "No Binario";
            this.rb_NoBinario.UseVisualStyleBackColor = true;
            // 
            // cb_Csharp
            // 
            this.cb_Csharp.AutoSize = true;
            this.cb_Csharp.Location = new System.Drawing.Point(17, 22);
            this.cb_Csharp.Name = "cb_Csharp";
            this.cb_Csharp.Size = new System.Drawing.Size(40, 19);
            this.cb_Csharp.TabIndex = 0;
            this.cb_Csharp.Text = "C ·";
            this.cb_Csharp.UseVisualStyleBackColor = true;
            // 
            // cb_cmas
            // 
            this.cb_cmas.AutoSize = true;
            this.cb_cmas.Location = new System.Drawing.Point(17, 54);
            this.cb_cmas.Name = "cb_cmas";
            this.cb_cmas.Size = new System.Drawing.Size(53, 19);
            this.cb_cmas.TabIndex = 1;
            this.cb_cmas.Text = "C ++";
            this.cb_cmas.UseVisualStyleBackColor = true;
            // 
            // cb_Javascript
            // 
            this.cb_Javascript.AutoSize = true;
            this.cb_Javascript.Location = new System.Drawing.Point(17, 89);
            this.cb_Javascript.Name = "cb_Javascript";
            this.cb_Javascript.Size = new System.Drawing.Size(77, 19);
            this.cb_Javascript.TabIndex = 2;
            this.cb_Javascript.Text = "Javascript";
            this.cb_Javascript.UseVisualStyleBackColor = true;
            // 
            // lstb_Paises
            // 
            this.lstb_Paises.FormattingEnabled = true;
            this.lstb_Paises.ItemHeight = 15;
            this.lstb_Paises.Location = new System.Drawing.Point(12, 145);
            this.lstb_Paises.Name = "lstb_Paises";
            this.lstb_Paises.Size = new System.Drawing.Size(151, 169);
            this.lstb_Paises.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstb_Paises);
            this.Controls.Add(this.gpb_Cursos);
            this.Controls.Add(this.gpb_Genero);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.gpb_Detalles);
            this.Name = "Form1";
            this.Text = "No Binario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_Detalles.ResumeLayout(false);
            this.gpb_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Edad)).EndInit();
            this.gpb_Genero.ResumeLayout(false);
            this.gpb_Genero.PerformLayout();
            this.gpb_Cursos.ResumeLayout(false);
            this.gpb_Cursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpb_Detalles;
        private Label lbl_Nombre;
        private Label lbl_Edad;
        private Label lbl_direccion;
        private TextBox txt_Nombre;
        private TextBox txt_direccion;
        private Button btn_Ingresar;
        private NumericUpDown nup_Edad;
        private GroupBox gpb_Genero;
        private RadioButton rb_NoBinario;
        private RadioButton rb_Femenino;
        private RadioButton rb_Masculino;
        private GroupBox gpb_Cursos;
        private CheckBox cb_Javascript;
        private CheckBox cb_cmas;
        private CheckBox cb_Csharp;
        private ListBox lstb_Paises;
    }
}