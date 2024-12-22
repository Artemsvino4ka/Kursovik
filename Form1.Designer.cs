using System.Drawing;
using System.Windows.Forms;
using System;

namespace Kursovik
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateGraph = new System.Windows.Forms.Button();
            this.txtVertices = new System.Windows.Forms.TextBox();
            this.txtEdge = new System.Windows.Forms.TextBox();
            this.btnAddEdge = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateGraph
            // 
            this.btnCreateGraph.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateGraph.Location = new System.Drawing.Point(25, 99);
            this.btnCreateGraph.Name = "btnCreateGraph";
            this.btnCreateGraph.Size = new System.Drawing.Size(164, 53);
            this.btnCreateGraph.TabIndex = 0;
            this.btnCreateGraph.Text = "Создать граф";
            this.btnCreateGraph.UseVisualStyleBackColor = true;
            this.btnCreateGraph.Click += new System.EventHandler(this.btnCreateGraph_Click_1);
            // 
            // txtVertices
            // 
            this.txtVertices.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtVertices.Location = new System.Drawing.Point(297, 28);
            this.txtVertices.Multiline = true;
            this.txtVertices.Name = "txtVertices";
            this.txtVertices.Size = new System.Drawing.Size(61, 36);
            this.txtVertices.TabIndex = 1;
            // 
            // txtEdge
            // 
            this.txtEdge.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEdge.Location = new System.Drawing.Point(8, 51);
            this.txtEdge.Multiline = true;
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(262, 37);
            this.txtEdge.TabIndex = 2;
            // 
            // btnAddEdge
            // 
            this.btnAddEdge.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddEdge.Location = new System.Drawing.Point(8, 109);
            this.btnAddEdge.Name = "btnAddEdge";
            this.btnAddEdge.Size = new System.Drawing.Size(211, 58);
            this.btnAddEdge.TabIndex = 3;
            this.btnAddEdge.Text = "Добавить ребро";
            this.btnAddEdge.UseVisualStyleBackColor = true;
            this.btnAddEdge.Click += new System.EventHandler(this.btnAddEdge_Click_1);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Location = new System.Drawing.Point(504, 513);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(272, 84);
            this.txtResult.TabIndex = 4;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(38, 546);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(304, 84);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Отобразить результат топологической сортировки";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(487, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 317);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(663, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Отображение графа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите кол-во вершин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Добавьте поочередно ребра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(497, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(604, 40);
            this.label4.TabIndex = 10;
            this.label4.Text = "Отображение результата сортировки";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAddEdge);
            this.panel1.Controls.Add(this.txtEdge);
            this.panel1.Location = new System.Drawing.Point(17, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 176);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1215, 743);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtVertices);
            this.Controls.Add(this.btnCreateGraph);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Visualization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreateGraph;
        private TextBox txtVertices;
        private TextBox txtEdge;
        private Button btnAddEdge;
        private TextBox txtResult;
        private Button btnSort;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}

