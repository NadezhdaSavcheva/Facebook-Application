using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Facebook.Services.Models;

namespace Facebook.Services
{
    public partial class FacebookDBContext : DbContext
    {
        public FacebookDBContext()
        {
        }

        public FacebookDBContext(DbContextOptions<FacebookDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Friends> Friends { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<PostLikes> PostLikes { get; set; }
        public virtual DbSet<Posts> Posts { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Schools> Schools { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersEvents> UsersEvents { get; set; }
        public virtual DbSet<UsersGroups> UsersGroups { get; set; }
        public virtual DbSet<Workplaces> Workplaces { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=127.0.0.1;Database=facebook; uID=facebook.user; pwd=SQLFacebook33.3; persistsecurityinfo=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PRIMARY");

                entity.ToTable("cities");

                entity.HasIndex(e => e.CountryId)
                    .HasName("city_country_id_fk_idx");

                entity.HasIndex(e => e.Name)
                    .HasName("city_name_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ZipCode)
                    .HasName("city_zip_code_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasColumnName("zip_code")
                    .HasMaxLength(10);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("city_country_id_fk");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("countries");

                entity.HasIndex(e => e.Name)
                    .HasName("country_name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PRIMARY");

                entity.ToTable("events");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("event_creator_id_fk_idx");

                entity.HasIndex(e => e.LocationId)
                    .HasName("event_location_id_fk_idx");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("event_creator_id_fk");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("event_location_id_fk");
            });

            modelBuilder.Entity<Friends>(entity =>
            {
                entity.HasKey(e => new { e.FriendshipId, e.FriendOneId, e.FriendTwoId })
                    .HasName("PRIMARY");

                entity.ToTable("friends");

                entity.HasIndex(e => e.FriendOneId)
                    .HasName("friend_one_fk");

                entity.HasIndex(e => e.FriendTwoId)
                    .HasName("friend_two_fk_idx");

                entity.Property(e => e.FriendshipId)
                    .HasColumnName("friendship_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FriendOneId).HasColumnName("friend_one_id");

                entity.Property(e => e.FriendTwoId).HasColumnName("friend_two_id");

                entity.Property(e => e.InvitedBy).HasColumnName("invited_by");

                entity.Property(e => e.RelationshipType)
                    .IsRequired()
                    .HasColumnName("relationship_type")
                    .HasMaxLength(45);

                entity.HasOne(d => d.FriendOne)
                    .WithMany(p => p.FriendsFriendOne)
                    .HasForeignKey(d => d.FriendOneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("friend_one_fk");

                entity.HasOne(d => d.FriendTwo)
                    .WithMany(p => p.FriendsFriendTwo)
                    .HasForeignKey(d => d.FriendTwoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("friend_two_fk");
            });

            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("groups");

                entity.HasIndex(e => e.CreatorId)
                    .HasName("group_creator_id_fk_idx");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.CreatorId).HasColumnName("creator_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Creator)
                    .WithMany(p => p.Groups)
                    .HasForeignKey(d => d.CreatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("group_creator_id_fk");
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("PRIMARY");

                entity.ToTable("locations");

                entity.HasIndex(e => e.CityId)
                    .HasName("location_city_id_fk_idx");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("location_city_id_fk");
            });

            modelBuilder.Entity<PostLikes>(entity =>
            {
                entity.HasKey(e => e.PostLikeId)
                    .HasName("PRIMARY");

                entity.ToTable("post_likes");

                entity.HasIndex(e => e.PostId)
                    .HasName("post_id_fk_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id_fk_idx");

                entity.Property(e => e.PostLikeId).HasColumnName("post_like_id");

                entity.Property(e => e.LikeType)
                    .IsRequired()
                    .HasColumnName("like_type")
                    .HasMaxLength(10);

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.PostLikes)
                    .HasForeignKey(d => d.PostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("post_likes_post_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostLikes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("post_likes_user_id_fk");
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PRIMARY");

                entity.ToTable("posts");

                entity.HasIndex(e => e.AuthorId)
                    .HasName("author_id_fk_idx");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.ParentPostId).HasColumnName("parent_post_id");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("blob");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(45);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(45);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("posts_author_id_fk");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId)
                    .HasName("PRIMARY");

                entity.ToTable("profiles");

                entity.HasIndex(e => e.CityId)
                    .HasName("profile_city_id_fk_idx");

                entity.HasIndex(e => e.PostsId)
                    .HasName("profile_posts_id_fk_idx");

                entity.HasIndex(e => e.SchoolId)
                    .HasName("profile_school_id_fk_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UserStatusId)
                    .HasName("profile_user_status_id_fk_idx");

                entity.HasIndex(e => e.WorkplaceId)
                    .HasName("profile_workplace_id_fk_idx");

                entity.Property(e => e.ProfileId).HasColumnName("profile_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CoverPhoto)
                    .HasColumnName("cover_photo")
                    .HasColumnType("blob");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Hobbies).HasColumnName("hobbies");

                entity.Property(e => e.PostsId).HasColumnName("posts_id");

                entity.Property(e => e.ProfilePhoto)
                    .HasColumnName("profile_photo")
                    .HasColumnType("blob");

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserStatusId).HasColumnName("user_status_id");

                entity.Property(e => e.WorkplaceId).HasColumnName("workplace_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("profile_city_id_fk");

                entity.HasOne(d => d.Posts)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.PostsId)
                    .HasConstraintName("profile_posts_id_fk");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("profile_school_id_fk");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Profiles)
                    .HasForeignKey<Profiles>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("profile_user_id_fk");

                entity.HasOne(d => d.UserStatus)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.UserStatusId)
                    .HasConstraintName("profile_user_status_id_fk");

                entity.HasOne(d => d.Workplace)
                    .WithMany(p => p.Profiles)
                    .HasForeignKey(d => d.WorkplaceId)
                    .HasConstraintName("profile_workplace_id_fk");
            });

            modelBuilder.Entity<Schools>(entity =>
            {
                entity.HasKey(e => e.SchoolId)
                    .HasName("PRIMARY");

                entity.ToTable("schools");

                entity.HasIndex(e => e.CityId)
                    .HasName("school_city_id_fk_idx");

                entity.HasIndex(e => e.Name)
                    .HasName("school_name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.SchoolId).HasColumnName("school_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Schools)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("school_city_id_fk");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("first_name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnName("gender")
                    .HasMaxLength(45);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("last_name")
                    .HasColumnType("tinytext");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnName("password_hash")
                    .HasMaxLength(100);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasColumnName("phone_number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UsersEvents>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.EventId })
                    .HasName("PRIMARY");

                entity.ToTable("users_events");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_id_fk_idx");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.UsersEvents)
                    .HasForeignKey(d => d.EventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_event_event_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersEvents)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_event_user_id_fk");
            });

            modelBuilder.Entity<UsersGroups>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GroupId })
                    .HasName("PRIMARY");

                entity.ToTable("users_groups");

                entity.HasIndex(e => e.GroupId)
                    .HasName("group_id_fk_idx");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UsersGroups)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_group_group_id_fk");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersGroups)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("user_group_user_id_fk");
            });

            modelBuilder.Entity<Workplaces>(entity =>
            {
                entity.HasKey(e => e.WorkplaceId)
                    .HasName("PRIMARY");

                entity.ToTable("workplaces");

                entity.HasIndex(e => e.CityId)
                    .HasName("workplaces_city_id_fk_idx");

                entity.HasIndex(e => e.Name)
                    .HasName("workplace_name_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.WorkplaceId).HasColumnName("workplace_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Workplaces)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("workplace_city_id_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
