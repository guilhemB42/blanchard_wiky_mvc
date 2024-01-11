using IRepositories;
using Microsoft.EntityFrameworkCore;
using RepositoryContext.Entity_FRamework;
using RepositoryContext.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDdContext<CommentaireContext>( o=>
    { 
    o.UseSqlServer(builder.Configuration.GetConnectionString("wiki_gui"), b=>b.MigrationsAssembly("blanchard_wiky_mvc"));
});
builder.Services.AddDdContext<ArticleContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("wiki_gui"), b => b.MigrationsAssembly("blanchard_wiki_mvc"));
});

builder.Services.AddScoped<IArticleRepository, ArticleRepository>();
builder.Services.AddScoped<ICommentaireRepository, CommentaireRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
