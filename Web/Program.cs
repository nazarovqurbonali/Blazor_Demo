using Infrastructure.Data;
using Infrastructure.Services.MentorServices;
using Infrastructure.Services.StudentService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(configure =>
{
    configure.UseNpgsql(connectionString:
        builder.Configuration.GetConnectionString("DefaultConnection")
    );
});
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<IFacultyService, FacultyService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IFacultyService, FacultyService>();
builder.Services.AddTransient<IMentorService, MentorService>();


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
