using System.ComponentModel.DataAnnotations;

namespace JornadaMilhasApi.Models;

public abstract record IEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }
}
