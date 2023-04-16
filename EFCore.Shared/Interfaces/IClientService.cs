using EFCore.Model;

namespace EFCore.Shared.Interfaces;
public interface IClientService
{
    Client? Add(Client client);
    void Delete(Func<Client, bool> filter, bool loadRalatedData = false);
    void Edit(int clientIdToChange, string clientFirstName, string clientLastName, string clientEmail, string clientPhone);
    int LoadOrders(Client client);
    Client? GetClientByEmail(string email);
    Client? GetClientByPhoneNumber(string phone);
    Client? GetClientById(int id);
    List<Client> GetClientsByLastName(string lastName);
    bool IsEmailInUse(string email);
}