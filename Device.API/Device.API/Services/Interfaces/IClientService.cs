using Device.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Device.API.Services.Interfaces
{
    public interface IClientService
    {
        IEnumerable<Client> GetClients();
        Client GetClientById(int id);
        void SaveClient(Client client);
        void DeleteClient(Client client);
    }
}
