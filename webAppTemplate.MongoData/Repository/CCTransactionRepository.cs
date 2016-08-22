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
    public class CCTransactionRepository : EntityService<CCTransaction>, ICCTransactionRepository
    {
        public async Task<CCTransaction> GetBySessionId(string sessionId)
        {
            var builder = Builders<CCTransaction>.Filter;
            var filter = builder.Eq("SessionId", sessionId);
            var token = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (token != null)
            {
                if (token.Any())
                {
                    return token.FirstOrDefault();
                }
            }
            return null;
        }
    }
}
