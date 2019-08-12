using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using AssaKabrasa.DAO;
using MySql.Data.MySqlClient;
using AssaKabrasa.Controller;
using AssaKabrasa.Model;

namespace AssaKabrasa.Controller
{
    public class Program
    {
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MDISingleton.InstanciaMDI());  
        }      
    }
}

