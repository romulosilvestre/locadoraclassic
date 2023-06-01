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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LocadoraClassic.View
{
    public partial class FrmTelaFilme : Form
    {
        List<Categoria> categorias = new List<Categoria>();
        Categoria categoria = new Categoria();
        Genero genero = new Genero();
        GeneroDAL generoDAL = new GeneroDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        List<Genero> generos = new List<Genero>();
        int idSelecionadoCat;
        int idSelecionadoGen;
        public FrmTelaFilme()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaFilme_Load(object sender, EventArgs e)
        {
            //*******************MOCK DA LISTA*********************
            CarregarCategoria();
            CarregarGenero();
           




        }

        private void button1_Click(object sender, EventArgs e)
        {
            idSelecionadoCat = (int)cmbCategoria.SelectedValue;
            idSelecionadoGen = (int)cmbGenero.SelectedValue;

            MessageBox.Show("Id Cat:" + idSelecionadoCat.ToString());
            MessageBox.Show("Id Gen:" + idSelecionadoGen.ToString());

            Filme filme = new Filme();
            filme.IdCategoria= idSelecionadoCat;
            filme.IdGenero= idSelecionadoGen;
            filme.Nome = txtNome.Text;
            filme.Sinopse = multiSinopse.Text;
            filme.Duracao = TimeSpan.Parse(mskDuracao.Text);
            filme.StLocado = checkLocado.Checked;
            filme.Banner = "C:/imagens/filme.png";
            FilmeDAL filmeDAL = new FilmeDAL();
            filmeDAL.InserirFilme(filme);

            
        }

        private void cmbCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
          

        }

        public void CarregarCategoria()
        {
          
            //Criando categorias

           /* categoria.Id = 1;
            categoria.Nome = "Classic Vintage Raro";
            categoria.vlDiaria = 19.78m;

            Categoria categoria2 = new Categoria();
            categoria2.Id = 2;
            categoria2.Nome = "Popular Padrão";
            categoria2.vlDiaria = 9.50m;

            //Adicionando as duas categorias

            categorias.Add(categoria);
            categorias.Add(categoria2);*/

            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.DataSource = categoriaDAL.ObterCategorias().ToList();
        }


        public void CarregarGenero()
        {

            //Criando categorias

            /*genero.Id = 1;
            genero.Nome = "Terror";
          

            Genero genero2 = new Genero();
            genero2.Id = 2;
            genero2.Nome = "Comedia";


            //Adicionando dois generos
            generos.Add(genero);
            generos.Add(genero2);*/

           

            cmbGenero.DisplayMember = "Nome";
            cmbGenero.ValueMember = "Id";
            cmbGenero.DataSource = generoDAL.ObterGeneros().ToList();


        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }
    }
}
