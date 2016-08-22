using Auction.MongoData.Model;
using Auction.MongoData.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.MongoData.Interface
{
    public interface IParkingRepository : IEntityService<Parking>
    {
        Task<List<Parking>> GetByUsername(string username);
        Task<List<Parking>> GetByParkingSpace(string parkingSpaceId);
    }
}
