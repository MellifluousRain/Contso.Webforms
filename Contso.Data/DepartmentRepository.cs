using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Contso.Model;

namespace Contso.Data
{
    public class DepartmentRepository : IRepository<Department>
    {
        public void DeleteAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsDeleteAll";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBy(Department obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsDeleteById @ID";
                command.Parameters.AddWithValue("@ID", obj.id);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Department> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsGetAll";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                List<Department> list = new List<Department>();
                while (reader.Read())
                {
                    Department obj = new Department();
                    obj.id = Convert.ToInt32(reader["id"]);
                    obj.Name = reader["Name"].ToString();
                    obj.Budget = Convert.ToSingle(reader["Budget"]);
                    obj.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    obj.Instructorid = Convert.ToInt32(reader["Instructorid"]);
                    obj.RowVersion = reader["RowVersion"].ToString();
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.CreatedBy = reader["CreatedBy"].ToString();
                    obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    obj.UpdatedBy = reader["UpdatedBy"].ToString();
                    list.Add(obj);
                }
                return list;
            }
        }

        public Department GetBy(int id)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsGetById @ID";
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                Department obj = new Department();
                while (reader.Read())
                {
                    if (reader != null)
                    {
                        obj.id = Convert.ToInt32(reader["id"]);
                        obj.Name = reader["Name"].ToString();
                        obj.Budget = Convert.ToSingle(reader["Budget"]);
                        obj.StartDate = Convert.ToDateTime(reader["StartDate"]);
                        obj.Instructorid = Convert.ToInt32(reader["Instructorid"]);
                        obj.RowVersion = reader["RowVersion"].ToString();
                        obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                        obj.CreatedBy = reader["CreatedBy"].ToString();
                        obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                        obj.UpdatedBy = reader["UpdatedBy"].ToString();
                    }
                }
                return obj;
            }
        }

        public void Insert(Department obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsInsert @Name, @Budget, @StartDate, @Instructorid, @RowVersion, @CreateDate, @CreatedBy, @UpdatedDate, @UpdatedBy";
                command.Parameters.AddWithValue("@Name", obj.Name);
                command.Parameters.AddWithValue("@Budget", obj.Budget);
                command.Parameters.AddWithValue("@StartDate", obj.StartDate);
                command.Parameters.AddWithValue("@Instructorid", obj.Instructorid);
                command.Parameters.AddWithValue("@RowVersion", obj.RowVersion);
                command.Parameters.AddWithValue("@CreateDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Department obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spDepartmentsUpdate @id, @Name, @Budget, @StartDate, @Instructorid, @RowVersion, @CreateDate, @CreatedBy, @UpdatedDate, @UpdatedBy";
                command.Parameters.AddWithValue("@id", obj.id);
                command.Parameters.AddWithValue("@Name", obj.Name);
                command.Parameters.AddWithValue("@Budget", obj.Budget);
                command.Parameters.AddWithValue("@StartDate", obj.StartDate);
                command.Parameters.AddWithValue("@Instructorid", obj.Instructorid);
                command.Parameters.AddWithValue("@RowVersion", obj.RowVersion);
                command.Parameters.AddWithValue("@CreateDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}
