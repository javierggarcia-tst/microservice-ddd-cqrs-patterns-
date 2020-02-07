using MediatR;
using ServicioPrueba.Application.Atributos.GetAtributos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicioPrueba.Application.Atributos.AddAtributos
{
    public class AtributosAddCommand : IRequest<AtributoDto>
    {
        public int AtributoId { get; }

        public string Descripcion { get;  }

        public AtributosAddCommand(int id, string descripcion)
        {
            this.AtributoId = id;
            this.Descripcion = descripcion;
        }
    }
}
