using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repositories
{
    public class CategoriesRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        //GET: Categories
        public List<Category> Getall()
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
