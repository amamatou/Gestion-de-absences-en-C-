using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences
{
    class Absences
    {
        int Num_semaine, ID, Nbr_absences;

        public Absences(int num_semaine, int iD, int nbr_absences)
        {
            Num_semaine = num_semaine;
            ID = iD;
            Nbr_absences = nbr_absences;
        }

        public int Num_semaine1 { get => Num_semaine; set => Num_semaine = value; }
        public int ID1 { get => ID; set => ID = value; }
        public int Nbr_absences1 { get => Nbr_absences; set => Nbr_absences = value; }
    }
}
