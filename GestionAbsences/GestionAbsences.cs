using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAbsences
{
    public partial class GestionAbsences : Form
    {
        ElevesDAO elv;
        public GestionAbsences()
        {
            InitializeComponent();
            try
            {
                elv = new ElevesDAO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Charger()
        {
            dataEleve.Rows.Clear();
            List<Eleves> LE = elv.Select();
            for (int i = 0; i < LE.Count; i++)
            {
                dataEleve.Rows.Add();
                dataEleve.Rows[i].Cells[0].Value = LE[i].ID;
                dataEleve.Rows[i].Cells[1].Value = LE[i].Nom;
                dataEleve.Rows[i].Cells[2].Value = LE[i].Prenom;
                dataEleve.Rows[i].Cells[3].Value = LE[i].Groupe;

            }
        }
        private void Vider()
        {
            text_nom.Text = "";
            text_prenom.Text = "";
            text_groupe.Text = "";
        }
        public int getID()
        {
            return Int32.Parse(text_id.Text);
        }
        //private void Desactiver()
        //{
        //    text_nom.Enabled = false;
        //    text_prenom.Enabled = false;
        //    text_groupe.Enabled = false;
        //}
        //private void Reactiver()
        //{
        //    text_nom.Enabled = true;
        //    text_prenom.Enabled = true;
        //    text_groupe.Enabled = true;
        //}
        private void button_gestion_absences_Click(object sender, EventArgs e)
        {
            Absence.ouvrir();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean a= false;
                List<Eleves> LE = elv.Select();
                for (int i = 0; i < LE.Count; i++)
                {
                    if (Int32.Parse(text_id.Text) == LE[i].ID)
                        a = true;
                }
                if(a == true)
                {
                    MessageBox.Show("cet id a déja été attribué !!!!");
                    text_id.Focus();
                }
                else
                {
                    if (elv.Insert(new Eleves(Int32.Parse(text_id.Text), text_nom.Text, text_prenom.Text, Int32.Parse(text_groupe.Text))) != 0)
                    {
                        MessageBox.Show("Ajout effectué !!!!");
                        Vider();
                        Charger();
                    }
                }
                    
            }
            catch 
            {
                MessageBox.Show("Les champs sont vides !!!!");
            }
        }


        private void button_supprimer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmer la suppression ?", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (elv.Delete(new Eleves(Int32.Parse(text_id.Text))) != 0)
                    {
                        MessageBox.Show("Suppression effectuée !!!!");
                    }
                    else
                    {
                        MessageBox.Show("Id inextistant !!!!");
                    }
                    Vider();
                    Charger();
                }
                catch
                {
                    MessageBox.Show("Entrez l'Id de l'eleve à supprimer !!!!");
                }
            }
            
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean a = false;
                List<Eleves> LE = elv.Select();
                for (int i = 0; i < LE.Count; i++)
                {
                    if (Int32.Parse(text_id.Text) == LE[i].ID)
                        a = true;
                }
                if (a == true)
                {

                    if (elv.Update(new Eleves(Int32.Parse(text_id.Text), text_nom.Text, text_prenom.Text, Int32.Parse(text_groupe.Text))) != 0)
                    {
                        MessageBox.Show("Modification effectué !!!!");
                        Vider();
                        Charger();
                    }
                }
                else
                {
                        MessageBox.Show("Id inextistant !!!!");
                }
            }
            catch 
            {
                MessageBox.Show("Les champs sont vides !!!!");
            }
        }

        private void GestionAbsences_Load(object sender, EventArgs e)
        {
            Charger();
        }

        private void button_rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                dataEleve.Rows.Clear();
                List<Eleves> LE = elv.Select(new Eleves(Int32.Parse(text_id.Text)));
                if (LE.Count != 0)
                {
                    for (int i = 0; i < LE.Count; i++)
                    {
                        if (Int32.Parse(text_id.Text) == LE[i].ID)
                        {
                            dataEleve.Rows.Add();
                            dataEleve.Rows[i].Cells[0].Value = LE[i].ID;
                            dataEleve.Rows[i].Cells[1].Value = LE[i].Nom;
                            dataEleve.Rows[i].Cells[2].Value = LE[i].Prenom;
                            dataEleve.Rows[i].Cells[3].Value = LE[i].Groupe;
                        }
                    }
                    

                }
                else
                {
                    MessageBox.Show("Id inextistant !!!!");
                    Vider();
                }
            }
            catch
            {
                MessageBox.Show("Entrez l'Id de l'eleve recherché !!!!");
            }
        }
    }
}
