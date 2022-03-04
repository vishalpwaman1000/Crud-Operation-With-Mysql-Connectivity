using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudOperation_MysqlDB.Common_Utility
{
    public class SqlQueries
    {
        public static IConfiguration _sqlQueryConfiguration = new ConfigurationBuilder()
            .AddXmlFile("SqlQueries.xml", true, true)
            .Build();

        public static string RegisterUser { get { return _sqlQueryConfiguration["RegisterUser"]; } }
        public static string UserLogin { get { return _sqlQueryConfiguration["UserLogin"]; } }
        public static string AddInformation { get { return _sqlQueryConfiguration["AddInformation"]; } }
        public static string ReadInformation { get { return _sqlQueryConfiguration["ReadInformation"]; } }
        public static string ReadInformationById { get { return _sqlQueryConfiguration["ReadInformationById"]; } }
        public static string UpdateAllInformationById { get { return _sqlQueryConfiguration["UpdateAllInformationById"]; } }
        public static string UpdateOneInformationById { get { return _sqlQueryConfiguration["UpdateOneInformationById"]; } }
        public static string DeleteInformationByID { get { return _sqlQueryConfiguration["DeleteInformationByID"]; } }
        public static string GetAllDeleteInformation { get { return _sqlQueryConfiguration["GetAllDeleteInformation"]; } }
        public static string DeleteAllInformation { get { return _sqlQueryConfiguration["DeleteAllInformation"]; } }
    }
}
