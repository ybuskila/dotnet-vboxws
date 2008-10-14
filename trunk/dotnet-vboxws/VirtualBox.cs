using System;
using System.Net;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class VirtualBox
    {
        public static IVirtualBox connect(Uri url)
        {
            try
            {
                return connect(url, "", "");
            }
            catch (SoapException ex)
            {
                throw ex;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        public static IVirtualBox connect(Uri url, string username, string password)
        {
            try
            {
                VBoxService access = new VBoxService(url);
                String vbox = access.IWebsessionManager_logon(username, password);

                return new IVirtualBox(vbox, access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }
    }
}
