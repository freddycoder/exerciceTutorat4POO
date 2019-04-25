using Application.Data;

namespace Application
{
	public class CreateItem : ICommand<Item>
	{
        private readonly ApplicationDbContext _context;

        public CreateItem(ApplicationDbContext context)
        {
            _context = context;
        }

		public Item Model { get; set; }

		public void Execute()
		{
            _context.Add(Model);
            _context.SaveChanges();
		}
	}
}