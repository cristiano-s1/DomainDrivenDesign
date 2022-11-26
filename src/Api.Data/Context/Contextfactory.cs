using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context;

public class Contextfactory : IDesignTimeDbContextFactory<MyContext>
{
    public MyContext CreateDbContext(string[] args)
    {
        //Usado para Criar as Migrações
        var connectionString = "Server=HOME-CRISTIANO;Database=curso_aspnetcore_api;User Id=sa;Password=3271;";
        //var connectionString = "Server=.\\SQLEXPRESS2017;Database=dbAPI;User Id=sa;Password=3271";
        var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
        //optionsBuilder.UseMySql (connectionString);
        optionsBuilder.UseSqlServer(connectionString);
        return new MyContext(optionsBuilder.Options);
    }
}
