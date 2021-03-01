using AutoMapper;
using System.Collections.Generic;

namespace Eprescription
{
    public abstract class BaseViewModelMapper<Dto, Model>
    {
        private IMapper _mapper;

        public BaseViewModelMapper()
        {
            _mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Dto, Model>().ReverseMap();
            }).CreateMapper();
        }

        #region Maps
        public Model Map(Dto dto)
    => _mapper.Map<Model>(dto);

        public IEnumerable<Model> Map(IEnumerable<Dto> dtos)
            => _mapper.Map<IEnumerable<Model>>(dtos);

        public Dto Map(Model model)
            => _mapper.Map<Dto>(model);

        public IEnumerable<Dto> Map(IEnumerable<Model> models)
            => _mapper.Map<IEnumerable<Dto>>(models);


        #endregion

    }
}
