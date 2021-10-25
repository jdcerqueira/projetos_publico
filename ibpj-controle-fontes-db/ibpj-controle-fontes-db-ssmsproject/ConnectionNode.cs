using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibpj_controle_fontes_db_ssmsproject
{
    public class ConnectionNode
    {
        [System.Xml.Serialization.XmlAttribute]
        public string Name;

        public DateTime Created;
        public string Type;
        public string Server;
        public string UserName;
        public string Authentication;
        public string InitialDB;
        public int LoginTimeout;
        public int ExecutionTimeout;
        public string ConnectionProtocol;
        public string ApplicationName;


        public static ConnectionNode[] connectionNodesDefaultOfpjd000()
        {
            DateTime Created = DateTime.Now;
            string Type = "SQL";
            string Authentication = "Windows Authentication";
            int LoginTimeout = 30;
            int ExecutionTimeout = 0;
            string ConnectionProtocol = "NotSpecified";
            string ApplicationName = "Microsoft SQL Server Management Studio - Query";

            ConnectionNode[] connectionNodes = new ConnectionNode[]
            {
                new ConnectionNode()
                {
                    Name = "sala_limpa_A",
                    Created = Created,
                    Type = Type,
                    Server = @"LABS178\HM1120A",
                    UserName = "",
                    Authentication = Authentication,
                    InitialDB = "OFPJD000",
                    LoginTimeout = LoginTimeout,
                    ExecutionTimeout = ExecutionTimeout,
                    ConnectionProtocol = ConnectionProtocol,
                    ApplicationName = ApplicationName
                }
            };

            return connectionNodes;
        }

        public static ConnectionNode[] connectionNodesDefaultOfpjd001()
        {
            DateTime Created = DateTime.Now;
            string Type = "SQL";
            string Authentication = "Windows Authentication";
            int LoginTimeout = 30;
            int ExecutionTimeout = 0;
            string ConnectionProtocol = "NotSpecified";
            string ApplicationName = "Microsoft SQL Server Management Studio - Query";

            ConnectionNode[] connectionNodes = new ConnectionNode[]
            {
                new ConnectionNode()
                {
                    Name = "sala_limpa_B",
                    Created = Created,
                    Type = Type,
                    Server = @"LABS178\HM1120B",
                    UserName = "",
                    Authentication = Authentication,
                    InitialDB = "OFPJD001",
                    LoginTimeout = LoginTimeout,
                    ExecutionTimeout = ExecutionTimeout,
                    ConnectionProtocol = ConnectionProtocol,
                    ApplicationName = ApplicationName
                }
            };

            return connectionNodes;
        }
    }
}
