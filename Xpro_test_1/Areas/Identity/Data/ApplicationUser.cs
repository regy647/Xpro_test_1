using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Xpro_test_1.Models;

namespace Xpro_test_1.Areas.Identity.Data;
public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }

    public override string PhoneNumber { get; set; }

    public string Position { get; set; }

    public EmploymentType EmploymentType { get; set; }

    public string? EmploymentComment { get; set; }

    public bool IsActive { get; set; }

    public ICollection<WorkLog> WorkLogs { get; set; }

}

public enum EmploymentType
{
    DoločenČas,
    NedoločenČas,
    Student,
    Avtorsko,
    SP,
    Drugo
}

