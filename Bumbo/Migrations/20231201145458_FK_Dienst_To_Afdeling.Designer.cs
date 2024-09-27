﻿// <auto-generated />
using System;
using Bumbo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace Bumbo.Migrations
{
    [DbContext(typeof(BumboContext))]
    [Migration("20231201145458_FK_Dienst_To_Afdeling")]
    partial class FK_Dienst_To_Afdeling
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bumbo.Models.Activiteiten", b =>
                {
                    b.Property<int>("ActiviteitenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("activiteiten_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActiviteitenId"));

                    b.Property<int?>("AfdelingId")
                        .HasColumnType("int")
                        .HasColumnName("afdeling_id");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("text")
                        .HasColumnName("beschrijving");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("naam");

                    b.HasKey("ActiviteitenId")
                        .HasName("PK__activite__B26CABB6B0B8EE4E");

                    b.HasIndex(new[] { "AfdelingId" }, "IX_activiteiten_afdeling_id");

                    b.ToTable("activiteiten", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Afdelingen", b =>
                {
                    b.Property<int>("AfdelingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("afdeling_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfdelingId"));

                    b.Property<int>("AfdelingGroteInMeters")
                        .HasColumnType("int")
                        .HasColumnName("afdeling_grote_in_meters");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("naam");

                    b.HasKey("AfdelingId")
                        .HasName("PK__afdeling__6C5F284B47055CDE");

                    b.ToTable("afdelingen", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Beschikbaarheid", b =>
                {
                    b.Property<int>("BeschikbaarheidId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("beschikbaarheid_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BeschikbaarheidId"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date")
                        .HasColumnName("datum");

                    b.Property<TimeSpan>("EindTijd")
                        .HasColumnType("time")
                        .HasColumnName("eind_tijd");

                    b.Property<int?>("MedewerkerId")
                        .HasColumnType("int")
                        .HasColumnName("medewerker_id");

                    b.Property<int?>("SchoolUren")
                        .HasColumnType("int")
                        .HasColumnName("school_uren");

                    b.Property<TimeSpan>("StartTijd")
                        .HasColumnType("time")
                        .HasColumnName("start_tijd");

                    b.HasKey("BeschikbaarheidId")
                        .HasName("PK__beschikb__4A080957480D93FA");

                    b.HasIndex(new[] { "MedewerkerId" }, "IX_beschikbaarheid_medewerker_id");

                    b.ToTable("beschikbaarheid", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Diensten", b =>
                {
                    b.Property<int>("DienstenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("diensten_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DienstenId"));

                    b.Property<int>("AfdelingId")
                        .HasColumnType("int");

                    b.Property<int?>("AfdelingenAfdelingId")
                        .HasColumnType("int");

                    b.Property<int?>("BeschikbaarheidId")
                        .HasColumnType("int")
                        .HasColumnName("beschikbaarheid_id");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date")
                        .HasColumnName("datum");

                    b.Property<TimeSpan>("EindTijd")
                        .HasColumnType("time")
                        .HasColumnName("eind_tijd");

                    b.Property<int?>("MedewerkerId")
                        .HasColumnType("int")
                        .HasColumnName("medewerker_id");

                    b.Property<TimeSpan>("StartTijd")
                        .HasColumnType("time")
                        .HasColumnName("start_tijd");

                    b.HasKey("DienstenId")
                        .HasName("PK__diensten__A3C2395FDCA3385F");

                    b.HasIndex("AfdelingenAfdelingId");

                    b.HasIndex(new[] { "MedewerkerId" }, "IX_diensten_medewerker_id");

                    b.HasIndex(new[] { "BeschikbaarheidId" }, "UQ__diensten__4A080956DB00A71A")
                        .IsUnique()
                        .HasFilter("[beschikbaarheid_id] IS NOT NULL");

                    b.ToTable("diensten", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Filialen", b =>
                {
                    b.Property<int>("FiliaalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("filiaal_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FiliaalId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("email");

                    b.Property<string>("Huisnummer")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("huisnummer");

                    b.Property<Geometry>("Locatie")
                        .IsRequired()
                        .HasColumnType("geometry")
                        .HasColumnName("locatie");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("naam");

                    b.Property<string>("Plaats")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("plaats");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("postcode");

                    b.Property<string>("Straatnaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("straatnaam");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("telefoonnummer");

                    b.HasKey("FiliaalId")
                        .HasName("PK__filialen__2C34D497B730BE46");

                    b.HasIndex(new[] { "Postcode", "Huisnummer" }, "postcode_UNIQUE")
                        .IsUnique();

                    b.HasIndex(new[] { "Postcode", "Huisnummer" }, "straatnaam_UNIQUE")
                        .IsUnique();

                    b.ToTable("filialen", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Functie", b =>
                {
                    b.Property<int>("FunctieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("functie_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FunctieId"));

                    b.Property<string>("Beschrijving")
                        .HasColumnType("text")
                        .HasColumnName("beschrijving");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("naam");

                    b.Property<int>("Schaal")
                        .HasColumnType("int")
                        .HasColumnName("schaal");

                    b.HasKey("FunctieId")
                        .HasName("PK__functie__C321FA6BA6D21E03");

                    b.ToTable("functie", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Medewerker", b =>
                {
                    b.Property<int>("MedewerkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("medewerker_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedewerkerId"));

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("achternaam");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("email");

                    b.Property<int?>("FiliaalId")
                        .HasColumnType("int")
                        .HasColumnName("filiaal_id");

                    b.Property<int?>("FunctieId")
                        .HasColumnType("int")
                        .HasColumnName("functie_id");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("date")
                        .HasColumnName("geboortedatum");

                    b.Property<int>("Huisnummer")
                        .HasColumnType("int")
                        .HasColumnName("huisnummer");

                    b.Property<DateTime>("Indienst")
                        .HasColumnType("date")
                        .HasColumnName("indienst");

                    b.Property<string>("Plaats")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("plaats");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)")
                        .HasColumnName("postcode");

                    b.Property<string>("Straatnaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("straatnaam");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("telefoonnummer");

                    b.Property<string>("Tussenvoegsel")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("tussenvoegsel");

                    b.Property<bool>("Verwijdert")
                        .HasColumnType("bit")
                        .HasColumnName("verwijdert");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("voornaam");

                    b.HasKey("MedewerkerId")
                        .HasName("PK__medewerk__CB866CBE1B297B57");

                    b.HasIndex(new[] { "Email" }, "IX_medewerkers_email");

                    b.HasIndex(new[] { "FiliaalId" }, "IX_medewerkers_filiaal_id");

                    b.HasIndex(new[] { "FunctieId" }, "IX_medewerkers_functie_id");

                    b.ToTable("medewerkers", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Normeringen", b =>
                {
                    b.Property<int>("NormeringId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("normering_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NormeringId"));

                    b.Property<int>("Duur")
                        .HasColumnType("int")
                        .HasColumnName("duur");

                    b.Property<string>("Eenheid")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("eenheid");

                    b.Property<DateTime>("UploadDatum")
                        .HasColumnType("date")
                        .HasColumnName("upload_datum");

                    b.HasKey("NormeringId")
                        .HasName("PK__normerin__A425ADD599BA68A3");

                    b.ToTable("normeringen", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Prognose", b =>
                {
                    b.Property<int>("PrognoseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("prognose_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrognoseId"));

                    b.Property<int>("AantalCollies")
                        .HasColumnType("int")
                        .HasColumnName("aantal_collies");

                    b.Property<int>("AfdelingId")
                        .HasColumnType("int")
                        .HasColumnName("afdeling_id");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date")
                        .HasColumnName("datum");

                    b.Property<int>("FiliaalId")
                        .HasColumnType("int")
                        .HasColumnName("filiaal_id");

                    b.Property<int>("PotentieleAantalBezoekers")
                        .HasColumnType("int")
                        .HasColumnName("potentiele_aantal_bezoekers");

                    b.Property<int>("Uren")
                        .HasColumnType("int")
                        .HasColumnName("uren");

                    b.Property<byte>("Vakantiedag")
                        .HasColumnType("tinyint")
                        .HasColumnName("vakantiedag");

                    b.HasKey("PrognoseId")
                        .HasName("PK__Prognose__ID");

                    b.HasIndex(new[] { "AfdelingId" }, "IX_Prognose_afdeling_id");

                    b.HasIndex(new[] { "FiliaalId" }, "IX_Prognose_filiaal_id");

                    b.ToTable("prognose", (string)null);
                });

            modelBuilder.Entity("FilialenHasAfdelingen", b =>
                {
                    b.Property<int>("AfdelingId")
                        .HasColumnType("int")
                        .HasColumnName("afdeling_id");

                    b.Property<int>("FiliaalId")
                        .HasColumnType("int")
                        .HasColumnName("filiaal_id");

                    b.HasKey("AfdelingId", "FiliaalId")
                        .HasName("PK__filialen__0E9C6502D008BCDF");

                    b.HasIndex(new[] { "FiliaalId" }, "IX_filialen_has_afdelingen_filiaal_id");

                    b.ToTable("filialen_has_afdelingen", (string)null);
                });

            modelBuilder.Entity("FunctieHasAfdelingen", b =>
                {
                    b.Property<int>("AfdelingId")
                        .HasColumnType("int")
                        .HasColumnName("afdeling_id");

                    b.Property<int>("FunctieId")
                        .HasColumnType("int")
                        .HasColumnName("functie_id");

                    b.HasKey("AfdelingId", "FunctieId")
                        .HasName("PK__functie___C06D37ED8E8BE39C");

                    b.HasIndex(new[] { "FunctieId" }, "IX_functie_has_afdelingen_functie_id");

                    b.ToTable("functie_has_afdelingen", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NormeringenHasActiviteiten", b =>
                {
                    b.Property<int>("ActiviteitenId")
                        .HasColumnType("int")
                        .HasColumnName("activiteiten_id");

                    b.Property<int>("NormeringId")
                        .HasColumnType("int")
                        .HasColumnName("normering_id");

                    b.HasKey("ActiviteitenId", "NormeringId")
                        .HasName("PK__normerin__F82EF16BA1AB84F0");

                    b.HasIndex(new[] { "NormeringId" }, "IX_normeringen_has_activiteiten_normering_id");

                    b.ToTable("normeringen_has_activiteiten", (string)null);
                });

            modelBuilder.Entity("Bumbo.Models.Activiteiten", b =>
                {
                    b.HasOne("Bumbo.Models.Afdelingen", "Afdeling")
                        .WithMany("Activiteitens")
                        .HasForeignKey("AfdelingId")
                        .HasConstraintName("fk_activiteiten_afdelingen1");

                    b.Navigation("Afdeling");
                });

            modelBuilder.Entity("Bumbo.Models.Beschikbaarheid", b =>
                {
                    b.HasOne("Bumbo.Models.Medewerker", "Medewerker")
                        .WithMany("Beschikbaarheids")
                        .HasForeignKey("MedewerkerId")
                        .HasConstraintName("fk_medewerker_tijdslots_medewerkers1");

                    b.Navigation("Medewerker");
                });

            modelBuilder.Entity("Bumbo.Models.Diensten", b =>
                {
                    b.HasOne("Bumbo.Models.Afdelingen", "Afdelingen")
                        .WithMany()
                        .HasForeignKey("AfdelingenAfdelingId");

                    b.HasOne("Bumbo.Models.Beschikbaarheid", "Beschikbaarheid")
                        .WithOne("Diensten")
                        .HasForeignKey("Bumbo.Models.Diensten", "BeschikbaarheidId")
                        .HasConstraintName("FK_diensten_beschikbaarheid");

                    b.HasOne("Bumbo.Models.Medewerker", "Medewerker")
                        .WithMany("Dienstens")
                        .HasForeignKey("MedewerkerId")
                        .HasConstraintName("fk_diensten_medewerkers1");

                    b.Navigation("Afdelingen");

                    b.Navigation("Beschikbaarheid");

                    b.Navigation("Medewerker");
                });

            modelBuilder.Entity("Bumbo.Models.Medewerker", b =>
                {
                    b.HasOne("Bumbo.Models.Filialen", "Filiaal")
                        .WithMany("Medewerkers")
                        .HasForeignKey("FiliaalId")
                        .HasConstraintName("fk_medewerkers_filialen1");

                    b.HasOne("Bumbo.Models.Functie", "Functie")
                        .WithMany("Medewerkers")
                        .HasForeignKey("FunctieId")
                        .HasConstraintName("fk_medewerker_functie1");

                    b.Navigation("Filiaal");

                    b.Navigation("Functie");
                });

            modelBuilder.Entity("Bumbo.Models.Prognose", b =>
                {
                    b.HasOne("Bumbo.Models.Afdelingen", "Afdeling")
                        .WithMany("Prognoses")
                        .HasForeignKey("AfdelingId")
                        .IsRequired()
                        .HasConstraintName("FK__Prognose__Afdelingen");

                    b.HasOne("Bumbo.Models.Filialen", "Filiaal")
                        .WithMany("Prognoses")
                        .HasForeignKey("FiliaalId")
                        .IsRequired()
                        .HasConstraintName("FK__Prognose__Filialen");

                    b.Navigation("Afdeling");

                    b.Navigation("Filiaal");
                });

            modelBuilder.Entity("FilialenHasAfdelingen", b =>
                {
                    b.HasOne("Bumbo.Models.Afdelingen", null)
                        .WithMany()
                        .HasForeignKey("AfdelingId")
                        .IsRequired()
                        .HasConstraintName("fk_afdelingen_has_filialen_afdelingen1");

                    b.HasOne("Bumbo.Models.Filialen", null)
                        .WithMany()
                        .HasForeignKey("FiliaalId")
                        .IsRequired()
                        .HasConstraintName("fk_afdelingen_has_filialen_filialen1");
                });

            modelBuilder.Entity("FunctieHasAfdelingen", b =>
                {
                    b.HasOne("Bumbo.Models.Afdelingen", null)
                        .WithMany()
                        .HasForeignKey("AfdelingId")
                        .IsRequired()
                        .HasConstraintName("fk_afdelingen_has_functie_afdelingen1");

                    b.HasOne("Bumbo.Models.Functie", null)
                        .WithMany()
                        .HasForeignKey("FunctieId")
                        .IsRequired()
                        .HasConstraintName("fk_afdelingen_has_functie_functie1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NormeringenHasActiviteiten", b =>
                {
                    b.HasOne("Bumbo.Models.Activiteiten", null)
                        .WithMany()
                        .HasForeignKey("ActiviteitenId")
                        .IsRequired()
                        .HasConstraintName("fk_activiteiten_has_normeringen_activiteiten1");

                    b.HasOne("Bumbo.Models.Normeringen", null)
                        .WithMany()
                        .HasForeignKey("NormeringId")
                        .IsRequired()
                        .HasConstraintName("fk_activiteiten_has_normeringen_normeringen1");
                });

            modelBuilder.Entity("Bumbo.Models.Afdelingen", b =>
                {
                    b.Navigation("Activiteitens");

                    b.Navigation("Prognoses");
                });

            modelBuilder.Entity("Bumbo.Models.Beschikbaarheid", b =>
                {
                    b.Navigation("Diensten");
                });

            modelBuilder.Entity("Bumbo.Models.Filialen", b =>
                {
                    b.Navigation("Medewerkers");

                    b.Navigation("Prognoses");
                });

            modelBuilder.Entity("Bumbo.Models.Functie", b =>
                {
                    b.Navigation("Medewerkers");
                });

            modelBuilder.Entity("Bumbo.Models.Medewerker", b =>
                {
                    b.Navigation("Beschikbaarheids");

                    b.Navigation("Dienstens");
                });
#pragma warning restore 612, 618
        }
    }
}