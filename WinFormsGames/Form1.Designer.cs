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
            txbUserName = new TextBox();
            txbPassword = new TextBox();
            lbUser = new Label();
            lbPassword = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGame).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(293, 12);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 82;
            dgDatos.Size = new Size(1134, 420);
            dgDatos.TabIndex = 0;
            dgDatos.CellClick += dgDatos_CellClick;
            dgDatos.CellContentClick += dgDatos_CellContentClick;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(28, 335);
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
            picGame.Location = new Point(879, 474);
            picGame.Name = "picGame";
            picGame.Size = new Size(548, 238);
            picGame.TabIndex = 5;
            picGame.TabStop = false;
            picGame.Click += picGame_Click;
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(388, 483);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(200, 39);
            txbUserName.TabIndex = 6;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(388, 560);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(200, 39);
            txbPassword.TabIndex = 7;
            // 
            // lbUser
            // 
            lbUser.AutoSize = true;
            lbUser.Location = new Point(293, 486);
            lbUser.Name = "lbUser";
            lbUser.Size = new Size(66, 32);
            lbUser.TabIndex = 8;
            lbUser.Text = "User:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(243, 567);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(116, 32);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(307, 657);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 46);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 757);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbUser);
            Controls.Add(txbPassword);
            Controls.Add(txbUserName);
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
        private TextBox txbUserName;
        private TextBox txbPassword;
        private Label lbUser;
        private Label lbPassword;
        private Button btnLogin;
    }
}
