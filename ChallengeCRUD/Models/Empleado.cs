using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeCRUD.Models;

public partial class Empleado
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre es requerido.")]
    public string Nombrecompleto { get; set; } = null!;
    [Required(ErrorMessage = "La edad es requerida.")]
    [Range(0, 150, ErrorMessage = "La edad debe estar entre 0 y 150 años.")]
    public short Edad { get; set; }
   
   
    [Required(ErrorMessage = "El salario es requerido.")]
    [Column("Salario", TypeName = "float")]
    public double Salario { get; set; }
    [Required(ErrorMessage = "El departamento es requerido.")]
    public string Departamento { get; set; } = null!;
}
