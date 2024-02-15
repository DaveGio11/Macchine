using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Macchine
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Car = ConfigurationManager.ConnectionStrings["Autosalone"].ConnectionString;
            SqlConnection conn = new SqlConnection(Car);
            try
            {
                conn.Open();
                string scelta = DropDownList1.SelectedValue;
                SqlCommand command = new SqlCommand();
                command.Connection = conn;

                switch (scelta)
                {
                    case "Panda":
                        command.CommandText = "SELECT * FROM Generale WHERE Modello = 'Panda'";
                        break;
                    case "Golf":
                        command.CommandText = "SELECT * FROM Generale WHERE Modello = 'Golf'";
                        break;
                    case "ClasseA":
                        command.CommandText = "SELECT * FROM Generale WHERE Modello = 'ClasseA'";
                        break;

                }

                SqlDataReader reader = command.ExecuteReader();



                reader.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Errore");
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



    }
}