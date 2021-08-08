using System;
using System.Collections.Generic;
using System.Text;
using Music.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Music.DataAccess.Data
{
    public class MusicsDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }

        public MusicsDbContext()
        {

        }
        public MusicsDbContext(DbContextOptions<MusicsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
            modelBuilder.Entity<Song>()
                        .HasOne(m => m.Genre)
                        .WithMany(n => n.Songs)
                        .HasForeignKey(m => m.GenreId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SingerSong>()
                        .HasKey(ss => new { ss.SingerId, ss.SongId });

            modelBuilder.Entity<SingerSong>()
                        .HasOne(ss => ss.Song)
                        .WithMany(son => son.Singers)
                        .HasForeignKey(ss => ss.SingerId);

            modelBuilder.Entity<SingerSong>()
                        .HasOne(ss => ss.Singer)
                        .WithMany(sin => sin.Songs)
                        .HasForeignKey(ss => ss.SongId);

            modelBuilder.Entity<AlbumSong>()
                        .HasKey(ss => new { ss.AlbumId, ss.SongId });

            modelBuilder.Entity<AlbumSong>()
                        .HasOne(ss => ss.Album)
                        .WithMany(son => son.Songs)
                        .HasForeignKey(ss => ss.SongId)
                        .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);
        }
    }
}
