namespace ArchivoFinalProgramación
{
    partial class Form1
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
            this.btnAgregarProfeYMateria = new System.Windows.Forms.Button();
            this.btnVerYModificarCursosCargados = new System.Windows.Forms.Button();
            this.btnAgregarCursos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarProfeYMateria
            // 
            this.btnAgregarProfeYMateria.Location = new System.Drawing.Point(407, 140);
            this.btnAgregarProfeYMateria.Name = "btnAgregarProfeYMateria";
            this.btnAgregarProfeYMateria.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarProfeYMateria.TabIndex = 0;
            this.btnAgregarProfeYMateria.Text = "Agregar Profesores y Materias";
            this.btnAgregarProfeYMateria.UseVisualStyleBackColor = true;
            this.btnAgregarProfeYMateria.Click += new System.EventHandler(this.btnAgregarProfeYMateria_Click);
            // 
            // btnVerYModificarCursosCargados
            // 
            this.btnVerYModificarCursosCargados.Location = new System.Drawing.Point(407, 251);
            this.btnVerYModificarCursosCargados.Name = "btnVerYModificarCursosCargados";
            this.btnVerYModificarCursosCargados.Size = new System.Drawing.Size(121, 23);
            this.btnVerYModificarCursosCargados.TabIndex = 1;
            this.btnVerYModificarCursosCargados.Text = "Ver y Modificar Cursos Cargados";
            this.btnVerYModificarCursosCargados.UseVisualStyleBackColor = true;
            this.btnVerYModificarCursosCargados.Click += new System.EventHandler(this.btnVerYModificarCursosCargados_Click);
            // 
            // btnAgregarCursos
            // 
            this.btnAgregarCursos.Location = new System.Drawing.Point(407, 199);
            this.btnAgregarCursos.Name = "btnAgregarCursos";
            this.btnAgregarCursos.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarCursos.TabIndex = 2;
            this.btnAgregarCursos.Text = "Agregar";
            this.btnAgregarCursos.UseVisualStyleBackColor = true;
            this.btnAgregarCursos.Click += new System.EventHandler(this.btnAgregarCursos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(802, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarCursos);
            this.Controls.Add(this.btnVerYModificarCursosCargados);
            this.Controls.Add(this.btnAgregarProfeYMateria);
            this.Name = "Form1";
            this.Text = "Menú";
          
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarProfeYMateria;
        private System.Windows.Forms.Button btnVerYModificarCursosCargados;
        private System.Windows.Forms.Button btnAgregarCursos;
        private System.Windows.Forms.Button btnSalir;
    }
}