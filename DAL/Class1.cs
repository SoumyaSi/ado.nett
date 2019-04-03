using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Class1
    {
    }
    public class ClsDataLayer
    {
        SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K; database=GIC;integrated security=true;");
        public void insertdata(string addressid, string firstname, string lastname, string email, string phonenumber)
        {
            SqlDataAdapter da = new SqlDataAdapter("select *  from employeedetails", con);
            SqlCommandBuilder cdm = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow dr = ds.Tables[0].NewRow();
            dr[0] = addressid;
            dr[1] = firstname;
            dr[2] = lastname;
            dr[3] = email;
            dr[4] = phonenumber;
            ds.Tables[0].Rows.Add(dr);
            da.Update(ds);






        }
        public object selectdata()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from employeedetails", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public void updatedata(string addressid, string firstname, string lastname, string email, string phonenumber)
        {
            SqlDataAdapter da = new SqlDataAdapter("select *  from employeedetails", con);
            SqlCommandBuilder cdm = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            DataSet ds = new DataSet();
            da.Fill(ds);
            DataRow dr = ds.Tables[0].Rows.Find(addressid);
            dr[0] = addressid;
            dr[1] = firstname;
            dr[2] = lastname;
            dr[3] = email;
            dr[4] = phonenumber;
           // ds.Tables[0].Rows.Add(dr);
            da.Update(ds);
        }
        public void deletedata(string addressid)
        {
            SqlDataAdapter da = new SqlDataAdapter("select *  from employeedetails", con);
            SqlCommandBuilder cdm = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            DataSet ds = new DataSet();
            da.Fill(ds);
           ds.Tables[0].Rows.Find(addressid).Delete();
          
            // ds.Tables[0].Rows.Add(dr);
            da.Update(ds);
        }
    }
}
