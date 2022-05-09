namespace PetLoversDBMS
{
    partial class Inventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShowSupp = new System.Windows.Forms.Button();
            this.btnUpdateItm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1105, 270);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnShowSupp
            // 
            this.btnShowSupp.Location = new System.Drawing.Point(272, 317);
            this.btnShowSupp.Name = "btnShowSupp";
            this.btnShowSupp.Size = new System.Drawing.Size(137, 79);
            this.btnShowSupp.TabIndex = 2;
            this.btnShowSupp.Text = "Show Supplier";
            this.btnShowSupp.UseVisualStyleBackColor = true;
            this.btnShowSupp.Click += new System.EventHandler(this.btnShowSupp_Click);
            // 
            // btnUpdateItm
            // 
            this.btnUpdateItm.Location = new System.Drawing.Point(12, 402);
            this.btnUpdateItm.Name = "btnUpdateItm";
            this.btnUpdateItm.Size = new System.Drawing.Size(137, 79);
            this.btnUpdateItm.TabIndex = 3;
            this.btnUpdateItm.Text = "Add/Update Items";
            this.btnUpdateItm.UseVisualStyleBackColor = true;
            this.btnUpdateItm.Click += new System.EventHandler(this.btnUpdateItm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 402);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 79);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Supplier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1122, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdateItm);
            this.Controls.Add(this.btnShowSupp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory";
            this.Text = "Inventory Section";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnShowSupp;
        private System.Windows.Forms.Button btnUpdateItm;
        private System.Windows.Forms.Button button2;
    }
}