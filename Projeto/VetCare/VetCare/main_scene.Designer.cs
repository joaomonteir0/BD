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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            AnimalDataGrid = new DataGridView();
            painelRemovePaciente = new Panel();
            removerBotao = new Button();
            inputNumPacienteRemover = new TextBox();
            label12 = new Label();
            label11 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).BeginInit();
            painelRemovePaciente.SuspendLayout();
            painelAddAnimal.SuspendLayout();
            painelLogo.SuspendLayout();
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
            panel1.Location = new Point(12, 50);
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
            button6.Text = "Remover um Paciente";
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
            AnimalDataGrid.BackgroundColor = Color.White;
            AnimalDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            AnimalDataGrid.ColumnHeadersHeight = 25;
            AnimalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            AnimalDataGrid.ScrollBars = ScrollBars.Vertical;
            AnimalDataGrid.ShowEditingIcon = false;
            AnimalDataGrid.Size = new Size(798, 190);
            AnimalDataGrid.TabIndex = 0;
            AnimalDataGrid.CellContentClick += AnimalDataGrid_CellContentClick;
            // 
            // painelRemovePaciente
            // 
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
            // removerBotao
            // 
            removerBotao.BackColor = Color.IndianRed;
            removerBotao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removerBotao.ForeColor = Color.Black;
            removerBotao.Location = new Point(136, 136);
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
            inputNumPacienteRemover.Size = new Size(249, 27);
            inputNumPacienteRemover.TabIndex = 2;
            inputNumPacienteRemover.TextChanged += inputNumPacienteRemover_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 65);
            label12.Name = "label12";
            label12.Size = new Size(252, 20);
            label12.TabIndex = 1;
            label12.Text = "Número da ficha clínica do paciente:";
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
            // main_scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1212, 852);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "main_scene";
            Text = "Form1";
            Load += main_scene_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).EndInit();
            painelRemovePaciente.ResumeLayout(false);
            painelRemovePaciente.PerformLayout();
            painelAddAnimal.ResumeLayout(false);
            painelAddAnimal.PerformLayout();
            painelLogo.ResumeLayout(false);
            painelLogo.PerformLayout();
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
    }
}