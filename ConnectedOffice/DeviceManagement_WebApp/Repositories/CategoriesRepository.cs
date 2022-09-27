using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repositories
{
    public class CategoriesRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //GET: Categories
        public  List<Category> Getall()
        {
            return _context.Category.ToList();
        }

        /*// GET: Categories/Details/5
        public List<Category> Getall()
        {
            return _context.Category.ToList();
        }
        */
    }
}
