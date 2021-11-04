using System.Collections.Generic;
using System.Threading.Tasks;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Services
{
    public interface IAdultService
    {
        Task<IList<Adult>> GetAdults();
        Task<ActionResult<Adult>> GetAdult(int id);
        Task<ActionResult<Adult>> AddAdult(Adult adult);
        Task DeleteAdult(int id);
        Task<ActionResult<Adult>> UpdateAdult(Adult adult);
    }
}