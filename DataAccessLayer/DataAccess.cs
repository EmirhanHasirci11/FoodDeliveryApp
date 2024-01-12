using FoodDelivery.Models;
using System.Data.SqlClient;

namespace FoodDelivery.DataAccessLayer
{
    public class DataAccess
    {
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-D5ERFLF\\HONOSO;Initial Catalog=Food_Delivery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static int AddUser(User user)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_UyeEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", user.Ad);
            cmd.Parameters.AddWithValue("@Soyad", user.Soyad);
            cmd.Parameters.AddWithValue("@Telefon", user.Telefon);
            cmd.Parameters.AddWithValue("@Mail", user.Mail);
            cmd.Parameters.AddWithValue("@Dogum_Tarihi", user.Dogum_Tarihi);
            cmd.Parameters.AddWithValue("@Sifre", user.Sifre);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static int DeleteUser(int id)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_UyeSil", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static int UpdateUser(User user)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_UyeGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", user.ID);
            cmd.Parameters.AddWithValue("@Ad", user.Ad);
            cmd.Parameters.AddWithValue("@Soyad", user.Soyad);
            cmd.Parameters.AddWithValue("@Telefon", user.Telefon);
            cmd.Parameters.AddWithValue("@Mail", user.Mail);
            cmd.Parameters.AddWithValue("@Dogum_Tarihi", user.Dogum_Tarihi);
            cmd.Parameters.AddWithValue("@Sifre", user.Sifre);
            cmd.Parameters.AddWithValue("@Bakiye", user.Cuzdan_Bakiye);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static List<User> GetUsers()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_UyeHepsi", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new();
            while (reader.Read())
            {
                User user = new User() { ID = Convert.ToInt32(reader[0].ToString()), Ad = reader[1].ToString(), Soyad = reader[2].ToString(), Telefon = reader[3].ToString(), Mail = reader[4].ToString(), Dogum_Tarihi = DateTime.Parse(reader[5].ToString()), Sifre = reader[6].ToString(), Cuzdan_Bakiye = Convert.ToDecimal(reader[7].ToString()) };
                users.Add(user);
            }
            con.Close();
            return users;
        }
        public static User GetUserById(int id)
        {

            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("Food_Delivery_UyeBulId", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = new();
            while (reader.Read())
            {
                user.ID = Convert.ToInt32(reader[0].ToString());
                user.Ad = reader[1].ToString();
                user.Soyad = reader[2].ToString();
                user.Telefon = reader[3].ToString();
                user.Mail = reader[4].ToString();
                user.Dogum_Tarihi = DateTime.Parse(reader[5].ToString());
                user.Sifre = reader[6].ToString();
                user.Cuzdan_Bakiye = Convert.ToDecimal(0);
            }
            con.Close();
            return user;
        }
        public static int AddEnterprise(Enterprise ent)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_IsletmeEkle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ad", ent.Ad);
            cmd.Parameters.AddWithValue("@Aciklama", ent.Aciklama);
            cmd.Parameters.AddWithValue("@TeslimSaat", ent.Son_Teslim_Tarih);
            cmd.Parameters.AddWithValue("@MinGetirmeTutari", ent.Minimum_Getirme_Tutar);
            cmd.Parameters.AddWithValue("@Puan", 0);
            cmd.Parameters.AddWithValue("@Adres", ent.Adres);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static int UpdateEnterprise(Enterprise ent)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_IsletmeGuncelle", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", ent.ID);
            cmd.Parameters.AddWithValue("@Ad", ent.Ad);
            cmd.Parameters.AddWithValue("@Aciklama", ent.Aciklama);
            cmd.Parameters.AddWithValue("@TeslimSaat", ent.Son_Teslim_Tarih);
            cmd.Parameters.AddWithValue("@MinGetirmeTutari", ent.Minimum_Getirme_Tutar);
            cmd.Parameters.AddWithValue("@Puan", ent.İsletme_Puan);
            cmd.Parameters.AddWithValue("@Adres", ent.Adres);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static Enterprise GetEnterpriseById(int id)
        {

            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("Food_Delivery_IsletmeBulId", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Enterprise ent = new();
            while (reader.Read())
            {
                ent.ID = Convert.ToInt32(reader[0].ToString());
                ent.Ad = reader[1].ToString();
                ent.Aciklama = reader[2].ToString();
                ent.Son_Teslim_Tarih = DateTime.Parse(reader[3].ToString());
                ent.Minimum_Getirme_Tutar = Convert.ToDecimal(reader[4].ToString());
                ent.İsletme_Puan = Convert.ToDecimal(reader[5].ToString());
                ent.Adres = reader[6].ToString();
            }
            con.Close();
            return ent;
        }
        public static List<Enterprise> GetEnterprieses()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_IsletmeHepsi", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Enterprise> Enterprises = new();
            while (reader.Read())
            {
                Enterprise ent= new () { ID = Convert.ToInt32(reader[0].ToString()), Ad = reader[1].ToString(), Aciklama = reader[2].ToString(), Son_Teslim_Tarih= DateTime.Parse(reader[3].ToString()), Minimum_Getirme_Tutar = Convert.ToDecimal(reader[4].ToString()), İsletme_Puan = Convert.ToDecimal(reader[5].ToString()), Adres = reader[6].ToString()};
                Enterprises.Add(ent);
            }
            con.Close();
            return Enterprises;
        }
        public static int DeleteEnterprise(int id)
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
            SqlCommand cmd = new SqlCommand("FoodDelivery_IsletmeSil", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

    }
}


