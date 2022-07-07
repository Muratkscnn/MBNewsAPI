﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using News.DataAccess.Concreate;

#nullable disable

namespace News.DataAccess.Migrations
{
    [DbContext(typeof(MBContext))]
    [Migration("20220707133250_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("News.Entity.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("News.Entity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("News.Entity.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Ekonomi"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Siyaset"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Spor"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Ulusal"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Genel"
                        });
                });

            modelBuilder.Entity("News.Entity.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("InfoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("AppUserId");

                    b.HasIndex("InfoId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("News.Entity.Info", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NewsName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InfoId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Infos");

                    b.HasData(
                        new
                        {
                            InfoId = 1,
                            CategoryId = 5,
                            Content = "İtalya'da açıklarındaki feribot yangınında kaybolan TIR şoförü Mehmet Çakır'dan (42) 130 gündür haber alınamadı. Aydınlı olan Çakır'ın eniştesi Davut Gür (52), Hala bir ses yok.Ablası, annesi ve babası merak içinde.En azından öldüyse cenazesini memleketine defnetmek istiyoruz.Artık akıbetini öğrenmek istiyoruz dedi",
                            ImageUrl = "https://im.haberturk.com/2022/06/27/3473052_5f7955d6a10f726bfac7565d7f8ed46c_640x640.jpg",
                            NewsName = "İtalya da kaybolan Türk şoförden haber alınamıyor"
                        },
                        new
                        {
                            InfoId = 2,
                            CategoryId = 4,
                            Content = "Ürdün'ün Akabe kentinde tankerin patlaması sonucu sızan zehirli gazdan 10 kişi öldü, 250’den fazla kişi yaralandı",
                            ImageUrl = "https://im.haberturk.com/2022/06/27/ver1656350244/3473039_810x458.jpg",
                            NewsName = "Son dakika haberi Ürdün'de tanker patladı: 10 kişi öldü"
                        },
                        new
                        {
                            InfoId = 3,
                            CategoryId = 4,
                            Content = "NATO Genel Sekreteri Jens Stoltenberg, Madrid´de yapılacak NATO Liderler Zirvesi öncesi basın mensuplarının sorularını yanıtladı. Stoltenberg, İsveç, Finlandiya ve Türkiye arasında yapılacak toplantıya ilişkin Amaç elbette Finlandiya ve İsveç konusunda ilerleme kaydetmek.Herhangi bir söz vermeyeceğim ama sizi temin ederim ki ilerlemeyi sağlamak için aktif olarak çalışıyoruz dedi.",
                            ImageUrl = "https://im.haberturk.com/2022/06/27/ver1656345623/3472996_810x458.jpg",
                            NewsName = "Stoltenberg´den Türkiye açıklaması: Amacımız ilerleme kaydetmek"
                        },
                        new
                        {
                            InfoId = 4,
                            CategoryId = 2,
                            Content = "Son dakika haberi CHP'de Aykut Erdoğdu ve Tuba Torun istifa etti",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656507938/3473528_810x458.jpg",
                            NewsName = "CHP İstanbul Milletvekili Aykut Erdoğdu ve Yüksek Disiplin Kurulu üyesi Tuba Torun Erdoğdu partiden istifa etti. Erdoğdu ve Torun'un CHP'nin kendileri üzerinden yıpratılmaması amacıyla bu kararı aldıklarını belirtildi"
                        },
                        new
                        {
                            InfoId = 5,
                            CategoryId = 3,
                            Content = "Son dakika transfer haberi... Galatasaray, Joao Pedro ile prensipte anlaştı",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/3473478_be511c925b75dc7ecc2a46d64446ba17_640x640.jpg",
                            NewsName = "Galatasaray, İtalya Serie A ekiplerinden Cagliari'de forma giyen Joao Pedro'yu kadrosuna katmak üzere..."
                        },
                        new
                        {
                            InfoId = 6,
                            CategoryId = 3,
                            Content = "Son dakika Fenerbahçe haberleri... Süper Lig ekibi Fenerbahçe'nin deneyimli futbolcusu Enner Valencia, geleceğine ilişkin açıklamalarda bulundu. Valencia, 'Menajerim gelecek hafta Türkiye'ye gelecek, Fenerbahçe ile geleceğim hakkında konuşacak dedi!",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656493754/3473479_810x458.jpg",
                            NewsName = "Son dakika Fenerbahçe haberleri... Valencia'dan flaş açıklama: Menajerim gelecek!"
                        },
                        new
                        {
                            InfoId = 7,
                            CategoryId = 3,
                            Content = "Spor Toto Süper Lig'den düşen Yeni Malatyaspor Kulübü, olağanüstü seçimli genel kurul kararı aldı",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656511157/3473583_810x458.jpg",
                            NewsName = "Yeni Malatyaspor Kulübü olağanüstü genel kurul kararı aldı"
                        },
                        new
                        {
                            InfoId = 8,
                            CategoryId = 3,
                            Content = "Anadolu Efes, Adrien Moerman ile yolların ayrıldığını açıkladı",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656492854/3473474_810x458.jpg",
                            NewsName = "Anadolu Efes'te ayrılık"
                        },
                        new
                        {
                            InfoId = 15,
                            CategoryId = 3,
                            Content = "Aytemiz Alanyaspor, genç oyuncu Mert Yusuf Torlak'ı 5 yıllığına kadrosuna kattı",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656426239/3473301_810x458.jpg",
                            NewsName = "Mert Yusuf, 5 yıllığına Alanyaspor’da"
                        },
                        new
                        {
                            InfoId = 9,
                            CategoryId = 3,
                            Content = "Son dakika haberine göre; Fenerbahçe, Fatih Karagümrük'ten Emre Mor'un transferi için prensip anlaşmasına varıldığını açıkladı! Sarı-lacivertli kulübün paylaşımında Kulübümüz, Emre Mor transferi için Fatih Karagümrük Kulübü ve oyuncunun kendisi ile prensip anlaşmasına varmıştır ifadelerine yer verildi",
                            ImageUrl = "https://im.haberturk.com/2022/06/29/ver1656487958/3473369_810x458.jpg",
                            NewsName = "Son dakika: Fenerbahçe Emre Mor transferini açıkladı!"
                        },
                        new
                        {
                            InfoId = 10,
                            CategoryId = 3,
                            Content = "Galatasaray Nef, ABDli oyuncu Raymar Morgan'ı kadrosuna kattı. Raymar Morgan, Türkiye'de daha önce Pınar Karşıyaka ve TOFAŞ'ta forma giymişti",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656435892/3473333_810x458.jpg",
                            NewsName = "Raymar Morgan, Galatasaray Nef'e transfer oldu"
                        },
                        new
                        {
                            InfoId = 11,
                            CategoryId = 3,
                            Content = "Beşiktaş, yeni sezon hazırlıklarına bu akşam yaptığı çalışmayla devam etti. Valerien Ismael yönetiminde yapılan antrenman, yaklaşık 1.5 saat sürdü. Siyah-beyazlı ekip, yeni sezon hazırlıklarına, yarın saat 10.30 ve 16.00´da yapacağı çalışmalarla devam edecek",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656440926/3473346_810x458.jpg",
                            NewsName = "Beşiktaş'ta yeni sezon hazırlıkları sürdü"
                        },
                        new
                        {
                            InfoId = 12,
                            CategoryId = 3,
                            Content = "Aytemiz Alanyaspor, genç oyuncu Mert Yusuf Torlak'ı 5 yıllığına kadrosuna kattı",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656426239/3473301_810x458.jpg",
                            NewsName = "Mert Yusuf, 5 yıllığına Alanyaspor’da"
                        },
                        new
                        {
                            InfoId = 13,
                            CategoryId = 3,
                            Content = "Galatasaray'da yeni sezon hazırlıklarına başlayan futbolcular, sağlık kontrolünden geçti",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/ver1656418200/3473264_810x458.jpg",
                            NewsName = "Galatasaraylı futbolcular sağlık kontrolünden geçti"
                        },
                        new
                        {
                            InfoId = 14,
                            CategoryId = 3,
                            Content = "Son dakika Fenerbahçe transfer haberleri... Fenerbahçe golcü transferinde önceliğini Dominikli forvete verdi. Sarı-Lacivertliler, Real Madrid’in 6 milyon Euro'luk maliyeti nedeniyle kadroda düşünmediği 28 yaşındaki forvetle masaya oturdu. Olumlu geçen görüşmelerin kısa sürede netleşmesi bekleniyor. İşte son dakika haberinin detayları",
                            ImageUrl = "https://im.haberturk.com/2022/06/28/3473182_0fe84dd1097b9557ee2b9f146c3a560b_640x640.jpg",
                            NewsName = "Son dakika Fenerbahçe transfer haberleri - Hedefteki isim Mariano Diaz!"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("News.Entity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("News.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("News.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("News.Entity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("News.Entity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("News.Entity.Comment", b =>
                {
                    b.HasOne("News.Entity.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("News.Entity.Info", "Info")
                        .WithMany("Comments")
                        .HasForeignKey("InfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Info");

                    b.Navigation("User");
                });

            modelBuilder.Entity("News.Entity.Info", b =>
                {
                    b.HasOne("News.Entity.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("News.Entity.Category", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("News.Entity.Info", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
