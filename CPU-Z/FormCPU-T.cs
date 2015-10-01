using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Collections;

namespace CPU_Z
{
    public partial class formMain : Form
    {

        public formMain()
        {
            InitializeComponent();
            txtName.Text = " ";
            txtCPUUsage.Text = " ";
            txtManufacturer.Text = " ";
        }

        private void GetInfo(string key, string syntax, TextBox txt) // Ham lay thong tin cua bo phan syntax va in ra o tuong ung
        {
            
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM " + key);
            foreach (ManagementObject tmp in searcher.Get())
            {
                txt.Text = Convert.ToString(tmp[syntax]);
            }
                      
        }

        private void infoCPU(object sender, EventArgs e)
        {
            GetInfo("Win32_Processor", "Name", txtName);
            GetInfo("Win32_Processor", "Family", txtFamily);
            GetInfo("Win32_Processor", "SystemName", txtSysName);
            GetInfo("Win32_Processor", "ExtClock", txtExtClock);
            GetInfo("Win32_Processor", "Caption", txtCaption);
            GetInfo("Win32_Processor", "AssetTag", txtAssetTag);
            GetInfo("Win32_Processor", "ThreadCount", txtThreadCount);
            GetInfo("Win32_Processor", "DataWidth", txtDataWidth);
            GetInfo("Win32_Processor", "Level", txtLevel);
            GetInfo("Win32_Processor", "Revision", txtRevision);

            // Kiem tra xem CPU loai nao va dua ra hinh anh tuong ung
            string s1 = txtName.Text;
            if (s1.IndexOf("i7") >= 0)
                imageCPU.Image = Properties.Resources.core_i7;
            else if (s1.IndexOf("i5") >= 0)
                imageCPU.Image = Properties.Resources.core_i5;
            else if (s1.IndexOf("i3") >= 0)
                imageCPU.Image = Properties.Resources.core_i3;
        }

        private void infoMainBoard(object sender, EventArgs e)
        {
            GetInfo("Win32_BaseBoard", "Manufacturer", txtManufacturer);
            GetInfo("Win32_BaseBoard", "Product", txtModel);
            GetInfo("Win32_BaseBoard", "Version", txtVersionBase);
            GetInfo("Win32_BIOS", "SMBIOSBIOSVersion", txtVersionBIOS);
            GetInfo("Win32_BIOS", "Manufacturer", txtManuBIOS);
            GetInfo("Win32_BIOS", "SMBIOSMinorVersion", txtMinor);
            GetInfo("Win32_BIOS", "SMBIOSMajorVersion", txtMajor);
        }

        private void infoMemory(object sender, EventArgs e)
        {
           
        }
    }
}
