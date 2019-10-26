using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Safari.Entities;


namespace Safari.Services.Contracts
{
   
    [DataContract]
    public partial class ListarTodosEspecieResponse
    {
        [DataMember]
        public List<Especie> Result { get; set; }
    }
}

