using System;
using System.Collections.Generic;

namespace WebApp7ByJayson.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Faculty { get; set; } = null!;
}
