using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Contso.Model;

namespace Contso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        public void DeleteAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleDeleteAll";
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void DeleteBy(People obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleDeleteById @ID";
                command.Parameters.AddWithValue("@ID", obj.id);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<People> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleGetAll";
                command.Connection = connection;
                SqlDataReader reader = command.ExecuteReader();
                List<People> list = new List<People>();
                while (reader.Read())
                {
                    People obj = new People();
                    obj.id = Convert.ToInt32(reader["id"]);
                    obj.LastName = reader["LastName"].ToString();
                    obj.FirstName = reader["FirstName"].ToString();
                    obj.MiddleName = reader["MiddleName"].ToString();
                    obj.Age = Convert.ToInt32(reader["Age"]);
                    obj.Email = reader["Email"].ToString();
                    obj.Phone = reader["Phone"].ToString();
                    obj.AddressLine1 = reader["AddressLine1"].ToString();
                    obj.AddressLine2 = reader["AddressLine2"].ToString();
                    obj.UnitOrApartmentNumber = reader["UnitOrApartmentNumber"].ToString();
                    obj.City = reader["City"].ToString();
                    obj.State = reader["State"].ToString();
                    obj.Zipcode = reader["Zipcode"].ToString();
                    obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    obj.CreatedBy = reader["CreatedBy"].ToString();
                    obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                    obj.UpdatedBy = reader["UpdatedBy"].ToString();
                    obj.Password = reader["Password"].ToString();
                    obj.Salt = reader["Salt"].ToString();
                    obj.IsLocked = reader["IsLocked"].ToString();
                    obj.LastLockedDateTime = Convert.ToDateTime(reader["LastLockedDateTime"]);
                    obj.FailedAttempts = Convert.ToInt32(reader["FailedAttempts"]);
                    list.Add(obj);
                }
                return list;
            }
        }

        public People GetBy(int id)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleGetById @ID";
                command.Connection = connection;
                command.Parameters.AddWithValue("@ID", id);
                SqlDataReader reader = command.ExecuteReader();
                People obj = new People();
                while (reader.Read())
                {
                    if (reader != null)
                    {
                        obj.id = Convert.ToInt32(reader["id"]);
                        obj.LastName = reader["LastName"].ToString();
                        obj.FirstName = reader["FirstName"].ToString();
                        obj.MiddleName = reader["MiddleName"].ToString();
                        obj.Age = Convert.ToInt32(reader["Age"]);
                        obj.Email = reader["Email"].ToString();
                        obj.Phone = reader["Phone"].ToString();
                        obj.AddressLine1 = reader["AddressLine1"].ToString();
                        obj.AddressLine2 = reader["AddressLine2"].ToString();
                        obj.UnitOrApartmentNumber = reader["UnitOrApartmentNumber"].ToString();
                        obj.City = reader["City"].ToString();
                        obj.State = reader["State"].ToString();
                        obj.Zipcode = reader["Zipcode"].ToString();
                        obj.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                        obj.CreatedBy = reader["CreatedBy"].ToString();
                        obj.UpdatedDate = Convert.ToDateTime(reader["UpdatedDate"]);
                        obj.UpdatedBy = reader["UpdatedBy"].ToString();
                        obj.Password = reader["Password"].ToString();
                        obj.Salt = reader["Salt"].ToString();
                        obj.IsLocked = reader["IsLocked"].ToString();
                        obj.LastLockedDateTime = Convert.ToDateTime(reader["LastLockedDateTime"]);
                        obj.FailedAttempts = Convert.ToInt32(reader["FailedAttempts"]);
                    }
                }
                return obj;
            }
        }
        public void Insert(People obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleInsert @LastName, @FirstName, @MiddleName, @Age, @Email, @Phone, @AddressLine1, @AddressLine2, @UnitOrApartmentNumber, @City, @State, @Zipcode, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Salt, @IsLocked, @LastLockedDateTime, @FailedAttempts";
                command.Parameters.AddWithValue("@LastName", obj.LastName);
                command.Parameters.AddWithValue("@FirstName", obj.FirstName);
                command.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
                command.Parameters.AddWithValue("@Age", obj.Age);
                command.Parameters.AddWithValue("@Email", obj.Email);
                command.Parameters.AddWithValue("@Phone", obj.Phone);
                command.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
                command.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
                command.Parameters.AddWithValue("@UnitOrApartmentNumber", obj.UnitOrApartmentNumber);
                command.Parameters.AddWithValue("@City", obj.City);
                command.Parameters.AddWithValue("@State", obj.State);
                command.Parameters.AddWithValue("@Zipcode", obj.Zipcode);
                command.Parameters.AddWithValue("@CreatedDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Parameters.AddWithValue("@Salt", obj.Salt);
                command.Parameters.AddWithValue("@IsLocked", obj.IsLocked);
                command.Parameters.AddWithValue("@LastLockedDateTime", obj.LastLockedDateTime);
                command.Parameters.AddWithValue("@FailedAttempts", obj.FailedAttempts);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }

        public void Update(People obj)
        {
            using (SqlConnection connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "EXECUTE spPeopleUpdate @id, @LastName, @FirstName, @MiddleName, @Age, @Email, @Phone, @AddressLine1, @AddressLine2, @UnitOrApartmentNumber, @City, @State, @Zipcode, @CreatedDate, @CreatedBy, @UpdatedDate, @UpdatedBy, @Salt, @IsLocked, @LastLockedDateTime, @FailedAttempts";
                command.Parameters.AddWithValue("@id", obj.id);
                command.Parameters.AddWithValue("@LastName", obj.LastName);
                command.Parameters.AddWithValue("@FirstName", obj.FirstName);
                command.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
                command.Parameters.AddWithValue("@Age", obj.Age);
                command.Parameters.AddWithValue("@Email", obj.Email);
                command.Parameters.AddWithValue("@Phone", obj.Phone);
                command.Parameters.AddWithValue("@AddressLine1", obj.AddressLine1);
                command.Parameters.AddWithValue("@AddressLine2", obj.AddressLine2);
                command.Parameters.AddWithValue("@UnitOrApartmentNumber", obj.UnitOrApartmentNumber);
                command.Parameters.AddWithValue("@City", obj.City);
                command.Parameters.AddWithValue("@State", obj.State);
                command.Parameters.AddWithValue("@Zipcode", obj.Zipcode);
                command.Parameters.AddWithValue("@CreatedDate", obj.CreatedDate);
                command.Parameters.AddWithValue("@CreatedBy", obj.CreatedBy);
                command.Parameters.AddWithValue("@UpdatedDate", obj.UpdatedDate);
                command.Parameters.AddWithValue("@UpdatedBy", obj.UpdatedBy);
                command.Parameters.AddWithValue("@Salt", obj.Salt);
                command.Parameters.AddWithValue("@IsLocked", obj.IsLocked);
                command.Parameters.AddWithValue("@LastLockedDateTime", obj.LastLockedDateTime);
                command.Parameters.AddWithValue("@FailedAttempts", obj.FailedAttempts);
                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}
