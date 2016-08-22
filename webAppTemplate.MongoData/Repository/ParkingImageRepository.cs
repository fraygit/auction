using MongoDB.Driver;
using Auction.MongoData.Interface;
using Auction.MongoData.Model;
using Auction.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.MongoData.Repository
{
    public class ParkingImageRepository : EntityService<ParkingImage>, IParkingImageRepository
    {
        public async Task<ParkingImage> GetByParkingSpace(string parkingSpaceId)
        {
            var builder = Builders<ParkingImage>.Filter;
            var filter = builder.Eq("ParkingSpaceId", parkingSpaceId);
            var images = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (images.Any())
                return images.FirstOrDefault();
            return null;
        }
    }
}
