using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivoFinalProgramación
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver2_Click(object sender, EventArgs e) 
        {
            // Vuelvo al menu
            this.Hide();  
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
