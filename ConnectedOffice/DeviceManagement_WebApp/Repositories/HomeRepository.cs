﻿using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repositories
{
    public class HomeRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();
    }
}
