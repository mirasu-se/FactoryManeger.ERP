using System;
using System.Data.OleDb;
using SpaceM2.Core.BLL.Model;

namespace SpaceM2.Core.BLL.Service
{
    public class UserRepository : IUserRepository
    {
        public bool ValidateUser(string password)
        {

            var connection = ConnectionService.CreateDatabaseConnection();

            bool isPasswordValid;

            OleDbCommand cmd = new OleDbCommand(
                @"SELECT 
                    *
                    FROM [User]
                    WHERE User.UserPassword = @UserPassword;
                    ", connection);

            cmd.Parameters.AddWithValue("@UserPassword", password);

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                isPasswordValid = true;
            }
            else
            {
                isPasswordValid = false;
            }
            reader.Close();
            connection.Close();
            return isPasswordValid;
        }

        public UserModel GetLogedInUser(string password)
        {
            var connection = ConnectionService.CreateDatabaseConnection();

            var user = new UserModel();

            OleDbCommand cmd = new OleDbCommand(
                @"SELECT 
                    User.User_Id, 
                    User.Roll_Id, 
                    User.FirstName, 
                    User.LastName, 
                    User.UserName, 
                    User.DateOfBirth, 
                    User.UserPassword, 
                    User.Phone, 
                    User.Email, 
                    User.Address, 
                    User.ImageFilePath, 
                    User.IsActive, 
                    User.IsDeleted, 
                    User.IsEmployee, 
                    User.Employee_Id, 
                    User.DateCreated, 
                    User.UserCreated, 
                    User.DateDeleted, 
                    User.UserDeleted, 
                    UserRoll.Roll_Id, 
                    UserRoll.Key
                    FROM UserRoll 
                    INNER JOIN [User] 
                    ON UserRoll.Roll_Id = User.Roll_Id
                    WHERE User.UserPassword = @UserPassword;", 
                connection);
            cmd.Parameters.AddWithValue("@UserPassword", password);

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user.UserId = Convert.ToInt32(reader[0]);
                user.RoleId = Convert.ToInt32(reader[1]);
                user.FirstName = reader[2].ToString();
                user.LastName = reader[3].ToString();
                user.UserPassword = reader[6].ToString();
                user.ImageFilePath = reader[10].ToString();
                user.RoleKey = reader[20].ToString();
            }
            reader.Close();
            connection.Close();
            return user;
        }
    }
}
