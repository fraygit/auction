using Auction.MongoData.Model;
using Auction.MongoData.Service;
using System.Threading.Tasks;

namespace Auction.MongoData.Interface
{
    public interface IUserRepository : IEntityService<User>
    {
        Task<User> GetUser(string username);
    }
}
