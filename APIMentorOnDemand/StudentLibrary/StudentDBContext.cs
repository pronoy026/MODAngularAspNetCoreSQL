﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StudentLibrary
{
    public class StudentDBContext : IdentityDbContext
    {
        public StudentDBContext([NotNullAttribute] DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<UserModel> CustomUsers { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<MentorSkill> MentorSkills { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
