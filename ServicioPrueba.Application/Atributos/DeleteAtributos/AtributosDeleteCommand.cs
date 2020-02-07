using MediatR;
using ServicioPrueba.Application.Atributos.GetAtributos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicioPrueba.Application.Atributos.AddAtributos
{
    public class AtributosDeleteCommand : IRequest<bool>
    {
        public int AtributoId { get; }
        public AtributosDeleteCommand(int id)
        {
            this.AtributoId = id;
        }
    }
}
