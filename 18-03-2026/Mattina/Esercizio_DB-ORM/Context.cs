using System;
using Microsoft.EntityFrameworkCore;

public class ProdottoContext : DbContext
{
    public DbSet<Prodotto> Prodotti => Set<Prodotto>();
    private const string ConnString = "server=localhost;port=3306;database=negozio;user=root;password=NonTiCapisc0"; //inserisci la password utente MySQL in "password" e, se necessario, il nome del database modificando questa stringa

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var serverVersion = ServerVersion.AutoDetect(ConnString);
        options.UseMySql(ConnString, serverVersion);
    }
}