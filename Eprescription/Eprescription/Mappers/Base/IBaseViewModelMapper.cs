using System.Collections.Generic;

namespace Eprescription
{
    public interface IBaseViewModelMapper<Dto, Model>
    {
        Dto Map(Model model);
        Model Map(Dto dto);
        IEnumerable<Dto> Map(IEnumerable<Model> models);
        IEnumerable<Model> Map(IEnumerable<Dto> dtos);
    }
}
