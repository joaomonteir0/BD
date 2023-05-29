using Microsoft.VisualBasic.Logging;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using VetCare.classes;

namespace VetCare
{
    public partial class main_scene : Form
    {
        private SqlConnection? cn; // abrir a conexão com a DB
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
                    Console.Write("Erro na conexão");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conexão: " + ex.Message);
            }

            panel1.Visible = true;

            // popular dataTable("ANIMAL") com o método GetAnimalDataBlade()
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

        private void main_scene_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            painelLogo.Visible = false;
            painelAddAnimal.Visible = true;
            painelRemovePaciente.Visible = false;

            // Gerar um número random para a ficha clínica
            Random random = new Random();
            int numPaciente = random.Next(10000000, 99999999);
            numPacienteTextBox.Text = numPaciente.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            painelRemovePaciente.Visible = true;
            painelLogo.Visible = false;
            painelAddAnimal.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nomeDono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ccDono_TextChanged(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Obter os dados dos text boxes e combo box
            string nomeDono = nomeDonoTextBox.Text;
            string moradaDono = moradaDonoTextBox.Text;
            string contatoDono = contatoDonoTextBox.Text;
            string numCC = numCCTextBox.Text;
            string nomeAnimal = nomeAnimalTextBox.Text;
            string racaAnimal = racaAnimalTextBox.Text;
            string especieAnimal = especieAnimalTextBox.Text;
            string numPaciente = numPacienteTextBox.Text;
            DateTime dataNascimentoAnimal = dataNascimentoAnimalPicker.Value;
            int generoAnimal = generoComboBox.SelectedItem.ToString() == "Fêmea" ? 0 : 1;

            // Verificar se algum dos campos está vazio
            if (string.IsNullOrEmpty(nomeDono) || string.IsNullOrEmpty(moradaDono) ||
                string.IsNullOrEmpty(contatoDono) || string.IsNullOrEmpty(numCC) ||
                string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrEmpty(racaAnimal) ||
                string.IsNullOrEmpty(especieAnimal) || string.IsNullOrEmpty(numPaciente))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }


            // Inserir o dono na tabela DONO
            if (!InsertDono(nomeDono, moradaDono, contatoDono, numCC))
            {
                MessageBox.Show("Erro ao inserir o dono.");
                return;
            }

            // Inserir o animal na tabela ANIMAL
            if (!InsertAnimal(nomeAnimal, dataNascimentoAnimal, generoAnimal, racaAnimal, especieAnimal, numPaciente))
            {
                MessageBox.Show("Erro ao inserir o animal.");
                return;
            }

            // Gerar um número random para a ficha clínica
            Random random = new Random();
            int numFichaClinica = random.Next(1000, 9999);

            // Chamar o procedimento armazenado dbo.AdicionarFichaClinica
            if (!AdicionarFichaClinica(numFichaClinica, "", int.Parse(numCC), int.Parse(numPaciente)))
            {
                MessageBox.Show("Erro ao adicionar a ficha clínica.");
                return;
            }

            MessageBox.Show("Animal e dono adicionados com sucesso!");
            nomeDonoTextBox.Text = string.Empty;
            moradaDonoTextBox.Text = string.Empty;
            contatoDonoTextBox.Text = string.Empty;
            numCCTextBox.Text = string.Empty;
            nomeAnimalTextBox.Text = string.Empty;
            racaAnimalTextBox.Text = string.Empty;
            especieAnimalTextBox.Text = string.Empty;
            numPacienteTextBox.Text = string.Empty;
            generoComboBox.SelectedItem = string.Empty;
        }
        private bool InsertDono(string nomeDono, string moradaDono, string contatoDono, string numCC)
        {
            string query = "INSERT INTO DONO (nomeDono, moradaDono, contato, numCC) VALUES (@nomeDono, @moradaDono, @contatoDono, @numCC)";

            using (SqlConnection connection = getSGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeDono", nomeDono);
                    command.Parameters.AddWithValue("@moradaDono", moradaDono);
                    command.Parameters.AddWithValue("@contatoDono", contatoDono);
                    command.Parameters.AddWithValue("@numCC", numCC);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }

        private bool InsertAnimal(string nomeAnimal, DateTime dataNascimentoAnimal, int generoAnimal, string racaAnimal, string especieAnimal, string numPaciente)
        {
            string query = "INSERT INTO ANIMAL (nomeAnimal, dataNascimentoAnimal, genero, raca, especie, numPaciente) " +
                           "VALUES (@nomeAnimal, @dataNascimentoAnimal, @generoAnimal, @racaAnimal, @especieAnimal, @numPaciente)";

            using (SqlConnection connection = getSGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomeAnimal", nomeAnimal);
                    command.Parameters.AddWithValue("@dataNascimentoAnimal", dataNascimentoAnimal);
                    command.Parameters.AddWithValue("@generoAnimal", generoAnimal);
                    command.Parameters.AddWithValue("@racaAnimal", racaAnimal);
                    command.Parameters.AddWithValue("@especieAnimal", especieAnimal);
                    command.Parameters.AddWithValue("@numPaciente", numPaciente);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }

        private bool AdicionarFichaClinica(int numFichaClinica, string registoMedico, int numCC, int numPaciente)
        {
            string query = "EXEC dbo.AdicionarFichaClinica @numFichaClinica, @registoMedico, @numCC, @numPaciente";

            using (SqlConnection connection = getSGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@numFichaClinica", numFichaClinica);
                    command.Parameters.AddWithValue("@registoMedico", registoMedico);
                    command.Parameters.AddWithValue("@numCC", numCC);
                    command.Parameters.AddWithValue("@numPaciente", numPaciente);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void inputNumPacienteRemover_TextChanged(object sender, EventArgs e)
        {

        }

        private void removerBotao_Click(object sender, EventArgs e)
        {
            string inputNumFichaClinica = inputNumPacienteRemover.Text;

            // Verificar se o campo está vazio
            if (string.IsNullOrEmpty(inputNumFichaClinica))
            {
                MessageBox.Show("Por favor, preencha o campo 'Número da Ficha Clínica'.");
                return;
            }

            // Converter o número da ficha clínica para inteiro
            if (!int.TryParse(inputNumFichaClinica, out int numFichaClinica))
            {
                MessageBox.Show("Por favor, insira um número de ficha clínica válido.");
                return;
            }

            // Chamar o procedimento armazenado "dbo.RemoverFichaClinica"
            bool remocaoSucesso = RemoverFichaClinica(numFichaClinica);

            if (remocaoSucesso)
            {
                MessageBox.Show("Ficha clínica removida com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover a ficha clínica. Certifique-se de que o número da ficha clínica é válido.");
            }

            // Limpar o campo de entrada
            inputNumPacienteRemover.Text = string.Empty;
        }

        private bool RemoverFichaClinica(int numFichaClinica)
        {
            try
            {
                using (SqlConnection connection = getSGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand("dbo.RemoverFichaClinica", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@numFichaClinica", numFichaClinica);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        Debug.WriteLine("COISA ->>>> " + rowsAffected);
                        return -rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover a ficha clínica: " + ex.Message);
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}