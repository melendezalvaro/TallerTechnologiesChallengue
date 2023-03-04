using ServiceHost.Application;

namespace ServiceHost.Repository
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            try
            {
                DataBase.Cars().Add(car);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(int id)
        {
            Car? car = DataBase.Cars().Find(x => x.Id == id);
            if (car != null)
                DataBase.Cars().Remove(car);
        }

        public IEnumerable<Car> Get()
        {
            return DataBase.Cars();
        }

        public Car? GetById(int id)
        {
            return DataBase.Cars().Find(x => x.Id == id);
        }

        public void Update(Car car)
        {
            if (car != null)
            {
                DataBase.Cars().Remove(car);
                DataBase.Cars().Add(car);
            }
        }
    }
}
