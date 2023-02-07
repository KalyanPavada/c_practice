namespace test_WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBalancce = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.bntDestroy = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.txtEnteramount = new System.Windows.Forms.TextBox();
            this.btnDeposite = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnSetMB = new System.Windows.Forms.Button();
            this.txtMB = new System.Windows.Forms.TextBox();
            this.btnGetMB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ld";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balance";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(30, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 27);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 63);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 4;
            // 
            // txtBalancce
            // 
            this.txtBalancce.Location = new System.Drawing.Point(363, 61);
            this.txtBalancce.Name = "txtBalancce";
            this.txtBalancce.Size = new System.Drawing.Size(125, 27);
            this.txtBalancce.TabIndex = 5;
            this.txtBalancce.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(30, 111);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(125, 37);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(201, 111);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(125, 37);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(363, 111);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(125, 37);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(30, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bntDestroy
            // 
            this.bntDestroy.Location = new System.Drawing.Point(201, 172);
            this.bntDestroy.Name = "bntDestroy";
            this.bntDestroy.Size = new System.Drawing.Size(125, 40);
            this.bntDestroy.TabIndex = 10;
            this.bntDestroy.Text = "Destroy";
            this.bntDestroy.UseVisualStyleBackColor = true;
            this.bntDestroy.Click += new System.EventHandler(this.bntDestroy_Click);
            // 
            // btnGC
            // 
            this.btnGC.Location = new System.Drawing.Point(363, 172);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(125, 40);
            this.btnGC.TabIndex = 11;
            this.btnGC.Text = "GC";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(30, 230);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(125, 42);
            this.btnTemp.TabIndex = 12;
            this.btnTemp.Text = "Temp";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // txtEnteramount
            // 
            this.txtEnteramount.Location = new System.Drawing.Point(201, 266);
            this.txtEnteramount.Name = "txtEnteramount";
            this.txtEnteramount.Size = new System.Drawing.Size(125, 27);
            this.txtEnteramount.TabIndex = 13;
            // 
            // btnDeposite
            // 
            this.btnDeposite.Location = new System.Drawing.Point(201, 220);
            this.btnDeposite.Name = "btnDeposite";
            this.btnDeposite.Size = new System.Drawing.Size(125, 40);
            this.btnDeposite.TabIndex = 14;
            this.btnDeposite.Text = "Deposite";
            this.btnDeposite.UseVisualStyleBackColor = true;
            this.btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(363, 220);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(125, 40);
            this.btnWithdraw.TabIndex = 15;
            this.btnWithdraw.Text = "Witdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnSetMB
            // 
            this.btnSetMB.Location = new System.Drawing.Point(30, 306);
            this.btnSetMB.Name = "btnSetMB";
            this.btnSetMB.Size = new System.Drawing.Size(125, 42);
            this.btnSetMB.TabIndex = 16;
            this.btnSetMB.Text = "Set MB";
            this.btnSetMB.UseVisualStyleBackColor = true;
            this.btnSetMB.Click += new System.EventHandler(this.btnSetMB_Click);
            // 
            // txtMB
            // 
            this.txtMB.Location = new System.Drawing.Point(201, 321);
            this.txtMB.Name = "txtMB";
            this.txtMB.Size = new System.Drawing.Size(125, 27);
            this.txtMB.TabIndex = 17;
            // 
            // btnGetMB
            // 
            this.btnGetMB.Location = new System.Drawing.Point(363, 314);
            this.btnGetMB.Name = "btnGetMB";
            this.btnGetMB.Size = new System.Drawing.Size(125, 40);
            this.btnGetMB.TabIndex = 18;
            this.btnGetMB.Text = "Get MB";
            this.btnGetMB.UseVisualStyleBackColor = true;
            this.btnGetMB.Click += new System.EventHandler(this.btnGetMB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 370);
            this.Controls.Add(this.btnGetMB);
            this.Controls.Add(this.txtMB);
            this.Controls.Add(this.btnSetMB);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposite);
            this.Controls.Add(this.txtEnteramount);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.bntDestroy);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBalancce);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AccountFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtBalancce;
        private Button btnCreate;
        private Button btnSet;
        private Button btnGet;
        private Button btnClear;
        private Button bntDestroy;
        private Button btnGC;
        private EventHandler Form1_Load;
        private Button btnTemp;
        private TextBox txtEnteramount;
        private Button btnDeposite;
        private Button btnWithdraw;
        private Button btnSetMB;
        private TextBox txtMB;
        private Button btnGetMB;

        //public EventHandler Form1_Load { get; private set; }
    }
}