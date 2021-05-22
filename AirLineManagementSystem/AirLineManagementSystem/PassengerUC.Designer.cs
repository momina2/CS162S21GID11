
namespace AirLineManagementSystem
{
    partial class PassengerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.namel = new System.Windows.Forms.Label();
            this.ticketl = new System.Windows.Forms.Label();
            this.amountl = new System.Windows.Forms.Label();
            this.passnumberl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TICKET NUMBER:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(61, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TRANSACTION AMOUNT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "PASSPORT NUMBER:";
            // 
            // namel
            // 
            this.namel.AutoSize = true;
            this.namel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.namel.Location = new System.Drawing.Point(333, 28);
            this.namel.Name = "namel";
            this.namel.Size = new System.Drawing.Size(49, 21);
            this.namel.TabIndex = 4;
            this.namel.Text = "name";
            // 
            // ticketl
            // 
            this.ticketl.AutoSize = true;
            this.ticketl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ticketl.Location = new System.Drawing.Point(333, 57);
            this.ticketl.Name = "ticketl";
            this.ticketl.Size = new System.Drawing.Size(65, 21);
            this.ticketl.TabIndex = 5;
            this.ticketl.Text = "numner";
            this.ticketl.Click += new System.EventHandler(this.ticketl_Click);
            // 
            // amountl
            // 
            this.amountl.AutoSize = true;
            this.amountl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountl.Location = new System.Drawing.Point(333, 90);
            this.amountl.Name = "amountl";
            this.amountl.Size = new System.Drawing.Size(66, 21);
            this.amountl.TabIndex = 6;
            this.amountl.Text = "Amount";
            // 
            // passnumberl
            // 
            this.passnumberl.AutoSize = true;
            this.passnumberl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passnumberl.Location = new System.Drawing.Point(333, 117);
            this.passnumberl.Name = "passnumberl";
            this.passnumberl.Size = new System.Drawing.Size(96, 21);
            this.passnumberl.TabIndex = 7;
            this.passnumberl.Text = "passnumber";
            // 
            // PassengerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.passnumberl);
            this.Controls.Add(this.amountl);
            this.Controls.Add(this.ticketl);
            this.Controls.Add(this.namel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PassengerUC";
            this.Size = new System.Drawing.Size(546, 161);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label namel;
        private System.Windows.Forms.Label ticketl;
        private System.Windows.Forms.Label amountl;
        private System.Windows.Forms.Label passnumberl;
    }
}
