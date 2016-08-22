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
    public class UserCreditCardRepository : EntityService<UserCreditCard>, IUserCreditCardRepository
    {
        public async Task<UserCreditCard> GetDefaultCard(string username)
        {
            var builder = Builders<UserCreditCard>.Filter;
            var filter = builder.Eq("Username", username);
            var userCreditCard = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            if (userCreditCard.Any(n => n.IsDefault == true))
                return userCreditCard.First(n => n.IsDefault == true);
            return null;
        }
    }
}
