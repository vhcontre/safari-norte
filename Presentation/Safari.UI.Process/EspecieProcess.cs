using Safari.Entities;
using Safari.Framework.Common;
using Safari.Services;
using Safari.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;

namespace Safari.UI.Process
{    
    public partial class EspecieProcess : ProcessComponent
    {
        private IEspecieService _especieService;

        public EspecieProcess()
        {
            _especieService = ServiceFactory.Get<IEspecieService>(); ;
        }
        public List<Especie> ListarTodos()
        {
            List<Especie> result = default(List<Especie>);            
            var proxy = _especieService;
            try
            {
                result = proxy.ListarTodos();
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }            
            return result;
        }
        
        public Especie Agregar(Especie especie)
        {
            Especie result = default(Especie);
            var proxy = ServiceFactory.Get<IEspecieService>();

            try
            {
                result = proxy.Agregar(especie);
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            
            return result;
        }
    }
}
