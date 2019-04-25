using Application.Data;
using System.Collections.Generic;
using System.Linq;

namespace Application
{
    public class GetAllItem : IRequest<IEnumerable<Item>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllItem(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Execute()
        {
            return _context.Items.ToList();
        }
    }
}
