﻿using Microsoft.EntityFrameworkCore;
using Questor.DAL.Models;

namespace Questor.DAL
{
    public class QuestorContext : DbContext
    {
        public QuestorContext()
        {

        }
        public QuestorContext(DbContextOptions<QuestorContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestResult>()
                .HasOne(x => x.Quest)
                .WithMany(x => x.QuestResults)
                .HasForeignKey(x => x.QuestId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<QuestResult>()
                .HasOne(x => x.User)
                .WithMany(x => x.CompletedQuests)
                .HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Restrict);
        }
        public DbSet<User> Users { get; set; }
        //public DbSet<Creator> Creators { get; set; }
        //public DbSet<Participant> Participants { get; set; }
        public DbSet<Quest> Quests { get; set; }

        public DbSet<Question> Questions{get;set;}
        public DbSet<QuestResult> QuestResults {get;set;}
        public DbSet<Answer> Answers {get;set;}

    }
}