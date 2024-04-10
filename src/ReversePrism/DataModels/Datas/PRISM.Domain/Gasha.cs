using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GashaId                                  000186671910 ModelPrimitiveType string string string String
    // 018 GashaContentsType                        0001865F7620 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 020 BeginDate                                000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 EndDate                                  000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 PriceList                                000185CFA668 ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer
    // 048 BannerUrl                                000186671910 ModelPrimitiveType string string string String
    // 050 Caution                                  000186671910 ModelPrimitiveType string string string String
    // 058 ResourceId                               000186671910 ModelPrimitiveType string string string String
    // 060 IsPickup                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 064 SortId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 068 IsBonus                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 PrismGaugeId                             000186671910 ModelPrimitiveType string string string String
    // 078 GashaExchangeId                          000186671910 ModelPrimitiveType string string string String
    // 080 StepList                                 000185CFB9A8 ModelClassListType IReadOnlyList`1<IGashaStepStatus> IReadOnlyList`1<IGashaStepStatus> List<IGashaStepStatus> Pointer
    // 088 IsCompensation                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 090 DetailIdList                             000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 098 GashaExchanges                           000185CDDC58 ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer
    public partial class Gasha : DataModel
    {
        public string                                   GashaId                                 { get; set; }
        public GashaContentsType                        GashaContentsType                       { get; set; }
        public DateTime                                 BeginDate                               { get; set; }
        public DateTime                                 EndDate                                 { get; set; }
        public List<IGashaPriceStatus>?                 PriceList                               { get; set; }
        public string                                   BannerUrl                               { get; set; }
        public string                                   Caution                                 { get; set; }
        public string                                   ResourceId                              { get; set; }
        public bool                                     IsPickup                                { get; set; }
        public int                                      SortId                                  { get; set; }
        public bool                                     IsBonus                                 { get; set; }
        public string                                   PrismGaugeId                            { get; set; }
        public string                                   GashaExchangeId                         { get; set; }
        public List<IGashaStepStatus>?                  StepList                                { get; set; }
        public bool                                     IsCompensation                          { get; set; }
        public List<string>?                            DetailIdList                            { get; set; }
        public List<GashaExchange>?                     GashaExchanges                          { get; set; }

        public static Gasha? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Gasha() { Pointer= p0 };

            value.GashaId                                   = GetString(new IntPtr(p + 0x010)); // 02466535E678 0x10 GashaId                     ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaContentsType                         = (GashaContentsType)GetInt32(new IntPtr(p + 0x018)); // 02466535E698 0x18 GashaContentsType           ( 0001865F7620 ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 02466535E6B8 0x20 BeginDate                   ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x030)); // 02466535E6D8 0x30 EndDate                     ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PriceList                                 = GetObjectList<IGashaPriceStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGashaPriceStatus.FromPointer); // 02466535E6F8 0x40 PriceList                   ( 000185CFA668 ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x048)); // 02466535E718 0x48 BannerUrl                   ( 000186671910 ModelPrimitiveType string string string String )
            value.Caution                                   = GetString(new IntPtr(p + 0x050)); // 02466535E738 0x50 Caution                     ( 000186671910 ModelPrimitiveType string string string String )
            value.ResourceId                                = GetString(new IntPtr(p + 0x058)); // 02466535E758 0x58 ResourceId                  ( 000186671910 ModelPrimitiveType string string string String )
            value.IsPickup                                  = GetBool(new IntPtr(p + 0x060)); // 02466535E778 0x60 IsPickup                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x064)); // 02466535E798 0x64 SortId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IsBonus                                   = GetBool(new IntPtr(p + 0x068)); // 02466535E7B8 0x68 IsBonus                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x070)); // 02466535E7D8 0x70 PrismGaugeId                ( 000186671910 ModelPrimitiveType string string string String )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x078)); // 02466535E7F8 0x78 GashaExchangeId             ( 000186671910 ModelPrimitiveType string string string String )
            value.StepList                                  = GetObjectList<IGashaStepStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IGashaStepStatus.FromPointer); // 02466535E818 0x80 StepList                    ( 000185CFB9A8 ModelClassListType IReadOnlyList`1<IGashaStepStatus> IReadOnlyList`1<IGashaStepStatus> List<IGashaStepStatus> Pointer )
            value.IsCompensation                            = GetBool(new IntPtr(p + 0x088)); // 02466535E838 0x88 IsCompensation              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x090)); // 02466535E858 0x90 DetailIdList                ( 000185D16F48 ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.GashaExchanges                            = GetObjectList<GashaExchange>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaExchange.FromPointer); // 02466535E878 0x98 GashaExchanges              ( 000185CDDC58 ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer )

            return value;
        }
    }
}
