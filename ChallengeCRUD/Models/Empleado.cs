using System;
using System.Collections.Generic;

namespace ChallengeCRUD.Models;

public partial class Empleado
{
    public int Id { get; set; }

    public string Nombrecompleto { get; set; } = null!;

    public short Edad { get; set; }

    public decimal Salario { get; set; }

    public string Departamento { get; set; } = null!;
}
