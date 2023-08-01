﻿using CursoWindowsForms.Formulários_UC;
using System;
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
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleSenha = 0;
        int ControleArquivoImagem = 0;
        int ControleCadastroClientes = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            apagarAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;

            // apenas para lembrar que teria que fazer isso também =D

            //demonstraçãoKeyToolStripMenuItem.ShortcutKeys = Keys.None;
            //helloWorldToolStripMenuItem.ShortcutKeys = Keys.None;
            //mascaraToolStripMenuItem.ShortcutKeys = Keys.None;
            //validaCPFToolStripMenuItem.ShortcutKeys = Keys.None;
            //validaCPF2ToolStripMenuItem.ShortcutKeys = Keys.None;
            //validaSenhaToolStripMenuItem.ShortcutKeys = Keys.None;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;

            var U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = "Demonstração Key " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ControleHelloWorld += 1;

           var U = new Frm_HelloWorld_UC();
           U.Dock = DockStyle.Fill;
           var TB = new TabPage();
           TB.Name = "Hello World " + ControleHelloWorld;
           TB.Text = "Hello World " + ControleHelloWorld;
           TB.ImageIndex = 1;  
           TB.Controls.Add(U);
           Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;

            var U = new Frm_Mascara_UC();
            //U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Mascara " + ControleMascara;
            TB.Text = "Mascara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;

            var U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valida CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;

            var U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = "Valida CPF2 " + ControleValidaCPF2;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleSenha += 1;

            var U = new Frm_ValidaSenha_UC();
            //U.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleSenha;
            TB.Text = "Valida CPF2 " + ControleSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\helop\\OneDrive\\Área de Trabalho\\VisualStudioProjects\\Alura_CSharp_Forms\\CursoWindowsForms\\CursoWindowsForms\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;

                ControleArquivoImagem += 1;
                var U = new Frm_ArquivoImagem_UC(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                var TB = new TabPage();
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = "Arquivo Imagem " + ControleArquivoImagem;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;


                if (CursoWindowsFormsBiblioteca.Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    apagarAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    desconectarToolStripMenuItem.Enabled = true;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem-Vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);  
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Db = new Frm_Questao("icons8_question_mark_96", "Você deseja se desconectar?");
            Db.ShowDialog();

            if (Db.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);

                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i+=-1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                apagarAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                desconectarToolStripMenuItem.Enabled = false;
                cadastrosToolStripMenuItem.Enabled = false;
            }
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

                var ContextMenu = new ContextMenuStrip();

                var vToolTip001 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip002 = DesenhaItemMenu("Apagar todas a esquerda", "DeleteLeft");
                var vToolTip003 = DesenhaItemMenu("Apagar todas a direita", "DeleteRight");
                var vToolTip004 = DesenhaItemMenu("Apagar todas menos esta", "DeleteAll");


                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Items.Add(vToolTip003);
                ContextMenu.Items.Add(vToolTip004);


                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);
                vToolTip003.Click += new System.EventHandler(vToolTip003_Click);
                vToolTip004.Click += new System.EventHandler(vToolTip004_Click);

            }   

        }

        void vToolTip001_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        void vToolTip002_Click(object sender1, EventArgs e1)
        {
           if (!(Tbc_Aplicacoes.SelectedTab == null))
           {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
           }
            
        }

        void vToolTip003_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void vToolTip004_Click(object sender1, EventArgs e1)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }
        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
            vToolTip.Image = myImage;

            return vToolTip;
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1; i > ItemSelecionado; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i--)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControleCadastroClientes == 0)
            {
                ControleCadastroClientes += 1;

                var U = new Frm_CadastroCliente_UC();
                U.Dock = DockStyle.Fill;
                var TB = new TabPage();
                TB.Name = "Cadastro de Clientes ";
                TB.Text = "Cadastro de Clientes ";
                TB.ImageIndex = 7;
                TB.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TB);
            }
            else
            {
                MessageBox.Show("Não é possível abrir mais de uma aba de Cadastro de Cliente.", 
                                "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }

        void ApagaAba(TabPage TB)
        {
            if (TB.Name == "Cadastro de Clientes")
            {
                ControleCadastroClientes = 0;
            }
            Tbc_Aplicacoes.TabPages.Remove(TB);
        }

        private void agênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FForm = new Frm_Agencia();
            FForm.ShowDialog();
        }
    }
}

