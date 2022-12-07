namespace ArchivoFinalProgramación
{
    partial class Form4
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
            this.cmbDeCurso = new System.Windows.Forms.ComboBox();
            this.cmbVerProfesor = new System.Windows.Forms.ComboBox();
            this.cmbVerMateria = new System.Windows.Forms.ComboBox();
            this.txtVerAlumnos = new System.Windows.Forms.TextBox();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnModificarCurso = new System.Windows.Forms.Button();
            this.btnvolver3 = new System.Windows.Forms.Button();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDeCurso
            // 
            this.cmbDeCurso.FormattingEnabled = true;
            this.cmbDeCurso.Location = new System.Drawing.Point(229, 47);
            this.cmbDeCurso.Name = "cmbDeCurso";
            this.cmbDeCurso.Size = new System.Drawing.Size(94, 21);
            this.cmbDeCurso.TabIndex = 0;
            // 
            // cmbVerProfesor
            // 
            this.cmbVerProfesor.FormattingEnabled = true;
            this.cmbVerProfesor.Location = new System.Drawing.Point(229, 101);
            this.cmbVerProfesor.Name = "cmbVerProfesor";
            this.cmbVerProfesor.Size = new System.Drawing.Size(94, 21);
            this.cmbVerProfesor.TabIndex = 1;
            // 
            // cmbVerMateria
            // 
            this.cmbVerMateria.FormattingEnabled = true;
            this.cmbVerMateria.Location = new System.Drawing.Point(229, 160);
            this.cmbVerMateria.Name = "cmbVerMateria";
            this.cmbVerMateria.Size = new System.Drawing.Size(94, 21);
            this.cmbVerMateria.TabIndex = 2;
            // 
            // txtVerAlumnos
            // 
            this.txtVerAlumnos.Location = new System.Drawing.Point(229, 216);
            this.txtVerAlumnos.Name = "txtVerAlumnos";
            this.txtVerAlumnos.Size = new System.Drawing.Size(94, 20);
            this.txtVerAlumnos.TabIndex = 3;
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Location = new System.Drawing.Point(601, 281);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCurso.TabIndex = 4;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnModificarCurso
            // 
            this.btnModificarCurso.Location = new System.Drawing.Point(505, 281);
            this.btnModificarCurso.Name = "btnModificarCurso";
            this.btnModificarCurso.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCurso.TabIndex = 5;
            this.btnModificarCurso.Text = "Modificar";
            this.btnModificarCurso.UseVisualStyleBackColor = true;
            this.btnModificarCurso.Click += new System.EventHandler(this.btnModificarCurso_Click);
            // 
            // btnvolver3
            // 
            this.btnvolver3.Location = new System.Drawing.Point(713, 415);
            this.btnvolver3.Name = "btnvolver3";
            this.btnvolver3.Size = new System.Drawing.Size(75, 23);
            this.btnvolver3.TabIndex = 6;
            this.btnvolver3.Text = "Volver";
            this.btnvolver3.UseVisualStyleBackColor = true;
            this.btnvolver3.Click += new System.EventHandler(this.btnvolver3_Click);
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(480, 47);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(239, 228);
            this.dgvCursos.TabIndex = 7;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnvolver3);
            this.Controls.Add(this.btnModificarCurso);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.txtVerAlumnos);
            this.Controls.Add(this.cmbVerMateria);
            this.Controls.Add(this.cmbVerProfesor);
            this.Controls.Add(this.cmbDeCurso);
            this.Name = "Form4";
            this.Text = "Ver y modificar Cursos Cargados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeCurso;
        private System.Windows.Forms.ComboBox cmbVerProfesor;
        private System.Windows.Forms.ComboBox cmbVerMateria;
        private System.Windows.Forms.TextBox txtVerAlumnos;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnModificarCurso;
        private System.Windows.Forms.Button btnvolver3;
        private System.Windows.Forms.DataGridView dgvCursos;
    }
}