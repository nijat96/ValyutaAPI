using DataAccess.Entity;
using DTO.DTOEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IValyutaService 
        : IBaseService<ValyutaDTO, Valyuta, ValyutaDTO>
    {
    }
}
