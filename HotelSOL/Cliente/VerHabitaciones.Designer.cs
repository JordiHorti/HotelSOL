namespace HotelSOL.Cliente
{
    partial class VerHabitaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButtonTodas = new RadioButton();
            radioButtonEstandar = new RadioButton();
            radioButtonDoble = new RadioButton();
            buttonBuscar = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox5 = new GroupBox();
            dataGridViewSeaarchResult = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(buttonBuscar);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 26);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1162, 268);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar habitaciones";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButtonTodas);
            groupBox4.Controls.Add(radioButtonEstandar);
            groupBox4.Controls.Add(radioButtonDoble);
            groupBox4.Location = new Point(30, 67);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(960, 54);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipos";
            // 
            // radioButtonTodas
            // 
            radioButtonTodas.AutoSize = true;
            radioButtonTodas.Location = new Point(760, 20);
            radioButtonTodas.Margin = new Padding(3, 2, 3, 2);
            radioButtonTodas.Name = "radioButtonTodas";
            radioButtonTodas.Size = new Size(55, 19);
            radioButtonTodas.TabIndex = 3;
            radioButtonTodas.TabStop = true;
            radioButtonTodas.Text = "Todas";
            radioButtonTodas.UseVisualStyleBackColor = true;
            // 
            // radioButtonEstandar
            // 
            radioButtonEstandar.AutoSize = true;
            radioButtonEstandar.Location = new Point(433, 20);
            radioButtonEstandar.Margin = new Padding(3, 2, 3, 2);
            radioButtonEstandar.Name = "radioButtonEstandar";
            radioButtonEstandar.Size = new Size(70, 19);
            radioButtonEstandar.TabIndex = 1;
            radioButtonEstandar.TabStop = true;
            radioButtonEstandar.Text = "Estandar";
            radioButtonEstandar.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoble
            // 
            radioButtonDoble.AutoSize = true;
            radioButtonDoble.Location = new Point(164, 20);
            radioButtonDoble.Margin = new Padding(3, 2, 3, 2);
            radioButtonDoble.Name = "radioButtonDoble";
            radioButtonDoble.Size = new Size(56, 19);
            radioButtonDoble.TabIndex = 0;
            radioButtonDoble.TabStop = true;
            radioButtonDoble.Text = "Doble";
            radioButtonDoble.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = SystemColors.ActiveCaption;
            buttonBuscar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(977, 214);
            buttonBuscar.Margin = new Padding(3, 2, 3, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(115, 34);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 1;
            label1.Text = "Filtra por:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(30, 142);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(960, 54);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precio";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(760, 19);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Todas";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(433, 19);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "101-300€";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(164, 19);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "0-100€";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewSeaarchResult);
            groupBox5.Location = new Point(52, 318);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(1003, 226);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Resultados";
            // 
            // dataGridViewSeaarchResult
            // 
            dataGridViewSeaarchResult.BackgroundColor = Color.Azure;
            dataGridViewSeaarchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeaarchResult.GridColor = SystemColors.InactiveBorder;
            dataGridViewSeaarchResult.Location = new Point(23, 26);
            dataGridViewSeaarchResult.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSeaarchResult.Name = "dataGridViewSeaarchResult";
            dataGridViewSeaarchResult.RowHeadersWidth = 51;
            dataGridViewSeaarchResult.Size = new Size(955, 184);
            dataGridViewSeaarchResult.TabIndex = 1;
            // 
            // VerHabitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 682);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Name = "VerHabitaciones";
            Text = "VerHabitaciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeaarchResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private RadioButton radioButtonTodas;
        private RadioButton radioButtonEstandar;
        private RadioButton radioButtonDoble;
        private Button buttonBuscar;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox5;
        private DataGridView dataGridViewSeaarchResult;
    }
}