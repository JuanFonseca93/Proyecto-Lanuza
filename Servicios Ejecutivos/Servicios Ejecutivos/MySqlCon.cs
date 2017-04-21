using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Servicios_Ejecutivos
{
    
    class MySqlCon
    {
        private static MySqlConnection connect()
        {
            MySqlConnection conectar = new MySqlConnection("server=138.197.43.98; database=TaxiEjecutivo; Uid=juan; pwd=juan00;");

            conectar.Open();
            return conectar;
        }

        public static bool checkUser(String User, String Pass)
        {
            try {
                String Querry = "SELECT * FROM Usuarios where Alias ='" + User + "' and Pass ='" + Pass+"'";
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                MySqlDataReader R = cmd.ExecuteReader();
                if(R.Read())
                {
                    return true;
                }else
                {
                    return false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            
        }

        public static bool NewClient(String nombre, String Direccion, String Telefono, String Estado, String Municipio, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "INSERT INTO Usuarios VALUES(null, '" + User + "','" + Pass + "','" + nombre+"','"+Direccion+"','"+Telefono+"','"+Estado+"','"+Municipio+"',"+nivel+")";
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public static bool upclient(int id, String nombre, String Direccion, String Telefono, String Estado, String Municipio, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "UPDATE Usuarios SET Nombre_Usurio ='"+nombre+"', Direccion_Usuario='"+Direccion+"', Telefono='"+Telefono+"', Estado='"+ Estado+"', Municipio='"+Municipio+"', Alias='"+User+"', Pass='"+Pass+"' WHERE Id_Usuario="+id;
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static DataTable getUser()
        {
            try
            {
                String Querry = "SELECT * FROM Usuarios";
                DataTable dt = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool NewEmp(String nombre, String Direccion, String Telefono, String Empresa, String Puesto, String estado, String Municipio)
        {
            try
            {
                String Querry = "INSERT INTO Empleados VALUES(null,'" + nombre + "','" + Direccion + "','"+estado+"','"+Municipio+"','" + Telefono + "','"+Empresa+"','"+Puesto+"', true)";
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public static bool upEmp(int id, String nombre, String Direccion, String Telefono, String Empresa, String Puesto, String estado, String municipio)
        {
            try
            {
                String Querry = "UPDATE Empleados SET Nombre_E ='" + nombre + "', Direccion_E='" + Direccion + "', Telefono_E='" + Telefono + "', Empresa='" + Empresa + "', Puesto='" + Puesto + "', Estado_E='"+estado+ "', Municipio_E='"+municipio+"' WHERE Id_Empleado=" + id;
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static DataTable getEmp()
        {
            try
            {
                String Querry = "SELECT * FROM Empleados";
                DataTable dt = new DataTable();
                MySqlDataAdapter data = new MySqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool upAcEmp(int id, bool status)
        {
            try
            {
                String Querry = "UPDATE Empleados SET Estatus_E="+status+" WHERE Id_Empleado=" + id;
                MySqlCommand cmd = new MySqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}