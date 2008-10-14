using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IVRDPServer : VBoxInterface
    {
        public IVRDPServer(string _this, VBoxService access) : base(_this, access)
        {
        }

        public bool enabled
        {
            set
            {
                try
                {
                    this.access.IVRDPServer_setEnabled(this._this, value);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }

            get
            {
                try
                {
                    return this.access.IVRDPServer_getEnabled(this._this);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }
        }

        public bool allowMultiConnection
        {
            set
            {
                try
                {
                    this.access.IVRDPServer_setAllowMultiConnection(this._this, value);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }

            get
            {
                try
                {
                    return this.access.IVRDPServer_getAllowMultiConnection(this._this);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }
        }

        public VRDPAuthType authType
        {
            set
            {
                try
                {
                    this.access.IVRDPServer_setAuthType(this._this, value);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }

            get
            {
                try
                {
                    return this.access.IVRDPServer_getAuthType(this._this);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }
        }

        public uint authTimeout
        {
            set
            {
                try
                {
                    this.access.IVRDPServer_setAuthTimeout(this._this, value);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }

            get
            {
                try
                {
                    return this.access.IVRDPServer_getAuthTimeout(this._this);
                }
                catch (SoapException ex)
                {
                    throw ex;
                }
            }

        }
    }
}