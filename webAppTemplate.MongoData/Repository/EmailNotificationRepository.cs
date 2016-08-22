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
    public class EmailNotificationRepository : EntityService<EmailNotification>, IEmailNotificationRepository
    {
        public async Task<List<EmailNotification>> GetByStatus(int status)
        {
            var builder = Builders<EmailNotification>.Filter;
            var filter = builder.Eq("Status", status);
            var emailNotifications = await ConnectionHandler.MongoCollection.Find(filter).ToListAsync();
            return emailNotifications;
        }
    }
}
