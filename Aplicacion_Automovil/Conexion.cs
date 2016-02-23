﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aplicacion_Automovil
{
    class Conexion
    {
        private string cadena_conexion;
        
        public Conexion()
        {
            cadena_conexion = "Data Source=Edu-PC;Initial Catalog=venta_vehiculos;Integrated Security=True";
        }

        public bool testear_conexion()
        {
            SqlConnection conn = get_conexion();
            if (conn != null)
            {
                conn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }


        private SqlConnection get_conexion()
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena_conexion);
                conn.Open();
                return conn;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public bool insertar_vehiculo(string matricula, string marca, string modelo, string color, float precio, string descripcion)
        {
            SqlConnection conn;
            try
            {
                using (conn = get_conexion())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = "INSERT INTO vehiculo"
                            + "(matricula, marca, modelo, color, precio, descripcion)"
                            + "values (@matricula, @marca, @modelo, @color, @precio, @descripcion)";

                        command.Parameters.Add("@matricula", System.Data.SqlDbType.VarChar).Value = matricula;
                        command.Parameters.Add("@marca", System.Data.SqlDbType.VarChar).Value = marca;
                        command.Parameters.Add("@modelo", System.Data.SqlDbType.VarChar).Value = modelo;
                        command.Parameters.Add("@color", System.Data.SqlDbType.VarChar).Value = color;
                        command.Parameters.Add("@precio", System.Data.SqlDbType.Float).Value = precio;
                        command.Parameters.Add("@descripcion", System.Data.SqlDbType.VarChar).Value = descripcion;

                        return (command.ExecuteNonQuery() == 1);

                    }
                }
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        public bool actualizar_vehiculo(string matricula, string campo, string valor)
        {
            SqlConnection conn;
            try
            {
                using (conn = get_conexion())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = "UPDATE vehiculo"
                            + " SET "+campo+"=@nuevo_valor"
                            + " WHERE matricula=@matricula";

                        command.Parameters.Add("@matricula", System.Data.SqlDbType.VarChar).Value = matricula;

                        if (campo.CompareTo("precio") == 0)
                        {
                            float nuevo_precio = System.Convert.ToSingle(valor);
                            command.Parameters.Add("@nuevo_valor", System.Data.SqlDbType.Float).Value = nuevo_precio;
                        }
                        else
                        {
                            command.Parameters.Add("@nuevo_valor", System.Data.SqlDbType.VarChar).Value = valor;
                        }

                        return (command.ExecuteNonQuery() == 1);

                    }
                }
            }
            catch (Exception exc)
            {
                return false;
            }
        }

        public bool Agregar_Cliente(string nit, string nombre, string apellido, string direccion, string telefono)
        {
            SqlConnection conn;
            try
            {
                using (conn = get_conexion())
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = conn;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = "INSERT INTO cliente"
                            + "(nit, nombre, apellido, direccion, telefono)"
                            + " VALUES (@nit, @nombre, @apellido, @direccion, @telefono)";

                        command.Parameters.Add("@nit", System.Data.SqlDbType.VarChar).Value = nit;
                        command.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar).Value = nombre;
                        command.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar).Value = apellido;
                        command.Parameters.Add("@direccion", System.Data.SqlDbType.VarChar).Value = direccion;
                        command.Parameters.Add("@telefono", System.Data.SqlDbType.VarChar).Value = telefono;
                        
                        return (command.ExecuteNonQuery() == 1);
                    }
                }
            }
            catch (Exception exc)
            {
                return false;
            }
        }
    }
}
