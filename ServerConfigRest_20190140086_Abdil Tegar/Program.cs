using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ServiceRest_20190140086_Abdil_Tegar_Arifin;

namespace ServerConfigRest_20190140086_Abdil_Tegar
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;

            try
            {
                hostObjek = new ServiceHost(typeof(TI_UMY));
                hostObjek.Open();
                Console.WriteLine("Server is ready ...");
                Console.ReadLine();
                hostObjek.Close();
            }
            catch (Exception e)
            {
                hostObjek = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
