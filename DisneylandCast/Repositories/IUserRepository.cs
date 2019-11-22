using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DisneylandCast.Models;

namespace DisneylandCast.Repositories
{
    public interface IUserRepository
    {
        List<User> Users { get; }
    }
}
