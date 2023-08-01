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
    public partial class Frm_Menu_Flutuante : Form
    {
        public Frm_Menu_Flutuante()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Flutuante1_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {           

                var ContextMenu = new ContextMenuStrip(); 

                var vToolTip001 = new ToolStripMenuItem();
                vToolTip001.Text = "Item 1 do menu";

                var vToolTip002 = new ToolStripMenuItem();
                vToolTip002.Text = "Item 2 do menu";

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new System.EventHandler(vToolTip001_Click);
                vToolTip002.Click += new System.EventHandler(vToolTip002_Click);

            }

            void vToolTip001_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu flutuante 001");
            }

            void vToolTip002_Click(object sender1, EventArgs e1)
            {
                MessageBox.Show("Selecionei a opção do menu flutuante 002");
            }


            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem(); 
                vToolTip.Text = text;

                Image myImage = (Image)global::CursoWindowsForms.Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = myImage;

                return vToolTip;
            }
            
        }
    }
}
