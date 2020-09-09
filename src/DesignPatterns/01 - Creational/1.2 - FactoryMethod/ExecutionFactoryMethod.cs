using System;

namespace DesignPatterns.FactoryMethod
{
    class ExecutionFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(DataBase.SqlServer)
                                 .CreateConnector("myCS")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from sqlTable");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(DataBase.Oracle)
                                    .CreateConnector("myCS")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from oracleTable");
            oracleCn.Close();
        }
    }
}
