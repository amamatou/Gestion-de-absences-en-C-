using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAbsences
{
    interface IDAO<T>
    {
        int Insert(T o);
        int Update(T o);
        int Delete(T o);
        List<T> Select(T o);

    }
}
