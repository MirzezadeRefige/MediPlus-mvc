using Mediplus_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Mediplus_DAL.Contexts
{
    public class MediplusDbContext : DbContext
    {

        public DbSet<SliderItem> SliderItems { get; set; }

		public MediplusDbContext(DbContextOptions<MediplusDbContext> options) : base(options)
		{
		}


	}
}
