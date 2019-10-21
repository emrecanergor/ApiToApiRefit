using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebRefit.Refit
{
    public interface IGitHubApi
    {
        [Get("/users/{user}")]
        Task GetUser(string user);
    }
}
