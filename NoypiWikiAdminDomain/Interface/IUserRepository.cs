using System;
using NoypiWikiAdminDomain.Models;

namespace NoypiWikiAdminDomain.Interface;

public interface IUserEntityRepository
{
    Task Add(UserEntity user);
}
