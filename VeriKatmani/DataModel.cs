using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmani
{
    public class DataModel
    {
        SqlConnection _con;
        SqlCommand _cmd;
        public DataModel()
        {
            _con = new SqlConnection(concitonYol.conSTR);
            _cmd = _con.CreateCommand();
        }

        public bool NickIsHaveOther(string NickName)
        {
            try
            {
                _cmd.CommandText = "SELECT COUNT(*) FROM Members WHERE Nick = @putNick";
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@putNick",NickName);
                _con.Open();
                int HasHave = Convert.ToInt32(_cmd.ExecuteScalar());
                return HasHave > 0;
            }catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _con.Close();
            }
        }

        public bool MailIsHaveOther(string MailName)
        {
            try
            {
                _cmd.CommandText = "SELECT COUNT(*) FROM Members WHERE Mail = @putNick";
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@putNick", MailName);
                _con.Open();
                int HasHave = Convert.ToInt32(_cmd.ExecuteScalar());
                return HasHave > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _con.Close();
            }
        }

        public bool AddNewMember(string Nick,string Mail,string Password)
        {
            try
            {
                _cmd.CommandText = "INSERT INTO Members(Nick, Mail,Password) VALUES(@nick,@mail,@pasword)";
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@nick", Nick);
                _cmd.Parameters.AddWithValue("@mail", Mail);
                _cmd.Parameters.AddWithValue("@pasword", Password);
                _con.Open();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _con.Close();
            }
        }


        public bool LoginMember(string Nick,string Password)
        {
            try
            {
                _cmd.CommandText = "SELECT COUNT(*) FROM Members WHERE Nick = @SF AND Password = @PS";
                _cmd.Parameters.Clear();
                _cmd.Parameters.AddWithValue("@SF", Nick);
                _cmd.Parameters.AddWithValue("@PS", Password);
                _con.Open();
                int HasMember = Convert.ToInt32(_cmd.ExecuteScalar());
                if (HasMember > 0)
                {
                    _cmd.CommandText = "SELECT ID,Nick,Mail FROM Members WHERE Nick = @SF AND Password = @PS";
                    _cmd.Parameters.Clear();
                    _cmd.Parameters.AddWithValue("@SF", Nick);
                    _cmd.Parameters.AddWithValue("@PS", Password);
                    SqlDataReader reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Oturum.ID = reader.GetInt32(0);
                        Oturum.Nick = reader.GetString(1);
                        Oturum.Mail = reader.GetString(2);
                    }
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                return false;
            }
            finally {  _con.Close(); }
        }
    }
}
