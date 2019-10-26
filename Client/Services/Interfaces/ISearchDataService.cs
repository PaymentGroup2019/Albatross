using Albatross.Shared;
using System.Threading.Tasks;

namespace Albatross.Client.Services.Interfaces
{
    public interface ISearchDataService
    {
        Task<SearchData> GetSearchDataAsync();
    }
}
