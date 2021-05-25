using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using FinalProject.Modelo;

namespace FinalProject
{
    public partial class Inicializador : Form
    {
        private List<Circulo> Cobra = new List<Circulo>();
        private Circulo comida = new Circulo();
        private int contadorVelocidade = 0;
        private int contadorComida = 0;

        public object MaiorPontuacao { get; private set; }

        public Inicializador()
        {
            InitializeComponent();

            new Configuracoes();

            TempoDeJogo.Interval = Configuracoes.Velocidade;
            TempoDeJogo.Tick += AtualizarTela;
            TempoDeJogo.Start();

            IniciarJogo();
        }

        private void IniciarJogo()
        {
            lblFimDeJogo.Visible = false;

            new Configuracoes();

            //Criando um novo objeto, player.
            Cobra.Clear();
            Circulo cabeca = new Circulo();
            cabeca.X = 10;
            cabeca.Y = 5;
            Cobra.Add(cabeca);

            lblPontos.Text = Configuracoes.Pontos.ToString();
            contadorVelocidade = 0;
            lblVelocidade.Text = contadorVelocidade.ToString();
            GerarComida();
        }

        //Adiciona comida aleatoriamente no jogo.
        private void GerarComida()
        {
            int maxXPosicao = pbTela.Size.Width / Configuracoes.Largura;
            int maxYPosicao = pbTela.Size.Height / Configuracoes.Altura;

            Random random = new Random();
            comida = new Circulo();
            comida.X = random.Next(0, maxXPosicao);
            comida.Y = random.Next(0, maxYPosicao);
        }

        private void AtualizarTela(object sender, EventArgs e)
        {
            MostrarMelhorPontuacao();
            if (Configuracoes.FimDeJogo == true)
            {
                //Verifica se a tecla Enter foi pressionada.
                if (Entrada.TeclaPressionada(Keys.Enter))
                {
                    IniciarJogo();
                }
            }
            else
            {
                if (Entrada.TeclaPressionada(Keys.Right) && Configuracoes.direcao != Direcao.Esquerda)
                    Configuracoes.direcao = Direcao.Direita;
                else if (Entrada.TeclaPressionada(Keys.Left) && Configuracoes.direcao != Direcao.Direita)
                    Configuracoes.direcao = Direcao.Esquerda;
                else if (Entrada.TeclaPressionada(Keys.Up) && Configuracoes.direcao != Direcao.Baixo)
                    Configuracoes.direcao = Direcao.Cima;
                else if (Entrada.TeclaPressionada(Keys.Down) && Configuracoes.direcao != Direcao.Cima)
                    Configuracoes.direcao = Direcao.Baixo;

                MovimentacaoDoPlayer();
            }

            pbTela.Invalidate();
        }

        private void PbTela_Paint(object sender, PaintEventArgs e)
        {
            Graphics tela = e.Graphics;

            if (!Configuracoes.FimDeJogo)
            {
                //Design da cobra.
                Brush corDaCobra;
                for (int i = 0; i < Cobra.Count; i++)
                {
                    if (i == 0)
                        corDaCobra = Brushes.ForestGreen;
                    else
                        corDaCobra = Brushes.DarkSeaGreen;

                    tela.FillEllipse(corDaCobra, new Rectangle(Cobra[i].X * Configuracoes.Largura,
                                                               Cobra[i].Y * Configuracoes.Altura,
                                                               Configuracoes.Largura, Configuracoes.Altura));

                    //Design da comida.
                    tela.FillEllipse(Brushes.Red,
                        new Rectangle(comida.X * Configuracoes.Largura,
                                      comida.Y * Configuracoes.Altura, Configuracoes.Largura, Configuracoes.Altura));
                }
            }
            else
            {
                string fimDeJogo = "Fim de Jogo\nSua pontuacao foi: " + Configuracoes.Pontos + "\nPressione Enter para jogar novamente.";
                lblFimDeJogo.Text = fimDeJogo;
                lblFimDeJogo.Visible = true;
                ArmazenarPontuacao();

            }
        }

        private void MovimentacaoDoPlayer()
        {
            for (int i = Cobra.Count -1; i >= 0; i--)
            {
                //Movimenta a cabeça.
                if(i == 0)
                {
                    switch (Configuracoes.direcao)
                    {
                        case Direcao.Direita:
                            Cobra[i].X++;
                            break;
                        case Direcao.Esquerda:
                            Cobra[i].X--;
                            break;
                        case Direcao.Cima:
                            Cobra[i].Y--;
                            break;
                        case Direcao.Baixo:
                            Cobra[i].Y++;
                            break;
                    }

                    int maxXPosicao = pbTela.Size.Width / Configuracoes.Largura;
                    int maxYPosicao = pbTela.Size.Height / Configuracoes.Altura;

                    //Detecta colisão com as bordas.
                    if (Cobra[i].X < 0 || Cobra[i].Y < 0
                        || Cobra[i].X >= maxXPosicao || Cobra[i].Y >= maxYPosicao)
                    {
                        Perde();
                    }

                    //Detecta colisão com o corpo da cobra.
                    for (int j = 1; j < Cobra.Count; j++)
                    {
                        if (Cobra[i].X == Cobra[j].X && 
                            Cobra[i].Y == Cobra[j].Y)
                        {
                            Perde();
                        }
                    }

                    //Detecta colisão com a comida.
                    if (Cobra[0].X == comida.X && Cobra[0].Y == comida.Y)
                    {
                        Comer();
                    }
                }

                //Movimenta o corpo.
                else
                {
                    Cobra[i].X = Cobra[i - 1].X;
                    Cobra[i].Y = Cobra[i - 1].Y;
                }
            }
        }

        private void Perde()
        {
            Configuracoes.FimDeJogo = true;   
        }

        private void Comer()
        {
            //Adiciona tamanho à cobra.
            Circulo comida = new Circulo();
            comida.X = Cobra[Cobra.Count - 1].X;
            comida.Y = Cobra[Cobra.Count - 1].Y;

            Cobra.Add(comida);

            //Adiciona os pontos ao label na tela.
            Configuracoes.Pontos += Configuracoes.PontosPorComida;
            lblPontos.Text = Configuracoes.Pontos.ToString();

            contadorComida += 1;

            AumentarVelocidade();
            GerarComida();
        }

        private void AumentarVelocidade()
        {
            if ((contadorComida % 2 == 0) && (Configuracoes.Velocidade > 70))
            {
                contadorVelocidade += 1;
                Configuracoes.Velocidade -= 1;
                TempoDeJogo.Interval = Configuracoes.Velocidade;
                lblVelocidade.Text = contadorVelocidade.ToString();
            }
            else if (Configuracoes.Velocidade <= 70) lblVelocidade.Text = "Máxima";
        }

        private void ArmazenarPontuacao()
        {
            try
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\T-Gamer\Documents\iota\ADNPs\POO\Vstudio\FinalProject\FinalProject\ScoreBD.mdf;Integrated Security=True;Connect Timeout=30";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                //MessageBox.Show("Connection Open !");

                SqlCommand command = cnn.CreateCommand();
                command.CommandText = "insert into TBPontos (Pontuacoes) values ('"+Configuracoes.Pontos+"')";
                command.ExecuteNonQuery();

                MostrarMelhorPontuacao();

                cnn.Close();
                //MessageBox.Show("Deu certo !");
            }
            catch (SqlException erro)
            {
                MessageBox.Show("Erro" + erro);
            }
        }

        private void MostrarMelhorPontuacao()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\T-Gamer\Documents\iota\ADNPs\POO\Vstudio\FinalProject\FinalProject\ScoreBD.mdf;Integrated Security=True;Connect Timeout=30";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            MaiorPontuacao = new SqlCommand("SELECT MAX(Pontuacoes) FROM TBPontos", cnn).ExecuteScalar();
            melhorPontuaçãoLabel1.Text = MaiorPontuacao.ToString();

            cnn.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Entrada.MudarCondicao(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Entrada.MudarCondicao(e.KeyCode, false);
        }

        private void SCOREBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sCOREBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scoreBDDataSet);

        }

        private void Inicializador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'scoreBDDataSet1.TBPontos'. Você pode movê-la ou removê-la conforme necessário.
            this.tBPontosTableAdapter.Fill(this.scoreBDDataSet1.TBPontos);
            // TODO: esta linha de código carrega dados na tabela 'scoreBDDataSet.SCORE'. Você pode movê-la ou removê-la conforme necessário.
            this.sCORETableAdapter.Fill(this.scoreBDDataSet.SCORE);

        }
    }
}
