using System;

namespace Midnight
{
    public class AlertService
    {
        #region Description problem

        //Refactor the AlertService and AlertDAO classes:

        //Create a new interface, named IAlertDAO, that contains the same methods as AlertDAO.
        //AlertDAO should implement the IAlertDAO interface.
        //AlertService should have a constructor that accepts IAlertDAO.
        //The RaiseAlert and GetAlertTime methods should use the object passed through the constructor.

        #endregion

        private readonly IAlertDAO _storage;

        public AlertService(IAlertDAO storage)
        {
            _storage = storage;
        }

        public Guid RaiseAlert()
        {
            return this._storage.AddAlert(DateTime.Now);
        }

        public DateTime GetAlertTime(Guid id)
        {
            return this._storage.GetAlert(id);
        }
    }
}
