using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IWebSessionManager : VBoxInterface
    {
        public IWebSessionManager(VBoxService access) : base("", access)
        {
        }

        public ISession getSessionObject(IVirtualBox virtualBox)
        {
            try
            {
                string value = this.access.IWebsessionManager_getSessionObject(virtualBox.getReference());
                return new ISession(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void logOff(IVirtualBox virtualBox)
        {
            try
            {
                access.IWebsessionManager_logoff(virtualBox.getReference());
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
