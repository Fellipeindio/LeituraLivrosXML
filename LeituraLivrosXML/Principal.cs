﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraLivrosXML
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            foreach (string livro in Livros.LivrosBiblia())
            {
                cbxLivrosBiblia.Items.Add(livro);
            }
            cbxSurata.DataSource = Livros.LivrosAlcorao();
        }

        private void btnProcuraBiblia_Click(object sender, EventArgs e)
        {
            
        }
    }
}
