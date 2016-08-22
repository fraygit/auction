using Auction.MongoData.Interface;
using Auction.MongoData.Model;
using Auction.MongoData.Service;

namespace Auction.MongoData.Repository
{
    public class CarRepository : EntityService<Car>, ICarRepository
    {
    }
}
