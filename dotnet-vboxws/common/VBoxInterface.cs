using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class VBoxInterface
    {
        protected VBoxService access;
        protected string _this;

        public VBoxInterface(string _this, VBoxService access)
        {
            this._this = _this;
            this.access = access;
        }

        public VBoxService getWsAcces()
        {
            return access;
        }

        public void releaseRemote()
        {
            try
            {
                access.IManagedObjectRef_release(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public string getReference()
        {
            return this._this;
        }
    }
}
