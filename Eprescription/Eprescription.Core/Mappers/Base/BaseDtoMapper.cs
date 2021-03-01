using AutoMapper;
using System.Collections.Generic;

namespace Eprescription.Core
{
    public abstract class BaseDtoMapper<Entity, Dto>
    {
        private IMapper _mapper;

        public BaseDtoMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Entity, Dto>().ReverseMap();
            }).CreateMapper();
        }

        #region Maps
        public Dto Map(Entity entity)
    => _mapper.Map<Dto>(entity);

        public IEnumerable<Dto> Map(IEnumerable<Entity> entities)
            => _mapper.Map<IEnumerable<Dto>>(entities);

        public Entity Map(Dto entityDto)
            => _mapper.Map<Entity>(entityDto);

        public IEnumerable<Entity> Map(IEnumerable<Dto> entityDtos)
            => _mapper.Map<IEnumerable<Entity>>(entityDtos);


        #endregion

    }
}
