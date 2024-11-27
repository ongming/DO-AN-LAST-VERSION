namespace Car_Parking_Management_System_sourse
{
    partial class Attendant__Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIDDenyParking = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeny = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReasonDenyParking = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.txtTicketseri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtIDCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewParkingCar = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAcceptReceive = new System.Windows.Forms.Button();
            this.txtIDofCustomerReceive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewReceiveCar = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnChat = new System.Windows.Forms.Button();
            this.txtIDChat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGidviewChat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingCar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveCar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGidviewChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewParkingCar);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Park Car Request";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIDDenyParking);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnDeny);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtReasonDenyParking);
            this.groupBox2.Location = new System.Drawing.Point(305, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deny Request:";
            // 
            // txtIDDenyParking
            // 
            this.txtIDDenyParking.Location = new System.Drawing.Point(106, 53);
            this.txtIDDenyParking.Name = "txtIDDenyParking";
            this.txtIDDenyParking.Size = new System.Drawing.Size(92, 22);
            this.txtIDDenyParking.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "ID of Customer:";
            // 
            // btnDeny
            // 
            this.btnDeny.Location = new System.Drawing.Point(69, 165);
            this.btnDeny.Name = "btnDeny";
            this.btnDeny.Size = new System.Drawing.Size(75, 28);
            this.btnDeny.TabIndex = 2;
            this.btnDeny.Text = "Deny";
            this.btnDeny.UseVisualStyleBackColor = true;
            this.btnDeny.Click += new System.EventHandler(this.btnDeny_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Write reason why Deny:";
            // 
            // txtReasonDenyParking
            // 
            this.txtReasonDenyParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReasonDenyParking.Location = new System.Drawing.Point(6, 87);
            this.txtReasonDenyParking.Multiline = true;
            this.txtReasonDenyParking.Name = "txtReasonDenyParking";
            this.txtReasonDenyParking.Size = new System.Drawing.Size(192, 63);
            this.txtReasonDenyParking.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Controls.Add(this.txtTicketseri);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAccept);
            this.groupBox1.Controls.Add(this.txtIDCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accept Request:";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(167, 122);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 28);
            this.btnRandom.TabIndex = 5;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // txtTicketseri
            // 
            this.txtTicketseri.Location = new System.Drawing.Point(199, 74);
            this.txtTicketseri.Name = "txtTicketseri";
            this.txtTicketseri.Size = new System.Drawing.Size(56, 22);
            this.txtTicketseri.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Create Ticket Seri:   QMTL";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(45, 122);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 28);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtIDCustomer
            // 
            this.txtIDCustomer.Location = new System.Drawing.Point(155, 40);
            this.txtIDCustomer.Name = "txtIDCustomer";
            this.txtIDCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtIDCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID of Customer:";
            // 
            // dataGridViewParkingCar
            // 
            this.dataGridViewParkingCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParkingCar.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewParkingCar.Name = "dataGridViewParkingCar";
            this.dataGridViewParkingCar.RowHeadersWidth = 51;
            this.dataGridViewParkingCar.RowTemplate.Height = 24;
            this.dataGridViewParkingCar.Size = new System.Drawing.Size(503, 289);
            this.dataGridViewParkingCar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.dataGridViewReceiveCar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Receive Car Request";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAcceptReceive);
            this.groupBox3.Controls.Add(this.txtIDofCustomerReceive);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(6, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Accept Request:";
            // 
            // btnAcceptReceive
            // 
            this.btnAcceptReceive.Location = new System.Drawing.Point(99, 79);
            this.btnAcceptReceive.Name = "btnAcceptReceive";
            this.btnAcceptReceive.Size = new System.Drawing.Size(75, 28);
            this.btnAcceptReceive.TabIndex = 2;
            this.btnAcceptReceive.Text = "Accept";
            this.btnAcceptReceive.UseVisualStyleBackColor = true;
            this.btnAcceptReceive.Click += new System.EventHandler(this.btnAcceptReceive_Click);
            // 
            // txtIDofCustomerReceive
            // 
            this.txtIDofCustomerReceive.Location = new System.Drawing.Point(172, 40);
            this.txtIDofCustomerReceive.Name = "txtIDofCustomerReceive";
            this.txtIDofCustomerReceive.Size = new System.Drawing.Size(100, 22);
            this.txtIDofCustomerReceive.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID of Customer:";
            // 
            // dataGridViewReceiveCar
            // 
            this.dataGridViewReceiveCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiveCar.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewReceiveCar.Name = "dataGridViewReceiveCar";
            this.dataGridViewReceiveCar.RowHeadersWidth = 51;
            this.dataGridViewReceiveCar.RowTemplate.Height = 24;
            this.dataGridViewReceiveCar.Size = new System.Drawing.Size(503, 289);
            this.dataGridViewReceiveCar.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnChat);
            this.tabPage3.Controls.Add(this.txtIDChat);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dataGidviewChat);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(515, 523);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chat with Customer:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(187, 414);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(120, 36);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // txtIDChat
            // 
            this.txtIDChat.Location = new System.Drawing.Point(281, 347);
            this.txtIDChat.Name = "txtIDChat";
            this.txtIDChat.Size = new System.Drawing.Size(100, 22);
            this.txtIDChat.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Enter ID Customer to Chat:";
            // 
            // dataGidviewChat
            // 
            this.dataGidviewChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGidviewChat.Location = new System.Drawing.Point(6, 6);
            this.dataGidviewChat.Name = "dataGidviewChat";
            this.dataGidviewChat.RowHeadersWidth = 51;
            this.dataGidviewChat.RowTemplate.Height = 24;
            this.dataGidviewChat.Size = new System.Drawing.Size(503, 289);
            this.dataGidviewChat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attendant:";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbname.Location = new System.Drawing.Point(254, 75);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(40, 30);
            this.lbname.TabIndex = 3;
            this.lbname.Text = "...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(135)))));
            this.pictureBox1.Location = new System.Drawing.Point(315, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 231);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Attendant__Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(74)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(547, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Attendant__Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendant__Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParkingCar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveCar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGidviewChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewParkingCar;
        private System.Windows.Forms.DataGridView dataGridViewReceiveCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIDCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReasonDenyParking;
        private System.Windows.Forms.Button btnDeny;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAcceptReceive;
        private System.Windows.Forms.TextBox txtIDofCustomerReceive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTicketseri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtIDChat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGidviewChat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.TextBox txtIDDenyParking;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}