namespace DataGridViewEx
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgwLearning_Input = new System.Windows.Forms.DataGridView();
            this.testDbDataSet = new DataGridViewEx.testDbDataSet();
            this.testDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwLearning_Output = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwProgress_Output = new System.Windows.Forms.DataGridView();
            this.dgwProgress_Input = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLearning_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLearning_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProgress_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProgress_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLearning_Input
            // 
            this.dgwLearning_Input.AllowUserToOrderColumns = true;
            this.dgwLearning_Input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLearning_Input.Location = new System.Drawing.Point(14, 83);
            this.dgwLearning_Input.Name = "dgwLearning_Input";
            this.dgwLearning_Input.Size = new System.Drawing.Size(751, 293);
            this.dgwLearning_Input.TabIndex = 0;
            // 
            // testDbDataSet
            // 
            this.testDbDataSet.DataSetName = "testDbDataSet";
            this.testDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDbDataSetBindingSource
            // 
            this.testDbDataSetBindingSource.DataSource = this.testDbDataSet;
            this.testDbDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Обучение нейросети";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Обучающий набор: Входные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(806, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Обучающий набор: Результаты";
            // 
            // dgwLearning_Output
            // 
            this.dgwLearning_Output.AllowUserToOrderColumns = true;
            this.dgwLearning_Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLearning_Output.Location = new System.Drawing.Point(771, 83);
            this.dgwLearning_Output.Name = "dgwLearning_Output";
            this.dgwLearning_Output.Size = new System.Drawing.Size(351, 293);
            this.dgwLearning_Output.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Прогнозирование прогресса студентов";
            // 
            // dgwProgress_Output
            // 
            this.dgwProgress_Output.AllowUserToOrderColumns = true;
            this.dgwProgress_Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProgress_Output.Location = new System.Drawing.Point(771, 444);
            this.dgwProgress_Output.Name = "dgwProgress_Output";
            this.dgwProgress_Output.Size = new System.Drawing.Size(351, 185);
            this.dgwProgress_Output.TabIndex = 7;
            // 
            // dgwProgress_Input
            // 
            this.dgwProgress_Input.AllowUserToOrderColumns = true;
            this.dgwProgress_Input.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProgress_Input.Location = new System.Drawing.Point(14, 444);
            this.dgwProgress_Input.Name = "dgwProgress_Input";
            this.dgwProgress_Input.Size = new System.Drawing.Size(751, 185);
            this.dgwProgress_Input.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(882, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Построить прогноз";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(625, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Обучить нейросеть";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(882, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Загрузить данные";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 637);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwProgress_Output);
            this.Controls.Add(this.dgwProgress_Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwLearning_Output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwLearning_Input);
            this.Name = "Form1";
            this.Text = "PrognosticNET: Прогнозирование прогресса студентов";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLearning_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLearning_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProgress_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProgress_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwLearning_Input;
        private System.Windows.Forms.BindingSource testDbDataSetBindingSource;
        private testDbDataSet testDbDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwLearning_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwProgress_Output;
        private System.Windows.Forms.DataGridView dgwProgress_Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

