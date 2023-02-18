using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaS4.entidades;

namespace TareaS4.negocio
{
    public class ClsNegocioCont
    {

      public int LetrasCont(EntidadCont entidad)
      {
        return entidad.Texto.Length;
      }          
    }
}