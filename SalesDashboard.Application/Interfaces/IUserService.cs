﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDashboard.Application.Interfaces
{
    public interface IUserService
    {
        Task<string> AuthenticateAsync(string username, string password);
    }
}
