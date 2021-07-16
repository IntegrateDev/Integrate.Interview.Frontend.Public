namespace Integrate.Interview.Api.Mappers
{
    public interface IToDbMapper<in TApi, out TEntity>
    {
        TEntity Map(TApi apiPerson);
    }
}