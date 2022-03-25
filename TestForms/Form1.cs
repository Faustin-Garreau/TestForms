using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_informations.Text = "";
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            String PrenomForm = tb_prenom.Text;
            String NomForm = tb_nom.Text;

            if(PrenomForm == "")
            {
                erreur_prenom_deux.Text = "Veuillez remplir le champ prenom";
                erreur_prenom_deux.ForeColor = Color.Red;
                lb_informations.Text = "";
            } else
            {
                erreur_prenom_deux.Text = "";
                lb_informations.Text = "";
            }

            if (NomForm == "")
            {
                erreur_nom.Text = "Veuillez remplir le champ prenom";
                erreur_nom.ForeColor = Color.Red;
                lb_informations.Text = "";
            }else
            {
                erreur_nom.Text = "";
                lb_informations.Text = "";
            }

            if (PrenomForm != "" && NomForm != "")
            {
                lb_informations.Text = "Le compte de M/Mme" + NomForm + " et de son prenom " + PrenomForm + " a bien été créé";
                erreur_prenom_deux.Text = "";
                erreur_nom.Text = "";
            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            tb_prenom.Text = "";
            tb_nom.Text = "";
            lb_informations.Text = "Les informations ont bien été supprimées !";
            lb_informations.ForeColor = Color.Green;
        }
    }
}
