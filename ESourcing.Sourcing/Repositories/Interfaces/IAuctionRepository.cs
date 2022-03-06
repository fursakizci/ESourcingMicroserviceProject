using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ESourcing.Sourcing.Entities;

namespace ESourcing.Sourcing.Repositories.Interfaces
{
    public interface IAuctionRepository
    {
        Task<IEnumerable<Auction>> GetAuctions();

        Task<Auction> GetAuction(string Id);

        Task<Auction> GetAuctionByName(string name);

        Task Create(Auction auction);

        Task<bool> Update(Auction auction);

        Task<bool> Delete(string id);

    }
}