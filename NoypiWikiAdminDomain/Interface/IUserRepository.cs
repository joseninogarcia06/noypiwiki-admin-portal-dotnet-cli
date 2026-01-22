using System;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminDomain.Interface;

public interface IUserRepository
{
    Task Add(User user);
}
