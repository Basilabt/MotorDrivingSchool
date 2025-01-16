using DataAccessLayer.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer.Model
{
    public class clsCertificate
    {
        public int certificateID { get ; set; }
        public int courseID { get; set; }
        public DateTime issueDate { get; set; }




        public static DataTable getCertificates()
        {
            return clsCertificateDataAccess.getCertificates();
        }


    }
}
