//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;

//namespace GroupProject
//{
//    class User
//    {
//          //database stuff
//        private const String SERVER = "178.62.64.99";
//        private const String DATABASE = "GardenDB";
//        private const String UID = "bionic";
//        private const String PASSWORD = "EXPa05w01d";
//        private static MySqlConnection dbConn;
        
//        // User class stuff
//        public int Id { get; private set; }

//        public String Username { get; private set; }

//        public String Password { get; private set; }

//        private User(int id, String u, String p)
//        {
//            Id = id;
//            Username = u;
//            Password = p;
//        }

//        public static void InitializeDB()
//        {
//            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
//            builder.Server = SERVER;
//            builder.UserID = UID;
//            builder.Password = PASSWORD;
//            builder.Database = DATABASE;

//            String connString = builder.ToString();

//            builder = null;

//            Console.WriteLine(connString);

//            dbConn = new MySqlConnection(connString);

//            Application.ApplicationExit += (sender, args) => {
//                if (dbConn != null) 
//                {
//                    dbConn.Dispose();
//                    dbConn = null;
//                }
//            };
//        }

//        public static List<User> GetUsers()
//        {
//            List<User> users = new List<User>();

//            String query = "SELECT * FROM users";

//            MySqlCommand cmd = new MySqlCommand(query, dbConn);

//            dbConn.Open();

//            MySqlDataReader reader = cmd.ExecuteReader();

//            while (reader.Read())
//            {
//                int id = (int)reader["id"];
//                String username = reader["username"].ToString();
//                String password = reader["password"].ToString();

//                User u = new User(id, username, password);

//                users.Add(u);
//            }

//            reader.Close();

//            dbConn.Close();

//            return users;
//        }

//        public static User Insert(String u, String p)
//        {
//            String query = string.Format("INSERT INTO users(username, password) VALUES ('{0}', '{1}')", u, p);

//            MySqlCommand cmd = new MySqlCommand(query, dbConn);

//            dbConn.Open();

//            cmd.ExecuteNonQuery();
//            int id = (int)cmd.LastInsertedId;

//            User user = new User(id, u, p);

//            dbConn.Close();

//            return user;

//        }
//        public void Update(string u, string p)
//        {
//            String query = string.Format("UPDATE users SET username='{0}', password='{1}' WHERE ID={2}", u, p, Id);

//            MySqlCommand cmd = new MySqlCommand(query, dbConn);

//            dbConn.Open();

//            cmd.ExecuteNonQuery();

//            dbConn.Close();
//        }

//        public void Delete()
//        {
//            String query = string.Format("DELETE FROM users WHERE ID={0}", Id);

//            MySqlCommand cmd = new MySqlCommand(query, dbConn);

//            dbConn.Open();

//            cmd.ExecuteNonQuery();

//            dbConn.Close();
//        }
//    }
//}

