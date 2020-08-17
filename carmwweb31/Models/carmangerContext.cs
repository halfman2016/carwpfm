using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace carmwweb31.Models
{
    public partial class carmangerContext : DbContext
    {
        public carmangerContext()
        {
        }

        public carmangerContext(DbContextOptions<carmangerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Comins> Comins { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Forceins> Forceins { get; set; }
        public virtual DbSet<Insclass> Insclass { get; set; }
        public virtual DbSet<Orgs> Orgs { get; set; }
        public virtual DbSet<Orgset> Orgset { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Sysusers> Sysusers { get; set; }
        public virtual DbSet<Testrec> Testrec { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;uid=root;pwd=123456;database=carmanger;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cars>(entity =>
            {
                entity.HasKey(e => e.Idcars)
                    .HasName("PRIMARY");

                entity.ToTable("cars");

                entity.HasIndex(e => e.Idcars)
                    .HasName("idcars_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OrgsIdorgs)
                    .HasName("fk_cars_orgs1_idx");

                entity.Property(e => e.Idcars).HasColumnName("idcars");

                entity.Property(e => e.Applydate)
                    .HasColumnName("applydate")
                    .HasColumnType("date")
                    .HasComment("发证日期");

                entity.Property(e => e.Caraddress)
                    .HasColumnName("caraddress")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("住址");

                entity.Property(e => e.Carappeara)
                    .HasColumnName("carappeara")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("外观尺寸");

                entity.Property(e => e.Carbrand)
                    .HasColumnName("carbrand")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("品牌型号");

                entity.Property(e => e.Carcarry)
                    .HasColumnName("carcarry")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasComment("核定载人数");

                entity.Property(e => e.Carcarrymass)
                    .HasColumnName("carcarrymass")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("核定载重量");

                entity.Property(e => e.Caremass)
                    .HasColumnName("caremass")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("装备质量");

                entity.Property(e => e.Carengine)
                    .HasColumnName("carengine")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("发动机号");

                entity.Property(e => e.Carfule)
                    .HasColumnName("carfule")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasComment("汽油/柴油");

                entity.Property(e => e.Carmass)
                    .HasColumnName("carmass")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("总质量");

                entity.Property(e => e.Carplate)
                    .HasColumnName("carplate")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("号牌");

                entity.Property(e => e.Carscrapdate)
                    .HasColumnName("carscrapdate")
                    .HasColumnType("date")
                    .HasComment("强制报废日期");

                entity.Property(e => e.Cartype)
                    .HasColumnName("cartype")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("车辆类型");

                entity.Property(e => e.Caruae)
                    .HasColumnName("caruae")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("使用性质 非营运");

                entity.Property(e => e.Carvin)
                    .HasColumnName("carvin")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("车辆vin码");

                entity.Property(e => e.Filenum)
                    .HasColumnName("filenum")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("档案编号");

                entity.Property(e => e.OrgsIdorgs).HasColumnName("orgs_idorgs");

                entity.Property(e => e.OwnersIdowners).HasColumnName("owners_idowners");

                entity.Property(e => e.Papercode)
                    .HasColumnName("papercode")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("证件号码");

                entity.Property(e => e.Regdate)
                    .HasColumnName("regdate")
                    .HasColumnType("date")
                    .HasComment("注册日期");

                entity.HasOne(d => d.OrgsIdorgsNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.OrgsIdorgs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cars_orgs1");
            });

            modelBuilder.Entity<Comins>(entity =>
            {
                entity.HasKey(e => new { e.IdCommerceins, e.InsclassIdinsclass, e.CarsOwnersIdowners, e.CarsIdcars })
                    .HasName("PRIMARY");

                entity.ToTable("comins");

                entity.HasIndex(e => e.CarsIdcars)
                    .HasName("fk_comins_cars1_idx");

                entity.HasIndex(e => e.InsclassIdinsclass)
                    .HasName("fk_comins_insclass1_idx");

                entity.Property(e => e.IdCommerceins)
                    .HasColumnName("idCommerceins")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsclassIdinsclass).HasColumnName("insclass_idinsclass");

                entity.Property(e => e.CarsOwnersIdowners).HasColumnName("cars_owners_idowners");

                entity.Property(e => e.CarsIdcars).HasColumnName("cars_idcars");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasComment("保额");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Ponum)
                    .HasColumnName("ponum")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("保单号");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.HasOne(d => d.CarsIdcarsNavigation)
                    .WithMany(p => p.Comins)
                    .HasForeignKey(d => d.CarsIdcars)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comins_cars1");

                entity.HasOne(d => d.InsclassIdinsclassNavigation)
                    .WithMany(p => p.Comins)
                    .HasForeignKey(d => d.InsclassIdinsclass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_comins_insclass1");
            });

            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.HasKey(e => e.Iddriver)
                    .HasName("PRIMARY");

                entity.ToTable("drivers");

                entity.HasIndex(e => e.Iddriver)
                    .HasName("iddriver_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PeopleIdpeople)
                    .HasName("fk_drivers_people1_idx");

                entity.Property(e => e.Iddriver).HasColumnName("iddriver");

                entity.Property(e => e.Applydate)
                    .HasColumnName("applydate")
                    .HasColumnType("date")
                    .HasComment("发证日期");

                entity.Property(e => e.Licenseno)
                    .HasColumnName("licenseno")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("驾驶证号");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("姓名");

                entity.Property(e => e.PeopleIdpeople).HasColumnName("people_idpeople");

                entity.HasOne(d => d.PeopleIdpeopleNavigation)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.PeopleIdpeople)
                    .HasConstraintName("fk_drivers_people1");
            });

            modelBuilder.Entity<Forceins>(entity =>
            {
                entity.HasKey(e => new { e.IdInsurances, e.InsclassIdinsclass, e.CarsIdcars })
                    .HasName("PRIMARY");

                entity.ToTable("forceins");

                entity.HasIndex(e => e.CarsIdcars)
                    .HasName("fk_forceins_cars1_idx");

                entity.HasIndex(e => e.IdInsurances)
                    .HasName("idInsurances_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.InsclassIdinsclass)
                    .HasName("fk_Insurances_instype1_idx");

                entity.Property(e => e.IdInsurances)
                    .HasColumnName("idInsurances")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InsclassIdinsclass).HasColumnName("insclass_idinsclass");

                entity.Property(e => e.CarsIdcars).HasColumnName("cars_idcars");

                entity.Property(e => e.Deathinde)
                    .HasColumnName("deathinde")
                    .HasDefaultValueSql("'11000'")
                    .HasComment("死亡伤残赔偿限额");

                entity.Property(e => e.Dispute)
                    .HasColumnName("dispute")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'诉讼'")
                    .HasComment("争议解决方式");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasComment("至");

                entity.Property(e => e.Floatratio)
                    .HasColumnName("floatratio")
                    .HasComment("浮动比率");

                entity.Property(e => e.Handle)
                    .HasColumnName("handle")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("经办");

                entity.Property(e => e.Lpf)
                    .HasColumnName("lpf")
                    .HasDefaultValueSql("'0'")
                    .HasComment("滞纳金");

                entity.Property(e => e.Manufacturing)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("制单");

                entity.Property(e => e.Medinde)
                    .HasColumnName("medinde")
                    .HasDefaultValueSql("'10000'")
                    .HasComment("医疗费用赔偿限额");

                entity.Property(e => e.Nrdeathinde)
                    .HasColumnName("nrdeathinde")
                    .HasDefaultValueSql("'11000'")
                    .HasComment("无责任死亡伤残赔偿限额");

                entity.Property(e => e.Nrmedinde)
                    .HasColumnName("nrmedinde")
                    .HasDefaultValueSql("'1000'")
                    .HasComment("无责任医疗费用赔偿限额");

                entity.Property(e => e.Nrproinde)
                    .HasColumnName("nrproinde")
                    .HasDefaultValueSql("'100'")
                    .HasComment("无责任财产损失赔偿限额");

                entity.Property(e => e.Paypy)
                    .HasColumnName("paypy")
                    .HasDefaultValueSql("'0'")
                    .HasComment("往年补缴");

                entity.Property(e => e.Payty)
                    .HasColumnName("payty")
                    .HasComment("当年应缴");

                entity.Property(e => e.Ponum)
                    .HasColumnName("ponum")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("保单号");

                entity.Property(e => e.Premium)
                    .HasColumnName("premium")
                    .HasComment("保费");

                entity.Property(e => e.Proinde)
                    .HasColumnName("proinde")
                    .HasDefaultValueSql("'2000'")
                    .HasComment("财产损失赔偿限额");

                entity.Property(e => e.Signdate)
                    .HasColumnName("signdate")
                    .HasColumnType("date")
                    .HasComment("签单日期");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasComment("保险期间自");

                entity.Property(e => e.Ttax)
                    .HasColumnName("ttax")
                    .HasComment("合计");

                entity.Property(e => e.Underwriting)
                    .HasColumnName("underwriting")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("核保人");

                entity.HasOne(d => d.CarsIdcarsNavigation)
                    .WithMany(p => p.Forceins)
                    .HasForeignKey(d => d.CarsIdcars)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_forceins_cars1");

                entity.HasOne(d => d.InsclassIdinsclassNavigation)
                    .WithMany(p => p.Forceins)
                    .HasForeignKey(d => d.InsclassIdinsclass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Insurances_instype1");
            });

            modelBuilder.Entity<Insclass>(entity =>
            {
                entity.HasKey(e => e.Idinsclass)
                    .HasName("PRIMARY");

                entity.ToTable("insclass");

                entity.HasIndex(e => e.Idinsclass)
                    .HasName("idinstype_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idinsclass).HasColumnName("idinsclass");

                entity.Property(e => e.Corpaddr)
                    .HasColumnName("corpaddr")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Corppostcode)
                    .HasColumnName("corppostcode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Corptele)
                    .HasColumnName("corptele")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Inscorp)
                    .HasColumnName("inscorp")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Insname)
                    .HasColumnName("insname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Instype)
                    .HasColumnName("instype")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orgs>(entity =>
            {
                entity.HasKey(e => e.Idorgs)
                    .HasName("PRIMARY");

                entity.ToTable("orgs");

                entity.HasIndex(e => e.Idorgs)
                    .HasName("idorgs_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idorgs).HasColumnName("idorgs");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("地址");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment(@"机构代码
");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("名称");
            });

            modelBuilder.Entity<Orgset>(entity =>
            {
                entity.HasKey(e => e.OrgsIdorgs)
                    .HasName("PRIMARY");

                entity.ToTable("orgset");

                entity.HasIndex(e => e.OrgsIdorgs)
                    .HasName("fk_orgset_orgs1_idx");

                entity.Property(e => e.OrgsIdorgs).HasColumnName("orgs_idorgs");

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasDefaultValueSql("'20'")
                    .HasComment("临期提醒");

                entity.Property(e => e.Sms)
                    .HasColumnName("sms")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("是否开通短信");

                entity.HasOne(d => d.OrgsIdorgsNavigation)
                    .WithOne(p => p.Orgset)
                    .HasForeignKey<Orgset>(d => d.OrgsIdorgs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_orgset_orgs1");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.HasKey(e => e.Idpeople)
                    .HasName("PRIMARY");

                entity.ToTable("people");

                entity.HasIndex(e => e.Idpeople)
                    .HasName("idpeople_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OrgsIdorgs)
                    .HasName("fk_people_orgs_idx");

                entity.Property(e => e.Idpeople).HasColumnName("idpeople");

                entity.Property(e => e.Addr)
                    .HasColumnName("addr")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("地址");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("身份证号");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("手机号");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("姓名");

                entity.Property(e => e.OrgsIdorgs).HasColumnName("orgs_idorgs");

                entity.HasOne(d => d.OrgsIdorgsNavigation)
                    .WithMany(p => p.People)
                    .HasForeignKey(d => d.OrgsIdorgs)
                    .HasConstraintName("fk_people_orgs");
            });

            modelBuilder.Entity<Sysusers>(entity =>
            {
                entity.HasKey(e => e.Idsysuser)
                    .HasName("PRIMARY");

                entity.ToTable("sysusers");

                entity.HasIndex(e => e.Idsysuser)
                    .HasName("idsysuser_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.OrgsIdorgs)
                    .HasName("fk_sysusers_orgs1_idx");

                entity.Property(e => e.Idsysuser).HasColumnName("idsysuser");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("date")
                    .HasComment("建立日期");

                entity.Property(e => e.OrgsIdorgs).HasColumnName("orgs_idorgs");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("密码");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("角色");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasComment("用户名");

                entity.HasOne(d => d.OrgsIdorgsNavigation)
                    .WithMany(p => p.Sysusers)
                    .HasForeignKey(d => d.OrgsIdorgs)
                    .HasConstraintName("fk_sysusers_orgs1");
            });

            modelBuilder.Entity<Testrec>(entity =>
            {
                entity.HasKey(e => new { e.Idtestrec, e.CarsIdcars })
                    .HasName("PRIMARY");

                entity.ToTable("testrec");

                entity.HasIndex(e => e.CarsIdcars)
                    .HasName("fk_testrec_cars1_idx");

                entity.HasIndex(e => e.Idtestrec)
                    .HasName("idtestrec_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idtestrec)
                    .HasColumnName("idtestrec")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CarsIdcars).HasColumnName("cars_idcars");

                entity.Property(e => e.Exdate)
                    .HasColumnName("exdate")
                    .HasColumnType("date")
                    .HasComment("检验有效期");

                entity.Property(e => e.Testdate)
                    .HasColumnName("testdate")
                    .HasColumnType("date")
                    .HasComment("检验日期");

                entity.HasOne(d => d.CarsIdcarsNavigation)
                    .WithMany(p => p.Testrec)
                    .HasForeignKey(d => d.CarsIdcars)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_testrec_cars1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
