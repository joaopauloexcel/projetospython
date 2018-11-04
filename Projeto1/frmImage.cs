using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;//Biblioteca utilizada para o comando Process.Start() que permite executar o python no C#
using System.IO; // Biblioteca Input/Output, importante para salvar e ler arquivos

namespace Projeto1
{
    public partial class frmImage : Form
    {
        public frmImage()
        {
            InitializeComponent();
        }

        private Bitmap image1, image2; //img1: Imagem Original pega no computador, img2: Imagem Resultante dos filtros
        private Image img; //Permitirá o descarte da imagem utilizada na pasta Debug e assim não atrapalhar o filtro de uma nova imagem. 

        public string caminhoExecutavel() //Função que achaá o caminho do executável do C# no computador
        {
            try
            {
                string caminhoExecutavel = System.Reflection.Assembly.GetCallingAssembly().Location;//retorna a string do caminho do executável + nome do executável na pasta Debug
                string pastaExecutavel = new System.IO.FileInfo(caminhoExecutavel).DirectoryName;//retorna a string até a pasta do executável
                return pastaExecutavel += @"\";//Acrescenta uma \ após a pasta do caminho do executável e retorna esse caminho
            }
            catch
            {
                return null; //tratamento de exceção
            }
        }

        public bool CopiarImgParaLocal(string Arquivo)//Função que copia a imagem original para a pasta Debug do C# pegando o Arquivo Original da imagem aberta
        {
            try
            {
                string novoCaminhoArquivo;//Variável que receberá a string do novo caminho + nome do arquivo padrão jpg
                novoCaminhoArquivo = caminhoExecutavel() + "imgOriginal.jpg";//Cria a string do novo caminho já contendo o nome do arquivo da imagem que se tornará padrão para qualquer imagem e assim chamado no arquivo python
                System.IO.File.Copy(Arquivo, novoCaminhoArquivo, true);//Pega o arquivo original e copia para a pasta do executável com o nome já alterado
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void cmdFoto_Click(object sender, EventArgs e)
        {           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//Abre a tela de diálogo e aguarda pressionar o botão OK
            {
                image1 = new Bitmap(openFileDialog1.FileName);//Bitmap image1 recebe a imagem escolhida
                picFoto.Image = image1;//picture box mostrará a imagem no form
                FileInfo fileInfo = new FileInfo(openFileDialog1.FileName);//Variável recebe o nome da imagem escolhida
                string diretorio = fileInfo.DirectoryName;//Localiza o caminho do diretório onde a imagem está localizada no computador
                CopiarImgParaLocal(diretorio + "\\" + openFileDialog1.SafeFileName);//Função copia a imagem pega para a pasta do executável dessa aplicação
                btnFiltros.Visible = true;//Botão de filtros surge na tela
            }
        }

        private void cmdGrava_Click(System.Object sender, System.EventArgs e)
        {
            SaveFileDialog SalvarIMG = new SaveFileDialog();//Instancia o diálogo para salvar a nova imagem
            SalvarIMG.InitialDirectory = ("C:\\");//Diretorio padrão no diálogo
            SalvarIMG.FileName = "Nova Imagem";//Nome sugestivo da imagem
            SalvarIMG.Title = "Salvando Filtro";//Titulo da caixa de diálogo
            SalvarIMG.Filter = ("*jpg|*.jpg");//Extensão padrão
            SalvarIMG.ShowDialog();//Exibe a janela com todas as informações acima
            picResult.Image.Save(SalvarIMG.FileName);//Salva a imagem no diretorio do computador
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbEscolhas.Text = "Selecione o filtro";//ComboBox recebe texto padrão
            picFoto.Image = null;////Imagem atual desaparece do Picture Box
            picResult.Image = null;//Imagem atual desaparece do Picture Box
            pnlResultado.Enabled = false;//Desabilita o painel do resultado da imagem
            pnlFiltros.Visible = false;//Desabilita o painel de configuração dos filtros
            pnlCarregaImg.Enabled = true;//Habilita o painel que carrega a imagem
            pnlCarregaImg.Visible = true;//Torna visível na tela o painel que carrega a imagem
            pnlResultado.Visible = false;//Desabilita o painel de resultado dos filtros
            btnFiltros.Visible = false;//Faz sumir da tela o botão de Filtros
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (cmbEscolhas.SelectedIndex)//Switch que pega o índice da opção escolhida no Combo Box
            {
                case 0://Caso 1º item (posição 0)
                        System.Diagnostics.Process.Start(caminhoExecutavel() + "FiltroGaussiano.py");//Executa o arquivo python localizado na pasta do executável que realizará a média Gaussiana 
                        System.Threading.Thread.Sleep(1200);//Atraso na execução abaixo para dar tempo do arquivo pythom gerar a nova imagem resultante do filtro na pasta Debug
                        img = Image.FromFile("gaussiano.jpg");//Img do tipo Image Utiliza a imagem criada na pasta do executável
                        image2 = new Bitmap(img);//Image2 recebe uma nova imagem bitmap da imagem
                        img.Dispose();//Imagem utilizada na pasta cai em desuso para permitir o filtro de uma outra imagem posteriormente
                        picResult.Image = image2;//Picture Box mostra na tela a nova imagem obtida
                    break;
                case 1://Caso 2º item (posição 1)
                        System.Diagnostics.Process.Start(caminhoExecutavel() + "Subtracao.py");//Executa o arquivo Python de subtação
                        System.Threading.Thread.Sleep(1200);
                        img = Image.FromFile("sub.jpg");
                        image2 = new Bitmap(img);
                        img.Dispose();
                        picResult.Image = image2;
                    break;
                case 2: //Caso 3º item (posição 2) 
                        System.Diagnostics.Process.Start(caminhoExecutavel() + "Adicao.py");
                        System.Threading.Thread.Sleep(1200);
                        img = Image.FromFile("adicao.jpg");
                        image2 = new Bitmap(img);
                        img.Dispose();
                        picResult.Image = image2;
                    break;
                default:
                    MessageBox.Show("Escolha uma opção!");//Retorna um alerta, caso o usuário não escolha nenhuma opção
                    break;
            }
            cmdGrava.Enabled = true;//habilita o botão para salvar a imagem
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlFiltros.Visible = true; ;//Surge na tela o painel de controle de filtros
            pnlResultado.Visible = true;//Surge na tela o Painel da imagem resultante
            pnlResultado.Enabled = true;//Habilita o painel de resultado da imagem
            pnlCarregaImg.Enabled = false;//Desabilita o painel que carrega a imagem
            cmdGrava.Enabled = false;//Desabiilta o botão "Salvar Imagem"
        }

    }
}