﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver3_Click(object sender, EventArgs e) 
        {
            // Vuelvo al menu 
            this.Hide(); 
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
