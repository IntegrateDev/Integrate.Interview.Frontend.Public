namespace Integrate.Interview.Frontend.Mappers
{
    public interface IToDbMapper<in TApi, out TEntity>
    {
        TEntity Map(TApi apiPerson);
    }
}