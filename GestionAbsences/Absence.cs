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
    public partial class Absence : Form
    {
        public Absence()
        {
            InitializeComponent();
            text_total_absences.Enabled = false;
        }
        public static void ouvrir()
        {
            Absence abs = new Absence();
            abs.Show();
        }
        private void Absence_Load(object sender, EventArgs e)
        {
        }
        public void setTextid(string txt)
        {
            text_id.Text = txt;
        }

        private int Inserer(Absences o)
        {
            string sql = "insert into Absences(Num_semaine,ID,Nbr_absences)" +
              " values('" + o.Num_semaine1 + "','" + o.ID1+ o.Nbr_absences1 + "')";
            return (Connexion.IUD(sql));
        }
        private int Modifier(Absences o)
        {
            string sql = "update Absences set Num_semaine='" + o.Num_semaine1 + "'," + "Nbr_absences='" + o.Nbr_absences1 + "' " + "where id=" + o.ID1;
            return Connexion.IUD(sql);
        }
        private void button_enregistrer_Click(object sender, EventArgs em)
        {
            try
            {
                ElevesDAO elv = new ElevesDAO();
                Boolean a = false;
                List<Eleves> LE = elv.Select();
                for (int i = 0; i < LE.Count; i++)
                {
                    if (Int32.Parse(text_id.Text) == LE[i].ID)
                        a = true;
                }
                if (a == false)
                {
                    if (Inserer(new Absences(Int32.Parse((string)comboBox_semaine.SelectedItem), Int32.Parse(text_id.Text), Int32.Parse(text_nbAbsences.Text))) != 0)
                    {
                        MessageBox.Show("Enregistrement effectué !!!!");
                    }
                }
                else
                {
                    if (Modifier(new Absences(Int32.Parse((string)comboBox_semaine.SelectedItem), Int32.Parse(text_id.Text), Int32.Parse(text_nbAbsences.Text))) != 0)
                    {
                        MessageBox.Show("Modification effectué !!!!");
                    
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
