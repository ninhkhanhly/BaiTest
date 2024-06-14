using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ninhkhanhly22222.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<Ninhkhanhly22222.Models.LopHoc> LopHoc { get; set; } = default!;

public DbSet<Ninhkhanhly22222.Models.SinhVien> SinhVien { get; set; } = default!;
    }
