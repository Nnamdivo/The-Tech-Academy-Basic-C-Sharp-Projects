// T4 code generation is enabled for model 'C:\Users\nnamdi\CarInsurance\CarInsurance\Models\InsuranceEntities.edmx'. 
// To enable legacy code generation, change the value of the 'Code Generation Strategy' designer
// property to 'Legacy ObjectContext'.  This property is available in the Properties Window when the model
// is open in the designer.

// If no context and entity classes have been generated, it may be because you created an empty model but
// have not yet chosen which version of Entity Framework to use. To generate a context class and entity
// classes for your model, open the model in the designer, right-click on the designer surface, and
// select 'Update Model from Database...', 'Generate Database from Model...', or 'Add Code Generation
// Item...'.

namespace CarInsurance.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class InsuranceEntities : DbContext
    {
        public InsuranceEntities()
            : base("name=InsuranceEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Insuree> Insurees { get; set; }
    }
}

