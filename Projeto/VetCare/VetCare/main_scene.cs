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

            // Configurar as colunas da AnimalDataGrid
            AnimalDataGrid.AutoGenerateColumns = false;

            // Configurar as colunas para exibir as informações desejadas
            AnimalDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "nomeAnimal",
                HeaderText = "Nome Animal"
            });

            AnimalDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "numCC",
                HeaderText = "Número CC"
            });

            AnimalDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "numPaciente",
                HeaderText = "Número Paciente"
            });

            AnimalDataGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "numFichaUnica",
                HeaderText = "Número Ficha Única"
            });

            // Preencher dados da AnimalDataGrid com os dados lidos para a dataTable
            AnimalDataGrid.DataSource = dataTable;
            painelAddAnimal.Visible = false;
            painelLogo.Visible = true;
        }

        private DataTable GetAnimalDataTable(SqlConnection cn)
        {
            SqlCommand cmd = new SqlCommand("SELECT A.nomeAnimal, F.numCC, A.numPaciente, F.numFichaUnica FROM ANIMAL A CROSS APPLY dbo.GetCCAndFichaUnicaByNumPaciente(A.numPaciente) F", cn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            cn.Close();

            return dataTable;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            AtualizarDataGridViewMedicos();

        }

        private void AtualizarDataGridViewMedicos()
        {
            cn = getSGBDConnection();
            try
            {
                if (!verifySGBDConnection())
                {
                    Console.WriteLine("Erro na conexão");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na conexão: " + ex.Message);
                return;
            }

            string query = "SELECT nome, numProfissional, contato, email, morada FROM MEDICO_VET";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridMedicos.DataSource = dataTable;

            cn.Close();
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
            fecharLerFicha();
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
            // Limpar as colunas existentes na DataGridView
            AnimalDataGrid.Columns.Clear();

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

            DataTable dataTable = GetAnimalDataTable(cn);
            AnimalDataGrid.DataSource = dataTable;
            cn.Close();

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
                    initial_load();
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
            fecharLerFicha();
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

            DataTable dataTable = GetAnimalDataTable(cn);
            AnimalDataGrid.DataSource = dataTable;



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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void abrirFichaBotao_Click(object sender, EventArgs e)
        {
            string numFichaUnica = lerNumFichaAbrir.Text;

            // Verificar se o campo está vazio
            if (string.IsNullOrEmpty(numFichaUnica))
            {
                MessageBox.Show("Por favor, insira um número de ficha única.");
                return;
            }

            // Verificar se o número de ficha única é um valor inteiro
            if (!int.TryParse(numFichaUnica, out int numFicha))
            {
                MessageBox.Show("Por favor, insira um número de ficha única válido.");
                return;
            }

            // Verificar se existe uma ficha clínica com o número fornecido
            if (!VerificarExistenciaFichaClinica(numFicha))
            {
                MessageBox.Show("A ficha clínica com o número fornecido não existe.");
                return;
            }

            // Obter os dados da ficha clínica
            Dictionary<string, string> dadosFicha = ObterDadosFichaClinica(numFicha);

            // Preencher os campos do painel com os dados obtidos
            textBox2.Text = dadosFicha["nomeDono"];
            textBox3.Text = dadosFicha["nomeAnimal"];
            textBox4.Text = dadosFicha["moradaDono"];
            textBox5.Text = dadosFicha["contato"];
            nficha1.Text = "Nº Ficha: " + dadosFicha["numCC"];
            nCC1.Text = "Nº CC: " + dadosFicha["numFichaClinica"];
            label14.Text = "Espécie: " + dadosFicha["especie"];
            // Exibir o painel de informações da ficha
            infosFicha.Visible = true;
        }

        private bool VerificarExistenciaFichaClinica(int numFicha)
        {
            try
            {
                using (SqlConnection connection = getSGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM FICHA_CLINICA WHERE numFichaUnica = @numFicha", connection))
                    {
                        command.Parameters.AddWithValue("@numFicha", numFicha);

                        connection.Open();
                        int count = (int)command.ExecuteScalar();
                        connection.Close();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao verificar a existência da ficha clínica: " + ex.Message);
                return false;
            }
        }

        private Dictionary<string, string> ObterDadosFichaClinica(int numFicha)
        {
            Dictionary<string, string> dadosFicha = new Dictionary<string, string>();

            try
            {
                using (SqlConnection connection = getSGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand("SELECT * FROM ObterDadosFichaClinica(@numFicha)", connection))
                    {
                        command.Parameters.AddWithValue("@numFicha", numFicha);

                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            dadosFicha.Add("nomeDono", reader["nomeDono"].ToString());
                            dadosFicha.Add("nomeAnimal", reader["nomeAnimal"].ToString());
                            dadosFicha.Add("moradaDono", reader["moradaDono"].ToString());
                            dadosFicha.Add("contato", reader["contato"].ToString());
                            dadosFicha.Add("numCC", reader["numCC"].ToString());
                            dadosFicha.Add("numFichaClinica", reader["numFichaUnica"].ToString());
                            dadosFicha.Add("especie", reader["especie"].ToString());
                        }

                        reader.Close();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao obter os dados da ficha clínica: " + ex.Message);
            }

            return dadosFicha;
        }


        private void lerNumFichaAbrir_TextChanged(object sender, EventArgs e)
        {

        }

        private void infosFicha_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool modoEdicao = false;

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (modoEdicao)
            {
                // Modo de salvar alterações

                // Realizar as validações e salvar as alterações no banco de dados

                // Obter os novos valores das TextBox
                string novoNomeDono = textBox2.Text;
                string novoNomeAnimal = textBox3.Text;
                string novaMorada = textBox4.Text;
                string novoContacto = textBox5.Text;

                // Chamar a SP para atualizar os dados
                using (SqlConnection connection = getSGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand("AtualizarDadosFichaClinica", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string numFichaUnica = lerNumFichaAbrir.Text;
                        command.Parameters.AddWithValue("@numFichaUnica", numFichaUnica);
                        command.Parameters.AddWithValue("@novoNomeDono", novoNomeDono);
                        command.Parameters.AddWithValue("@novoNomeAnimal", novoNomeAnimal);
                        command.Parameters.AddWithValue("@novaMoradaDono", novaMorada);
                        command.Parameters.AddWithValue("@novoContato", novoContacto);

                        connection.Open();
                        command.ExecuteNonQuery();
                        DataTable dataTable = GetAnimalDataTable(connection);
                        AnimalDataGrid.DataSource = dataTable;
                        connection.Close();
                    }
                }

                // Desabilitar as TextBox para edição
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;

                // Alterar o texto do botão
                button7.Text = "Editar";

                // Alterar o modo de edição
                modoEdicao = false;
            }
            else
            {
                // Modo de edição

                // Habilitar as TextBox para edição
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;

                // Alterar o texto do botão
                button7.Text = "Guardar alterações";

                // Alterar o modo de edição
                modoEdicao = true;
            }
        }



        private void nPaciente1_Click(object sender, EventArgs e)
        {

        }

        private void nficha1_Click(object sender, EventArgs e)
        {
        }

        private void fecharAbrirFichaUnica_Click(object sender, EventArgs e)
        {
            fecharLerFicha();
        }

        private void fecharLerFicha()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            lerNumFichaAbrir.Text = string.Empty;
            infosFicha.Visible = false;
        }

        private void numPacienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}