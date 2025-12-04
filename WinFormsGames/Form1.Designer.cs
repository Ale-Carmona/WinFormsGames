namespace WinFormsGames
{
    partial class Form1
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
            dgDatos = new DataGridView();
            btnMostrar = new Button();
            lbID = new Label();
            txbID = new TextBox();
            btnBuscar = new Button();
            picGame = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGame).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(262, 24);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 82;
            dgDatos.Size = new Size(1095, 420);
            dgDatos.TabIndex = 0;
            dgDatos.CellClick += dgDatos_CellClick;
            dgDatos.CellContentClick += dgDatos_CellContentClick;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(262, 476);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(214, 67);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Juegos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(44, 70);
            lbID.Name = "lbID";
            lbID.Size = new Size(161, 32);
            lbID.TabIndex = 2;
            lbID.Text = "Buscar por ID:";
            // 
            // txbID
            // 
            txbID.Location = new Point(28, 137);
            txbID.Name = "txbID";
            txbID.Size = new Size(200, 39);
            txbID.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(28, 222);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(214, 60);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar por ID";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // picGame
            // 
            picGame.Location = new Point(809, 476);
            picGame.Name = "picGame";
            picGame.Size = new Size(548, 238);
            picGame.TabIndex = 5;
            picGame.TabStop = false;
            picGame.Click += picGame_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 757);
            Controls.Add(picGame);
            Controls.Add(btnBuscar);
            Controls.Add(txbID);
            Controls.Add(lbID);
            Controls.Add(btnMostrar);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgDatos;
        private Button btnMostrar;
        private Label lbID;
        private TextBox txbID;
        private Button btnBuscar;
        private PictureBox picGame;
    }
}
