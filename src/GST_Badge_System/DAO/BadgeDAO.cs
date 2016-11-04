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
     This class will be used to read/write all the badge data from the data database
     */
    public class BadgeDAO
    {

        //Badge
        public static void Add_Badge(Badge new_Badge)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = @"INSERT INTO Badge (Badge_Image , Badge_RetireDate ,Badge_ActivateDate ,Badge_ID ,Badge_Name,Badge_Descript ,Badge_Status,BT_ID ,BGT_ID) VALUES (@Badge_Image , @Badge_RetireDate ,@Badge_ActivateDate ,@Badge_ID ,@Badge_Name,@Badge_Descript ,@Badge_Status,@BT_ID ,@BGT_ID)";
                db.Execute(SqlQuery, new_Badge);

            }
        }
        public static void Delete_Badge(Badge badge)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = "DELETE FROM Badge WHERE Badge_ID = @Badge_ID ";
                db.Execute(SqlQuery, badge);
            }
        }

        public static void Retire_Badge(Badge badge)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = " ";
            }
        }
        public static void Update_Badge(Badge badge)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                string SqlQuery = "UPDATE Badge SET Badge_Image = @Badge_Image," + " Badge_RetireDate = @Badge_RetireDate,"+ "Badge_ActivateDate = @Badge_ActivateDate ," +"Badge_Name = @Badge_Name ,"+ "Badge_Descript = @Badge_Descript ," + "Badge_Status =@Badge_Status ," +"BadgeType = @Badge_Type ," +"BadgeGiveType = @BadgeGiveType " +"WHERE Badge_ID = @Badge_ID ";
                db.Execute(SqlQuery,badge);
            }
        }
        public static Badge Find_Badge(int id)
        {
            using (IDbConnection db = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = BadgeSystemSQLDB; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {

                return db.Query<Badge>("Select * From Badge" +

                 "WHERE Badge_ID = @Badge_ID", new { id }).SingleOrDefault();

            }
        }
        public static create_Badge_DB (string filePath)
        {
            //Delete current db
            //create new db
            // read file & insert badges
        }

        //BadgeType



    }
}
