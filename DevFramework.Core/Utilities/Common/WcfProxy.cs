using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceModel;

namespace DevFramework.Core.Utilities.Common
{
    public class WcfProxy<T>
    {
        public static T CreateChannel()
        {
            string baseAdress = ConfigurationManager.AppSettings["ServiceAdress"];
            string adress = string.Format(baseAdress, typeof(T).Name.Substring(1));

            var binding = new BasicHttpBinding();
            var channel = new ChannelFactory<T>(binding,adress);
            return channel.CreateChannel();
        }
    }
}
