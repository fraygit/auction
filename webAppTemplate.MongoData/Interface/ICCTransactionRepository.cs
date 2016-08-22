using Auction.MongoData.Model;
using Auction.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.MongoData.Interface
{
    public interface ICCTransactionRepository : IEntityService<CCTransaction>
    {
        Task<CCTransaction> GetBySessionId(string sessionId);
    }
}
