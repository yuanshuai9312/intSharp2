using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;//引用命名空間
using System.IO;

namespace OperationIniFile
{
    public partial class Form1 : Form
    {

        #region "聲明變數"
        /// <summary>
        /// 寫入INI文件
        /// </summary>
        /// <param name="section">節點名稱[如[TypeName]]</param>
        /// <param name="key">鍵</param>
        /// <param name="val">值</param>
        /// <param name="filepath">檔路徑</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filepath);
        /// <summary>
        /// 讀取INI文件
        /// </summary>
        /// <param name="section">節點名稱</param>
        /// <param name="key">鍵</param>
        /// <param name="def">值</param>
        /// <param name="retval">stringbulider對象</param>
        /// <param name="size">位元組大小</param>
        /// <param name="filePath">檔路徑</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retval, int size, string filePath);

        private string strFilePath = Application.StartupPath + "\\FileConfig.ini";//獲取INI檔路徑
        private string strSec = string.Empty; //INI檔案名

        string[] valName;
        string[] valSex;
        string[] valAge;
        string[] valAddress;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            btnRead.PerformClick();
        }

        /// <summary>
        /// 讀取INI檔中的內容的方法
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        private string ContentValue(string Section, string key)
        {
            StringBuilder temp = new StringBuilder(1024);
            GetPrivateProfileString(Section, key, "", temp, 1024, strFilePath);
            return temp.ToString();
        }

        /// <summary>
        /// 寫入按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                //根據INI檔案名設置要寫入INI文件的節點名稱
                //此處的節點名稱完全可以根據實際需要進行配置
                strSec = Path.GetFileNameWithoutExtension(strFilePath);
                
                if (cbWriteAnnotate.Checked)
                {
                    WritePrivateProfileString(strSec, "Name", txtName.Text.Trim() + ";" + txtNameAnnotate.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Sex", txtSex.Text.Trim() + ";" + txtSexAnnotate.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Age", txtAge.Text.Trim() + ";" + txtAgeAnnotate.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Address", txtAddress.Text.Trim() + ";" + txtAddressAnnotate.Text.Trim(), strFilePath);
                }
                else
                {
                    WritePrivateProfileString(strSec, "Name", txtName.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Sex", txtSex.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Age", txtAge.Text.Trim(), strFilePath);
                    WritePrivateProfileString(strSec, "Address", txtAddress.Text.Trim(), strFilePath);
                }

                //WritePrivateProfileString(strSec, "Name", txtName.Text.Trim(), strFilePath);
                //WritePrivateProfileString(strSec, "Sex", txtSex.Text.Trim(), strFilePath);
                //WritePrivateProfileString(strSec, "Age", txtAge.Text.Trim(), strFilePath);
                //WritePrivateProfileString(strSec, "Address", txtAddress.Text.Trim(), strFilePath);
                MessageBox.Show("寫入成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// 讀取按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            string temp = string.Empty;            

            if (File.Exists(strFilePath))//讀取時先要判讀INI檔是否存在
            {
                strSec = Path.GetFileNameWithoutExtension(strFilePath);
                valName = ContentValue(strSec, "Name").Split(';');
                valSex = ContentValue(strSec, "Sex").Split(';');
                valAge = ContentValue(strSec, "Age").Split(';');
                valAddress = ContentValue(strSec, "Address").Split(';');

                if (cbShowAnnotate.Checked)
                {
                    txtName.Text = valName[0];
                    txtSex.Text = valSex[0];
                    txtAge.Text = valAge[0];
                    txtAddress.Text = valAddress[0];

                    txtNameAnnotate.Text = valName[1];
                    txtSexAnnotate.Text = valSex[1];
                    txtAgeAnnotate.Text = valAge[1];
                    txtAddressAnnotate.Text = valAddress[1]; 
                }
                else
                {
                    txtName.Text = valName[0];
                    txtSex.Text = valSex[0];
                    txtAge.Text = valAge[0];
                    txtAddress.Text = valAddress[0]; 
                }
                
                //txtName.Text = ContentValue(strSec, "Name");
                //txtSex.Text = ContentValue(strSec, "Sex");
                //txtAge.Text = ContentValue(strSec, "Age");
                //txtAddress.Text = ContentValue(strSec, "Address");
            }
            else
            {
                MessageBox.Show("INI文件不存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNameAnnotate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexAnnotate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgeAnnotate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddressAnnotate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}