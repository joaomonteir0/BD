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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            AnimalDataGrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).BeginInit();
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
            button3.Location = new Point(839, 50);
            button3.Name = "button3";
            button3.Size = new Size(95, 31);
            button3.TabIndex = 2;
            button3.Text = "Consultas";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(839, 94);
            button4.Name = "button4";
            button4.Size = new Size(95, 31);
            button4.TabIndex = 3;
            button4.Text = "Cirurgias";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(AnimalDataGrid);
            panel1.Location = new Point(12, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 493);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // AnimalDataGrid
            // 
            AnimalDataGrid.AllowUserToAddRows = false;
            AnimalDataGrid.AllowUserToDeleteRows = false;
            AnimalDataGrid.AllowUserToResizeColumns = false;
            AnimalDataGrid.AllowUserToResizeRows = false;
            AnimalDataGrid.BackgroundColor = SystemColors.ActiveCaption;
            AnimalDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            AnimalDataGrid.ColumnHeadersHeight = 29;
            AnimalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AnimalDataGrid.GridColor = SystemColors.ActiveCaption;
            AnimalDataGrid.Location = new Point(8, 300);
            AnimalDataGrid.Name = "AnimalDataGrid";
            AnimalDataGrid.RowHeadersWidth = 51;
            AnimalDataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AnimalDataGrid.RowTemplate.Height = 29;
            AnimalDataGrid.ScrollBars = ScrollBars.Vertical;
            AnimalDataGrid.Size = new Size(798, 188);
            AnimalDataGrid.TabIndex = 0;
            AnimalDataGrid.CellContentClick += AnimalDataGrid_CellContentClick;
            // 
            // main_scene
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 571);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "main_scene";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1; // painel dos animais
        private DataGridView AnimalDataGrid;
    }
}