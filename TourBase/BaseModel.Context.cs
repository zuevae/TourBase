﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TourBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ToursBase_BarashenkovEntities : DbContext
    {
        private static ToursBase_BarashenkovEntities _context;
        public ToursBase_BarashenkovEntities()
            : base("name=ToursBase_BarashenkovEntities")
        {
        }
        public static ToursBase_BarashenkovEntities GetContext()
        {
            if (_context == null)
                _context = new ToursBase_BarashenkovEntities();
            return _context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Country> Country { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelComment> HotelComment { get; set; }
        public DbSet<HotelImage> HotelImage { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Tour> Tour { get; set; }
        public DbSet<Type> Type { get; set; }
    }
}