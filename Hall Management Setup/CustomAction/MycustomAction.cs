using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Xml.Linq;

namespace CustomAction
{
    [RunInstaller(true)]
    public class MycustomAction : Installer
    {
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Install(IDictionary savedState)
        {
            //System.Diagnostics.Debugger.Launch();
            base.Install(savedState);

            string installationPath = this.Context.Parameters["targetdir"];
            string databaseServerTitle = Context.Parameters["DBServerTitle"];
            string databaseServerAddress = Context.Parameters["DBServerAddress"];
            string dbName = Context.Parameters["DBName"];
            string userName = Context.Parameters["UserName"];
            string password = Context.Parameters["Password"];

            XDocument doc =
                         new XDocument(
                           new XElement("DataBaseServers",
                             new XElement("DataBaseServer", new XAttribute("id", "1"), new XAttribute("title", databaseServerTitle), new XAttribute("address", databaseServerAddress)),
                             new XElement("DataBases",
                                 new XElement("Database", new XAttribute("id", "1"), new XAttribute("name", dbName), new XAttribute("userid", userName), new XAttribute("password", password))
                             )));
            
            var currentDirectory = Path.Combine(installationPath, "DataSource");
            bool IsExists = System.IO.Directory.Exists(currentDirectory);
            if (!IsExists) System.IO.Directory.CreateDirectory(currentDirectory);

            var fileName = Path.Combine(currentDirectory, "DatabaseServers.xml");
            doc.Save(fileName); 

        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);            
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
        }
    }
}
