namespace Puzzle8
{
    partial class screen_puzzle8
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.shuffle = new System.Windows.Forms.Button();
            this.resolve = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.n1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.n2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.n3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.n6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.n5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.n4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.n9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.n8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.n7 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Button();
            this.breadth = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.Steps = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // shuffle
            // 
            this.shuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shuffle.FlatAppearance.BorderSize = 0;
            this.shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shuffle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shuffle.ForeColor = System.Drawing.Color.White;
            this.shuffle.Location = new System.Drawing.Point(13, 434);
            this.shuffle.Name = "shuffle";
            this.shuffle.Size = new System.Drawing.Size(223, 50);
            this.shuffle.TabIndex = 0;
            this.shuffle.Text = "SHUFFLE";
            this.shuffle.UseVisualStyleBackColor = false;
            this.shuffle.Click += new System.EventHandler(this.shuffle_Click);
            // 
            // resolve
            // 
            this.resolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.resolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resolve.FlatAppearance.BorderSize = 0;
            this.resolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolve.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resolve.ForeColor = System.Drawing.Color.White;
            this.resolve.Location = new System.Drawing.Point(242, 434);
            this.resolve.Name = "resolve";
            this.resolve.Size = new System.Drawing.Size(223, 50);
            this.resolve.TabIndex = 1;
            this.resolve.Text = "RESOLVE";
            this.resolve.UseVisualStyleBackColor = false;
            this.resolve.Click += new System.EventHandler(this.resolve_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.n1);
            this.panel1.Location = new System.Drawing.Point(65, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 110);
            this.panel1.TabIndex = 2;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n1.Location = new System.Drawing.Point(20, 11);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(74, 86);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.n2);
            this.panel2.Location = new System.Drawing.Point(181, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 110);
            this.panel2.TabIndex = 3;
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n2.Location = new System.Drawing.Point(21, 11);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(74, 86);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.n3);
            this.panel3.Location = new System.Drawing.Point(297, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 110);
            this.panel3.TabIndex = 3;
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n3.Location = new System.Drawing.Point(19, 11);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(74, 86);
            this.n3.TabIndex = 2;
            this.n3.Text = "3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.n6);
            this.panel4.Location = new System.Drawing.Point(297, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 110);
            this.panel4.TabIndex = 6;
            // 
            // n6
            // 
            this.n6.AutoSize = true;
            this.n6.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n6.Location = new System.Drawing.Point(19, 11);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(74, 86);
            this.n6.TabIndex = 5;
            this.n6.Text = "6";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Controls.Add(this.n5);
            this.panel5.Location = new System.Drawing.Point(181, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 110);
            this.panel5.TabIndex = 5;
            // 
            // n5
            // 
            this.n5.AutoSize = true;
            this.n5.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n5.Location = new System.Drawing.Point(21, 11);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(74, 86);
            this.n5.TabIndex = 4;
            this.n5.Text = "5";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.n4);
            this.panel6.Location = new System.Drawing.Point(65, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 110);
            this.panel6.TabIndex = 4;
            // 
            // n4
            // 
            this.n4.AutoSize = true;
            this.n4.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n4.Location = new System.Drawing.Point(20, 11);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(74, 86);
            this.n4.TabIndex = 3;
            this.n4.Text = "4";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel7.Controls.Add(this.n9);
            this.panel7.Location = new System.Drawing.Point(297, 244);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 110);
            this.panel7.TabIndex = 6;
            // 
            // n9
            // 
            this.n9.AutoSize = true;
            this.n9.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n9.Location = new System.Drawing.Point(19, 12);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(0, 86);
            this.n9.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel8.Controls.Add(this.n8);
            this.panel8.Location = new System.Drawing.Point(181, 244);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 110);
            this.panel8.TabIndex = 5;
            // 
            // n8
            // 
            this.n8.AutoSize = true;
            this.n8.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n8.Location = new System.Drawing.Point(21, 12);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(74, 86);
            this.n8.TabIndex = 2;
            this.n8.Text = "8";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel9.Controls.Add(this.n7);
            this.panel9.Location = new System.Drawing.Point(65, 244);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(110, 110);
            this.panel9.TabIndex = 4;
            // 
            // n7
            // 
            this.n7.AutoSize = true;
            this.n7.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.n7.Location = new System.Drawing.Point(20, 12);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(74, 86);
            this.n7.TabIndex = 1;
            this.n7.Text = "7";
            // 
            // depth
            // 
            this.depth.BackColor = System.Drawing.Color.SlateBlue;
            this.depth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depth.FlatAppearance.BorderSize = 0;
            this.depth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.ForeColor = System.Drawing.Color.White;
            this.depth.Location = new System.Drawing.Point(133, 371);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(107, 44);
            this.depth.TabIndex = 7;
            this.depth.Text = "DEPTH";
            this.depth.UseVisualStyleBackColor = false;
            this.depth.Click += new System.EventHandler(this.depth_Click);
            // 
            // breadth
            // 
            this.breadth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.breadth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breadth.FlatAppearance.BorderSize = 0;
            this.breadth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breadth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breadth.ForeColor = System.Drawing.Color.White;
            this.breadth.Location = new System.Drawing.Point(240, 373);
            this.breadth.Name = "breadth";
            this.breadth.Size = new System.Drawing.Size(107, 40);
            this.breadth.TabIndex = 8;
            this.breadth.Text = "BREADTH";
            this.breadth.UseVisualStyleBackColor = false;
            this.breadth.Click += new System.EventHandler(this.breadth_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.SlateBlue;
            this.panel10.Controls.Add(this.Steps);
            this.panel10.Location = new System.Drawing.Point(377, 376);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(30, 34);
            this.panel10.TabIndex = 9;
            // 
            // Steps
            // 
            this.Steps.AutoSize = true;
            this.Steps.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Steps.ForeColor = System.Drawing.Color.White;
            this.Steps.Location = new System.Drawing.Point(6, 7);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(18, 20);
            this.Steps.TabIndex = 6;
            this.Steps.Text = "0";
            // 
            // screen_puzzle8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(479, 496);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.breadth);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resolve);
            this.Controls.Add(this.shuffle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "screen_puzzle8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle 8";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shuffle;
        private System.Windows.Forms.Button resolve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Label n6;
        private System.Windows.Forms.Label n5;
        private System.Windows.Forms.Label n4;
        private System.Windows.Forms.Label n8;
        private System.Windows.Forms.Label n7;
        private System.Windows.Forms.Label n9;
        private System.Windows.Forms.Button depth;
        private System.Windows.Forms.Button breadth;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label Steps;
    }
}

