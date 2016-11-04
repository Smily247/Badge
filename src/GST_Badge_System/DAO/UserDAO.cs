using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GST_Badge_System.Model;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace GST_Badge_System.DAO
{
    /*
     This class will be used to read/write all the user data from the data database
     */
    public class UserDAO
    {
        public static void Add_User(User new_User)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = @"INSERT INTO USERS (User_ID ,User_NAME ,EMAIL ,USER_TYPE ) VALUES (@User_ID ,@User_NAME ,@EMAIL ,@USER_TYPE)";
                db.Execute(SqlQuery, new_User);

            }
        }
        public static void Delete_User(User user)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = "DELETE FROM Badge WHERE User_ID = @User_ID ";
                db.Execute(SqlQuery, user);
            }
        }

     
        public static void Update_User(User user)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = "UPDATE Users SET User_NAME = @User_NAME,"+"EMAIL= @EMAIL ,"+"USER_TYPE =@USER_TYPE" + "WHERE User_ID = @User_ID ";
                db.Execute(SqlQuery, user);
            }
        }
        public static Badge Find_Badge(int id)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {

                return db.Query<User>("Select * From USERS" +

                 "WHERE User_ID = @User_ID", new { id }).SingleOrDefault();

            }
        }
        public static create_User_DB(string filePath)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                //Delete current db
                foreach (User u in db)
            //create new db
            // read file & insert Users from file
        }

    }
}
