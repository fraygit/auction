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
    public class ParkingRepository : EntityService<Parking>, IParkingRepository
    {
        public async Task<List<Parking>> GetByUsername(string username)
        {
            var builder = Builders<Parking>.Filter;
            var filter = builder.Eq("username", username);
            var transactions = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            return transactions;
        }

        public async Task<List<Parking>> GetByParkingSpace(string parkingSpaceId)
        {
            var builder = Builders<Parking>.Filter;
            var filter = builder.Eq("ParkingSpaceId", parkingSpaceId);
            var transactions = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            return transactions;
        }
    }
}
