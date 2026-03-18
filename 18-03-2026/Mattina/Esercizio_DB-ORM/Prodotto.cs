using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Table("prodotti")] //nome tabella sql
public class Prodotto
{
    [Key] // Specifica che è la chiave primaria
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Nome { get; set; } = default!;

    public decimal Prezzo { get; set; } = default!;
}