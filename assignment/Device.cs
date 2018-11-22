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
    class Device
    {
        private string Dtype, Dloc, Dmanufacturer, Dmodel, Dserialnum, Ddate, Dcomments;
        
        ArrayList compswitch;

        public Device(string devtype, string devloc, string devmanufacturer, string devmodel, string devserialnum, string devdate, string devcomments) 
        {
            Dtype = devtype;
            Dloc = devloc;
            Dmanufacturer = devmanufacturer;
            Dmodel = devmodel;
            Dserialnum = devserialnum;
            Ddate = devdate;
            Dcomments = devcomments;
            compswitch = new ArrayList();
        }

        
        public string gettype() 
        {
            return Dtype;
        }

        public string getloc()
        {
            return Dloc;
        }

        public string getmanufacturer()
        {
            return Dmanufacturer;
        }

        public string getmodel()
        {
            return Dmodel;
        }

        public string getserialnum()
        {
            return Dserialnum;
        }

        public string getdate()
        {
            return Ddate;
        }

        public string getcomments()
        {
            return Dcomments;
        }

        public ArrayList getcompswitch() 
        {
            return compswitch;
        }

        
        public void settype(string devicetype) 
        {
            Dtype = devicetype;
        }

        public void setloc(string deviceloc)
        {
            Dloc = deviceloc;
        }

        public void setmanufacturer(string devicemanufacturer)
        {
            Dmanufacturer = devicemanufacturer;
        }

        public void setmodel(string devicemodel)
        {
            Dmodel = devicemodel;
        }

        public void setserialnum(string deviceserialnum)
        {
            Dserialnum = deviceserialnum;
        }

        public void setdate(string devicedate)
        {
            Ddate = devicedate;
        }

        public void setcomments(string devicecomments)
        {
            Dcomments = devicecomments;
        }

        public void setswitches(ArrayList compswitches)
        {
            compswitch = compswitches;
        }
    }
}
