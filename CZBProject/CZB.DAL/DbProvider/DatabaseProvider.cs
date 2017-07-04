using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.DAL
{
    public class DatabaseProvider
    {
        private DatabaseProvider()
        { }

        private static IDataProvider _instance = null;
        private static object lockHelper = new object();

        static DatabaseProvider()
        {
            GetProvider();
        }

        private static void GetProvider()
        {
            try
            {
                //string DbType = BaseConfigs.GetDbType;
                string DbType = "MySql";
                _instance = (IDataProvider)Activator.CreateInstance(Type.GetType(string.Format("Renrenyishu.Data.{0}.DataProvider, Renrenyishu.Data.{0}", DbType), false, true));
            }
            catch
            {
                throw new Exception("请检查Base.config中Dbtype节点数据库类型是否正确，例如：SqlServer、Access、MySql");
            }
        }

        public static IDataProvider GetInstance()
        {
            if (_instance == null)
            {
                lock (lockHelper)
                {
                    if (_instance == null)
                    {
                        GetProvider();
                    }
                }
            }
            return _instance;
        }

        public static void ResetDbProvider()
        {
            _instance = null;
        }
    }
}
