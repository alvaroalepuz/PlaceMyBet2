using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class apuestaRepository
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

        internal apuesta Retrive()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from apuesta";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            apuesta a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetInt32(3) + " " + res.GetString(4));
                a = new apuesta(res.GetInt32(0), res.GetString(1), res.GetDouble(2), res.GetInt32(3), res.GetString(4));

            }
            return a;
        }
        internal apuestaDto RetriveCosas()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select Tipo, Dinero ,CuotaOver,CuotaUnder,emailid, Fecha from apuesta INNER JOIN mercado INNER JOIN evento";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            apuestaDto a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetDateTime(5).ToString("yyyy-MM-dd"));
                a = new apuestaDto(res.GetString(0), res.GetDouble(1), res.GetDouble(2), res.GetInt32(3), res.GetString(4), res.GetDateTime(5).ToString("yyyy-MM-dd"));

            }
            return a;
        }
        internal apuestaDto RetriveFiltrado()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select Tipo, Dinero ,CuotaOver,CuotaUnder,emailid, Fecha from apuesta INNER JOIN mercado INNER JOIN evento";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            apuestaDto a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetString(0) + " " + res.GetDouble(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetString(4) + " " + res.GetDateTime(5).ToString("yyyy-MM-dd"));
                a = new apuestaDto(res.GetString(0), res.GetDouble(1), res.GetDouble(2), res.GetInt32(3), res.GetString(4), res.GetDateTime(5).ToString("yyyy-MM-dd"));

            }
            return a;
        }
        internal apuestaDto2 RetriveFiltro()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select Tipo, Dinero ,CuotaOver,CuotaUnder,emailid, Fecha from apuesta INNER JOIN mercado INNER JOIN evento";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            apuestaDto2 a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4));
                a = new apuestaDto2(res.GetInt32(0), res.GetString(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4));

            }
            return a;
        }
        internal apuestaDto3 RetriveFiltro3()
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "SELECT mercado , Tipo ,CuotaOver, CuotaUnder ,Dinero FROM mercado INNER JOIN apuesta INNER JOIN usuarios WHERE IDMercado = MercadoIDFK AND IDMercado = MercadoIDFK3;";
            con.Open();
            MySqlDataReader res = command.ExecuteReader();
            apuestaDto3 a = null;
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetDouble(0) + " " + res.GetString(1) + " " + res.GetDouble(2) + " " + res.GetDouble(3) + " " + res.GetDouble(4));
                a = new apuestaDto3(res.GetDouble(0), res.GetString(1), res.GetDouble(2), res.GetDouble(3), res.GetDouble(4));

            }
            return a;
        }
        internal void Save(apuesta apuesta)
        {

            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "insert into apuesta(Tipo, Dinero, MercadoId, emailId) values ('" + apuesta.Tipo + "','" + apuesta.Dinero + "','" + apuesta.MercadoId + "','" + apuesta.emailId + "');";
            Debug.WriteLine("comando " + command.CommandText);
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (MySqlException)
            {

                Debug.WriteLine("Se ha producido un error");
            }
        }
    }
}