using ServiceHost.Application;

namespace ServiceHost.Repository
{
    public interface ICarRepository
    {
        void Add(Car car);
        void Delete(int id);
        IEnumerable<Car> Get();
        Car? GetById(int id);
        void Update(Car car);
    }
}
