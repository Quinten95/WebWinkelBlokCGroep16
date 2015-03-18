using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWinkelGroep16.Controllers
{
    public abstract class DatabaseController
    {
        protected MySqlConnection conn;

        public DatabaseController()
        {
            conn = new MySqlConnection("Server=meru.hhs.nl;Database=14090619;Uid=14090619;Pwd=nohgheuXan;");

            if (conn == null)
            {
                Console.WriteLine("geen verbinding");
                Console.ReadKey();
            }
        }

    }
}
