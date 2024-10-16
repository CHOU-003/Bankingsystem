using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newbt.Models;
using DBconnect;
using System.Reflection;

namespace Newbt.Controllers
{
    internal class EmployeeController : IController
    {
        private List<IModel> _items;
        private SqlConnectionManager _connectionManager;
        private EmployeeModel models;

        public EmployeeController()
        {
            _items = new List<IModel>();
            _connectionManager = new SqlConnectionManager();
        }

        public List<IModel> Items => this._items;

        public bool Create(IModel model)
        {
            EmployeeModel emp = (EmployeeModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "INSERT INTO EMPLOYEE (id, name, password, role) VALUES (@ID, @Name, @Password, @Role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", emp.id);
                    command.Parameters.AddWithValue("@Name", emp.name);
                    command.Parameters.AddWithValue("@Password", emp.password);
                    command.Parameters.AddWithValue("@Role", emp.role);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Create: " + ex.Message);
                return false;
            }
        }

        public bool Delete(IModel id)
        {
            EmployeeModel emp = (EmployeeModel)models;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "DELETE FROM EMPLOYEE WHERE id = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", emp.id);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Delete: " + ex.Message);
                return false;
            }
        }

        public bool Load()
        {
            try
            {
                _items.Clear();
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM EMPLOYEE"; 
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeModel model = new EmployeeModel
                        {
                            id = reader["ID"].ToString(),
                            name = reader["Name"].ToString(),
                            password = reader["Password"].ToString(),
                            role = reader["Role"].ToString()
                        };
                        _items.Add(model);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Load: " + ex.Message);
                return false;
            }

        }

        public bool Load(object id)
        {
            throw new NotImplementedException();
        }

        public IModel Read(IModel id)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT * FROM EMPLOYEE WHERE id = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            EmployeeModel model = new EmployeeModel
                            {
                                id = reader["ID"].ToString(),
                                name = reader["Name"].ToString(),
                                password = reader["Password"].ToString(),
                                role = reader["Role"].ToString()
                            };
                            return model; // Trả về model nếu tìm thấy
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Read: " + ex.Message);
            }
            return null;
        }

        public bool Update(IModel model)
        {
            EmployeeModel emp = (EmployeeModel)model;
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "UPDATE EMPLOYEE SET name = @Name, password = @Password, role = @Role WHERE id = @ID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", emp.id);
                        command.Parameters.AddWithValue("@Name", emp.name);
                        command.Parameters.AddWithValue("@Password", emp.password);
                        command.Parameters.AddWithValue("@Role", emp.role);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in Update: " + ex.Message);
                return false;
            }
        }
        public bool IsExist(object id)
        {
            try
            {
                using (SqlConnection connection = _connectionManager.GetConnection())
                {
                    string query = "SELECT COUNT(*) FROM EMPLOYEE WHERE ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xử lý: " + ex.Message);
                return false;
            }
        }
        public bool Read(Object id)
        {

            return true;
        }

        IModel IController.Read(object id)
        {
            throw new NotImplementedException();
        }
    }

}
