using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using VetCare.classes;

namespace VetCare
{
    public partial class main_scene : Form
    {
        private SqlConnection? cn; // abrir a conex�o com a DB
        private Animal? animal;

        public main_scene()
        {
            InitializeComponent();
            initial_load();
            //panel2.Visible = false;
        }

        private void initial_load()
        {
            cn = getSGBDConnection();
            try
            {
                if (!verifySGBDConnection())
                    return;
                else
                {
                    Console.Write("Erro na conex�o");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conex�o: " + ex.Message);
            }

            panel1.Visible = true;

            // popular dataTable("ANIMAL") com o m�todo GetAnimalDataBlade()
            DataTable dataTable = GetAnimalDataTable(cn);

            // Preencher dados da AnimalDataGrid com os dados lidos para a dataTable
            AnimalDataGrid.DataSource = dataTable;
        }



        private DataTable GetAnimalDataTable(SqlConnection cn)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ANIMAL", cn);
            // Para utilizar procedures
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add()
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            cn.Close();

            return dataTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //panel2.Visible = true;
            panel1.Visible = false;
        }


        // SQL methods 
        private SqlConnection getSGBDConnection()
        {
            // Constructs a new SqlConnection 
            return new SqlConnection("Data Source=JOAO;Initial Catalog=VetCare;Integrated Security=True");
        }

        private bool verifySGBDConnection()
        {
            // Opens connection to the DB 
            if (cn == null)
                cn = getSGBDConnection();

            if (cn != null)
            {
                try
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                }
                catch (SqlException e)
                {
                    return false;
                }

                return cn.State == ConnectionState.Open;
            }

            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnimalDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}