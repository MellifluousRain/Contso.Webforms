using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;
using System.Data.SqlClient;

namespace Contso.Data
{
    public class CourseRepository : IRepository<Courses>
    {
        public void DeleteAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesDeleteAll";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBy(Courses obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesDeleteById @ID";
                command.Parameters.AddWithValue("@ID", obj.id);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Courses> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesGetAll";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                List<Courses> list = new List<Courses>();
                while (reader.Read())
                {
                    Courses obj = new Courses();
                    obj.id = Convert.ToInt32(reader["id"]);
                    obj.Title = reader["Title"].ToString();
                    obj.Credits = Convert.ToSingle(reader["Credits"]);
                    obj.Departmentid = Convert.ToInt32(reader["Departmentid"]);
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.CreatedBy = reader["CreatedBy"].ToString();
                    obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    obj.UpdatedBy = reader["UpdatedBy"].ToString();
                    list.Add(obj);
                }
                return list;
            }
        }

        public Courses GetBy(int id)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesGetById @ID";
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                Courses obj = new Courses();
                while (reader.Read())
                {
                    if (reader != null)
                    {
                        obj.id = Convert.ToInt32(reader["id"]);
                        obj.Title = reader["Title"].ToString();
                        obj.Credits = Convert.ToSingle(reader["Credits"]);
                        obj.Departmentid = Convert.ToInt32(reader["Departmentid"]);
                        obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                        obj.CreatedBy = reader["CreatedBy"].ToString();
                        obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                        obj.UpdatedBy = reader["UpdatedBy"].ToString();
                    }
                }
                return obj;
            }
        }

        public void Insert(Courses obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesInsert @Title, @Credits, @Departmentid, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy";
                command.Parameters.AddWithValue("@Title", obj.Title);
                command.Parameters.AddWithValue("@Credits", obj.Credits);
                command.Parameters.AddWithValue("@Departmentid", obj.Departmentid);
                command.Parameters.AddWithValue("@CreatedDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void Update(Courses obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spCoursesUpdate @id, @Title, @Credits, @Departmentid, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy";
                command.Parameters.AddWithValue("@id", obj.id);
                command.Parameters.AddWithValue("@Title", obj.Title);
                command.Parameters.AddWithValue("@Credits", obj.Credits);
                command.Parameters.AddWithValue("@Departmentid", obj.Departmentid);
                command.Parameters.AddWithValue("@CreatedDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}
