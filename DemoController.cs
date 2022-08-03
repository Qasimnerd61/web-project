using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DemoController : ApiController
    {
        public class Emp
        {
            public string EMPNo { get; set; }
            public string EmpName { get; set; }
            public List<Emp> GetEmpList()

            {

                List<Emp> lstEmp = new List<Emp>();

                Emp objEmp = new Emp();

                objEmp.EMPNo = "23";

                objEmp.EmpName = "DEVESH OMAR";

                lstEmp.Add(objEmp);

                objEmp = new Emp();

                objEmp.EMPNo = "46";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);
                objEmp = new Emp();

                objEmp.EMPNo = "46";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);
                objEmp = new Emp();

                objEmp.EMPNo = "47";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);
                objEmp = new Emp();

                objEmp.EMPNo = "48";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);
                objEmp = new Emp();

                objEmp.EMPNo = "49";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);
                objEmp = new Emp();

                objEmp.EMPNo = "46";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);


                objEmp = new Emp();

                objEmp.EMPNo = "46";

                objEmp.EmpName = "NIKHIL VATS";

                lstEmp.Add(objEmp);



                objEmp = new Emp();

                objEmp.EMPNo = "37";

                objEmp.EmpName = "KUMAR GAURAV";

                lstEmp.Add(objEmp);



                objEmp = new Emp();

                objEmp.EMPNo = "36";

                objEmp.EmpName = "RAM PRAKSSH";

                lstEmp.Add(objEmp);



                objEmp = new Emp();

                objEmp.EMPNo = "56";

                objEmp.EmpName = "VISHAL";

                lstEmp.Add(objEmp);



                objEmp = new Emp();

                objEmp.EMPNo = "40";

                objEmp.EmpName = "POOJA";

                lstEmp.Add(objEmp);

                return lstEmp;

            }
        }
        public List<Emp> Get()
        {
            Emp emp = new Emp();
            return (emp.GetEmpList());
        }
        [Route("GetEmployees")]
        public List<Emp> GetAll()
        {
            Emp emp = new Emp();
            return (emp.GetEmpList());
        }
    }
}
