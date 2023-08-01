﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Questao : Form
    {
        public Frm_Questao(string nomeImagem, string mensagem)
        {
            InitializeComponent();

            var MyImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            Pic_Imagem.Image = MyImage;
            Lbl_Questao.Text = mensagem;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
