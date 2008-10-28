using System;
using System.Web.Services.Protocols;

// Next -> getId

namespace VBoxWebService
{
    public class IProgress : VBoxInterface
    {
        public IProgress(string _this, VBoxService access) : base(_this, access)
        {
        }

        public void cancel()
        {
            try
            {
                this.access.IProgress_cancel(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void waitForCompletion(int timeout)
        {
            try
            {
                this.access.IProgress_waitForCompletion(this._this, timeout);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public string description()
        {
            try
            {
                return this.access.IProgress_getDescription(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public bool completed()
        {
            try
            {
                return this.access.IProgress_getCompleted(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public bool canceled()
        {
            try
            {
                return this.access.IProgress_getCanceled(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public bool cancelable()
        {
            try
            {
                return this.access.IProgress_getCancelable(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public long resultCode()
        {
            try
            {
                return this.access.IProgress_getResultCode(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
