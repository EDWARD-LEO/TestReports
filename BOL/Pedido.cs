using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Pedido
    {
        DBAccess acceso = new DBAccess();

        public DataTable listarAnio(string anio)
        {
            return acceso.getDataWithCondition("spu_pedidos_anio", "@anio", anio);
        }
    }
}
