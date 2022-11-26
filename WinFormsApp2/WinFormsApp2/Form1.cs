using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private TextBox[,] matriz;
        public Form1()
        {
            InitializeComponent();
        }
        private float[,] PopulaMatriz(int coluna, int linha)
        {
            float[,] matrizN;
            matrizN = new float[linha, coluna];
            for (int indice = 0; indice < linha; indice++)
            {

                for (int indice2 = 0; indice2 < coluna; indice2++)
                {
                    matrizN[indice, indice2] = float.Parse(matriz[indice, indice2].Text);
                }
            }
            return matrizN;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Label label3 = new Label();
            label3.Text = "Matriz 1";
            label3.Name = "label3";
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(356, 28);
            label3.Size = new Size(118, 38);

            Label labelcolunas = new Label();
            labelcolunas.Text = "Colunas";
            labelcolunas.Name = "labelcolunas";
            labelcolunas.ForeColor = SystemColors.ControlLightLight;
            labelcolunas.Location = new Point(269, 93);
            labelcolunas.Size = new Size(118, 38);

            Label labellinhas = new Label();
            labellinhas.Text = "Linhas";
            labellinhas.Name = "labellinhas";
            labellinhas.ForeColor = SystemColors.ControlLightLight;
            labellinhas.Location = new Point(449, 93);
            labellinhas.Size = new Size(118, 38);

            TextBox colunastxt = new TextBox();
            colunastxt.Text = " ";
            colunastxt.Name = "colunastxt";
            colunastxt.Location = new Point(269, 145);
            colunastxt.Size = new Size(125, 43);

            TextBox linhastxt = new TextBox();
            linhastxt.Text = " ";
            linhastxt.Name = "linhastxt";
            linhastxt.Location = new Point(449, 145);
            linhastxt.Size = new Size(125, 43);

            Button gerarbtn = new Button();
            gerarbtn.Text = "Gerar";
            gerarbtn.Name = "gerarbtn";
            gerarbtn.Location = new Point(299, 226);
            gerarbtn.Size = new Size(229, 69);
            gerarbtn.BackColor = SystemColors.ControlDark;

            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelcolunas);
            panel1.Controls.Add(labellinhas);
            panel1.Controls.Add(colunastxt);
            panel1.Controls.Add(linhastxt);
            



            gerarbtn.Click += (object sender, EventArgs e) =>
         {

             panel1.Controls.Clear();
             
             Label label3 = new Label();
             label3.Text = "Matriz 1";
             label3.Name = "label3";
             label3.ForeColor = SystemColors.ControlLightLight;
             label3.Location = new Point(356, 28);
             label3.Size = new Size(118, 38);
             panel1.Controls.Add(label3);

             int coluna = int.Parse(colunastxt.Text);
             int linhas = int.Parse(linhastxt.Text);


             int x = 20;
             int y = 83;

             matriz = new TextBox[linhas, coluna];
             for (int indice = 0; indice < linhas; indice++)
             {

                 for (int indice2 = 0; indice2 < coluna; indice2++)
                 {
                     matriz[indice, indice2] = new TextBox();
                     matriz[indice, indice2].Location = new Point(x, y);
                     matriz[indice, indice2].Text = "0";
                     matriz[indice, indice2].Width = 50;
                     panel1.Controls.Add(matriz[indice, indice2]);
                     x += 60;
                     if (indice2 == (coluna - 1))
                     {
                         x = 20;

                     }
                 }
                 y += 60;
             }

             Button teste = new Button();
             teste.Width = 200;
             teste.Height = 80;
             teste.Name = "Calcular";
             teste.Text = "Determinante";
             teste.Location = new Point(532, 64);
             teste.Click += (object sender, EventArgs e) =>
             {

                 if (coluna != linhas || coluna > 4)
                 {
                     MessageBox.Show("Não é possível calcular determinante desta matriz");
                 }
                 else
                 {
                     if(linhas == 1)
                     {
                         MessageBox.Show("1x1 não é uma matriz válida");
                     }
                     if (linhas == 2)
                     {
                         float[,] matrizNumeros = PopulaMatriz(coluna, linhas);
                         double detMatriz = (matrizNumeros[0, 0] * matrizNumeros[1, 1]) - (matrizNumeros[0, 1] * matrizNumeros[1, 0]);
                         MessageBox.Show($"Determinante: {detMatriz}");
                     }
                     if (linhas == 3)
                     {
                         float[,] matrizNumeros = PopulaMatriz(coluna, linhas);
                         double detMatriz = ((matrizNumeros[0, 0] * matrizNumeros[1, 1] * matrizNumeros[2, 2]) +
                           (matrizNumeros[0, 1] * matrizNumeros[1, 2] * matrizNumeros[2, 0]) +
                           (matrizNumeros[0, 2] * matrizNumeros[1, 0] * matrizNumeros[2, 1])) -
                           ((matrizNumeros[0, 2] * matrizNumeros[1, 1] * matrizNumeros[2, 0]) +
                           (matrizNumeros[0, 0] * matrizNumeros[1, 2] * matrizNumeros[2, 1]) +
                           (matrizNumeros[0, 1] * matrizNumeros[1, 0] * matrizNumeros[2, 2]));
                         MessageBox.Show($"Determinante: {detMatriz}");
                     }
                     if (linhas == 4)
                     {
                         float[,] matrizNumeros = PopulaMatriz(coluna, linhas);

                         double detMatrizUm = ((matrizNumeros[1, 1] * matrizNumeros[2, 2] * matrizNumeros[3, 3]) +
                           (matrizNumeros[1, 2] * matrizNumeros[2, 3] * matrizNumeros[3, 1]) +
                           (matrizNumeros[1, 3] * matrizNumeros[2, 1] * matrizNumeros[3, 2])) -
                           ((matrizNumeros[1, 3] * matrizNumeros[2, 2] * matrizNumeros[3, 1]) +
                           (matrizNumeros[1, 1] * matrizNumeros[2, 3] * matrizNumeros[3, 2]) +
                           (matrizNumeros[1, 2] * matrizNumeros[2, 1] * matrizNumeros[3, 3]));

                         double detMatrizDois = ((matrizNumeros[1, 0] * matrizNumeros[2, 2] * matrizNumeros[3, 3]) +
                           (matrizNumeros[1, 2] * matrizNumeros[2, 3] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 3] * matrizNumeros[2, 0] * matrizNumeros[3, 2])) -
                           ((matrizNumeros[1, 3] * matrizNumeros[2, 2] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 0] * matrizNumeros[2, 3] * matrizNumeros[3, 2]) +
                           (matrizNumeros[1, 2] * matrizNumeros[2, 0] * matrizNumeros[3, 3]));

                         double detMatrizTres = ((matrizNumeros[1, 0] * matrizNumeros[2, 1] * matrizNumeros[3, 3]) +
                           (matrizNumeros[1, 1] * matrizNumeros[2, 3] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 3] * matrizNumeros[2, 0] * matrizNumeros[3, 1])) -
                           ((matrizNumeros[1, 3] * matrizNumeros[2, 1] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 0] * matrizNumeros[2, 3] * matrizNumeros[3, 1]) +
                           (matrizNumeros[1, 1] * matrizNumeros[2, 0] * matrizNumeros[3, 3]));

                         double detMatrizQuatro = ((matrizNumeros[1, 0] * matrizNumeros[2, 1] * matrizNumeros[3, 2]) +
                           (matrizNumeros[1, 1] * matrizNumeros[2, 2] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 2] * matrizNumeros[2, 0] * matrizNumeros[3, 1])) -
                           ((matrizNumeros[1, 2] * matrizNumeros[2, 1] * matrizNumeros[3, 0]) +
                           (matrizNumeros[1, 0] * matrizNumeros[2, 2] * matrizNumeros[3, 1]) +
                           (matrizNumeros[1, 1] * matrizNumeros[2, 0] * matrizNumeros[3, 2]));

                         double detMatriz = 1 * matrizNumeros[0, 0] * detMatrizUm +
                                         (-1) * matrizNumeros[0, 1] * detMatrizDois +
                                         1 * matrizNumeros[0, 2] * detMatrizTres +
                                        (-1) * matrizNumeros[0, 3] * detMatrizQuatro;
                         MessageBox.Show($"Determinante: {detMatriz}");
                     }
                 }

             };

             panel1.Controls.Add(teste);
             Button novaMatriz = new Button();
             novaMatriz.Width = 200;
             novaMatriz.Height = 80;
             novaMatriz.Name = "novaMatriz";
             novaMatriz.Text = "Nova Matriz";
             novaMatriz.Location = new Point(532, 580);
             novaMatriz.Click += (object sender, EventArgs e) =>
             {
                 panel1.Controls.Clear();
                 Label label3 = new Label();
                 label3.Text = "CALCULAR MATRIZ";
                 label3.Name = "label3";
                 label3.ForeColor = SystemColors.ControlLightLight;
                 label3.Location = new Point(247, 28);
                 label3.Size = new Size(315, 45);

                 Button gerarbtn = new Button();
                 gerarbtn.Text = "Gerar Matriz";
                 gerarbtn.Name = "gerarbtn";
                 gerarbtn.Location = new Point(299, 226);
                 gerarbtn.Size = new Size(229, 69);
                 gerarbtn.Click += new EventHandler(this.button1_Click);
                 gerarbtn.BackColor = SystemColors.ControlDark;

                 panel1.Controls.Add(label3);
                 panel1.Controls.Add(gerarbtn);

             };
             panel1.Controls.Add(novaMatriz);
             
             Button MatrizInversa = new Button();
             MatrizInversa.Width = 200;
             MatrizInversa.Height = 80;
             MatrizInversa.Name = "Inversa";
             MatrizInversa.Text = "Inversa";
             MatrizInversa.Location = new Point(532, 236);
             MatrizInversa.Click += (object sender, EventArgs e) =>
             {   if (coluna == 2 && linhas == 2)
                 {
                     float[,] matrizInv = PopulaMatriz(coluna, linhas);
                     double[,] matrizInversa = new double[2, 2];
                     matrizInversa[0, 0] = matrizInv[1, 1];
                     matrizInversa[1, 1] = matrizInv[0, 0];
                     matrizInversa[0, 1] = -matrizInv[0, 1];
                     matrizInversa[1, 0] = -matrizInv[1, 0];
                   

                     for (int indice = 0; indice < linhas; indice++)
                     {

                         for (int indice2 = 0; indice2 < coluna; indice2++)
                         {
                           
                             matriz[indice, indice2].Text = matrizInversa[indice,indice2].ToString();

                         }
                    
                     }
                 }
                 else
                 {
                     MessageBox.Show("Não é possível calcular inversa que não seja ordem 2 neste programa");
                 }



             };
             panel1.Controls.Add(MatrizInversa);

             Button MatrizTransposta = new Button();
             MatrizTransposta.Width = 200;
             MatrizTransposta.Height = 80;
             MatrizTransposta.Name = "Tranposta";
             MatrizTransposta.Text = "Transposta";
             MatrizTransposta.Location = new Point(532, 150);
             MatrizTransposta.Click += (object sender, EventArgs e) =>
             {
                 float[,] matrizTransposta;
                 matrizTransposta = new float[linhas, coluna];
                 float[,] matrizTrans = PopulaMatriz(coluna, linhas);
                 for (int x = 0; x < linhas; x++)
                 {
                     for (int z = 0; z < coluna; z++)
                     {
                         matrizTransposta[x, z] = matrizTrans[z, x];
                     }
                 }

                 for (int indice = 0; indice < linhas; indice++)
                 {

                     for (int indice2 = 0; indice2 < coluna; indice2++)
                     {

                         matriz[indice, indice2].Text = matrizTransposta[indice, indice2].ToString() ;

                     }

                 }
             };
             panel1.Controls.Add(MatrizTransposta);
             Button MatrizSoma = new Button();
             MatrizSoma.Width = 200;
             MatrizSoma.Height = 80;
             MatrizSoma.Name = "Soma matriz";
             MatrizSoma.Text = "Soma Matriz";
             MatrizSoma.Location = new Point(532, 322);
             MatrizSoma.Click += (object sender, EventArgs e) =>
             {
                 float[,] matrizOriginal = new float[linhas, coluna];
                 matrizOriginal = PopulaMatriz(coluna, linhas);
                 panel1.Controls.Clear();
                 Label label3 = new Label();
                 label3.Text = "Matriz 2";
                 label3.Name = "label3";
                 label3.ForeColor = SystemColors.ControlLightLight;
                 label3.Location = new Point(356, 28);
                 label3.Size = new Size(118, 38);

                 Label labelcolunas = new Label();
                 labelcolunas.Text = "Colunas";
                 labelcolunas.Name = "labelcolunas2";
                 labelcolunas.ForeColor = SystemColors.ControlLightLight;
                 labelcolunas.Location = new Point(269, 93);
                 labelcolunas.Size = new Size(118, 38);

                 Label labellinhas = new Label();
                 labellinhas.Text = "Linhas";
                 labellinhas.Name = "labellinhas2";
                 labellinhas.ForeColor = SystemColors.ControlLightLight;
                 labellinhas.Location = new Point(449, 93);
                 labellinhas.Size = new Size(118, 38);

                 TextBox colunastxt = new TextBox();
                 colunastxt.Text = " ";
                 colunastxt.Name = "colunastxt2";
                 colunastxt.Location = new Point(269, 145);
                 colunastxt.Size = new Size(125, 43);

                 TextBox linhastxt = new TextBox();
                 linhastxt.Text = " ";
                 linhastxt.Name = "linhastxt2";
                 linhastxt.Location = new Point(449, 145);
                 linhastxt.Size = new Size(125, 43);

                 Button gerarbtn2 = new Button();
                 gerarbtn2.Text = "Gerar";
                 gerarbtn2.Name = "gerarbtn2";
                 gerarbtn2.Location = new Point(299, 226);
                 gerarbtn2.Size = new Size(229, 69);
                 gerarbtn2.BackColor = SystemColors.ControlDark;
                 

                 panel1.Controls.Add(label3);
                 panel1.Controls.Add(labelcolunas);
                 panel1.Controls.Add(labellinhas);
                 panel1.Controls.Add(colunastxt);
                 panel1.Controls.Add(linhastxt);
                 gerarbtn2.Click += (object sender, EventArgs e) =>
                 {

                     panel1.Controls.Clear();

                     Label label3 = new Label();
                     label3.Text = "Matriz 2";
                     label3.Name = "label3";
                     label3.ForeColor = SystemColors.ControlLightLight;
                     label3.Location = new Point(356, 28);
                     label3.Size = new Size(118, 38);
                     panel1.Controls.Add(label3);

                     int coluna = int.Parse(colunastxt.Text);
                     int linhas = int.Parse(linhastxt.Text);


                     int x = 20;
                     int y = 83;

                     matriz = new TextBox[linhas, coluna];
                     for (int indice = 0; indice < linhas; indice++)
                     {

                         for (int indice2 = 0; indice2 < coluna; indice2++)
                         {
                             matriz[indice, indice2] = new TextBox();
                             matriz[indice, indice2].Location = new Point(x, y);
                             matriz[indice, indice2].Text = "0";
                             matriz[indice, indice2].Width = 50;
                             panel1.Controls.Add(matriz[indice, indice2]);
                             x += 60;
                             if (indice2 == (coluna - 1))
                             {
                                 x = 20;

                             }
                         }
                         y += 60;
                     }

                     Button teste = new Button();
                     teste.Width = 200;
                     teste.Height = 80;
                     teste.Name = "Calcular";
                     teste.Text = "Somar";
                     teste.Location = new Point(532, 64);
                     teste.Click += (object sender, EventArgs e) =>
                     {
                         float[,] matrizOriginal2 = new float[linhas, coluna];
                         matrizOriginal2 = PopulaMatriz(coluna, linhas);
                         if (matrizOriginal.GetLength(0) == matrizOriginal2.GetLength(0) && matrizOriginal.GetLength(1) == matrizOriginal2.GetLength(1))
                         {
                             double[,] matriz = new double[matrizOriginal.GetLength(0), matrizOriginal2.GetLength(1)];

                             for (int yx = 0; yx < matrizOriginal.GetLength(0); yx++)
                             {
                                 for (int z = 0; z < matrizOriginal.GetLength(1); z++)
                                 {
                                     matriz[yx, z] = matrizOriginal[yx, z] + matrizOriginal2[yx, z];

                                 }
                             }
                             panel1.Controls.Clear();
                             Label label3 = new Label();
                             label3.Text = "RESULTADO";
                             Font smallFont = new Font("Arial", 9);
                             label3.Font = smallFont;
                             label3.Size = new Size(315, 45);
                             label3.Name = "label3";
                             label3.ForeColor = SystemColors.ControlLightLight;
                             label3.Location = new Point(356, 28);
                             label3.Size = new Size(118, 38);
                             panel1.Controls.Add(label3);

                             int coluna = matriz.GetLength(1);
                             int linhas = matriz.GetLength(0);


                             int x = 20;
                             int y = 83;
                             Label[,] matrizRes;
                             matrizRes = new Label[linhas, coluna];
                             for (int indice = 0; indice < linhas; indice++)
                             {

                                 for (int indice2 = 0; indice2 < coluna; indice2++)
                                 {
                                     matrizRes[indice, indice2] = new Label();
                                     matrizRes[indice, indice2].Location = new Point(x, y);
                                     Font fsmallFont = new Font("Arial", 9);
                                     matrizRes[indice, indice2].Font = fsmallFont;
                                     matrizRes[indice, indice2].Text = matriz[indice, indice2].ToString();
                                     matrizRes[indice, indice2].Width = 50;
                                     panel1.Controls.Add(matrizRes[indice, indice2]);
                                     x += 60;
                                     if (indice2 == (coluna - 1))
                                     {
                                         x = 20;

                                     }
                                 }
                                 y += 60;
                             }
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);

                         }
                         else
                         {
                             MessageBox.Show("Não é possível Somar estas matrizes");
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);
                         }
                     };
                     panel1.Controls.Add(teste);
                 };
                 panel1.Controls.Add(gerarbtn2);

             };
             
             panel1.Controls.Add(MatrizSoma);
             Button MatrizSubtrai = new Button();
             MatrizSubtrai.Width = 200;
             MatrizSubtrai.Height = 80;
             MatrizSubtrai.Name = "Subtrai Matriz";
             MatrizSubtrai.Text = "Subtrai Matriz";
             MatrizSubtrai.Location = new Point(532, 408);
             MatrizSubtrai.Click += (object sender, EventArgs e) =>
             {
                 float[,] matrizOriginal = new float[linhas, coluna];
                 matrizOriginal = PopulaMatriz(coluna, linhas);
                 panel1.Controls.Clear();
                 Label label3 = new Label();
                 label3.Text = "Matriz 2";
                 label3.Name = "label3";
                 label3.ForeColor = SystemColors.ControlLightLight;
                 label3.Location = new Point(356, 28);
                 label3.Size = new Size(118, 38);

                 Label labelcolunas = new Label();
                 labelcolunas.Text = "Colunas";
                 labelcolunas.Name = "labelcolunas2";
                 labelcolunas.ForeColor = SystemColors.ControlLightLight;
                 labelcolunas.Location = new Point(269, 93);
                 labelcolunas.Size = new Size(118, 38);

                 Label labellinhas = new Label();
                 labellinhas.Text = "Linhas";
                 labellinhas.Name = "labellinhas2";
                 labellinhas.ForeColor = SystemColors.ControlLightLight;
                 labellinhas.Location = new Point(449, 93);
                 labellinhas.Size = new Size(118, 38);

                 TextBox colunastxt = new TextBox();
                 colunastxt.Text = " ";
                 colunastxt.Name = "colunastxt2";
                 colunastxt.Location = new Point(269, 145);
                 colunastxt.Size = new Size(125, 43);

                 TextBox linhastxt = new TextBox();
                 linhastxt.Text = " ";
                 linhastxt.Name = "linhastxt2";
                 linhastxt.Location = new Point(449, 145);
                 linhastxt.Size = new Size(125, 43);

                 Button gerarbtn2 = new Button();
                 gerarbtn2.Text = "Gerar";
                 gerarbtn2.Name = "gerarbtn2";
                 gerarbtn2.Location = new Point(299, 226);
                 gerarbtn2.Size = new Size(229, 69);
                 gerarbtn2.BackColor = SystemColors.ControlDark;


                 panel1.Controls.Add(label3);
                 panel1.Controls.Add(labelcolunas);
                 panel1.Controls.Add(labellinhas);
                 panel1.Controls.Add(colunastxt);
                 panel1.Controls.Add(linhastxt);
                 gerarbtn2.Click += (object sender, EventArgs e) =>
                 {

                     panel1.Controls.Clear();

                     Label label3 = new Label();
                     label3.Text = "Matriz 2";
                     label3.Name = "label3";
                     label3.ForeColor = SystemColors.ControlLightLight;
                     label3.Location = new Point(356, 28);
                     label3.Size = new Size(118, 38);
                     panel1.Controls.Add(label3);

                     int coluna = int.Parse(colunastxt.Text);
                     int linhas = int.Parse(linhastxt.Text);


                     int x = 20;
                     int y = 83;

                     matriz = new TextBox[linhas, coluna];
                     for (int indice = 0; indice < linhas; indice++)
                     {

                         for (int indice2 = 0; indice2 < coluna; indice2++)
                         {
                             matriz[indice, indice2] = new TextBox();
                             matriz[indice, indice2].Location = new Point(x, y);
                             matriz[indice, indice2].Text = "0";
                             matriz[indice, indice2].Width = 50;
                             panel1.Controls.Add(matriz[indice, indice2]);
                             x += 60;
                             if (indice2 == (coluna - 1))
                             {
                                 x = 20;

                             }
                         }
                         y += 60;
                     }

                     Button teste = new Button();
                     teste.Width = 200;
                     teste.Height = 80;
                     teste.Name = "Calcular";
                     teste.Text = "Subtrair";
                     teste.Location = new Point(532, 64);
                     teste.Click += (object sender, EventArgs e) =>
                     {
                         float[,] matrizOriginal2 = new float[linhas, coluna];
                         matrizOriginal2 = PopulaMatriz(coluna, linhas);
                         if (matrizOriginal.GetLength(0) == matrizOriginal2.GetLength(0) && matrizOriginal.GetLength(1) == matrizOriginal2.GetLength(1))
                         {
                             double[,] matriz = new double[matrizOriginal.GetLength(0), matrizOriginal2.GetLength(1)];

                             for (int yx = 0; yx < matrizOriginal.GetLength(0); yx++)
                             {
                                 for (int z = 0; z < matrizOriginal.GetLength(0); z++)
                                 {
                                     matriz[yx, z] = matrizOriginal[yx, z] - matrizOriginal2[yx, z];

                                 }
                             }
                             panel1.Controls.Clear();
                             Label label3 = new Label();
                             label3.Text = "RESULTADO";
                             label3.Name = "label3";
                             Font smallFont = new Font("Arial", 12);
                             label3.Font = smallFont;
                             label3.Size = new Size(315, 45);
                             label3.ForeColor = SystemColors.ControlLightLight;
                             label3.Location = new Point(356, 28);
                             label3.Size = new Size(118, 38);
                             panel1.Controls.Add(label3);

                             int coluna = matriz.GetLength(1);
                             int linhas = matriz.GetLength(0);


                             int x = 20;
                             int y = 83;
                             Label[,] matrizRes;
                             matrizRes = new Label[linhas, coluna];
                             for (int indice = 0; indice < linhas; indice++)
                             {

                                 for (int indice2 = 0; indice2 < coluna; indice2++)
                                 {
                                     matrizRes[indice, indice2] = new Label();
                                     matrizRes[indice, indice2].Location = new Point(x, y);
                                     Font ffsmallFont = new Font("Arial", 9);
                                     matrizRes[indice, indice2].Font = ffsmallFont;
                                     matrizRes[indice, indice2].Text = matriz[indice, indice2].ToString();
                                     matrizRes[indice, indice2].Width = 50;
                                     panel1.Controls.Add(matrizRes[indice, indice2]);
                                     x += 60;
                                     if (indice2 == (coluna - 1))
                                     {
                                         x = 20;

                                     }
                                 }
                                 y += 60;
                             }
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);

                         }

                         else
                         {
                             MessageBox.Show("Não é possíve Subtratir estas matrizes");
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);
                         }
                     };
                     panel1.Controls.Add(teste);

                 };
                 panel1.Controls.Add(gerarbtn2);
             };
             panel1.Controls.Add(MatrizSubtrai);
             Button MatrizMultiplica = new Button();
             MatrizMultiplica.Width = 200;
             MatrizMultiplica.Height = 80;
             MatrizMultiplica.Name = "Multiplica Matriz";
             MatrizMultiplica.Text = "Multiplica Matriz";
             MatrizMultiplica.Location = new Point(532, 494);
             MatrizMultiplica.Click += (object sender, EventArgs e) =>
             {
                 float[,] matrizOriginal = new float[linhas, coluna];
                 matrizOriginal = PopulaMatriz(coluna, linhas);
                 panel1.Controls.Clear();
                 Label label3 = new Label();
                 label3.Text = "Matriz 2";
                 label3.Name = "label3";
                 label3.ForeColor = SystemColors.ControlLightLight;
                 label3.Location = new Point(356, 28);
                 label3.Size = new Size(118, 38);

                 Label labelcolunas = new Label();
                 labelcolunas.Text = "Colunas";
                 labelcolunas.Name = "labelcolunas2";
                 labelcolunas.ForeColor = SystemColors.ControlLightLight;
                 labelcolunas.Location = new Point(269, 93);
                 labelcolunas.Size = new Size(118, 38);

                 Label labellinhas = new Label();
                 labellinhas.Text = "Linhas";
                 labellinhas.Name = "labellinhas2";
                 labellinhas.ForeColor = SystemColors.ControlLightLight;
                 labellinhas.Location = new Point(449, 93);
                 labellinhas.Size = new Size(118, 38);

                 TextBox colunastxt = new TextBox();
                 colunastxt.Text = " ";
                 colunastxt.Name = "colunastxt2";
                 colunastxt.Location = new Point(269, 145);
                 colunastxt.Size = new Size(125, 43);

                 TextBox linhastxt = new TextBox();
                 linhastxt.Text = " ";
                 linhastxt.Name = "linhastxt2";
                 linhastxt.Location = new Point(449, 145);
                 linhastxt.Size = new Size(125, 43);

                 Button gerarbtn2 = new Button();
                 gerarbtn2.Text = "Gerar";
                 gerarbtn2.Name = "gerarbtn2";
                 gerarbtn2.Location = new Point(299, 226);
                 gerarbtn2.Size = new Size(229, 69);
                 gerarbtn2.BackColor = SystemColors.ControlDark;


                 panel1.Controls.Add(label3);
                 panel1.Controls.Add(labelcolunas);
                 panel1.Controls.Add(labellinhas);
                 panel1.Controls.Add(colunastxt);
                 panel1.Controls.Add(linhastxt);
                 gerarbtn2.Click += (object sender, EventArgs e) =>
                 {

                     panel1.Controls.Clear();

                     Label label3 = new Label();
                     label3.Text = "Matriz 2";
                     label3.Name = "label3";
                     label3.ForeColor = SystemColors.ControlLightLight;
                     label3.Location = new Point(356, 28);
                     label3.Size = new Size(118, 38);
                     panel1.Controls.Add(label3);

                     int coluna = int.Parse(colunastxt.Text);
                     int linhas = int.Parse(linhastxt.Text);


                     int x = 20;
                     int y = 83;

                     matriz = new TextBox[linhas, coluna];
                     for (int indice = 0; indice < linhas; indice++)
                     {

                         for (int indice2 = 0; indice2 < coluna; indice2++)
                         {
                             matriz[indice, indice2] = new TextBox();
                             matriz[indice, indice2].Location = new Point(x, y);
                             matriz[indice, indice2].Text = "0";
                             matriz[indice, indice2].Width = 50;
                             panel1.Controls.Add(matriz[indice, indice2]);
                             x += 60;
                             if (indice2 == (coluna - 1))
                             {
                                 x = 20;

                             }
                         }
                         y += 60;
                     }

                     Button teste = new Button();
                     teste.Width = 200;
                     teste.Height = 80;
                     teste.Name = "Calcular";
                     teste.Text = "Multiplicar";
                     teste.Location = new Point(532, 64);
                     teste.Click += (object sender, EventArgs e) =>
                     {
                         float[,] matrizOriginal2 = new float[linhas, coluna];
                         matrizOriginal2 = PopulaMatriz(coluna, linhas);
                         if ((matrizOriginal.GetLength(1)) == (matrizOriginal2.GetLength(0)))
                         {

                             double[,] matriz = new double[(matrizOriginal.GetLength(0)), (matrizOriginal2.GetLength(1))];
                             for (int i = 0; i < matrizOriginal.GetLength(1); i++)
                             {
                                 for (int z = 0; z < matrizOriginal.GetLength(0); z++)
                                 {
                                     for (int yx = 0; yx < matrizOriginal2.GetLength(0); yx++)
                                     {
                                         matriz[z, i] += matrizOriginal[z, yx] * matrizOriginal2[yx, i];

                                     }
                                 }
                             }
                             panel1.Controls.Clear();
                             Label label3 = new Label();
                             label3.Text = "RESULTADO";
                             Font smallFont = new Font("Arial", 12);
                             label3.Font = smallFont;
                             label3.Size = new Size(315, 45);
                             label3.Name = "label3";
                             label3.ForeColor = SystemColors.ControlLightLight;
                             label3.Location = new Point(356, 28);
                             label3.Size = new Size(118, 38);
                             panel1.Controls.Add(label3);

                             int coluna = matriz.GetLength(1);
                             int linhas = matriz.GetLength(0);


                             int x = 20;
                             int y = 83;
                             Label[,] matrizRes;
                             matrizRes = new Label[linhas, coluna];
                             for (int indice = 0; indice < linhas; indice++)
                             {

                                 for (int indice2 = 0; indice2 < coluna; indice2++)
                                 {
                                     matrizRes[indice, indice2] = new Label();
                                     matrizRes[indice, indice2].Location = new Point(x, y);
                                     Font fffsmallFont = new Font("Arial", 9);
                                     matrizRes[indice, indice2].Font = fffsmallFont;
                                     matrizRes[indice, indice2].Text = matriz[indice, indice2].ToString();
                                     matrizRes[indice, indice2].Width = 50;
                                     panel1.Controls.Add(matrizRes[indice, indice2]);
                                     x += 60;
                                     if (indice2 == (coluna - 1))
                                     {
                                         x = 20;

                                     }
                                 }
                                 y += 60;
                             }
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);
                         }
                         else
                         {
                             MessageBox.Show("Não é possível multiplicar essas Matrizes");
                             Button novaMatriz = new Button();
                             novaMatriz.Width = 200;
                             novaMatriz.Height = 80;
                             novaMatriz.Name = "novaMatriz";
                             novaMatriz.Text = "Nova Matriz";
                             novaMatriz.Location = new Point(532, 580);
                             novaMatriz.Click += (object sender, EventArgs e) =>
                             {
                                 panel1.Controls.Clear();
                                 Label label3 = new Label();
                                 label3.Text = "CALCULAR MATRIZ";
                                 label3.Name = "label3";
                                 label3.ForeColor = SystemColors.ControlLightLight;
                                 label3.Location = new Point(247, 28);
                                 label3.Size = new Size(315, 45);

                                 Button gerarbtn = new Button();
                                 gerarbtn.Text = "Gerar Matriz";
                                 gerarbtn.Name = "gerarbtn";
                                 gerarbtn.Location = new Point(299, 226);
                                 gerarbtn.Size = new Size(229, 69);
                                 gerarbtn.Click += new EventHandler(this.button1_Click);
                                 gerarbtn.BackColor = SystemColors.ControlDark;

                                 panel1.Controls.Add(label3);
                                 panel1.Controls.Add(gerarbtn);

                             };
                             panel1.Controls.Add(novaMatriz);
                         }
                     };
                     panel1.Controls.Add(teste);

                 };
                 panel1.Controls.Add(gerarbtn2);
             };
             panel1.Controls.Add(MatrizMultiplica);
         };
            panel1.Controls.Add(gerarbtn);
        }

     }
}
