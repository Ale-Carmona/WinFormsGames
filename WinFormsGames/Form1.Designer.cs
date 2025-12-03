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
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // dgDatos
            // 
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Location = new Point(396, 24);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 82;
            dgDatos.Size = new Size(1095, 370);
            dgDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(396, 451);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(214, 67);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Juegos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 643);
            Controls.Add(btnMostrar);
            Controls.Add(dgDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDatos;
        private Button btnMostrar;
    }
}
