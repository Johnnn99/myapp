using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    class GameAssignmentDbHandler
    {
        private static SqlConnection Connectiondb;
       

        public static bool GPlayerRegister(String name1, String email1, String password1)
        {
            try
            {               
                getConnection();
                String qs = "insert into GamePlayer(Name,Email,Password) values(@n,@e,@p)";
                SqlCommand cmdd = new SqlCommand(qs, Connectiondb);                       
                cmdd.Parameters.AddWithValue("@n", name1);
                cmdd.Parameters.AddWithValue("@e", email1);
                cmdd.Parameters.AddWithValue("@p", password1);
                int row=cmdd.ExecuteNonQuery();
                Connectiondb.Close();
                if (row > 0)
                {
                    return true;
                }
                return false;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SqlConnection getConnection()
        {
            try
            {
                String AssignUrl = Directory.GetParent(Directory.GetParent(Application.StartupPath) + "") + "\\AssignmentDb.mdf"; ;
                Connectiondb = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=" + AssignUrl + ";Integrated Security=True");
                Connectiondb.Open();
                return Connectiondb;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
       public static int Loginform(String emails1, String password)
        {
            try
            {
                getConnection();
                int playerId = -1;
                String qs = "select id from GamePlayer where Email=@email and Password=@password";
                SqlCommand cmdd = new SqlCommand(qs, Connectiondb);
                cmdd.Parameters.AddWithValue("@email", emails1);
                cmdd.Parameters.AddWithValue("@password", password);
                SqlDataReader drdr = cmdd.ExecuteReader();
                while (drdr.Read())
                {
                    playerId = Convert.ToInt32(drdr[0].ToString());
                }
                Connectiondb.Close();

                return playerId;
            }
            catch (Exception)
            {
                return -1;
            }
        }

       public static List<Vocabs> getVocabs(int id)
       {
           try
           {
               getConnection();
               List<Vocabs> vList = new List<Vocabs>();
               String qs = "select engvocab,vocabularies from Vocabs where vocabTypeID=@id";
               SqlCommand cmdd = new SqlCommand(qs, Connectiondb);
               cmdd.Parameters.AddWithValue("@id", id);
               SqlDataReader drdr = cmdd.ExecuteReader();
               while (drdr.Read())
               {
                   Vocabs vc = new Vocabs(drdr[0].ToString(), drdr[1].ToString());
                   vList.Add(vc);
               }
               Connectiondb.Close();
               return vList;
           }
           catch (Exception)
           {
               return null;
           }
       }
       public static int GVocabType(String lang1,String type)
       {
           try
           {
               getConnection();
               int vocabId = -1;
               String qs = "Select id from VocabTypes where Name=@name and Language=@language";
               SqlCommand cmd = new SqlCommand(qs, Connectiondb);
               cmd.Parameters.AddWithValue("@name", type);
               cmd.Parameters.AddWithValue("@language", lang1);
               SqlDataReader drdr = cmd.ExecuteReader();
               while (drdr.Read())
               {
                   vocabId = Convert.ToInt32(drdr[0].ToString());
               }
               Connectiondb.Close();

               return vocabId;
           }
           catch (Exception)
           {
               return -1;
           }
       }

       public static bool SofPlayerRegister(int s, float sr, int tt, int pid)
       {
           try
           {
               getConnection();
               String qs = "insert into PlayerScore(score,successrate,ttime,gamerplayerid) values(@s,@sr,@tt,@pid)";
               SqlCommand cmdd = new SqlCommand(qs, Connectiondb);
               cmdd.Parameters.AddWithValue("@s", s);
               cmdd.Parameters.AddWithValue("@sr", sr);
               cmdd.Parameters.AddWithValue("@tt", tt);
               cmdd.Parameters.AddWithValue("@pid", pid);
               int row = cmdd.ExecuteNonQuery();
               Connectiondb.Close();
               if (row > 0)
               {
                   return true;
               }
               return false;

           }
           catch (Exception)
           {
               return false;
           }
       }
      
    }
}
