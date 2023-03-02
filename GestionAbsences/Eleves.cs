using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences
{
    class Eleves
    {
        int id;
        string nom, prenom;
        int groupe;

        public Eleves(int id=0, string nom = null, string prenom = null, int groupe = 0)
        {
            this.id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Groupe = groupe;
        }

        public int ID { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Groupe { get => groupe; set => groupe = value; }
    }
}
