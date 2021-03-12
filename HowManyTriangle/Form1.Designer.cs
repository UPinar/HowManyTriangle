
using System;
using System.Windows.Forms;

namespace HowManyTriangle
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.textBoxTriangleCount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.thirdPointTextY = new System.Windows.Forms.TextBox();
            this.thirdPointTextX = new System.Windows.Forms.TextBox();
            this.secondPointTextY = new System.Windows.Forms.TextBox();
            this.secondPointTextX = new System.Windows.Forms.TextBox();
            this.firstPointTextY = new System.Windows.Forms.TextBox();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDrawTriangle = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.firstPointTextX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.infoPanel.Controls.Add(this.textBoxTriangleCount);
            this.infoPanel.Controls.Add(this.btnCalculate);
            this.infoPanel.Controls.Add(this.btnClean);
            this.infoPanel.Controls.Add(this.thirdPointTextY);
            this.infoPanel.Controls.Add(this.thirdPointTextX);
            this.infoPanel.Controls.Add(this.secondPointTextY);
            this.infoPanel.Controls.Add(this.secondPointTextX);
            this.infoPanel.Controls.Add(this.firstPointTextY);
            this.infoPanel.Controls.Add(this.btnTriangle);
            this.infoPanel.Controls.Add(this.btnLine);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.btnDrawTriangle);
            this.infoPanel.Controls.Add(this.btnRefresh);
            this.infoPanel.Controls.Add(this.btnDrawLine);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.firstPointTextX);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Location = new System.Drawing.Point(600, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(200, 450);
            this.infoPanel.TabIndex = 0;
            // 
            // textBoxTriangleCount
            // 
            this.textBoxTriangleCount.Enabled = false;
            this.textBoxTriangleCount.Location = new System.Drawing.Point(25, 372);
            this.textBoxTriangleCount.Name = "textBoxTriangleCount";
            this.textBoxTriangleCount.Size = new System.Drawing.Size(152, 20);
            this.textBoxTriangleCount.TabIndex = 21;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(25, 342);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 23);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(25, 162);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(152, 23);
            this.btnClean.TabIndex = 19;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // thirdPointTextY
            // 
            this.thirdPointTextY.Location = new System.Drawing.Point(145, 136);
            this.thirdPointTextY.Name = "thirdPointTextY";
            this.thirdPointTextY.Size = new System.Drawing.Size(43, 20);
            this.thirdPointTextY.TabIndex = 18;
            // 
            // thirdPointTextX
            // 
            this.thirdPointTextX.Location = new System.Drawing.Point(88, 136);
            this.thirdPointTextX.Name = "thirdPointTextX";
            this.thirdPointTextX.Size = new System.Drawing.Size(43, 20);
            this.thirdPointTextX.TabIndex = 17;
            // 
            // secondPointTextY
            // 
            this.secondPointTextY.Location = new System.Drawing.Point(145, 105);
            this.secondPointTextY.Name = "secondPointTextY";
            this.secondPointTextY.Size = new System.Drawing.Size(43, 20);
            this.secondPointTextY.TabIndex = 16;
            // 
            // secondPointTextX
            // 
            this.secondPointTextX.Location = new System.Drawing.Point(88, 105);
            this.secondPointTextX.Name = "secondPointTextX";
            this.secondPointTextX.Size = new System.Drawing.Size(43, 20);
            this.secondPointTextX.TabIndex = 15;
            // 
            // firstPointTextY
            // 
            this.firstPointTextY.Location = new System.Drawing.Point(145, 77);
            this.firstPointTextY.Name = "firstPointTextY";
            this.firstPointTextY.Size = new System.Drawing.Size(43, 20);
            this.firstPointTextY.TabIndex = 14;
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(104, 12);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(75, 23);
            this.btnTriangle.TabIndex = 10;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.BtnTriangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(25, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 9;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Third Point";
            // 
            // btnDrawTriangle
            // 
            this.btnDrawTriangle.Location = new System.Drawing.Point(25, 244);
            this.btnDrawTriangle.Name = "btnDrawTriangle";
            this.btnDrawTriangle.Size = new System.Drawing.Size(154, 23);
            this.btnDrawTriangle.TabIndex = 6;
            this.btnDrawTriangle.Text = "Draw Triangle";
            this.btnDrawTriangle.UseVisualStyleBackColor = true;
            this.btnDrawTriangle.Click += new System.EventHandler(this.btnDrawTriangle_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(25, 41);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(25, 215);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(154, 23);
            this.btnDrawLine.TabIndex = 4;
            this.btnDrawLine.Text = "Draw Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Point";
            // 
            // firstPointTextX
            // 
            this.firstPointTextX.Location = new System.Drawing.Point(88, 77);
            this.firstPointTextX.Name = "firstPointTextX";
            this.firstPointTextX.Size = new System.Drawing.Size(43, 20);
            this.firstPointTextX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Point";
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(600, 450);
            this.buttonPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.infoPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstPointTextX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDrawTriangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.TextBox thirdPointTextY;
        private System.Windows.Forms.TextBox thirdPointTextX;
        private System.Windows.Forms.TextBox secondPointTextY;
        private System.Windows.Forms.TextBox secondPointTextX;
        private System.Windows.Forms.TextBox firstPointTextY;
        public Panel buttonPanel;
        private Button btnClean;
        private TextBox textBoxTriangleCount;
        private Button btnCalculate;
    }
}

