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
    class Switch
    {

        private string Sserialnum, Stype, Sdate, Slast, Sid;
        private int Sdevices;
        ArrayList compdevice;

        public Switch(string strSnum, string strType, string strDate, string strLast, string strId, int numdevices) 
        {
            Sserialnum = strSnum;
            Stype = strType;
            Sdate = strDate;
            Slast = strLast;
            Sid = strId;
            Sdevices = numdevices;
            compdevice = new ArrayList();
        }

        
        public string getserial() 
        {
            return Sserialnum;
        }

        public string gettype()
        {
            return Stype;
        }

        public string getdate()
        {
            return Sdate;
        }

        public string getlast()
        {
            return Slast;
        }

        public string getid()
        {
            return Sid;
        }

        public int getdevices()
        {
            return Sdevices;
        }

        public ArrayList getcompdevices() 
        {
            return compdevice;
        }

        
        public void setserial(string serialnumber) 
        {
            Sserialnum = serialnumber;
        }

        public void settype(string switchtype)
        {
            Stype = switchtype;
        }

        public void setdate(string switchdate)
        {
            Sdate = switchdate;
        }

        public void setlast(string switchtest)
        {
            Slast = switchtest;
        }

        public void setid(string switchid)
        {
            Sid = switchid;
        }

        public void setdevices(ArrayList switchdevices)
        {
            compdevice = switchdevices;
        }
    }
}
