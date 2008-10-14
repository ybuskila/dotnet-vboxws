using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IProgress : VBoxInterface
    {
        public IProgress(string _this, VBoxService access) : base(_this, access)
        {
        }

        public void waitForCompletion(int timeout)
        {
            try
            {
                access.IProgress_waitForCompletion(this._this, timeout);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public long getResultCode()
        {
            try
            {
                return access.IProgress_getResultCode(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
