namespace ImageUploadToDB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=BakeryConnection")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
      
    }
}
