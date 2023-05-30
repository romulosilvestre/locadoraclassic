using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmTelaCategoria : Form
    {
        public FrmTelaCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Criar um objeto
            Categoria categoria = new Categoria();
            categoria.Nome = textBox1.Text;
            categoria.vlDiaria = Convert.ToDecimal(txtVlDiaria.Text);

            CategoriaDAL categoriaDAL = new CategoriaDAL();
            categoriaDAL.InserirCategoria(categoria);
            textBox1.Text = "";
            txtVlDiaria.Text = "";
            MessageBox.Show("Dados inserido com sucesso!");

           
            
        }
    }
}
