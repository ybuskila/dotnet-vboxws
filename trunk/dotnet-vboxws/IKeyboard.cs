using System;
using System.Web.Services.Protocols;
using System.Collections.Generic;

namespace VBoxWebService
{
    public class IKeyboard : VBoxInterface
    {
        public IKeyboard(string _this, VBoxService access) : base(_this, access)
        {
        }

        public void putScancode(int scancode)
        {
            try
            {
                this.access.IKeyboard_putScancode(this._this, scancode);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public long putScancodes(List<int> scancodes)
        {
            try
            {
                long value = this.access.IKeyboard_putScancodes(this._this, scancodes.ToArray());
                return value;
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
        
        public void putCAD()
        {
            try
            {
                this.access.IKeyboard_putCAD(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
