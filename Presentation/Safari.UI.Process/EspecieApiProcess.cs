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
    public partial class EspecieApiProcess : ProcessComponent
    {

        public List<Especie> ToList()
        {
            var result = default(List<Especie>);
            try
            {
                var response = HttpGet<ListarTodosEspecieResponse>("api/Especie/ListarTodos", new Dictionary<string, object>(), MediaType.Json);
                result = response.Result;
            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }
            return result;
        }



        public Especie Add(Especie especie)
        {
            Especie result = default(Especie);
            try
            {

            }
            catch (FaultException fex)
            {
                throw new ApplicationException(fex.Message);
            }

            return result;
        }


    }
}
