using MongoDB.Bson;

namespace Auction.MongoData.Entities.Base
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
