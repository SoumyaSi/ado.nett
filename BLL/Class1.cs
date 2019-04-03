using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Class1
    {
    }
    public class CLSBussLayer
    {
        ClsDataLayer objDAL = new ClsDataLayer();
        public void InsertDetails(string addressid, string firstname, string lastname,string email,string phonenumber)
        {
            objDAL.insertdata(addressid,firstname,lastname,email,phonenumber);
        }
        public object SelectDetails()
        {
            return objDAL.selectdata();
        }
        public void UpdateDetails(string addressid, string firstname, string lastname, string email, string phonenumber)
        {
            objDAL.updatedata(addressid,firstname,lastname,email,phonenumber);
        }
        public void DeleteDetails(string addressid)
        {
            objDAL.deletedata(addressid);
        }
    }
}
