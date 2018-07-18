using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetEnvironmentVariable("HOMEDRIVE")
                + Environment.GetEnvironmentVariable("HOMEPATH")
                + "\\Pictures";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Limpando a figura
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Mostra a caixa de diálogo de cor. Se o usuário clicar OK, a cor de fundo
            // do controle PictureBox muda para a cor escolhida pelo usuário
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário seleciona o check box de Alongado,
            // a propriedade SizeMode do PictureBox muda para "Alongado".
            // Se o usuário limpar o check box, ele muda para "Normal".
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
    }
}
