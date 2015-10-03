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
            txtManufacturer.Text = " ";
            txtRam.Text = " ";
            txtDisksize.Text = " ";
        }

        private void GetInfo(string key, string syntax, TextBox txt) 
        // Ham lay thong tin cua bo phan syntax va in ra o tuong ung
        {

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + key);
            foreach (ManagementObject tmp in searcher.Get())
            {
                txt.Text = Convert.ToString(tmp[syntax]);
            }

        }

        private void infoCPU(object sender, EventArgs e)
        {
            //In thong tin trong tab CPU
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
            //In thong tin trong tab MainBoard
            GetInfo("Win32_BaseBoard", "Manufacturer", txtManufacturer);
            GetInfo("Win32_BaseBoard", "Product", txtModel);
            GetInfo("Win32_BaseBoard", "Version", txtVersionBase);
            GetInfo("Win32_BIOS", "SMBIOSBIOSVersion", txtVersionBIOS);
            GetInfo("Win32_BIOS", "Manufacturer", txtManuBIOS);
            GetInfo("Win32_BIOS", "SMBIOSMinorVersion", txtMinor);
            GetInfo("Win32_BIOS", "SMBIOSMajorVersion", txtMajor);
        }

        private void DisplayRam(object sender, EventArgs e)
        {
            //In thong so trong tabMemry
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;
            long FreePhysicalMemory = 0;


            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            txtRam.Text = MemSize.ToString() + "  MB";

            // Get info RAM availble
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject tmp in searcher.Get())
            {
                FreePhysicalMemory = Convert.ToInt64(tmp["FreePhysicalMemory"]);
            }
            FreePhysicalMemory = (FreePhysicalMemory) / 1024;
            txtRamAvai.Text = FreePhysicalMemory.ToString() + "  MB";
        }

        private void GetDisk(object sender, EventArgs e)
        {
            //In thong so trong tab Memory
            //Get CPU speed in GHz
            long DiskSize = 0;
            double? GHz = null;

            using (ManagementClass mc = new ManagementClass("Win32_Processor"))
            {
                foreach (ManagementObject mo in mc.GetInstances())
                {
                    GHz = 0.001 * (UInt32)mo.Properties["CurrentClockSpeed"].Value;
                    break;
                }
            }
            txtSpeed.Text = GHz.ToString() + " Ghz";

            //Lay thong tin ve tong dung luong may
            long memCPU = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");
            foreach (ManagementObject tmp in searcher.Get())
            {
                memCPU = Convert.ToInt64(tmp["Capacity"]);
                DiskSize += memCPU;
            }
            DiskSize = (DiskSize) / 1024 / 1024 / 1024;
            txtDisksize.Text = DiskSize.ToString() + " GB";
        }
    }
}
