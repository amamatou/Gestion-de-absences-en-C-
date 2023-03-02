using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionAbsences
{
    class ElevesDAO : IDAO<Eleves>
    {
        public ElevesDAO()
        {
            Connexion.Connect("gestion_absence");
        }
        public int Delete(Eleves o)
        {
            string sql = "delete from Eleves where ID=" + o.ID;
            return Connexion.IUD(sql);
        }

        public int Insert(Eleves o)
        {
            string sql = "insert into Eleves(id,nom,prenom,groupe)" +
              " values('" + o.ID + "','" + o.Nom + "','" + o.Prenom + "','" + o.Groupe + "')";
            return Connexion.IUD(sql);
        }

        public List<Eleves> Select(Eleves o=null)
        {
            List<Eleves> LE = new List<Eleves>();
            string sql = "select * from Eleves ";
            if (o != null)
                sql += "where id=" + o.ID;
            MySqlDataReader Dr = Connexion.select(sql);
            while (Dr.Read())
                LE.Add(new Eleves(Dr.GetInt32(0), Dr.GetString(1), Dr.GetString(2), Dr.GetInt32(3)));
            Dr.Close();
            return LE;
        }

        public int Update(Eleves o)
        {
            string sql = "update Eleves set nom='" + o.Nom + "'," + "prenom='" + o.Prenom + "'," + "groupe='" + o.Groupe + "' " + "where id=" + o.ID;
            return Connexion.IUD(sql);
        }
    }
}
