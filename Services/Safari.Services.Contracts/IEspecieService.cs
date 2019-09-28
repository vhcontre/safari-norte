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
        Especie Add(Especie especie);
        [OperationContract]
        List<Especie> ToList();
        [OperationContract]
        Especie Find(int? id);
        [OperationContract]
        void Edit(Especie especie);
        [OperationContract]
        void Remove(Especie especie);

    }
}
