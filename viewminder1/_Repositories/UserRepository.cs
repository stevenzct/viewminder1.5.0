using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using viewminder1.Models;

namespace viewminder1._Repositories
{
   /* public class UserRepository : BaseRepository, IUserRepository
    {
        private string value;

        //constructor
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //methods
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetAll()
        {
            var userList = new List<UserModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string username = value;

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from login1 
                                        where id=@id or username like @username+'%'
                                        order by id desc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@username", SqlDbType.Int).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var userModel = new UserModel();
                        userModel.Id = (int)reader[0];
                        userModel.Username = reader[1].ToString();
                        userModel.Password = reader[2].ToString();
                        userModel.FullName = reader[3].ToString();
                        userModel.Email = reader[4].ToString();
                        userModel.PhoneNumber = reader[5].ToString();
                        userModel.Pin = (int)reader[6];
                    }
                }
            }
                return userList;

        }

        public IEnumerable<UserModel> ByValue => throw new NotImplementedException();
    } */
}
