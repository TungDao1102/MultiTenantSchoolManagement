using Finbuckle.MultiTenant.Abstractions;

namespace MTSM.Infrastructure.Tenancy
{
    public class SchoolTenantInfo : ITenantInfo
    {
        public string? Id { get; set; }
        public string? Identifier { get; set; }
        public string? Name { get; set; }

        // custom properties
        public string ConnectionString { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime ValidTo { get; set; }
        public bool IsActive { get; set; }
    }
}
