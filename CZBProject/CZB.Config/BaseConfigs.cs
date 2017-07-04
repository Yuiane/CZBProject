using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CZB.Config
{
    public class BaseConfigs
    {
        // private static System.Timers.Timer baseConfigTimer = new System.Timers.Timer(60000);

        private static BaseConfigInfo m_configinfo;

        /// <summary>
        /// 静态构造函数初始化相应实例和定时器
        /// </summary>
        static BaseConfigs()
        {
            m_configinfo = BaseConfigFileManager.LoadConfig();
            /*
            baseConfigTimer.AutoReset = true;
            baseConfigTimer.Enabled = true;
            baseConfigTimer.Elapsed += new System.Timers.ElapsedEventHandler(Timer_Elapsed);
            baseConfigTimer.Start();*/
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            ResetConfig();
        }


        /// <summary>
        /// 重设配置类实例
        /// </summary>
        public static void ResetConfig()
        {
            m_configinfo = BaseConfigFileManager.LoadConfig();
        }


        /// <summary>
        /// 重设配置类实例
        /// </summary>
        public static void ResetRealConfig()
        {
            m_configinfo = BaseConfigFileManager.LoadRealConfig();
        }

        public static BaseConfigInfo GetBaseConfig()
        {
            return m_configinfo;
        }

        /// <summary>
        /// 返回数据库连接串
        /// </summary>
        public static string GetDBConnectString
        {
            get
            {
                BaseConfigInfo config = GetBaseConfig();
                if (config != null)
                    return GetBaseConfig().Dbconnectstring;
                else
                {
                    HttpContext context = HttpContext.Current;
                    if (context == null)
                    {
                        return ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
                    }
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// 返回表前缀
        /// </summary>
        public static string GetTablePrefix
        {
            get
            {
                BaseConfigInfo config = GetBaseConfig();
                if (config != null)
                    return GetBaseConfig().Tableprefix;
                else
                    return "CZB";

            }
        }


        /// <summary>
        /// 返回数据库类型
        /// </summary>
        public static string GetDbType
        {
            get
            {
                BaseConfigInfo config = GetBaseConfig();
                if (config != null)
                    return GetBaseConfig().Dbtype;
                else
                    return "SqlServer";
            }
        }


        /// <summary>
        /// 保存配置实例
        /// </summary>
        /// <param name="baseconfiginfo"></param>
        /// <returns></returns>
        public static bool SaveConfig(BaseConfigInfo baseconfiginfo)
        {
            BaseConfigFileManager acfm = new BaseConfigFileManager();
            BaseConfigFileManager.ConfigInfo = baseconfiginfo;
            return acfm.SaveConfig();
        }
    }
}
