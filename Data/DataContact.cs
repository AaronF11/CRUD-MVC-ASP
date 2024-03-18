using CRUD_MVC_ASP.Models;
using System.Data.SqlClient;
using System.Data;
using System.Numerics;
using System.Xml.Linq;

namespace CRUD_MVC_ASP.Data
{
    public class DataContact
    {
        public List<ContactModel> GetListOfContacts()
        {
            var List = new List<ContactModel>();

            var conn = new ConnectionSQL();

            using (var cn = new SqlConnection(conn.GetConnectionString()))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("GetListOfContact", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        List.Add(new ContactModel()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Name = dr["Name"].ToString(),
                            Phone = dr["Phone"].ToString(),
                            Email = dr["Mail"].ToString()
                        });
                    }
                }
            }

            return List;
        }

        public ContactModel GetContact(int Id)
        {
            var Contact = new ContactModel();

            var conn = new ConnectionSQL();

            using (var cn = new SqlConnection(conn.GetConnectionString()))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("GetOneContact", cn);
                cmd.Parameters.AddWithValue("Id", Id);
                cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Contact.Id = Convert.ToInt32(dr["Id"]);
                        Contact.Name = dr["Name"].ToString();
                        Contact.Phone = dr["Phone"].ToString();
                        Contact.Email = dr["Mail"].ToString();
                    }
                }
            }

            return Contact;
        }

        public bool CreateContact(ContactModel Contact)
        {
            bool answer;

            try
            {
                var conn = new ConnectionSQL();

                using (var cn = new SqlConnection(conn.GetConnectionString()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("CreateNewContact", cn);
                    cmd.Parameters.AddWithValue("Name", Contact.Name);
                    cmd.Parameters.AddWithValue("Phone", Contact.Phone);
                    cmd.Parameters.AddWithValue("Mail", Contact.Email);
                    cmd.CommandType = CommandType.StoredProcedure;    
                    cmd.ExecuteNonQuery();
                }
                
                answer = true;
            }
            catch (Exception e)
            {
                string Error = e.Message;
                answer = false;
            }

            return answer;
        }

        public bool UpdateContact(ContactModel Contact)
        {
            bool answer;

            try
            {
                var conn = new ConnectionSQL();

                using (var cn = new SqlConnection(conn.GetConnectionString()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("UpdateContact", cn);
                    cmd.Parameters.AddWithValue("Id", Contact.Id);
                    cmd.Parameters.AddWithValue("Name", Contact.Name);
                    cmd.Parameters.AddWithValue("Phone", Contact.Phone);
                    cmd.Parameters.AddWithValue("Mail", Contact.Email);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                answer = true;
            }
            catch (Exception e)
            {
                string Error = e.Message;
                answer = false;
            }

            return answer;
        }
        
        public bool DeleteContact(int Id)
        {
            bool answer;

            try
            {
                var conn = new ConnectionSQL();

                using (var cn = new SqlConnection(conn.GetConnectionString()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("DeleteContact", cn);
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }

                answer = true;
            }
            catch (Exception e)
            {
                string Error = e.Message;
                answer = false;
            }

            return answer;
        }
    }
}
