namespace ArchivoFinalProgramación
{
    partial class Form2
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
            this.txtMaterias = new System.Windows.Forms.TextBox();
            this.txtProfeNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProfesores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarProfe = new System.Windows.Forms.Button();
            this.btnEliminarProfe = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnEliminarMaterias = new System.Windows.Forms.Button();
            this.btnModificarMateria = new System.Windows.Forms.Button();
            this.lblAgregarProfe = new System.Windows.Forms.Label();
            this.txtProfeApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaterias
            // 
            this.txtMaterias.Location = new System.Drawing.Point(310, 164);
            this.txtMaterias.Name = "txtMaterias";
            this.txtMaterias.Size = new System.Drawing.Size(100, 20);
            this.txtMaterias.TabIndex = 0;
            // 
            // txtProfeNombre
            // 
            this.txtProfeNombre.Location = new System.Drawing.Point(234, 83);
            this.txtProfeNombre.Name = "txtProfeNombre";
            this.txtProfeNombre.Size = new System.Drawing.Size(100, 20);
            this.txtProfeNombre.TabIndex = 1;
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(500, 80);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProfesor.TabIndex = 3;
            this.btnAgregarProfesor.Text = "Agregar";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(433, 162);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMateria.TabIndex = 4;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materia});
            this.dgvMaterias.Location = new System.Drawing.Point(423, 250);
            this.dgvMaterias.MultiSelect = false;
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.Size = new System.Drawing.Size(245, 150);
            this.dgvMaterias.TabIndex = 5;
            this.dgvMaterias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterias_CellClick);
            // 
            // materia
            // 
            this.materia.HeaderText = "Materia";
            this.materia.MinimumWidth = 10;
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 200;
            // 
            // dgvProfesores
            // 
            this.dgvProfesores.AllowUserToAddRows = false;
            this.dgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido});
            this.dgvProfesores.Location = new System.Drawing.Point(68, 250);
            this.dgvProfesores.MultiSelect = false;
            this.dgvProfesores.Name = "dgvProfesores";
            this.dgvProfesores.ReadOnly = true;
            this.dgvProfesores.Size = new System.Drawing.Size(244, 150);
            this.dgvProfesores.TabIndex = 6;
            this.dgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesores_CellClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // btnModificarProfe
            // 
            this.btnModificarProfe.Location = new System.Drawing.Point(104, 406);
            this.btnModificarProfe.Name = "btnModificarProfe";
            this.btnModificarProfe.Size = new System.Drawing.Size(75, 23);
            this.btnModificarProfe.TabIndex = 7;
            this.btnModificarProfe.Text = "Modificar";
            this.btnModificarProfe.UseVisualStyleBackColor = true;
            this.btnModificarProfe.Click += new System.EventHandler(this.btnModificarProfe_Click);
            // 
            // btnEliminarProfe
            // 
            this.btnEliminarProfe.Location = new System.Drawing.Point(210, 406);
            this.btnEliminarProfe.Name = "btnEliminarProfe";
            this.btnEliminarProfe.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProfe.TabIndex = 8;
            this.btnEliminarProfe.Text = "Eliminar";
            this.btnEliminarProfe.UseVisualStyleBackColor = true;
            this.btnEliminarProfe.Click += new System.EventHandler(this.btnEliminarProfe_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(723, 415);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnEliminarMaterias
            // 
            this.btnEliminarMaterias.Location = new System.Drawing.Point(562, 415);
            this.btnEliminarMaterias.Name = "btnEliminarMaterias";
            this.btnEliminarMaterias.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMaterias.TabIndex = 10;
            this.btnEliminarMaterias.Text = "Eliminar";
            this.btnEliminarMaterias.UseVisualStyleBackColor = true;
            this.btnEliminarMaterias.Click += new System.EventHandler(this.btnEliminarMaterias_Click);
            // 
            // btnModificarMateria
            // 
            this.btnModificarMateria.Location = new System.Drawing.Point(445, 415);
            this.btnModificarMateria.Name = "btnModificarMateria";
            this.btnModificarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMateria.TabIndex = 11;
            this.btnModificarMateria.Text = "Modificar";
            this.btnModificarMateria.UseVisualStyleBackColor = true;
            this.btnModificarMateria.Click += new System.EventHandler(this.btnModificarMateria_Click);
            // 
            // lblAgregarProfe
            // 
            this.lblAgregarProfe.AutoSize = true;
            this.lblAgregarProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProfe.Location = new System.Drawing.Point(319, 20);
            this.lblAgregarProfe.Name = "lblAgregarProfe";
            this.lblAgregarProfe.Size = new System.Drawing.Size(69, 20);
            this.lblAgregarProfe.TabIndex = 12;
            this.lblAgregarProfe.Text = "Profesor";
            // 
            // txtProfeApellido
            // 
            this.txtProfeApellido.Location = new System.Drawing.Point(359, 83);
            this.txtProfeApellido.Name = "txtProfeApellido";
            this.txtProfeApellido.Size = new System.Drawing.Size(100, 20);
            this.txtProfeApellido.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Materia";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(258, 67);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 16;
            this.lblnombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(389, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(356, 216);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(28, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "error";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProfeApellido);
            this.Controls.Add(this.lblAgregarProfe);
            this.Controls.Add(this.btnModificarMateria);
            this.Controls.Add(this.btnEliminarMaterias);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminarProfe);
            this.Controls.Add(this.btnModificarProfe);
            this.Controls.Add(this.dgvProfesores);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.txtProfeNombre);
            this.Controls.Add(this.txtMaterias);
            this.Name = "Form2";
            this.Text = "agregar prof y mat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterias;
        private System.Windows.Forms.TextBox txtProfeNombre;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridView dgvProfesores;
        private System.Windows.Forms.Button btnModificarProfe;
        private System.Windows.Forms.Button btnEliminarProfe;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEliminarMaterias;
        private System.Windows.Forms.Button btnModificarMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.Label lblAgregarProfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.TextBox txtProfeApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblError;
    }
}