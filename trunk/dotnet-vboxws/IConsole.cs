using System.Collections.Generic;
using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IConsole : VBoxInterface
    {
        public IConsole(string _this, VBoxService access) : base(_this,access)
        {
        }

        public void pause()
        {
            try
            {
                this.access.IConsole_pause(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void resume()
        {
            try
            {
                this.access.IConsole_resume(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void powerDown()
        {
            try
            {
                this.access.IConsole_powerDown(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IProgress powerUp()
        {
            try
            {
                string value = this.access.IConsole_powerUp(this._this);
                return new IProgress(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IKeyboard getKeyboard()
        {
            try
            {
                string value = this.access.IConsole_getKeyboard(this._this);
                return new IKeyboard(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
