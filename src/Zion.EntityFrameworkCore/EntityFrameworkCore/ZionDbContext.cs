using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using Zion.Rooms;
using Zion.SchoolYears;
using Zion.Sections;
using Zion.Students;
using Zion.Subjects;
using Zion.Teachers;


namespace Zion.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class ZionDbContext :
    AbpDbContext<ZionDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    // Students
    public virtual DbSet<Student> Students { get; set; }

    // School Years
    public virtual DbSet<SchoolYear> SchoolYears { get; set; }

    // Rooms
    public virtual DbSet<Room> Rooms { get; set; }

    // Sections
    public virtual DbSet<Section> Sections { get; set; }

    // Teachers

    public virtual DbSet<Teacher> Teachers { get; set; }

    // Subjects
    public virtual DbSet<Subject> Subjects { get; set; }

    #endregion

    public ZionDbContext(DbContextOptions<ZionDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();


        ConfigureStudents(builder);

        ConfigureSchoolYears(builder);
        ConfigureRooms(builder);
        ConfigureSections(builder);
        ConfigureTeachers(builder);
        ConfigureSubjects(builder);

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(ZionConsts.DbTablePrefix + "YourEntities", ZionConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }

    private void ConfigureStudents(ModelBuilder builder)
    {
        builder.Entity<Student>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "Students", ZionConsts.DbSchema);
            b.ConfigureByConvention(); ;
        });
    }

    private void ConfigureSchoolYears(ModelBuilder builder)
    {
        builder.Entity<SchoolYear>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "SchoolYears", ZionConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }

    private void ConfigureRooms(ModelBuilder builder)
    {
        builder.Entity<Room>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "Rooms", ZionConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }

    private void ConfigureSections(ModelBuilder builder)
    {
        builder.Entity<Section>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "Sections", ZionConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }

    private void ConfigureTeachers(ModelBuilder builder)
    {
        builder.Entity<Teacher>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "Teachers", ZionConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }

    private void ConfigureSubjects(ModelBuilder builder)
    {
        builder.Entity<Subject>(b =>
        {
            b.ToTable(ZionConsts.DbTablePrefix + "Subjects", ZionConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }


}
