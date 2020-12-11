using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class mercadoRepository
    {
            internal List<mercado> Retrieve()
            {

                List<mercado> mercado = new List<mercado>();
                using (PlaceMyBetContext context = new PlaceMyBetContext())
                {
                mercado = context.Mercado.ToList();
                }

                return mercado;

            }

            internal mercado Retrieve(int id)
            {
            mercado mercado;

                using (PlaceMyBetContext context = new PlaceMyBetContext())
                {
                mercado = context.Mercado
                        .Where(s => s.mercadoId == id)
                        .FirstOrDefault();
                }


                return mercado;
            }

            internal void Save(mercado d)
            {
                PlaceMyBetContext context = new PlaceMyBetContext();

                context.Mercado.Add(d);
                context.SaveChanges();

            }
            //private MySqlConnection Connect()
            //{
            //    string server = "server=127.0.0.1;";
            //    string port = "port=3306;";
            //    string database = "database=PlaceMyBet;";
            //    string usuario = "uid=root;";
            //    string password = "pwd=;";
            //    string dateTimeAvailable = "Convert Zero Datetime=True";
            //    string connectionstring = server + port + database + usuario + password + dateTimeAvailable;
            //    MySqlConnection con = new MySqlConnection(connectionstring);
            //    return con;
            //}

            //internal mercado Retrive()
            //{

            //    MySqlConnection con = Connect();
            //    MySqlCommand command = con.CreateCommand();
            //    command.CommandText = "select * from mercado";
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();
            //    mercado m = null;
            //    if (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5));
            //        m = new mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5));

            //    }
            //    return m;
            //}
            //internal mercadoDto RetriveTipoMercado()
            //{

            //    MySqlConnection con = Connect();
            //    MySqlCommand command = con.CreateCommand();
            //    command.CommandText = "select Mercado, CuotaOver, CuotaUnder from mercado";
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();
            //    mercadoDto e = null;
            //    if (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetDouble(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2));

            //        e = new mercadoDto(res.GetDouble(0), res.GetDouble(1), res.GetDouble(2));

            //    }
            //    return e;
            //}
            //internal mercado RetriveFiltrado()
            //{

            //    MySqlConnection con = Connect();
            //    MySqlCommand command = con.CreateCommand();
            //    command.CommandText = "SELECT IdMercado, Mercado, CuotaOver, CuotaUnder,DineroOver,DineroUnder FROM mercado INNER JOIN evento  WHERE IdEvento = 1;";
            //    con.Open();
            //    MySqlDataReader res = command.ExecuteReader();
            //    mercado e = null;
            //    if (res.Read())
            //    {
            //        Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4) + " " + res.GetDouble(5));
            //        e = new mercado(res.GetInt32(0), res.GetDouble(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4), res.GetDouble(5));

            //    }
            //    return e;
            //}


        }
}