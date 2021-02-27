using Eprescription.Database;

namespace Eprescription.Core
{
    public class BaseManager<Entity, Dto> where Entity : BaseEntity
    {
        private IBaseDtoMapper<Entity, Dto> _mapper;
        private IBaseRepository<Entity> _repository;

        public BaseManager(IBaseDtoMapper<Entity, Dto> mapper,
          IBaseRepository<Entity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public bool AddNew(Dto dto)
        {
            var entity = _mapper.Map(dto);
            return _repository.AddNew(entity);
        }

        public bool Delete(Dto dto)
        {
            var entity = _mapper.Map(dto);
            return _repository.Delete(entity);
        }
    }
}
