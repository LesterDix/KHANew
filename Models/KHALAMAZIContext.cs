using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace KHANew.Models
{
    public partial class KHALAMAZIContext : DbContext
    {
        public KHALAMAZIContext()
        {
        }

        public KHALAMAZIContext(DbContextOptions<KHALAMAZIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChgUnt> ChgUnt { get; set; }
        public virtual DbSet<CnsInvoice> CnsInvoice { get; set; }
        public virtual DbSet<CnsLines> CnsLines { get; set; }
        public virtual DbSet<Cnsment> Cnsment { get; set; }
        public virtual DbSet<ConsigmentId> ConsigmentId { get; set; }
        public virtual DbSet<Consignee> Consignee { get; set; }
        public virtual DbSet<CreditDetails> CreditDetails { get; set; }
        public virtual DbSet<CreditNoteDetail> CreditNoteDetail { get; set; }
        public virtual DbSet<CrmSummary> CrmSummary { get; set; }
        public virtual DbSet<Cultivars> Cultivars { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerBalances> CustomerBalances { get; set; }
        public virtual DbSet<CustomerReconciliation> CustomerReconciliation { get; set; }
        public virtual DbSet<CustomerRemitValue> CustomerRemitValue { get; set; }
        public virtual DbSet<CustomerRemittanceReconciliation> CustomerRemittanceReconciliation { get; set; }
        public virtual DbSet<ExportSummary> ExportSummary { get; set; }
        public virtual DbSet<Exporter> Exporter { get; set; }
        public virtual DbSet<Exports> Exports { get; set; }
        public virtual DbSet<FreightCostAndCharge> FreightCostAndCharge { get; set; }
        public virtual DbSet<FreightCostByAwb> FreightCostByAwb { get; set; }
        public virtual DbSet<FreightCostVsCharge> FreightCostVsCharge { get; set; }
        public virtual DbSet<FreightFob> FreightFob { get; set; }
        public virtual DbSet<FreightInvoiceRecon> FreightInvoiceRecon { get; set; }
        public virtual DbSet<FreightRemittanceTotal> FreightRemittanceTotal { get; set; }
        public virtual DbSet<FreightRemittances> FreightRemittances { get; set; }
        public virtual DbSet<FreightSalesDetails> FreightSalesDetails { get; set; }
        public virtual DbSet<FrtCheck> FrtCheck { get; set; }
        public virtual DbSet<FrtRates> FrtRates { get; set; }
        public virtual DbSet<FrtRatesFob> FrtRatesFob { get; set; }
        public virtual DbSet<FrtRemit> FrtRemit { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceBoe> InvoiceBoe { get; set; }
        public virtual DbSet<InvoiceCheck> InvoiceCheck { get; set; }
        public virtual DbSet<InvoiceCnDnRecon> InvoiceCnDnRecon { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetail { get; set; }
        public virtual DbSet<InvoiceReconByLine> InvoiceReconByLine { get; set; }
        public virtual DbSet<InvoiceReconciliation> InvoiceReconciliation { get; set; }
        public virtual DbSet<InvoiceRemitCn> InvoiceRemitCn { get; set; }
        public virtual DbSet<InvoiceSummary> InvoiceSummary { get; set; }
        public virtual DbSet<InvoiceValueByCustomerByDate> InvoiceValueByCustomerByDate { get; set; }
        public virtual DbSet<InvoiceValues> InvoiceValues { get; set; }
        public virtual DbSet<LinesFreight> LinesFreight { get; set; }
        public virtual DbSet<PdFreightInvoiceRecon> PdFreightInvoiceRecon { get; set; }
        public virtual DbSet<PdFrtRemit> PdFrtRemit { get; set; }
        public virtual DbSet<PkgCtn> PkgCtn { get; set; }
        public virtual DbSet<PkgLbl> PkgLbl { get; set; }
        public virtual DbSet<PkgMsc> PkgMsc { get; set; }
        public virtual DbSet<PkgPak> PkgPak { get; set; }
        public virtual DbSet<PlgCustomerReconciliation> PlgCustomerReconciliation { get; set; }
        public virtual DbSet<PlgCustomerReconciliationB> PlgCustomerReconciliationB { get; set; }
        public virtual DbSet<PlgInvoiceReconciliation> PlgInvoiceReconciliation { get; set; }
        public virtual DbSet<PlgInvoiceReconciliationB> PlgInvoiceReconciliationB { get; set; }
        public virtual DbSet<PrdLines> PrdLines { get; set; }
        public virtual DbSet<ProdFrcst> ProdFrcst { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Remittances> Remittances { get; set; }
        public virtual DbSet<RoseExports> RoseExports { get; set; }
        public virtual DbSet<SalesByLineByCustomer> SalesByLineByCustomer { get; set; }
        public virtual DbSet<SalesFrcst> SalesFrcst { get; set; }
        public virtual DbSet<SalesWeeks> SalesWeeks { get; set; }
        public virtual DbSet<ShipCnsmentDetail> ShipCnsmentDetail { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<StkCtn> StkCtn { get; set; }
        public virtual DbSet<StkLbl> StkLbl { get; set; }
        public virtual DbSet<StkMsc> StkMsc { get; set; }
        public virtual DbSet<StkPak> StkPak { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<TranscationReconciliation> TranscationReconciliation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChgUnt>(entity =>
            {
                entity.HasKey(e => e.Ref);

                entity.ToTable("CHG_UNT");

                entity.Property(e => e.Ref).HasColumnName("REF");

                entity.Property(e => e.ChgUnt1)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CnsInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CnsInvoice");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.COfONo)
                    .HasColumnName("C_OF_O_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CnsAdd1)
                    .HasColumnName("CNS_ADD1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsAdd2)
                    .HasColumnName("CNS_ADD2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsAdd3)
                    .HasColumnName("CNS_ADD3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsAdd4)
                    .HasColumnName("CNS_ADD4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsAdd5)
                    .HasColumnName("CNS_ADD5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsCell)
                    .HasColumnName("CNS_CELL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsCntct)
                    .HasColumnName("CNS_CNTCT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsEmail)
                    .HasColumnName("CNS_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsLl)
                    .HasColumnName("CNS_LL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsName)
                    .HasColumnName("CNS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Container1)
                    .HasColumnName("CONTAINER1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container2)
                    .HasColumnName("CONTAINER2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container3)
                    .HasColumnName("CONTAINER3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container4)
                    .HasColumnName("CONTAINER4")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container5)
                    .HasColumnName("CONTAINER5")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container6)
                    .HasColumnName("CONTAINER6")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container7)
                    .HasColumnName("CONTAINER7")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container8)
                    .HasColumnName("CONTAINER8")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CstAdd1)
                    .HasColumnName("CST_ADD1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstAdd2)
                    .HasColumnName("CST_ADD2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstAdd3)
                    .HasColumnName("CST_ADD3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstAdd4)
                    .HasColumnName("CST_ADD4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstAdd5)
                    .HasColumnName("CST_ADD5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstCell)
                    .HasColumnName("CST_CELL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstCnt)
                    .HasColumnName("CST_CNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstEMail)
                    .HasColumnName("CST_E_MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstLl)
                    .HasColumnName("CST_LL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CstName)
                    .HasColumnName("CST_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestCode)
                    .IsRequired()
                    .HasColumnName("DEST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExporterName)
                    .IsRequired()
                    .HasColumnName("EXPORTER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Flight1)
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Flight2)
                    .HasColumnName("FLIGHT2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Flight3)
                    .HasColumnName("FLIGHT3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhytoNo)
                    .HasColumnName("PHYTO_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Routing)
                    .HasColumnName("ROUTING")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sundry2)
                    .HasColumnName("SUNDRY2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CnsLines>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("CNS_LINES");

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.BnchLineId).HasColumnName("BNCH_LINE_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrtChgUnt)
                    .HasColumnName("FRT_CHG_UNT")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.KgPkUnt).HasColumnName("KG_PK_UNT");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkDow)
                    .HasColumnName("PK_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PkWeek).HasColumnName("PK_WEEK");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Cnsment)
                    .WithMany(p => p.CnsLines)
                    .HasForeignKey(d => d.CnsmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNS_LINES_CNSMENT");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.CnsLines)
                    .HasForeignKey(d => d.LineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNS_LINES_PRD_LINES");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CnsLines)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNS_LINES_SUPPLIER");
            });

            modelBuilder.Entity<Cnsment>(entity =>
            {
                entity.HasKey(e => e.CnsmentId)
                    .IsClustered(false);

                entity.ToTable("CNSMENT");

                entity.HasIndex(e => e.CnsmentId)
                    .HasName("CNSMENT")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BookedBoxes).HasColumnName("BOOKED_BOXES");

                entity.Property(e => e.BookedKg).HasColumnName("BOOKED_KG");

                entity.Property(e => e.COfONo)
                    .HasColumnName("C_OF_O_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChgUnt)
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CnsgneeId)
                    .IsRequired()
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Container1)
                    .HasColumnName("CONTAINER1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container2)
                    .HasColumnName("CONTAINER2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container3)
                    .HasColumnName("CONTAINER3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container4)
                    .HasColumnName("CONTAINER4")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container5)
                    .HasColumnName("CONTAINER5")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container6)
                    .HasColumnName("CONTAINER6")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container7)
                    .HasColumnName("CONTAINER7")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Container8)
                    .HasColumnName("CONTAINER8")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeadChgUsd)
                    .HasColumnName("DEAD_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.DeadUnts).HasColumnName("DEAD_UNTS");

                entity.Property(e => e.DepDow)
                    .IsRequired()
                    .HasColumnName("DEP_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.FreightInvoice)
                    .HasColumnName("FREIGHT_INVOICE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChgUsd)
                    .HasColumnName("FRT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.FrtCstUsd)
                    .HasColumnName("FRT_CST_USD")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgBox).HasColumnName("KG_BOX");

                entity.Property(e => e.OthrChgDesc)
                    .HasColumnName("OTHR_CHG_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OthrChgUsd)
                    .HasColumnName("OTHR_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.PhytoNo)
                    .HasColumnName("PHYTO_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RateUntUsd)
                    .HasColumnName("RATE_UNT_USD")
                    .HasColumnType("money");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.Status)
                    .HasColumnName("STATUS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sundry2)
                    .HasColumnName("SUNDRY2")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotChgUsd)
                    .HasColumnName("TOT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");

                entity.HasOne(d => d.Cnsgnee)
                    .WithMany(p => p.Cnsment)
                    .HasForeignKey(d => d.CnsgneeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNSMENT_CONSIGNEE");

                entity.HasOne(d => d.CstmerNavigation)
                    .WithMany(p => p.Cnsment)
                    .HasForeignKey(d => d.Cstmer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNSMENT_CUSTOMER");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.Cnsment)
                    .HasForeignKey(d => d.Currency)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNSMENT_CURRENCY");

                entity.HasOne(d => d.ExporterNavigation)
                    .WithMany(p => p.Cnsment)
                    .HasForeignKey(d => d.Exporter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNSMENT_EXPORTER");

                entity.HasOne(d => d.Ship)
                    .WithMany(p => p.Cnsment)
                    .HasForeignKey(d => d.ShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNSMENT_SHIPMENT");
            });

            modelBuilder.Entity<ConsigmentId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Consigment_ID");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight1)
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Routing)
                    .HasColumnName("ROUTING")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sundry2)
                    .HasColumnName("SUNDRY2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<Consignee>(entity =>
            {
                entity.HasKey(e => e.CnsgneeId);

                entity.ToTable("CONSIGNEE");

                entity.Property(e => e.CnsgneeId)
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasColumnName("ADDRESS4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address5)
                    .HasColumnName("ADDRESS5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .HasColumnName("CELL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cstmer)
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DestCode)
                    .IsRequired()
                    .HasColumnName("DEST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Landline)
                    .HasColumnName("LANDLINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CreditDetails>(entity =>
            {
                entity.HasKey(e => e.CnNo);

                entity.ToTable("CREDIT_DETAILS");

                entity.Property(e => e.CnNo).HasColumnName("CN_NO");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasColumnName("MEMO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.Week).HasColumnName("WEEK");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.CreditDetails)
                    .HasForeignKey(d => d.TransId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CREDIT_DETAILS_CNS_LINES");
            });

            modelBuilder.Entity<CreditNoteDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CreditNoteDetail");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnNo).HasColumnName("CN_NO");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo)
                    .HasColumnName("MEMO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.Week).HasColumnName("WEEK");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CRM_Summary");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoStems).HasColumnName("NO_STEMS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StemsCarton).HasColumnName("STEMS_CARTON");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Cultivars>(entity =>
            {
                entity.HasKey(e => e.CulitvarId);

                entity.ToTable("CULTIVARS");

                entity.Property(e => e.CulitvarId).HasColumnName("CULITVAR_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CrncyCode);

                entity.ToTable("CURRENCY");

                entity.Property(e => e.CrncyCode)
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency1)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Cstmer);

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.Cstmer)
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("ADDRESS3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasColumnName("ADDRESS4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address5)
                    .HasColumnName("ADDRESS5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .HasColumnName("CELL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsgneeId)
                    .IsRequired()
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contact)
                    .HasColumnName("CONTACT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Landline)
                    .HasColumnName("LANDLINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerBalances>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer Balances");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Difference)
                    .HasColumnName("DIFFERENCE")
                    .HasColumnType("money");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<CustomerReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer Reconciliation");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Difference)
                    .HasColumnName("DIFFERENCE")
                    .HasColumnType("money");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<CustomerRemitValue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer Remit Value");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TotRemit)
                    .HasColumnName("TOT_REMIT")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<CustomerRemittanceReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer Remittance Reconciliation");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<ExportSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Export Summary");

                entity.Property(e => e.BnchLineId).HasColumnName("BNCH_LINE_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpDow)
                    .IsRequired()
                    .HasColumnName("EXP_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExpWeek).HasColumnName("EXP_WEEK");

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotChgUnts).HasColumnName("TOT_CHG_UNTS");

                entity.Property(e => e.TotPkUnts).HasColumnName("TOT_PK_UNTS");
            });

            modelBuilder.Entity<Exporter>(entity =>
            {
                entity.HasKey(e => e.Exporter1);

                entity.ToTable("EXPORTER");

                entity.Property(e => e.Exporter1)
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExporterName)
                    .IsRequired()
                    .HasColumnName("EXPORTER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Exports>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Exports");

                entity.Property(e => e.BnchLineId).HasColumnName("BNCH_LINE_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepDow)
                    .IsRequired()
                    .HasColumnName("DEP_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChgUnt)
                    .HasColumnName("FRT_CHG_UNT")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.KgPkUnt).HasColumnName("KG_PK_UNT");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkDow)
                    .HasColumnName("PK_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PkWeek).HasColumnName("PK_WEEK");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightCostAndCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight Cost and Charge");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.Airline)
                    .HasColumnName("AIRLINE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChgUnt)
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CnsgneeId)
                    .IsRequired()
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeadChgUsd)
                    .HasColumnName("DEAD_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.DeadUnts).HasColumnName("DEAD_UNTS");

                entity.Property(e => e.FreightInvoice)
                    .HasColumnName("FREIGHT_INVOICE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChgUsd)
                    .HasColumnName("FRT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.FrtCstUsd)
                    .HasColumnName("FRT_CST_USD")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgBox).HasColumnName("KG_BOX");

                entity.Property(e => e.OthrChgDesc)
                    .HasColumnName("OTHR_CHG_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OthrChgUsd)
                    .HasColumnName("OTHR_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.RateUntUsd)
                    .HasColumnName("RATE_UNT_USD")
                    .HasColumnType("money");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotChgUsd)
                    .HasColumnName("TOT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightCostByAwb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight Cost by AWB");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Chg)
                    .HasColumnName("CHG")
                    .HasColumnType("money");

                entity.Property(e => e.Cst)
                    .HasColumnName("CST")
                    .HasColumnType("money");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightCostVsCharge>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight Cost vs Charge");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.Airline)
                    .HasColumnName("AIRLINE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChg)
                    .HasColumnName("FRT_CHG")
                    .HasColumnType("money");

                entity.Property(e => e.FrtCost)
                    .HasColumnName("FRT_COST")
                    .HasColumnType("money");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightFob>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight FOB");

                entity.Property(e => e.Cartons).HasColumnName("CARTONS");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Cstmer)
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChg)
                    .HasColumnName("FRT_CHG")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("money");

                entity.Property(e => e.Stems).HasColumnName("STEMS");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightInvoiceRecon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight_Invoice_Recon");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Balance)
                    .HasColumnName("BALANCE")
                    .HasColumnType("money");

                entity.Property(e => e.BookedBoxes).HasColumnName("BOOKED_BOXES");

                entity.Property(e => e.BookedKg).HasColumnName("BOOKED_KG");

                entity.Property(e => e.ChgUnt)
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CnsgneeId)
                    .IsRequired()
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeadChgUsd)
                    .HasColumnName("DEAD_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.DeadUnts).HasColumnName("DEAD_UNTS");

                entity.Property(e => e.Flight1)
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FreightInvoice)
                    .HasColumnName("FREIGHT_INVOICE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtCstUsd)
                    .HasColumnName("FRT_CST_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Invoice).HasColumnName("INVOICE");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgBox).HasColumnName("KG_BOX");

                entity.Property(e => e.OthrChgDesc)
                    .HasColumnName("OTHR_CHG_DESC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OthrChgUsd)
                    .HasColumnName("OTHR_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.RateUntUsd)
                    .HasColumnName("RATE_UNT_USD")
                    .HasColumnType("money");

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Routing)
                    .HasColumnName("ROUTING")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.TotFrtChg)
                    .HasColumnName("TOT_FRT_CHG")
                    .HasColumnType("money");

                entity.Property(e => e.TotFrtRmt)
                    .HasColumnName("TOT_FRT_RMT")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightRemittanceTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight_Remittance_Total");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitTotal)
                    .HasColumnName("REMIT_TOTAL")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<FreightRemittances>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight Remittances");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmrRemitno)
                    .HasColumnName("CSTMR_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FreightSalesDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Freight Sales Details");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight1)
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FreightInvoice)
                    .HasColumnName("FREIGHT_INVOICE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChgUsd)
                    .HasColumnName("FRT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FrtCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FRT Check");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.ChgUnt)
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChgUsd)
                    .HasColumnName("FRT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Invoice).HasColumnName("INVOICE");

                entity.Property(e => e.KgBox).HasColumnName("KG_BOX");

                entity.Property(e => e.RateUntUsd)
                    .HasColumnName("RATE_UNT_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<FrtRates>(entity =>
            {
                entity.HasKey(e => e.RateId);

                entity.ToTable("FRT_RATES");

                entity.Property(e => e.RateId).HasColumnName("RATE_ID");

                entity.Property(e => e.DepDow)
                    .IsRequired()
                    .HasColumnName("DEP_DOW")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DestCode)
                    .IsRequired()
                    .HasColumnName("DEST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight1)
                    .IsRequired()
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight2)
                    .IsRequired()
                    .HasColumnName("FLIGHT2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight3)
                    .IsRequired()
                    .HasColumnName("FLIGHT3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtRateCode1)
                    .IsRequired()
                    .HasColumnName("FRT_RATE_CODE1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtRateCode2)
                    .IsRequired()
                    .HasColumnName("FRT_RATE_CODE2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RateUsdKg)
                    .IsRequired()
                    .HasColumnName("RATE_USD_KG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Routing)
                    .IsRequired()
                    .HasColumnName("ROUTING")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SdryUsdKg)
                    .IsRequired()
                    .HasColumnName("SDRY_USD_KG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FrtRatesFob>(entity =>
            {
                entity.HasKey(e => e.Cstmer);

                entity.ToTable("FRT_RATES_FOB");

                entity.Property(e => e.Cstmer)
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("smallmoney");
            });

            modelBuilder.Entity<FrtRemit>(entity =>
            {
                entity.HasKey(e => e.RemitNo);

                entity.ToTable("FRT_REMIT");

                entity.Property(e => e.RemitNo).HasColumnName("REMIT_NO");

                entity.Property(e => e.CstmrRemitno)
                    .HasColumnName("CSTMR_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrtChgUnt)
                    .HasColumnName("FRT_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoStems).HasColumnName("NO_STEMS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StemsCarton).HasColumnName("STEMS_CARTON");

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InvoiceBoe>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice_BOE");

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice Check");

                entity.Property(e => e.CrncyChg)
                    .HasColumnName("CRNCY_CHG")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Invoice).HasColumnName("INVOICE");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceCnDnRecon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice CN DN Recon");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceDetail");

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceReconByLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice_Recon_by_Line");

                entity.Property(e => e.BalVal)
                    .HasColumnName("BAL_VAL")
                    .HasColumnType("money");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrValue)
                    .HasColumnName("CR_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RmtAmt)
                    .HasColumnName("RMT_AMT")
                    .HasColumnType("money");

                entity.Property(e => e.RmtValue)
                    .HasColumnName("RMT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotChgUnt).HasColumnName("TOT_CHG_UNT");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice Reconciliation");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnNo).HasColumnName("CN_NO");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kg).HasColumnName("KG");

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitNo).HasColumnName("REMIT_NO");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsdValue)
                    .HasColumnName("USD_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceRemitCn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice_Remit_CN");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Invoice)
                    .HasColumnName("INVOICE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice Summary");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoStems).HasColumnName("NO_STEMS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InvoiceValueByCustomerByDate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice Value by Customer by Date");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvDnVal)
                    .HasColumnName("INV_DN_VAL")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<InvoiceValues>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Invoice Values");

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue)
                    .HasColumnName("CRNCY_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LinesFreight>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Lines Freight");

                entity.Property(e => e.BnchLineId).HasColumnName("BNCH_LINE_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgPkUnt).HasColumnName("KG_PK_UNT");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrdId)
                    .IsRequired()
                    .HasColumnName("PRD_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("smallmoney");
            });

            modelBuilder.Entity<PdFreightInvoiceRecon>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PD_Freight_Invoice_Recon");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Cstmer)
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmrRemitno)
                    .HasColumnName("CSTMR_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FrtChg)
                    .HasColumnName("FRT_CHG")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<PdFrtRemit>(entity =>
            {
                entity.HasKey(e => e.RemitNo);

                entity.ToTable("PD_FRT_REMIT");

                entity.Property(e => e.RemitNo).HasColumnName("REMIT_NO");

                entity.Property(e => e.CstmrRemitno)
                    .HasColumnName("CSTMR_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasColumnName("RECEIPT_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<PkgCtn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PKG_CTN");

                entity.Property(e => e.CtnId1)
                    .HasColumnName("CTN_ID1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtnId2)
                    .HasColumnName("CTN_ID2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtnId3)
                    .HasColumnName("CTN_ID3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtnId4)
                    .HasColumnName("CTN_ID4")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtnId5)
                    .HasColumnName("CTN_ID5")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CtnNo1).HasColumnName("CTN_NO1");

                entity.Property(e => e.CtnNo2).HasColumnName("CTN_NO2");

                entity.Property(e => e.CtnNo3).HasColumnName("CTN_NO3");

                entity.Property(e => e.CtnNo4).HasColumnName("CTN_NO4");

                entity.Property(e => e.CtnNo5).HasColumnName("CTN_NO5");

                entity.Property(e => e.PkcdeId).HasColumnName("PKCDE_ID");
            });

            modelBuilder.Entity<PkgLbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PKG_LBL");

                entity.Property(e => e.LblId1)
                    .HasColumnName("LBL_ID1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId10)
                    .HasColumnName("LBL_ID10")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId2)
                    .HasColumnName("LBL_ID2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId3)
                    .HasColumnName("LBL_ID3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId4)
                    .HasColumnName("LBL_ID4")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId5)
                    .HasColumnName("LBL_ID5")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId6)
                    .HasColumnName("LBL_ID6")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId7)
                    .HasColumnName("LBL_ID7")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId8)
                    .HasColumnName("LBL_ID8")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblId9)
                    .HasColumnName("LBL_ID9")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LblNo1).HasColumnName("LBL_NO1");

                entity.Property(e => e.LblNo10).HasColumnName("LBL_NO10");

                entity.Property(e => e.LblNo2).HasColumnName("LBL_NO2");

                entity.Property(e => e.LblNo3).HasColumnName("LBL_NO3");

                entity.Property(e => e.LblNo4).HasColumnName("LBL_NO4");

                entity.Property(e => e.LblNo5).HasColumnName("LBL_NO5");

                entity.Property(e => e.LblNo6).HasColumnName("LBL_NO6");

                entity.Property(e => e.LblNo7).HasColumnName("LBL_NO7");

                entity.Property(e => e.LblNo8).HasColumnName("LBL_NO8");

                entity.Property(e => e.LblNo9).HasColumnName("LBL_NO9");

                entity.Property(e => e.PkcdeId).HasColumnName("PKCDE_ID");
            });

            modelBuilder.Entity<PkgMsc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PKG_MSC");

                entity.Property(e => e.MscId1)
                    .HasColumnName("MSC_ID1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MscId2)
                    .HasColumnName("MSC_ID2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MscId3)
                    .HasColumnName("MSC_ID3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MscId4)
                    .HasColumnName("MSC_ID4")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MscId5)
                    .HasColumnName("MSC_ID5")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MscNo1).HasColumnName("MSC_NO1");

                entity.Property(e => e.MscNo2).HasColumnName("MSC_NO2");

                entity.Property(e => e.MscNo3).HasColumnName("MSC_NO3");

                entity.Property(e => e.MscNo4).HasColumnName("MSC_NO4");

                entity.Property(e => e.MscNo5).HasColumnName("MSC_NO5");

                entity.Property(e => e.PkcdeId).HasColumnName("PKCDE_ID");
            });

            modelBuilder.Entity<PkgPak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PKG_PAK");

                entity.Property(e => e.PakId1)
                    .HasColumnName("PAK_ID1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PakId2)
                    .HasColumnName("PAK_ID2")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PakId3)
                    .HasColumnName("PAK_ID3")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PakId4)
                    .HasColumnName("PAK_ID4")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PakId5)
                    .HasColumnName("PAK_ID5")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PakNo1).HasColumnName("PAK_NO1");

                entity.Property(e => e.PakNo2).HasColumnName("PAK_NO2");

                entity.Property(e => e.PakNo3).HasColumnName("PAK_NO3");

                entity.Property(e => e.PakNo4).HasColumnName("PAK_NO4");

                entity.Property(e => e.PakNo5).HasColumnName("PAK_NO5");

                entity.Property(e => e.PkcdeId).HasColumnName("PKCDE_ID");
            });

            modelBuilder.Entity<PlgCustomerReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PLG Customer Reconciliation");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Difference)
                    .HasColumnName("DIFFERENCE")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("numeric(38, 5)");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<PlgCustomerReconciliationB>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PLG_Customer Reconciliation B");

                entity.Property(e => e.CnValue).HasColumnName("CN_VALUE");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("numeric(38, 4)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<PlgInvoiceReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PLG Invoice Reconciliation");

                entity.Property(e => e.BalValue)
                    .HasColumnName("BAL_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnNo).HasColumnName("CN_NO");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitNo).HasColumnName("REMIT_NO");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsdValue)
                    .HasColumnName("USD_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<PlgInvoiceReconciliationB>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PLG_Invoice Reconciliation B");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnNo).HasColumnName("CN_NO");

                entity.Property(e => e.CnValue).HasColumnName("CN_VALUE");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("numeric(20, 4)");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.InvDnValue)
                    .HasColumnName("INV_DN_VALUE")
                    .HasColumnType("numeric(31, 4)");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoChgUnts).HasColumnName("NO_CHG_UNTS");

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsdValue)
                    .HasColumnName("USD_VALUE")
                    .HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<PrdLines>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("PRD_LINES");

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.BnchLineId).HasColumnName("BNCH_LINE_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgPkUnt).HasColumnName("KG_PK_UNT");

                entity.Property(e => e.PkRate).HasColumnName("PK_RATE");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrdId)
                    .IsRequired()
                    .HasColumnName("PRD_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Prd)
                    .WithMany(p => p.PrdLines)
                    .HasForeignKey(d => d.PrdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRD_LINES_PRODUCT");
            });

            modelBuilder.Entity<ProdFrcst>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROD_FRCST");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrnhseId)
                    .IsRequired()
                    .HasColumnName("GRNHSE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hectares).HasColumnName("HECTARES");

                entity.Property(e => e.StemFcst).HasColumnName("STEM_FCST");

                entity.Property(e => e.Stems).HasColumnName("STEMS");

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PrdId);

                entity.ToTable("PRODUCT");

                entity.Property(e => e.PrdId)
                    .HasColumnName("PRD_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Remittances>(entity =>
            {
                entity.HasKey(e => e.RemitNo);

                entity.ToTable("REMITTANCES");

                entity.Property(e => e.RemitNo).HasColumnName("REMIT_NO");

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasColumnName("NARRATION")
                    .HasMaxLength(50);

                entity.Property(e => e.RemitAmnt)
                    .HasColumnName("REMIT_AMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.HasOne(d => d.Trans)
                    .WithMany(p => p.Remittances)
                    .HasForeignKey(d => d.TransId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_REMITTANCES_CNS_LINES");
            });

            modelBuilder.Entity<RoseExports>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Rose-Exports");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue).HasColumnName("CRNCY_VALUE");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.NetCrncyValue).HasColumnName("NET_CRNCY_VALUE");

                entity.Property(e => e.NetUsdValue).HasColumnName("NET_USD_VALUE");

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalStems).HasColumnName("TOTAL_STEMS");

                entity.Property(e => e.UsdVal).HasColumnName("USD_VAL");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<SalesByLineByCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Sales by Line by Customer");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChgUntPkUnt).HasColumnName("CHG_UNT_PK_UNT");

                entity.Property(e => e.CifCrncyChgUnt)
                    .HasColumnName("CIF_CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CnTotalStems).HasColumnName("CN_TOTAL_STEMS");

                entity.Property(e => e.CnValue)
                    .HasColumnName("CN_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.CnsmentId).HasColumnName("CNSMENT_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasColumnName("COLOUR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CrncyChgUnt)
                    .HasColumnName("CRNCY_CHG_UNT")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CrncyValue).HasColumnName("CRNCY_VALUE");

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cultivar)
                    .IsRequired()
                    .HasColumnName("CULTIVAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgNet).HasColumnName("KG_NET");

                entity.Property(e => e.KgPkUnt).HasColumnName("KG_PK_UNT");

                entity.Property(e => e.NetCrncyValue).HasColumnName("NET_CRNCY_VALUE");

                entity.Property(e => e.NetStems).HasColumnName("NET_STEMS");

                entity.Property(e => e.NetUsdValue).HasColumnName("NET_USD_VALUE");

                entity.Property(e => e.NoCartons).HasColumnName("NO_CARTONS");

                entity.Property(e => e.NoPkUnts).HasColumnName("NO_PK_UNTS");

                entity.Property(e => e.PkUnt)
                    .IsRequired()
                    .HasColumnName("PK_UNT")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrdId)
                    .IsRequired()
                    .HasColumnName("PRD_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RateCrncyStem)
                    .HasColumnName("RATE_CRNCY_STEM")
                    .HasColumnType("smallmoney");

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierId)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TotalStems).HasColumnName("TOTAL_STEMS");

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.TransType)
                    .IsRequired()
                    .HasColumnName("TRANS_TYPE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsdVal).HasColumnName("USD_VAL");

                entity.Property(e => e.Week).HasColumnName("WEEK");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesFrcst>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("SALES_FRCST");

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.ChgUnt)
                    .IsRequired()
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId).HasColumnName("LINE_ID");

                entity.Property(e => e.NoChgUnt).HasColumnName("NO_CHG_UNT");

                entity.Property(e => e.PrdId)
                    .IsRequired()
                    .HasColumnName("PRD_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLine)
                    .IsRequired()
                    .HasColumnName("PRODUCT_LINE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<SalesWeeks>(entity =>
            {
                entity.HasKey(e => e.DateId);

                entity.ToTable("SALES_WEEKS");

                entity.Property(e => e.DateId).HasColumnName("DATE_ID");

                entity.Property(e => e.Daydate)
                    .HasColumnName("DAYDATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<ShipCnsmentDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Ship_Cnsment_Detail");

                entity.Property(e => e.ActBoxes).HasColumnName("ACT_BOXES");

                entity.Property(e => e.ActKg).HasColumnName("ACT_KG");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BoeNo)
                    .HasColumnName("BOE_NO")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.BookedBoxes).HasColumnName("BOOKED_BOXES");

                entity.Property(e => e.BookedKg).HasColumnName("BOOKED_KG");

                entity.Property(e => e.ChgUnt)
                    .HasColumnName("CHG_UNT")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CnsgneeId)
                    .IsRequired()
                    .HasColumnName("CNSGNEE_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasColumnName("CURRENCY")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeadChgUsd)
                    .HasColumnName("DEAD_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.DeadUnts).HasColumnName("DEAD_UNTS");

                entity.Property(e => e.DestCode)
                    .HasColumnName("DEST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Exporter)
                    .IsRequired()
                    .HasColumnName("EXPORTER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ForexUsdRate)
                    .HasColumnName("FOREX_USD_RATE")
                    .HasColumnType("money");

                entity.Property(e => e.FrtChgUsd)
                    .HasColumnName("FRT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KgActual).HasColumnName("KG_ACTUAL");

                entity.Property(e => e.KgBooked).HasColumnName("KG_BOOKED");

                entity.Property(e => e.KgBox).HasColumnName("KG_BOX");

                entity.Property(e => e.KgCharged).HasColumnName("KG_CHARGED");

                entity.Property(e => e.OtherUsdKg)
                    .HasColumnName("OTHER_USD_KG")
                    .HasColumnType("money");

                entity.Property(e => e.OtherUsdShpmnt)
                    .HasColumnName("OTHER_USD_SHPMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RateUntUsd)
                    .HasColumnName("RATE_UNT_USD")
                    .HasColumnType("money");

                entity.Property(e => e.RateUsdKg)
                    .HasColumnName("RATE_USD_KG")
                    .HasColumnType("money");

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipDow)
                    .HasColumnName("SHIP_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.TotChgUsd)
                    .HasColumnName("TOT_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.TotalChgUsd)
                    .HasColumnName("TOTAL_CHG_USD")
                    .HasColumnType("money");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.HasKey(e => e.ShipId);

                entity.ToTable("SHIPMENT");

                entity.Property(e => e.ShipId).HasColumnName("SHIP_ID");

                entity.Property(e => e.AwbNo)
                    .HasColumnName("AWB_NO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Container1)
                    .HasColumnName("CONTAINER1")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Container2)
                    .HasColumnName("CONTAINER2")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Container3)
                    .HasColumnName("CONTAINER3")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Container4)
                    .HasColumnName("CONTAINER4")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.Container5)
                    .HasColumnName("CONTAINER5")
                    .HasMaxLength(15)
                    .IsFixedLength();

                entity.Property(e => e.DestCode)
                    .HasColumnName("DEST_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Flight1)
                    .HasColumnName("FLIGHT1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Flight2)
                    .HasColumnName("FLIGHT2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Flight3)
                    .HasColumnName("FLIGHT3")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.KgActual).HasColumnName("KG_ACTUAL");

                entity.Property(e => e.KgBooked).HasColumnName("KG_BOOKED");

                entity.Property(e => e.KgCharged).HasColumnName("KG_CHARGED");

                entity.Property(e => e.OtherUsdKg)
                    .HasColumnName("OTHER_USD_KG")
                    .HasColumnType("money");

                entity.Property(e => e.OtherUsdShpmnt)
                    .HasColumnName("OTHER_USD_SHPMNT")
                    .HasColumnType("money");

                entity.Property(e => e.RateCode)
                    .HasColumnName("RATE_CODE")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RateUsdKg)
                    .HasColumnName("RATE_USD_KG")
                    .HasColumnType("money");

                entity.Property(e => e.Routing)
                    .HasColumnName("ROUTING")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.ShipDate)
                    .HasColumnName("SHIP_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipDow)
                    .HasColumnName("SHIP_DOW")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sundry2)
                    .HasColumnName("SUNDRY2")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TotalChgUsd)
                    .HasColumnName("TOTAL_CHG_USD")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<StkCtn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STK_CTN");

                entity.Property(e => e.CtnId)
                    .IsRequired()
                    .HasColumnName("CTN_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StkLbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STK_LBL");

                entity.Property(e => e.LblId)
                    .IsRequired()
                    .HasColumnName("LBL_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StkMsc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STK_MSC");

                entity.Property(e => e.MscId)
                    .IsRequired()
                    .HasColumnName("MSC_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<StkPak>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STK_PAK");

                entity.Property(e => e.BalNo).HasColumnName("BAL_NO");

                entity.Property(e => e.BalUsd)
                    .HasColumnName("BAL_USD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DatePhys)
                    .HasColumnName("DATE_PHYS")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InNo).HasColumnName("IN_NO");

                entity.Property(e => e.InUsd)
                    .HasColumnName("IN_USD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OpnNo).HasColumnName("OPN_NO");

                entity.Property(e => e.OpnUsd)
                    .HasColumnName("OPN_USD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OutNo).HasColumnName("OUT_NO");

                entity.Property(e => e.OutUsd)
                    .HasColumnName("OUT_USD")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PakId)
                    .IsRequired()
                    .HasColumnName("PAK_ID")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Supplier)
                    .HasColumnName("SUPPLIER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.ToTable("SUPPLIER");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TranscationReconciliation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Transcation Reconciliation");

                entity.Property(e => e.CnDate)
                    .HasColumnName("CN_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CnValues)
                    .HasColumnName("CN_VALUES")
                    .HasColumnType("money");

                entity.Property(e => e.CrncyCode)
                    .IsRequired()
                    .HasColumnName("CRNCY_CODE")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cstmer)
                    .IsRequired()
                    .HasColumnName("CSTMER")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CstmerRemitno)
                    .HasColumnName("CSTMER_REMITNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvDnVal)
                    .HasColumnName("INV_DN_VAL")
                    .HasColumnType("money");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("INVOICE_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasColumnName("INVOICE_NO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitDate)
                    .HasColumnName("REMIT_DATE")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RemitValue)
                    .HasColumnName("REMIT_VALUE")
                    .HasColumnType("money");

                entity.Property(e => e.Sundry1)
                    .HasColumnName("SUNDRY1")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransId).HasColumnName("TRANS_ID");

                entity.Property(e => e.Week).HasColumnName("WEEK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
