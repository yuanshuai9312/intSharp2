namespace OperationIniFile
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNameAnnotate = new System.Windows.Forms.TextBox();
            this.txtAddressAnnotate = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAgeAnnotate = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSexAnnotate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.cbShowAnnotate = new System.Windows.Forms.CheckBox();
            this.cbWriteAnnotate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameAnnotate);
            this.groupBox1.Controls.Add(this.txtAddressAnnotate);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtAgeAnnotate);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtSexAnnotate);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(768, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作示例";
            // 
            // txtNameAnnotate
            // 
            this.txtNameAnnotate.Location = new System.Drawing.Point(531, 49);
            this.txtNameAnnotate.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameAnnotate.Name = "txtNameAnnotate";
            this.txtNameAnnotate.Size = new System.Drawing.Size(188, 27);
            this.txtNameAnnotate.TabIndex = 4;
            this.txtNameAnnotate.TextChanged += new System.EventHandler(this.txtNameAnnotate_TextChanged);
            // 
            // txtAddressAnnotate
            // 
            this.txtAddressAnnotate.Location = new System.Drawing.Point(531, 154);
            this.txtAddressAnnotate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddressAnnotate.Name = "txtAddressAnnotate";
            this.txtAddressAnnotate.Size = new System.Drawing.Size(188, 27);
            this.txtAddressAnnotate.TabIndex = 7;
            this.txtAddressAnnotate.TextChanged += new System.EventHandler(this.txtAddressAnnotate_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 27);
            this.txtName.TabIndex = 0;
            // 
            // txtAgeAnnotate
            // 
            this.txtAgeAnnotate.Location = new System.Drawing.Point(531, 119);
            this.txtAgeAnnotate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgeAnnotate.Name = "txtAgeAnnotate";
            this.txtAgeAnnotate.Size = new System.Drawing.Size(188, 27);
            this.txtAgeAnnotate.TabIndex = 6;
            this.txtAgeAnnotate.TextChanged += new System.EventHandler(this.txtAgeAnnotate_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(80, 154);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(402, 27);
            this.txtAddress.TabIndex = 3;
            // 
            // txtSexAnnotate
            // 
            this.txtSexAnnotate.Location = new System.Drawing.Point(531, 84);
            this.txtSexAnnotate.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexAnnotate.Name = "txtSexAnnotate";
            this.txtSexAnnotate.Size = new System.Drawing.Size(188, 27);
            this.txtSexAnnotate.TabIndex = 5;
            this.txtSexAnnotate.TextChanged += new System.EventHandler(this.txtSexAnnotate_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(80, 119);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(188, 27);
            this.txtAge.TabIndex = 2;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(80, 84);
            this.txtSex.Margin = new System.Windows.Forms.Padding(4);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(188, 27);
            this.txtSex.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "年齡：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "性別：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(76, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "值";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(527, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "註解";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.Location = new System.Drawing.Point(684, 236);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 30);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "讀取";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWrite.Location = new System.Drawing.Point(576, 236);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(4);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 30);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "寫入";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // cbShowAnnotate
            // 
            this.cbShowAnnotate.AutoSize = true;
            this.cbShowAnnotate.Checked = true;
            this.cbShowAnnotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowAnnotate.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbShowAnnotate.Location = new System.Drawing.Point(16, 241);
            this.cbShowAnnotate.Name = "cbShowAnnotate";
            this.cbShowAnnotate.Size = new System.Drawing.Size(91, 23);
            this.cbShowAnnotate.TabIndex = 10;
            this.cbShowAnnotate.Text = "註解顯示";
            this.cbShowAnnotate.UseVisualStyleBackColor = true;
            // 
            // cbWriteAnnotate
            // 
            this.cbWriteAnnotate.AutoSize = true;
            this.cbWriteAnnotate.Checked = true;
            this.cbWriteAnnotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWriteAnnotate.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbWriteAnnotate.Location = new System.Drawing.Point(113, 241);
            this.cbWriteAnnotate.Name = "cbWriteAnnotate";
            this.cbWriteAnnotate.Size = new System.Drawing.Size(91, 23);
            this.cbWriteAnnotate.TabIndex = 10;
            this.cbWriteAnnotate.Text = "寫入註解";
            this.cbWriteAnnotate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 277);
            this.Controls.Add(this.cbWriteAnnotate);
            this.Controls.Add(this.cbShowAnnotate);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作INI檔案";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtNameAnnotate;
        private System.Windows.Forms.TextBox txtAddressAnnotate;
        private System.Windows.Forms.TextBox txtAgeAnnotate;
        private System.Windows.Forms.TextBox txtSexAnnotate;
        private System.Windows.Forms.CheckBox cbShowAnnotate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbWriteAnnotate;
    }
}