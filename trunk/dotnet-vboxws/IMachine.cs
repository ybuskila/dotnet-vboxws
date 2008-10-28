using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IMachine : VBoxInterface
    {
        public IMachine(string _this, VBoxService access) : base(_this, access)
        {
        }

        public string getName()
        {
            try
            {
                return access.IMachine_getName(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public Guid getId()
        {
            try
            {
                string value = access.IMachine_getId(this._this);
                return new Guid(value);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public MachineState getState()
        {
            try
            {
                return this.access.IMachine_getState(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IVRDPServer getVRDPServer()
        {
            try
            {

                string value = this.access.IMachine_getVRDPServer(this._this);
                return new IVRDPServer(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
