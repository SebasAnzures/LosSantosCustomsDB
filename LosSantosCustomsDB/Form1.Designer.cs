namespace LosSantosCustomsDB
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
            gvDatos = new DataGridView();
            btnLeer = new Button();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            tbID = new TextBox();
            tbMarca = new TextBox();
            tbModelo = new TextBox();
            tbAno = new TextBox();
            tbDisponible = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)gvDatos).BeginInit();
            SuspendLayout();
            // 
            // gvDatos
            // 
            gvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvDatos.Location = new Point(12, 12);
            gvDatos.Name = "gvDatos";
            gvDatos.Size = new Size(776, 306);
            gvDatos.TabIndex = 0;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 415);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(75, 23);
            btnLeer.TabIndex = 1;
            btnLeer.Text = "Leer";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(93, 415);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(174, 415);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(255, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // tbID
            // 
            tbID.Location = new Point(12, 386);
            tbID.Name = "tbID";
            tbID.Size = new Size(100, 23);
            tbID.TabIndex = 5;
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(118, 386);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(100, 23);
            tbMarca.TabIndex = 6;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(224, 386);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(100, 23);
            tbModelo.TabIndex = 7;
            // 
            // tbAno
            // 
            tbAno.Location = new Point(330, 386);
            tbAno.Name = "tbAno";
            tbAno.Size = new Size(100, 23);
            tbAno.TabIndex = 8;
            // 
            // tbDisponible
            // 
            tbDisponible.Location = new Point(436, 386);
            tbDisponible.Name = "tbDisponible";
            tbDisponible.Size = new Size(100, 23);
            tbDisponible.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 368);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 368);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 368);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 368);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 13;
            label4.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 368);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 14;
            label5.Text = "Dispinible";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbDisponible);
            Controls.Add(tbAno);
            Controls.Add(tbModelo);
            Controls.Add(tbMarca);
            Controls.Add(tbID);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(btnLeer);
            Controls.Add(gvDatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvDatos;
        private Button btnLeer;
        private Button btnInsertar;
        private Button btnActualizar;
        private Button btnEliminar;
        private TextBox tbID;
        private TextBox tbMarca;
        private TextBox tbModelo;
        private TextBox tbAno;
        private TextBox tbDisponible;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
