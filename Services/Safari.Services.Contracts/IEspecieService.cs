using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using Safari.Entities;

namespace Safari.Services.Contracts
{
   
    [ServiceContract]
    public interface IEspecieService
    {
        [OperationContract]
        Especie Agregar(Especie especie);

        [OperationContract]
        List<Especie> ListarTodos();
    }
}
