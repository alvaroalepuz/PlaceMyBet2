using Microsoft.EntityFrameworkCore;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class usuarioRepository
    {
        internal List<usuario> Retrieve()
        {

            List<usuario> usuario = new List<usuario>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuario = context.Usuario.ToList();
            }

            return usuario;

        }
        
        internal usuario Retrieve(string id)
        {
            usuario usuario;

            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                usuario = context.Usuario
                    .Where(s => s.usuarioId == id)
                    .FirstOrDefault();
            }


            return usuario;
        }

        internal void Save(usuario d)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            context.Usuario.Add(d);
            context.SaveChanges();

        }

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
    //internal usuario Retrive()
    //{

    //    MySqlConnection con = Connect();
    //    MySqlCommand command = con.CreateCommand();
    //    command.CommandText = "select * from usuario";
    //    con.Open();
    //    MySqlDataReader res = command.ExecuteReader();
    //    usuario u = null;
    //    if (res.Read())
    //    {
    //        Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt32(3) + " " + res.GetInt32(4));
    //        u = new usuario(res.GetString(0), res.GetString(1), res.GetString(2), res.GetInt32(3), res.GetInt32(4));

    //    }
    //    return u;
    //}
}