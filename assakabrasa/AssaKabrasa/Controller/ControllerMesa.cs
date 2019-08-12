using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssaKabrasa.DAO;
using AssaKabrasa.Model;

namespace AssaKabrasa.Controller
{
    class ControllerMesa
    {
        static DAOConexao cx = new DAOConexao();
        DAOMesa mesaDao = new DAOMesa(cx);
        Mesa mesa = new Mesa();

        public List<int> BuscarTodas()
        {
            List<Mesa> al = mesaDao.BuscarTodas();
            List<int> nomeMesa = new List<int>();
            foreach (Mesa item in al)
            {
                nomeMesa.Add(item.N_mesa);
            }
            return nomeMesa;
        }

        public void CadastrarMesa(int numeroMesa, int status)
        {
            mesaDao.Create(numeroMesa,status);
        }

    }
}
