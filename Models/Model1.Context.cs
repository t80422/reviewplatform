﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebApplication1.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class ReviewPlatformEntities : DbContext
{
    public ReviewPlatformEntities()
        : base("name=ReviewPlatformEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<information_group> information_group { get; set; }

    public virtual DbSet<login_out> login_out { get; set; }

    public virtual DbSet<manager> manager { get; set; }

    public virtual DbSet<user_accounts> user_accounts { get; set; }

    public virtual DbSet<information> information { get; set; }

    public virtual DbSet<member> member { get; set; }

    public virtual DbSet<subsidy_member> subsidy_member { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<subsidy> subsidy { get; set; }

    public virtual DbSet<industry> industry { get; set; }

}

}

