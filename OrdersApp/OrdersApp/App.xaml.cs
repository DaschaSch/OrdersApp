using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using OrdersApp.Views;
using System.IO;
using System.Reflection;

namespace OrdersApp
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "OrderAppDB.db";
        public static Database database;

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    // путь, по которому будет находиться база данных
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME);
                    //string dbPath = "C:/Users/dshishko/Desktop/ITMO/OrdersApp/OrdersApp/OrdersApp" + DATABASE_NAME;
                    // если база данных не существует (еще не скопирована)
                    if (!File.Exists(dbPath))
                    {
                        // получаем текущую сборку
                        var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                        // берем из нее ресурс базы данных и создаем из него поток
                        using (Stream stream = assembly.GetManifestResourceStream($"SQLiteApp.{DATABASE_NAME}"))
                        {
                            using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                            {
                                stream.CopyTo(fs);  // копируем файл базы данных 
                                fs.Flush();
                            }
                        }
                    }
                    database = new Database(dbPath);
                }
                return database;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
