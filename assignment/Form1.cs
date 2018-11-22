using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList arrswitch = new ArrayList();
            ArrayList compdata = new ArrayList();
            StreamReader lecky = new StreamReader(@"F:\year 1\soft151\project\assignment\assignment\viva.txt");
            string serialnum, switchType, switchInstalled, switchTested, switchStaffid, switchdevices;
            string deviceType, deviceLoc, deviceManufacturer, deviceModel, deviceSnum, deviceDate, deviceComments;
            int devices = 0;
            
            serialnum = lecky.ReadLine();

            while (serialnum != null)
            {              
                switchType = lecky.ReadLine();
                switchInstalled = lecky.ReadLine();
                switchTested = lecky.ReadLine();
                switchStaffid = lecky.ReadLine();
                switchdevices = lecky.ReadLine();
                lstswitch.Items.Add(string.Format("serial number: {0}  |  Switch type: {1}  |  Date installed: {2}  |  Date tested: {3}  |  Staff id: {4}  |  number of devices: {5}",serialnum,switchType, switchInstalled, switchTested, switchStaffid, switchdevices));
                devices = Convert.ToInt32(switchdevices);
                Switch switcher = new Switch(serialnum, switchType, switchInstalled, switchTested, switchStaffid, devices);
               
                arrswitch = new ArrayList();
                for (int i = 0; i < devices; i++) 
                {
                    deviceType = lecky.ReadLine();
                    deviceLoc = lecky.ReadLine();
                    deviceManufacturer = lecky.ReadLine();
                    deviceModel = lecky.ReadLine();
                    deviceSnum = lecky.ReadLine();
                    deviceDate = lecky.ReadLine();                   
                    lstdevice.Items.Add(string.Format("type: {0}  |  location: {1}  |  manufacturer {2}  |  model: {3}  |  serial number: {4}  |  date tested: {5}", deviceType, deviceLoc, deviceManufacturer, deviceModel, deviceSnum, deviceDate));
                    deviceComments = lecky.ReadLine();
                    lstcomments.Items.Add(deviceComments);
                    Device devicer = new Device(deviceType, deviceLoc, deviceManufacturer,deviceModel,deviceSnum,deviceDate, deviceComments);
                    arrswitch.Add(devicer);
                }

                switcher.setdevices(arrswitch);

                compdata.Add(switcher);

                serialnum = lecky.ReadLine();                

            }         

            lecky.Close();

            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSadd_Click(object sender, EventArgs e)
        {
            //string type, installed, tested, id, devices;

            if (string.IsNullOrWhiteSpace(txtSserialnum.Text)) 
            {
                MessageBox.Show("please input serial number");
            }
            else if (string.IsNullOrWhiteSpace(cmbtype.Text))
            {
                MessageBox.Show("please select type");
            }
            else if (string.IsNullOrWhiteSpace(txtSdate.Text)) 
            {
                MessageBox.Show("please input installation date");
            }
            else if (string.IsNullOrWhiteSpace(txtSlast.Text)) 
            {
                MessageBox.Show("please input last tested date");
            }
            else if (string.IsNullOrWhiteSpace(txtSid.Text)) 
            {
                MessageBox.Show("please input staff id");
            }
            else if (string.IsNullOrWhiteSpace(txtSdevices.Text))
            {
                MessageBox.Show("please input correct number of devices");
            }
            else 
            { 
                lstswitch.Items.Add(string.Format("serial number: {0}  |  Switch type: {1}  |  Date installed: {2}  |  Date tested: {3}  |  Staff id: {4}  |  number of devices: {5}", txtSserialnum.Text, cmbtype.Text, txtSdate.Text, txtSlast.Text, txtSid.Text, txtSdevices.Text));
                txtSdate.Text = "";
                txtSdevices.Text = "";
                txtSid.Text = "";
                txtSlast.Text = "";
                txtSserialnum.Text = "";
                cmbtype.Text = "";
                MessageBox.Show("successfully added a switch");
            }
                       
        }

        private void btnSedit_Click(object sender, EventArgs e)
        {
        //    if (
        //    switcheditor Seditor = new switcheditor();
        //    Seditor.Show();
        }

        private void lstswitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDtype.Text))
            {
                MessageBox.Show("please input device type");
            }
            else if (string.IsNullOrWhiteSpace(txtDloc.Text))
            {
                MessageBox.Show("please input device location");
            }
            else if (string.IsNullOrWhiteSpace(txtDmanufaturer.Text))
            {
                MessageBox.Show("please input device manufacturer");
            }
            else if (string.IsNullOrWhiteSpace(txtDmodel.Text))
            {
                MessageBox.Show("please input device model");
            }
            else if (string.IsNullOrWhiteSpace(txtDserialnum.Text))
            {
                MessageBox.Show("please input device serial number");
            }
            else if (string.IsNullOrWhiteSpace(txtDdate.Text))
            {
                MessageBox.Show("please input device date");
            }
            else if(string.IsNullOrWhiteSpace(txtDcomments.Text))
            {
                MessageBox.Show("please input device comments");
            }
            else
            {
                lstdevice.Items.Add(string.Format("type: {0}  |  location: {1}  |  manufacturer {2}  |  model: {3}  |  serial number: {4}  |  date tested: {5}",txtDtype, txtDloc,txtDmanufaturer,txtDmodel,txtDserialnum,txtDdate));
                lstcomments.Items.Add(txtDcomments.Text);
                txtDcomments.Text = "";
                txtDdate.Text = "";
                txtDloc.Text = "";
                txtDmanufaturer.Text = "";
                txtDmodel.Text = "";
                txtDserialnum.Text = "";
                txtDtype.Text = "";
                MessageBox.Show("successfully added a device");
            
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("are you sure you want to delete ", "Delete", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {
                for (int i = lstdevice.SelectedIndices.Count - 1; i >= 0; i--) 
                { 
                    lstdevice.Items.RemoveAt(lstdevice.SelectedIndices[i]);
                }
            }
            else 
            {
                
            }
            
        }

            
        
    }
}
