using Four.DAL;
using System;

namespace Four.Controllers
{
    internal class AddDbContext
    {
        public object Faqs { get; internal set; }

        public static implicit operator AddDbContext(AppDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}