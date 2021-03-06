namespace PetLoversDBMS
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInv = new System.Windows.Forms.Button();
            this.btnEmpl = new System.Windows.Forms.Button();
            this.btnCustRep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(788, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Pet Lovers Store DBMS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pet and Customer Section";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInv
            // 
            this.btnInv.Location = new System.Drawing.Point(208, 136);
            this.btnInv.Name = "btnInv";
            this.btnInv.Size = new System.Drawing.Size(123, 95);
            this.btnInv.TabIndex = 2;
            this.btnInv.Text = "Inventory Section";
            this.btnInv.UseVisualStyleBackColor = true;
            this.btnInv.Click += new System.EventHandler(this.btnInv_Click);
            // 
            // btnEmpl
            // 
            this.btnEmpl.Location = new System.Drawing.Point(389, 136);
            this.btnEmpl.Name = "btnEmpl";
            this.btnEmpl.Size = new System.Drawing.Size(123, 95);
            this.btnEmpl.TabIndex = 3;
            this.btnEmpl.Text = "Employee Section";
            this.btnEmpl.UseVisualStyleBackColor = true;
            this.btnEmpl.Click += new System.EventHandler(this.btnEmpl_Click);
            // 
            // btnCustRep
            // 
            this.btnCustRep.Location = new System.Drawing.Point(580, 136);
            this.btnCustRep.Name = "btnCustRep";
            this.btnCustRep.Size = new System.Drawing.Size(123, 95);
            this.btnCustRep.TabIndex = 4;
            this.btnCustRep.Text = "Custom Reports";
            this.btnCustRep.UseVisualStyleBackColor = true;
            this.btnCustRep.Click += new System.EventHandler(this.btnCustRep_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(841, 327);
            this.Controls.Add(this.btnCustRep);
            this.Controls.Add(this.btnEmpl);
            this.Controls.Add(this.btnInv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "The Pet Lovers Store Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btnEmpl;
        private System.Windows.Forms.Button btnCustRep;
    }
}

