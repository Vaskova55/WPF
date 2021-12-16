using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;
using Vaskova_433.Classes.Entityes;

namespace Vaskova_433
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]


    public class EfModel : DbContext
    {
        private static EfModel instance;
        public static EfModel init()
        {
            if (instance == null)
            {
                instance = new EfModel();
            }
            return instance;
        }
        // Your context has been configured to use a 'EfModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Vaskova_433.EfModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EfModel' 
        // connection string in the application configuration file.
        public EfModel()
            : base("server = cfif31.ru; database=ISPr21-33_VaskovaAN_TestWPF;" +
                  "user id=ISPr21-33_VaskovaAN;port=3306;characterset=utf8;password=KimBTSAlena5")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<UsersClass> Users { get; set; }
    }
}