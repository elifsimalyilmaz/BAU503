using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kutuphane.EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace Kutuphane.FacadeLayer
{
  public class FKITAP
    {
        public static int Insert(EKITAP item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Insert", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;// ınsert'ümüz sqlimizde bir storedprcedure olduğu için bunu belirttik.

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);
                etkilenen = com.ExecuteNonQuery();
            }
            catch(Exception)
            {

                etkilenen = -1;
            }
            return etkilenen;

        }

        public static bool Update(EKITAP item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Update", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;// ınsert'ümüz sqlimizde bir storedprcedure olduğu için bunu belirttik.

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ID", item.ID);
                com.Parameters.AddWithValue("ADI", item.ADI);
                com.Parameters.AddWithValue("YAZAR", item.YAZAR);
                com.Parameters.AddWithValue("SAYFASAYISI", item.SAYFASAYISI);
                com.Parameters.AddWithValue("KATEGORIID", item.KATEGORIID);
                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch
            {

                sonuc = false;
            }
            return sonuc;

        }

        public static bool Delete(int _ID)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Delete", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;// ınsert'ümüz sqlimizde bir storedprcedure olduğu için bunu belirttik.

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID", _ID);
                sonuc = com.ExecuteNonQuery() > 0;
            }
            catch
            {

                sonuc = false;
            }
            return sonuc;

        }

        public static EKITAP Select(int _ID)
        {
            EKITAP item = null;
            try
            {
                SqlCommand com = new SqlCommand("KITAP_Select", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;// ınsert'ümüz sqlimizde bir storedprcedure olduğu için bunu belirttik.

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }

                com.Parameters.AddWithValue("ID", _ID);
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        item = new EKITAP();
                        item.ID = int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI =short.Parse(rdr["SAYFASAYISI"].ToString());
                        item.KATEGORIID = int.Parse(rdr["KATEGORIID"].ToString());
                        item.GMT = DateTime.Parse(rdr["GMT"].ToString());
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.KATEGORIADI = rdr["KATEGORIADI"].ToString();
                    }
                }
                rdr.Close();
            }
            catch
            {
                item = null;
            }
           
            return item;

        }

        public static List<EKITAP> SelectList()
        {
            List<EKITAP> itemList = null;// new list<EKATEGORI>();
            try
            {
                SqlCommand com = new SqlCommand("KITAP_SelectList", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;// ınsert'ümüz sqlimizde bir storedprcedure olduğu için bunu belirttik.

                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }


                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EKITAP>();
                    while (rdr.Read())
                    {
                        EKITAP item = new EKITAP();
                        item.ID = int.Parse(rdr["ID"].ToString());
                        item.ADI = rdr["ADI"].ToString();
                        item.YAZAR = rdr["YAZAR"].ToString();
                        item.SAYFASAYISI = short.Parse(rdr["SAYFASAYISI"].ToString());
                        item.KATEGORIID = int.Parse(rdr["KATEGORIID"].ToString());
                        item.GMT = DateTime.Parse(rdr["GMT"].ToString());
                        item.HOSTNAME = rdr["HOSTNAME"].ToString();
                        item.KATEGORIADI = rdr["KATEGORIADI"].ToString();
                        itemList.Add(item);
                    }
                }rdr.Close();
            }
            catch
            {
                itemList = null;
            }
            return itemList;

        }
    }
}
