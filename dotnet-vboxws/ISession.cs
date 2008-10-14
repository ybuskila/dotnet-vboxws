using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class ISession : VBoxInterface
    {
        public ISession(string _this, VBoxService access) : base(_this, access)
        {
        }

        public IConsole getConsole()
        {
            try
            {
                string value = this.access.ISession_getConsole(this._this);
                return new IConsole(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IMachine getMachine()
        {
            try
            {
                string value = this.access.ISession_getMachine(this._this);
                return new IMachine(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
