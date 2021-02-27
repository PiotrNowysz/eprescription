namespace Eprescription.Core
{
    public interface IBaseManager<Dto>
    {
        bool AddNew(Dto dto);
        bool Delete(Dto dto);
    }
}
