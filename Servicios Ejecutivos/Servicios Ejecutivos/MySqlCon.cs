using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Servicios_Ejecutivos
{

    class MySqlCon
    {
        private static SqlConnection connect()
        {
            SqlConnection conectar = new SqlConnection("Data Source= CORTANA\\SQLEXPRESS;Initial Catalog=TaxiEjecutivo1;Integrated Security=True");

            try
            {
                conectar.Open();
                return conectar;
                MessageBox.Show("Conectado");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static bool checkUser(String User, String Pass)
        {
            try
            {
                String Querry = "SELECT * FROM Usuarios where Alias ='" + User + "' and Pass ='" + Pass + "'";
                SqlCommand cmd = new SqlCommand(Querry, connect());
                SqlDataReader R = cmd.ExecuteReader();
                if (R.Read())
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

        public static bool NewClient(String nombre, String Direccion, String Telefono, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "INSERT INTO Usuarios VALUES('" + User + "','" + Pass + "','" + nombre + "','" + Direccion + "','" + Telefono + "'," + nivel + ")";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
        public static bool upclient(int id, String nombre, String Direccion, String Telefono, String User, String Pass, int nivel)
        {
            try
            {
                String Querry = "UPDATE Usuarios SET Nombre_Usurio ='" + nombre + "', Direccion_Usuario='" + Direccion + "', Telefono='" + Telefono + "', Alias='" + User + "', Pass='" + Pass + "' WHERE Id_Usuario=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool NewEmp(String nombre, String Direccion, String Telefono, String Empresa, String Puesto, String Foto)
        {
            try
            {
                String Querry = "INSERT INTO Empleados VALUES('" + nombre + "','" + Direccion + "','" + Telefono + "','" + Empresa + "','" + Puesto + "','" + Foto + "', 1)";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
        public static bool upEmp(int id, String nombre, String Direccion, String Telefono, String Empresa, String Puesto, String Foto)
        {
            try
            {
                String Querry = "UPDATE Empleados SET Nombre_E ='" + nombre + "', Direccion_E='" + Direccion + "', Telefono_E='" + Telefono + "', Empresa='" + Empresa + "', Puesto='" + Puesto + "', Foto_E='" + Foto + "' WHERE Id_Empleado=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool upAcEmp(int id, int status)
        {
            try
            {
                String Querry = "UPDATE Empleados SET Estatus_E=" + status + " WHERE Id_Empleado=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static DataTable getveh()
        {
            try
            {
                String Querry = "SELECT * FROM Vehiculos";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool NewVeh(String tipo, String Concesion, String Concesionario, String Linea, String Direccion, String Telefono, String Marca, String Modelo, String Ano)
        {
            try
            {
                String Querry = "INSERT INTO Vehiculos VALUES('" + tipo + "','" + Concesion + "','" + Concesionario + "','" + Linea + "','" + Direccion + "','" + Telefono + "','" + Marca + "','" + Modelo + "','" + Ano + "',null, 1)";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
        public static bool upAcVeh(int id, int status)
        {
            try
            {
                String Querry = "UPDATE Vehiculos SET Estatus_V=" + status + " WHERE Id_Vehiculo=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static bool UpVeh(String tipo, String Concesion, String Concesionario, String Linea, String Direccion, String Telefono, String Marca, String Modelo, String Ano, int id)
        {
            try
            {
                String Querry = "UPDATE Vehiculos SET Tipo_V='" + tipo + "', Concesion='" + Concesion + "', Concesionario='" + Concesionario + "', Linea='" + Linea + "', Direccion_V='" + Direccion + "', Telefono_V='" + Telefono + "', Marca='" + Marca + "', Modelo='" + Modelo + "',Anno='" + Ano + "' WHERE Id_Vehiculo=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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
        public static bool NewOper(String Unidad, String Nombre, String Direccion, String Telefono, String fecha, String foto, String Estatus, int vehiculo)
        {
            try
            {
                String Querry = "INSERT INTO Operadores VALUES('" + Unidad + "','" + Nombre + "','" + Direccion + "','" + Telefono + "',0 ,'" + foto + "','" + Estatus + "', null ," + vehiculo + ")";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static DataTable getOp()
        {
            try
            {
                String Querry = "SELECT * FROM Operadores";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static bool UpOper(String Unidad, String Nombre, String Direccion, String Telefono, String fecha, String foto, String Estatus, int vehiculo, int id)
        {
            try
            {
                String Querry = "UPDATE Operadores SET Unidad='" + Unidad + "', Nombre_U='" + Nombre + "', 	Direccion_U='" + Direccion + "', Telefono_U='" + Telefono + "', Foto_O='" + foto + "',  Id_Vehiculo='" + vehiculo + "' WHERE Id_Operador=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
                int R = cmd.ExecuteNonQuery();
                if (R != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                    MessageBox.Show("A");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }

        }
        public static DataTable getIDveh()
        {
            try
            {
                String Querry = "SELECT Id_Vehiculo FROM Vehiculos";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool upAcOper(int id, int status)
        {
            try
            {
                String Querry = "UPDATE Operadores SET Estatus_O=" + status + " WHERE Id_Operador=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static DataTable CobFrec(String Unidad)
        {
            try
            {
                String Querry = "SELECT Id_Operador, Nombre_U, Saldo, Foto_O FROM Operadores WHERE Unidad ='" + Unidad + "'";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;

            }
        }

        public static DataTable getEmps()
        {
            try
            {
                String Querry = "SELECT * FROM Empresas ";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public static bool NewEmpr(String Nombre, String RazonSc, String RFC, String Direccion, String Telefono, String Contacto, String TelCont, String Correo, String Estado, String Ciudad)
        {
            try
            {
                String Querry = "INSERT INTO Empresas VALUES('" + Nombre + "','" + RazonSc + "','" + RFC + "','" + Direccion + "','"+Telefono+"' ,'" + Contacto + "','" + TelCont + "', '"+Correo+"' ,'" + Estado + "','"+Ciudad+"',1)";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static bool UpEmpr(String Nombre, String RazonSc, String RFC, String Direccion, String Telefono, String Contacto, String TelCont, String Correo, String Estado, String Ciudad, int id)
        {
            try
            {
                String Querry = "UPDATE Empresas SET Nombre='" + Nombre + "', Razon_Social='" + RazonSc + "', RFC='" + RFC + "', Direccion_Emp='" + Direccion + "', Telefono_Emp='" + Telefono + "', Nombre_Contacto='" + Contacto + "', Telefono_Contacto='" + TelCont + "', Correo_Emp='" + Correo + "',Estado_Emp='" + Estado + "', Ciudad_Emp='"+Ciudad+"' WHERE Id_Empresa=" + id;
                SqlCommand cmd = new SqlCommand(Querry, connect());
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

        public static DataTable getEmprs()
        {
            try
            {
                String Querry = "SELECT Id_Empresa, Nombre FROM Empresas ";
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(Querry, connect());
                data.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public static bool NewVales(String Empresa, String Serie, int Folio, String Fecha)
        {
            try
            {
                String Querry = "INSERT INTO entrega_vales VALUES('" + Empresa + "','" + Serie + "','" + Folio + "','" + Fecha + "')";
                SqlCommand cmd = new SqlCommand(Querry, connect());
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