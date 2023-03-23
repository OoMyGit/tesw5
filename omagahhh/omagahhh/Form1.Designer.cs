namespace omagahhh
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
            this.taimer = new System.Windows.Forms.Timer(this.components);
            this.lebel = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bruh = new System.Windows.Forms.DataGridView();
            this.labelnama = new System.Windows.Forms.Label();
            this.labeltim = new System.Windows.Forms.Label();
            this.labelstadion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bruh)).BeginInit();
            this.SuspendLayout();
            // 
            // taimer
            // 
            this.taimer.Enabled = true;
            this.taimer.Interval = 1000;
            // 
            // lebel
            // 
            this.lebel.AutoSize = true;
            this.lebel.Location = new System.Drawing.Point(25, 37);
            this.lebel.Name = "lebel";
            this.lebel.Size = new System.Drawing.Size(45, 13);
            this.lebel.TabIndex = 0;
            this.lebel.Text = "laabbelll";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(467, 219);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(321, 23);
            this.progress.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "behel ricky seksi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // bruh
            // 
            this.bruh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bruh.Location = new System.Drawing.Point(12, 12);
            this.bruh.Name = "bruh";
            this.bruh.Size = new System.Drawing.Size(330, 253);
            this.bruh.TabIndex = 4;
            // 
            // labelnama
            // 
            this.labelnama.AutoSize = true;
            this.labelnama.Location = new System.Drawing.Point(378, 37);
            this.labelnama.Name = "labelnama";
            this.labelnama.Size = new System.Drawing.Size(35, 13);
            this.labelnama.TabIndex = 5;
            this.labelnama.Text = "Nama";
            // 
            // labeltim
            // 
            this.labeltim.AutoSize = true;
            this.labeltim.Location = new System.Drawing.Point(378, 75);
            this.labeltim.Name = "labeltim";
            this.labeltim.Size = new System.Drawing.Size(24, 13);
            this.labeltim.TabIndex = 6;
            this.labeltim.Text = "Tim";
            // 
            // labelstadion
            // 
            this.labelstadion.AutoSize = true;
            this.labelstadion.Location = new System.Drawing.Point(378, 114);
            this.labelstadion.Name = "labelstadion";
            this.labelstadion.Size = new System.Drawing.Size(43, 13);
            this.labelstadion.TabIndex = 7;
            this.labelstadion.Text = "Stadion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(445, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(445, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(435, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelstadion);
            this.Controls.Add(this.labeltim);
            this.Controls.Add(this.labelnama);
            this.Controls.Add(this.bruh);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lebel);
            this.Name = "Form1";
            this.Text = "wow";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bruh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lebel;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer taimer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView bruh;
        private System.Windows.Forms.Label labelnama;
        private System.Windows.Forms.Label labeltim;
        private System.Windows.Forms.Label labelstadion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
    }
}

