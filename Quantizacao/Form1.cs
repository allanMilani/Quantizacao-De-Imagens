using DIPLi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quantizacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Imagem img = new Imagem("C:\\Users\\allan\\source\\repos\\Quantizacao\\Quantizacao\\Cerebro.bmp");
        
        public void Quantizacao(Imagem I, PictureBox Result, int subDivision) {
            Imagem aux = new Imagem(I.Largura, I.Altura);
            int color = 255 / (subDivision - 1);
            int range = 256 / subDivision;
            for (int i = 0; i < I.Altura; i++)
            {
                for (int j = 0; j < I.Largura; j++)
                {
                    if (I[i, j] >= 0 && I[i, j] <= range)
                    {
                        aux[i, j] = 0;
                    }
                    else
                    {
                        aux[i, j] = color * Math.Floor(I[i, j] / range);
                    }
                }
            }
            Result.Image = aux.ToBitmap();
        }

        private void btnSub2_Click(object sender, EventArgs e)
        {
           Quantizacao(img, pbImagem, 2);
        }

        private void btnSub4_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 4);
        }

        private void btnSub8_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 8);
        }

        private void btnSub16_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 16);
        }

        private void btnSub32_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 32);
        }

        private void btnSub64_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 64);
        }

        private void btnSub128_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 128);
        }

        private void btnSub256_Click(object sender, EventArgs e)
        {
            Quantizacao(img, pbImagem, 256);
        }
    }
}
