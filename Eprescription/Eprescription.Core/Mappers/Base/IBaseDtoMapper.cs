using System;
using System.Collections.Generic;
using System.Text;

namespace Eprescription.Core
{
    public interface IBaseDtoMapper<Entity, Dto>
    {
        Entity Map(Dto entityDto);
        Dto Map(Entity entity);
        IEnumerable<Entity> Map(IEnumerable<Dto> entityDtos);
        IEnumerable<Dto> Map(IEnumerable<Entity> entities);
    }
}
