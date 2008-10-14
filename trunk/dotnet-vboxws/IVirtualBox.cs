using System.Collections.Generic;
using System;
using System.Web.Services.Protocols;

namespace VBoxWebService
{
    public class IVirtualBox : VBoxInterface
    {
        public IVirtualBox(string _this, VBoxService acess) : base(_this, acess)
        {
        }

        public string getVersion()
        {
            try
            {
                return access.IVirtualBox_getVersion(this._this);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IMachine getMachine(Guid uuid)
        {
            try
            {
                string value = access.IVirtualBox_getMachine(this._this, uuid.ToString());
                return new IMachine(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }


        public IMachine findMachine(string name)
        {
            try
            {
                string value = this.access.IVirtualBox_findMachine(this._this, name);
                return new IMachine(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public List<IMachine> getMachines2()
        {
            try
            {
                List<IMachine> iMachines;
                string[] machines;

                iMachines = new List<IMachine>();
                machines = access.IVirtualBox_getMachines2(this._this);

                foreach (string machine in machines)
                {
                    iMachines.Add(new IMachine(machine, this.access));
                }

                return iMachines;
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public IProgress openRemoteSession(ISession session, Guid machineId, string type, string environment)
        {
            try
            {
                string value = access.IVirtualBox_openRemoteSession(this._this, session.getReference(), machineId.ToString(), type, environment);
                return new IProgress(value, this.access);
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void openExistingSession(ISession session, Guid machineId)
        {
            try
            {
                access.IVirtualBox_openExistingSession(this._this, session.getReference(), machineId.ToString());
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }

        public void openSession(ISession session, Guid machineId)
        {
            try
            {
                access.IVirtualBox_openSession(this._this, session.getReference(), machineId.ToString());
            }
            catch (SoapException ex)
            {
                throw ex;
            }
        }
    }
}
