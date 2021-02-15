using Eprescription.Database;

namespace Eprescription.Core
{

    public abstract class BaseManager<Entity, Dto> : IBaseManager<Dto> where Entity : BaseEntity
    {
        private readonly IRepository<Entity> _repository;
        private readonly IBaseDtoMapper<Entity, Dto> _baseMapper;
        public BaseManager(IRepository<Entity> repository, IBaseDtoMapper<Entity, Dto> baseMapper)
        {
            _repository = repository;
            _baseMapper = baseMapper;
        }

        public bool AddNew(Dto dto)
        {
            var entity = _baseMapper.Map(dto);
            return _repository.AddNew(entity);
        }

        public bool Delete(Dto dto)
        {
            var entity = _baseMapper.Map(dto);
            return _repository.Delete(entity);
        }

    }
}

