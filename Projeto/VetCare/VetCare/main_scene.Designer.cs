namespace VetCare
{
    partial class main_scene
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_scene));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            AnimalDataGrid = new DataGridView();
            painelAddAnimal = new Panel();
            adicionarPaciente = new Button();
            label10 = new Label();
            numPacienteTextBox = new TextBox();
            label9 = new Label();
            especieAnimalTextBox = new TextBox();
            generoComboBox = new ComboBox();
            dataNascimentoAnimalPicker = new DateTimePicker();
            label5 = new Label();
            racaAnimalTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            nomeAnimalTextBox = new TextBox();
            label4 = new Label();
            numCCTextBox = new TextBox();
            label3 = new Label();
            contatoDonoTextBox = new TextBox();
            label2 = new Label();
            moradaDonoTextBox = new TextBox();
            label1 = new Label();
            nomeDonoTextBox = new TextBox();
            painelLogo = new Panel();
            textBox1 = new TextBox();
            painelRemovePaciente = new Panel();
            infosFicha = new Panel();
            nCC1 = new Label();
            nficha1 = new Label();
            button7 = new Button();
            fecharAbrirFichaUnica = new Button();
            label18 = new Label();
            textBox5 = new TextBox();
            label17 = new Label();
            textBox4 = new TextBox();
            label16 = new Label();
            textBox3 = new TextBox();
            label15 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            abrirFichaBotao = new Button();
            lerNumFichaAbrir = new TextBox();
            label13 = new Label();
            removerBotao = new Button();
            inputNumPacienteRemover = new TextBox();
            label12 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            dataGridMedicos = new DataGridView();
            button9 = new Button();
            button8 = new Button();
            gerenciarMedico = new Panel();
            button11 = new Button();
            button10 = new Button();
            label27 = new Label();
            textNumProf = new TextBox();
            label28 = new Label();
            textBox11 = new TextBox();
            label25 = new Label();
            textBox8 = new TextBox();
            label24 = new Label();
            textBox7 = new TextBox();
            label23 = new Label();
            textBox6 = new TextBox();
            allDoctorsSelect = new ComboBox();
            adicionarMedico = new Panel();
            pictureBox1 = new PictureBox();
            adicionarMedicoButton = new Button();
            textMoradaMedico = new TextBox();
            label22 = new Label();
            textEmailMedico = new TextBox();
            label21 = new Label();
            textContatoMedico = new TextBox();
            label20 = new Label();
            textNomeMedico = new TextBox();
            label19 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).BeginInit();
            painelAddAnimal.SuspendLayout();
            painelLogo.SuspendLayout();
            painelRemovePaciente.SuspendLayout();
            infosFicha.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).BeginInit();
            gerenciarMedico.SuspendLayout();
            adicionarMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Animais";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Médicos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1095, 49);
            button3.Name = "button3";
            button3.Size = new Size(95, 31);
            button3.TabIndex = 2;
            button3.Text = "Consultas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1095, 93);
            button4.Name = "button4";
            button4.Size = new Size(95, 31);
            button4.TabIndex = 3;
            button4.Text = "Cirurgias";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(AnimalDataGrid);
            panel1.Controls.Add(painelAddAnimal);
            panel1.Controls.Add(painelLogo);
            panel1.Controls.Add(painelRemovePaciente);
            panel1.Location = new Point(16, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1073, 636);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.Location = new Point(8, 96);
            button6.Name = "button6";
            button6.Size = new Size(132, 62);
            button6.TabIndex = 3;
            button6.Text = "Gerenciar Pacientes";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(8, 13);
            button5.Name = "button5";
            button5.Size = new Size(132, 62);
            button5.TabIndex = 2;
            button5.Text = "Adicionar um Paciente";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AnimalDataGrid
            // 
            AnimalDataGrid.AllowUserToAddRows = false;
            AnimalDataGrid.AllowUserToDeleteRows = false;
            AnimalDataGrid.AllowUserToResizeColumns = false;
            AnimalDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            AnimalDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            AnimalDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AnimalDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AnimalDataGrid.BackgroundColor = Color.White;
            AnimalDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            AnimalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AnimalDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            AnimalDataGrid.GridColor = SystemColors.ActiveCaption;
            AnimalDataGrid.Location = new Point(8, 402);
            AnimalDataGrid.Name = "AnimalDataGrid";
            AnimalDataGrid.ReadOnly = true;
            AnimalDataGrid.RowHeadersWidth = 51;
            AnimalDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AnimalDataGrid.RowTemplate.Height = 29;
            AnimalDataGrid.RowTemplate.ReadOnly = true;
            AnimalDataGrid.ScrollBars = ScrollBars.Vertical;
            AnimalDataGrid.ShowEditingIcon = false;
            AnimalDataGrid.Size = new Size(798, 190);
            AnimalDataGrid.TabIndex = 0;
            AnimalDataGrid.CellContentClick += AnimalDataGrid_CellContentClick;
            // 
            // painelAddAnimal
            // 
            painelAddAnimal.BorderStyle = BorderStyle.FixedSingle;
            painelAddAnimal.Controls.Add(adicionarPaciente);
            painelAddAnimal.Controls.Add(label10);
            painelAddAnimal.Controls.Add(numPacienteTextBox);
            painelAddAnimal.Controls.Add(label9);
            painelAddAnimal.Controls.Add(especieAnimalTextBox);
            painelAddAnimal.Controls.Add(generoComboBox);
            painelAddAnimal.Controls.Add(dataNascimentoAnimalPicker);
            painelAddAnimal.Controls.Add(label5);
            painelAddAnimal.Controls.Add(racaAnimalTextBox);
            painelAddAnimal.Controls.Add(label6);
            painelAddAnimal.Controls.Add(label7);
            painelAddAnimal.Controls.Add(label8);
            painelAddAnimal.Controls.Add(nomeAnimalTextBox);
            painelAddAnimal.Controls.Add(label4);
            painelAddAnimal.Controls.Add(numCCTextBox);
            painelAddAnimal.Controls.Add(label3);
            painelAddAnimal.Controls.Add(contatoDonoTextBox);
            painelAddAnimal.Controls.Add(label2);
            painelAddAnimal.Controls.Add(moradaDonoTextBox);
            painelAddAnimal.Controls.Add(label1);
            painelAddAnimal.Controls.Add(nomeDonoTextBox);
            painelAddAnimal.Location = new Point(162, 13);
            painelAddAnimal.Name = "painelAddAnimal";
            painelAddAnimal.Size = new Size(644, 364);
            painelAddAnimal.TabIndex = 1;
            painelAddAnimal.Visible = false;
            // 
            // adicionarPaciente
            // 
            adicionarPaciente.BackColor = Color.OliveDrab;
            adicionarPaciente.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            adicionarPaciente.ForeColor = Color.Snow;
            adicionarPaciente.Location = new Point(265, 262);
            adicionarPaciente.Name = "adicionarPaciente";
            adicionarPaciente.Size = new Size(196, 72);
            adicionarPaciente.TabIndex = 22;
            adicionarPaciente.Text = "Adicionar";
            adicionarPaciente.UseVisualStyleBackColor = false;
            adicionarPaciente.Click += button7_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(26, 294);
            label10.Name = "label10";
            label10.Size = new Size(154, 20);
            label10.TabIndex = 21;
            label10.Text = "Número do paciente:";
            label10.Click += label10_Click;
            // 
            // numPacienteTextBox
            // 
            numPacienteTextBox.BackColor = Color.Silver;
            numPacienteTextBox.BorderStyle = BorderStyle.None;
            numPacienteTextBox.Enabled = false;
            numPacienteTextBox.Location = new Point(29, 317);
            numPacienteTextBox.Name = "numPacienteTextBox";
            numPacienteTextBox.Size = new Size(189, 20);
            numPacienteTextBox.TabIndex = 20;
            numPacienteTextBox.Text = "1111";
            numPacienteTextBox.TextChanged += numPacienteTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(26, 239);
            label9.Name = "label9";
            label9.Size = new Size(135, 20);
            label9.TabIndex = 19;
            label9.Text = "Espécie do animal:";
            // 
            // especieAnimalTextBox
            // 
            especieAnimalTextBox.Location = new Point(29, 262);
            especieAnimalTextBox.Name = "especieAnimalTextBox";
            especieAnimalTextBox.Size = new Size(189, 27);
            especieAnimalTextBox.TabIndex = 18;
            // 
            // generoComboBox
            // 
            generoComboBox.FormattingEnabled = true;
            generoComboBox.Items.AddRange(new object[] { "Fêmea", "Macho" });
            generoComboBox.Location = new Point(27, 152);
            generoComboBox.Name = "generoComboBox";
            generoComboBox.Size = new Size(191, 28);
            generoComboBox.TabIndex = 17;
            generoComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataNascimentoAnimalPicker
            // 
            dataNascimentoAnimalPicker.Location = new Point(25, 94);
            dataNascimentoAnimalPicker.Name = "dataNascimentoAnimalPicker";
            dataNascimentoAnimalPicker.Size = new Size(193, 27);
            dataNascimentoAnimalPicker.TabIndex = 16;
            dataNascimentoAnimalPicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(26, 184);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 15;
            label5.Text = "Raça do animal:";
            // 
            // racaAnimalTextBox
            // 
            racaAnimalTextBox.Location = new Point(29, 207);
            racaAnimalTextBox.Name = "racaAnimalTextBox";
            racaAnimalTextBox.Size = new Size(189, 27);
            racaAnimalTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(24, 129);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 13;
            label6.Text = "Género do animal:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(22, 73);
            label7.Name = "label7";
            label7.Size = new Size(220, 20);
            label7.TabIndex = 11;
            label7.Text = "Data de nascimento do animal:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(22, 16);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 9;
            label8.Text = "Nome do animal:";
            label8.Click += label8_Click;
            // 
            // nomeAnimalTextBox
            // 
            nomeAnimalTextBox.Location = new Point(25, 39);
            nomeAnimalTextBox.Name = "nomeAnimalTextBox";
            nomeAnimalTextBox.Size = new Size(189, 27);
            nomeAnimalTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(262, 184);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 7;
            label4.Text = "Número do CC:";
            label4.Click += label4_Click;
            // 
            // numCCTextBox
            // 
            numCCTextBox.Location = new Point(265, 207);
            numCCTextBox.Name = "numCCTextBox";
            numCCTextBox.Size = new Size(196, 27);
            numCCTextBox.TabIndex = 6;
            numCCTextBox.TextChanged += ccDono_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(262, 130);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 5;
            label3.Text = "Contacto do dono:";
            // 
            // contatoDonoTextBox
            // 
            contatoDonoTextBox.Location = new Point(265, 153);
            contatoDonoTextBox.Name = "contatoDonoTextBox";
            contatoDonoTextBox.Size = new Size(196, 27);
            contatoDonoTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(265, 71);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Morada do dono:";
            label2.Click += label2_Click;
            // 
            // moradaDonoTextBox
            // 
            moradaDonoTextBox.Location = new Point(268, 94);
            moradaDonoTextBox.Name = "moradaDonoTextBox";
            moradaDonoTextBox.Size = new Size(196, 27);
            moradaDonoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(266, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do dono:";
            label1.Click += label1_Click;
            // 
            // nomeDonoTextBox
            // 
            nomeDonoTextBox.Location = new Point(269, 39);
            nomeDonoTextBox.Name = "nomeDonoTextBox";
            nomeDonoTextBox.Size = new Size(196, 27);
            nomeDonoTextBox.TabIndex = 0;
            nomeDonoTextBox.TextChanged += nomeDono_TextChanged;
            // 
            // painelLogo
            // 
            painelLogo.Controls.Add(textBox1);
            painelLogo.Location = new Point(162, 13);
            painelLogo.Name = "painelLogo";
            painelLogo.Size = new Size(644, 364);
            painelLogo.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(166, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 107);
            textBox1.TabIndex = 0;
            textBox1.Text = "VetCare";
            // 
            // painelRemovePaciente
            // 
            painelRemovePaciente.Controls.Add(infosFicha);
            painelRemovePaciente.Controls.Add(abrirFichaBotao);
            painelRemovePaciente.Controls.Add(lerNumFichaAbrir);
            painelRemovePaciente.Controls.Add(label13);
            painelRemovePaciente.Controls.Add(removerBotao);
            painelRemovePaciente.Controls.Add(inputNumPacienteRemover);
            painelRemovePaciente.Controls.Add(label12);
            painelRemovePaciente.Controls.Add(label11);
            painelRemovePaciente.Location = new Point(162, 13);
            painelRemovePaciente.Name = "painelRemovePaciente";
            painelRemovePaciente.Size = new Size(644, 364);
            painelRemovePaciente.TabIndex = 5;
            painelRemovePaciente.Visible = false;
            // 
            // infosFicha
            // 
            infosFicha.Controls.Add(nCC1);
            infosFicha.Controls.Add(nficha1);
            infosFicha.Controls.Add(button7);
            infosFicha.Controls.Add(fecharAbrirFichaUnica);
            infosFicha.Controls.Add(label18);
            infosFicha.Controls.Add(textBox5);
            infosFicha.Controls.Add(label17);
            infosFicha.Controls.Add(textBox4);
            infosFicha.Controls.Add(label16);
            infosFicha.Controls.Add(textBox3);
            infosFicha.Controls.Add(label15);
            infosFicha.Controls.Add(textBox2);
            infosFicha.Controls.Add(label14);
            infosFicha.Location = new Point(317, 65);
            infosFicha.Name = "infosFicha";
            infosFicha.Size = new Size(323, 282);
            infosFicha.TabIndex = 7;
            infosFicha.Visible = false;
            infosFicha.Paint += infosFicha_Paint;
            // 
            // nCC1
            // 
            nCC1.AutoSize = true;
            nCC1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            nCC1.Location = new Point(193, 21);
            nCC1.Name = "nCC1";
            nCC1.Size = new Size(127, 17);
            nCC1.TabIndex = 12;
            nCC1.Text = "NºFicha: 123123123";
            // 
            // nficha1
            // 
            nficha1.AutoSize = true;
            nficha1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            nficha1.Location = new Point(193, 4);
            nficha1.Name = "nficha1";
            nficha1.Size = new Size(127, 17);
            nficha1.TabIndex = 11;
            nficha1.Text = "NºFicha: 123123123";
            nficha1.Click += nficha1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.SandyBrown;
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(5, 244);
            button7.Name = "button7";
            button7.Size = new Size(163, 29);
            button7.TabIndex = 10;
            button7.Text = "Editar dados";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // fecharAbrirFichaUnica
            // 
            fecharAbrirFichaUnica.BackColor = Color.Red;
            fecharAbrirFichaUnica.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fecharAbrirFichaUnica.Location = new Point(176, 244);
            fecharAbrirFichaUnica.Name = "fecharAbrirFichaUnica";
            fecharAbrirFichaUnica.Size = new Size(103, 29);
            fecharAbrirFichaUnica.TabIndex = 9;
            fecharAbrirFichaUnica.Text = "Fechar";
            fecharAbrirFichaUnica.UseVisualStyleBackColor = false;
            fecharAbrirFichaUnica.Click += fecharAbrirFichaUnica_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 190);
            label18.Name = "label18";
            label18.Size = new Size(72, 20);
            label18.TabIndex = 8;
            label18.Text = "Contacto:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(224, 224, 224);
            textBox5.Enabled = false;
            textBox5.Location = new Point(5, 211);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 27);
            textBox5.TabIndex = 7;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 139);
            label17.Name = "label17";
            label17.Size = new Size(64, 20);
            label17.TabIndex = 6;
            label17.Text = "Morada:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(224, 224, 224);
            textBox4.Enabled = false;
            textBox4.Location = new Point(5, 160);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 27);
            textBox4.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 87);
            label16.Name = "label16";
            label16.Size = new Size(124, 20);
            label16.TabIndex = 4;
            label16.Text = "Nome do animal:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(224, 224, 224);
            textBox3.Enabled = false;
            textBox3.Location = new Point(5, 108);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 27);
            textBox3.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 38);
            label15.Name = "label15";
            label15.Size = new Size(114, 20);
            label15.TabIndex = 2;
            label15.Text = "Nome do dono:";
            label15.Click += label15_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Enabled = false;
            textBox2.Location = new Point(5, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 27);
            textBox2.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(3, 9);
            label14.Name = "label14";
            label14.Size = new Size(142, 28);
            label14.TabIndex = 0;
            label14.Text = "Espécie - Cão:";
            // 
            // abrirFichaBotao
            // 
            abrirFichaBotao.BackColor = Color.OliveDrab;
            abrirFichaBotao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            abrirFichaBotao.ForeColor = Color.Black;
            abrirFichaBotao.Location = new Point(165, 267);
            abrirFichaBotao.Name = "abrirFichaBotao";
            abrirFichaBotao.Size = new Size(136, 45);
            abrirFichaBotao.TabIndex = 6;
            abrirFichaBotao.Text = "Abrir";
            abrirFichaBotao.UseVisualStyleBackColor = false;
            abrirFichaBotao.Click += abrirFichaBotao_Click;
            // 
            // lerNumFichaAbrir
            // 
            lerNumFichaAbrir.Location = new Point(20, 233);
            lerNumFichaAbrir.Name = "lerNumFichaAbrir";
            lerNumFichaAbrir.Size = new Size(281, 27);
            lerNumFichaAbrir.TabIndex = 5;
            lerNumFichaAbrir.TextChanged += lerNumFichaAbrir_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(19, 206);
            label13.Name = "label13";
            label13.Size = new Size(292, 20);
            label13.TabIndex = 4;
            label13.Text = "Abrir ficha clínica por número do paciente:";
            label13.Click += label13_Click;
            // 
            // removerBotao
            // 
            removerBotao.BackColor = Color.IndianRed;
            removerBotao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removerBotao.ForeColor = Color.Black;
            removerBotao.Location = new Point(165, 128);
            removerBotao.Name = "removerBotao";
            removerBotao.Size = new Size(136, 45);
            removerBotao.TabIndex = 3;
            removerBotao.Text = "Remover";
            removerBotao.UseVisualStyleBackColor = false;
            removerBotao.Click += removerBotao_Click;
            // 
            // inputNumPacienteRemover
            // 
            inputNumPacienteRemover.Location = new Point(23, 95);
            inputNumPacienteRemover.Name = "inputNumPacienteRemover";
            inputNumPacienteRemover.Size = new Size(278, 27);
            inputNumPacienteRemover.TabIndex = 2;
            inputNumPacienteRemover.TextChanged += inputNumPacienteRemover_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 65);
            label12.Name = "label12";
            label12.Size = new Size(281, 20);
            label12.TabIndex = 1;
            label12.Text = "Pelo número da ficha clínica do paciente:";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 19);
            label11.Name = "label11";
            label11.Size = new Size(353, 31);
            label11.TabIndex = 0;
            label11.Text = "Remover um paciente do sistema";
            label11.Click += label11_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridMedicos);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(gerenciarMedico);
            panel2.Controls.Add(adicionarMedico);
            panel2.Location = new Point(16, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 638);
            panel2.TabIndex = 5;
            panel2.Visible = false;
            // 
            // dataGridMedicos
            // 
            dataGridMedicos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMedicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMedicos.GridColor = SystemColors.ControlLightLight;
            dataGridMedicos.Location = new Point(8, 404);
            dataGridMedicos.Name = "dataGridMedicos";
            dataGridMedicos.RowHeadersWidth = 51;
            dataGridMedicos.RowTemplate.Height = 29;
            dataGridMedicos.ScrollBars = ScrollBars.Vertical;
            dataGridMedicos.Size = new Size(987, 221);
            dataGridMedicos.TabIndex = 2;
            dataGridMedicos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button9
            // 
            button9.Location = new Point(8, 91);
            button9.Name = "button9";
            button9.Size = new Size(132, 62);
            button9.TabIndex = 1;
            button9.Text = "Gerenciar Médicos";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(8, 15);
            button8.Name = "button8";
            button8.Size = new Size(132, 62);
            button8.TabIndex = 0;
            button8.Text = "Adicionar Médico";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // gerenciarMedico
            // 
            gerenciarMedico.Controls.Add(button11);
            gerenciarMedico.Controls.Add(button10);
            gerenciarMedico.Controls.Add(label27);
            gerenciarMedico.Controls.Add(textNumProf);
            gerenciarMedico.Controls.Add(label28);
            gerenciarMedico.Controls.Add(textBox11);
            gerenciarMedico.Controls.Add(label25);
            gerenciarMedico.Controls.Add(textBox8);
            gerenciarMedico.Controls.Add(label24);
            gerenciarMedico.Controls.Add(textBox7);
            gerenciarMedico.Controls.Add(label23);
            gerenciarMedico.Controls.Add(textBox6);
            gerenciarMedico.Controls.Add(allDoctorsSelect);
            gerenciarMedico.Location = new Point(162, 21);
            gerenciarMedico.Name = "gerenciarMedico";
            gerenciarMedico.Size = new Size(833, 367);
            gerenciarMedico.TabIndex = 4;
            gerenciarMedico.Visible = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 128, 128);
            button11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button11.Location = new Point(230, 293);
            button11.Name = "button11";
            button11.Size = new Size(205, 65);
            button11.TabIndex = 13;
            button11.Text = "Remover do Sistema";
            button11.UseVisualStyleBackColor = false;
            button11.Visible = false;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(255, 192, 128);
            button10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button10.Location = new Point(14, 293);
            button10.Name = "button10";
            button10.Size = new Size(205, 65);
            button10.TabIndex = 12;
            button10.Text = "Editar Dados";
            button10.UseVisualStyleBackColor = false;
            button10.Visible = false;
            button10.Click += button10_Click;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(313, 137);
            label27.Name = "label27";
            label27.Size = new Size(236, 20);
            label27.TabIndex = 11;
            label27.Text = "Número Identificação Profissional:";
            // 
            // textNumProf
            // 
            textNumProf.Enabled = false;
            textNumProf.Location = new Point(314, 158);
            textNumProf.Name = "textNumProf";
            textNumProf.Size = new Size(261, 27);
            textNumProf.TabIndex = 10;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(311, 64);
            label28.Name = "label28";
            label28.Size = new Size(64, 20);
            label28.TabIndex = 9;
            label28.Text = "Morada:";
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(312, 85);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(261, 27);
            textBox11.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(14, 213);
            label25.Name = "label25";
            label25.Size = new Size(49, 20);
            label25.TabIndex = 7;
            label25.Text = "Email:";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(15, 234);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(261, 27);
            textBox8.TabIndex = 6;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(13, 137);
            label24.Name = "label24";
            label24.Size = new Size(72, 20);
            label24.TabIndex = 5;
            label24.Text = "Contacto:";
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(14, 158);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(261, 27);
            textBox7.TabIndex = 4;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(11, 64);
            label23.Name = "label23";
            label23.Size = new Size(53, 20);
            label23.TabIndex = 3;
            label23.Text = "Nome:";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(12, 85);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(261, 27);
            textBox6.TabIndex = 2;
            // 
            // allDoctorsSelect
            // 
            allDoctorsSelect.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            allDoctorsSelect.FormattingEnabled = true;
            allDoctorsSelect.Location = new Point(13, 16);
            allDoctorsSelect.Name = "allDoctorsSelect";
            allDoctorsSelect.Size = new Size(248, 33);
            allDoctorsSelect.TabIndex = 1;
            allDoctorsSelect.Text = "Selecionar um médico";
            allDoctorsSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // adicionarMedico
            // 
            adicionarMedico.Controls.Add(pictureBox1);
            adicionarMedico.Controls.Add(adicionarMedicoButton);
            adicionarMedico.Controls.Add(textMoradaMedico);
            adicionarMedico.Controls.Add(label22);
            adicionarMedico.Controls.Add(textEmailMedico);
            adicionarMedico.Controls.Add(label21);
            adicionarMedico.Controls.Add(textContatoMedico);
            adicionarMedico.Controls.Add(label20);
            adicionarMedico.Controls.Add(textNomeMedico);
            adicionarMedico.Controls.Add(label19);
            adicionarMedico.Location = new Point(162, 21);
            adicionarMedico.Name = "adicionarMedico";
            adicionarMedico.Size = new Size(833, 367);
            adicionarMedico.TabIndex = 3;
            adicionarMedico.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.medical_icon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(415, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 262);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // adicionarMedicoButton
            // 
            adicionarMedicoButton.BackColor = Color.FromArgb(0, 192, 0);
            adicionarMedicoButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            adicionarMedicoButton.Location = new Point(17, 308);
            adicionarMedicoButton.Name = "adicionarMedicoButton";
            adicionarMedicoButton.Size = new Size(321, 47);
            adicionarMedicoButton.TabIndex = 8;
            adicionarMedicoButton.Text = "Adicionar";
            adicionarMedicoButton.UseVisualStyleBackColor = false;
            adicionarMedicoButton.Click += adicionarMedicoButton_Click;
            // 
            // textMoradaMedico
            // 
            textMoradaMedico.Location = new Point(17, 260);
            textMoradaMedico.Name = "textMoradaMedico";
            textMoradaMedico.Size = new Size(321, 27);
            textMoradaMedico.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(13, 233);
            label22.Name = "label22";
            label22.Size = new Size(64, 20);
            label22.TabIndex = 6;
            label22.Text = "Morada:";
            // 
            // textEmailMedico
            // 
            textEmailMedico.Location = new Point(19, 191);
            textEmailMedico.Name = "textEmailMedico";
            textEmailMedico.Size = new Size(321, 27);
            textEmailMedico.TabIndex = 5;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(15, 164);
            label21.Name = "label21";
            label21.Size = new Size(49, 20);
            label21.TabIndex = 4;
            label21.Text = "Email:";
            // 
            // textContatoMedico
            // 
            textContatoMedico.Location = new Point(21, 122);
            textContatoMedico.Name = "textContatoMedico";
            textContatoMedico.Size = new Size(321, 27);
            textContatoMedico.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(17, 95);
            label20.Name = "label20";
            label20.Size = new Size(72, 20);
            label20.TabIndex = 2;
            label20.Text = "Contacto:";
            // 
            // textNomeMedico
            // 
            textNomeMedico.Location = new Point(23, 52);
            textNomeMedico.Name = "textNomeMedico";
            textNomeMedico.Size = new Size(321, 27);
            textNomeMedico.TabIndex = 1;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(19, 25);
            label19.Name = "label19";
            label19.Size = new Size(129, 20);
            label19.TabIndex = 0;
            label19.Text = "Nome do médico:";
            // 
            // main_scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1212, 852);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "main_scene";
            Text = "Form1";
            Load += main_scene_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).EndInit();
            painelAddAnimal.ResumeLayout(false);
            painelAddAnimal.PerformLayout();
            painelLogo.ResumeLayout(false);
            painelLogo.PerformLayout();
            painelRemovePaciente.ResumeLayout(false);
            painelRemovePaciente.PerformLayout();
            infosFicha.ResumeLayout(false);
            infosFicha.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMedicos).EndInit();
            gerenciarMedico.ResumeLayout(false);
            gerenciarMedico.PerformLayout();
            adicionarMedico.ResumeLayout(false);
            adicionarMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1; // painel dos animais
        private DataGridView AnimalDataGrid;
        private Button button5;
        private Button button6;
        private Panel painelAddAnimal;
        private Label label1;
        private TextBox nomeDonoTextBox;
        private Panel painelLogo;
        private TextBox textBox1;
        private Label label4;
        private TextBox numCCTextBox;
        private Label label3;
        private TextBox contatoDonoTextBox;
        private Label label2;
        private TextBox moradaDonoTextBox;
        private Label label5;
        private TextBox racaAnimalTextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox nomeAnimalTextBox;
        private DateTimePicker dataNascimentoAnimalPicker;
        private ComboBox generoComboBox;
        private Label label10;
        private TextBox numPacienteTextBox;
        private Label label9;
        private TextBox especieAnimalTextBox;
        private Button adicionarPaciente;
        private Panel painelRemovePaciente;
        private Label label11;
        private Button removerBotao;
        private TextBox inputNumPacienteRemover;
        private Label label12;
        private Label label13;
        private Panel infosFicha;
        private Label label15;
        private TextBox textBox2;
        private Label label14;
        private Button abrirFichaBotao;
        private TextBox lerNumFichaAbrir;
        private Label label18;
        private TextBox textBox5;
        private Label label17;
        private TextBox textBox4;
        private Label label16;
        private TextBox textBox3;
        private Button button7;
        private Button fecharAbrirFichaUnica;
        private Label nCC1;
        private Label nficha1;
        private Panel panel2;
        private DataGridView dataGridMedicos;
        private Button button9;
        private Button button8;
        private Panel adicionarMedico;
        private PictureBox pictureBox1;
        private Button adicionarMedicoButton;
        private TextBox textMoradaMedico;
        private Label label22;
        private TextBox textEmailMedico;
        private Label label21;
        private TextBox textContatoMedico;
        private Label label20;
        private TextBox textNomeMedico;
        private Label label19;
        private Panel gerenciarMedico;
        private ComboBox allDoctorsSelect;
        private Button button11;
        private Button button10;
        private Label label27;
        private TextBox textNumProf;
        private Label label28;
        private TextBox textBox11;
        private Label label25;
        private TextBox textBox8;
        private Label label24;
        private TextBox textBox7;
        private Label label23;
        private TextBox textBox6;
    }
}