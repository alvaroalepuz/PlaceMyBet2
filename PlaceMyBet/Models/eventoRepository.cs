﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class eventoRepository
    {
        private MySqlConnection Connect()
        {
            string server = "server=127.0.0.1;";
            string port = "port=3306;";
            string database = "database=PlaceMyBet;";
            string usuario = "uid=root;";
            string password = "pwd=;";
            string dateTimeAvailable = "Convert Zero Datetime=True";
            string connectionstring = server + port + database + usuario + password + dateTimeAvailable;
            MySqlConnection con = new MySqlConnection(connectionstring);
            return con;
        }

        internal evento Retrive()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from evento";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            evento e = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetDateTime(3).ToString("yyyy-MM-dd") + " " + res.GetInt32(4));
                e = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetDateTime(3).ToString("yyyy-MM-dd"), res.GetInt32(4));

            }
            return e;
        }
        internal eventoDto RetriveNameDate()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select NombreEquipoLocal, NombreEquipoVisitante, Fecha from evento";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            eventoDto e = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetString(1) + " " + res.GetDateTime(2).ToString("yyyy-MM-dd"));

                e = new eventoDto(res.GetString(0), res.GetString(1), res.GetDateTime(2).ToString("yyyy-MM-dd"));

            }
            return e;
        }
    }
}