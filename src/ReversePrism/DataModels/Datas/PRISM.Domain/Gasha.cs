using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 GashaId                                  ModelPrimitiveType string string string String
    // 018 GashaContentsType                        ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32
    // 020 BeginDate                                ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 030 EndDate                                  ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 040 PriceList                                ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer
    // 048 BannerUrl                                ModelPrimitiveType string string string String
    // 050 Caution                                  ModelPrimitiveType string string string String
    // 058 ResourceId                               ModelPrimitiveType string string string String
    // 060 IsPickup                                 ModelPrimitiveType bool bool bool Bool
    // 064 SortId                                   ModelPrimitiveType int int int Int32
    // 068 IsBonus                                  ModelPrimitiveType bool bool bool Bool
    // 070 PrismGaugeId                             ModelPrimitiveType string string string String
    // 078 GashaExchangeId                          ModelPrimitiveType string string string String
    // 080 StepList                                 ModelClassListType IReadOnlyList`1<IGashaStepStatus> IReadOnlyList`1<IGashaStepStatus> List<IGashaStepStatus> Pointer
    // 088 IsCompensation                           ModelPrimitiveType bool bool bool Bool
    // 090 DetailIdList                             ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer
    // 098 GashaExchanges                           ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer
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

            value.GashaId                                   = GetString(new IntPtr(p + 0x010)); // 0x10 GashaId                     ( ModelPrimitiveType string string string String )
            value.GashaContentsType                         = (GashaContentsType)GetInt32(new IntPtr(p + 0x018)); // 0x18 GashaContentsType           ( ModelEnumType GashaContentsType GashaContentsType GashaContentsType Int32 )
            value.BeginDate                                 = GetDateTime(new IntPtr(p + 0x020)); // 0x20 BeginDate                   ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.EndDate                                   = GetDateTime(new IntPtr(p + 0x030)); // 0x30 EndDate                     ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.PriceList                                 = GetObjectList<IGashaPriceStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IGashaPriceStatus.FromPointer); // 0x40 PriceList                   ( ModelClassListType IReadOnlyList`1<IGashaPriceStatus> IReadOnlyList`1<IGashaPriceStatus> List<IGashaPriceStatus> Pointer )
            value.BannerUrl                                 = GetString(new IntPtr(p + 0x048)); // 0x48 BannerUrl                   ( ModelPrimitiveType string string string String )
            value.Caution                                   = GetString(new IntPtr(p + 0x050)); // 0x50 Caution                     ( ModelPrimitiveType string string string String )
            value.ResourceId                                = GetString(new IntPtr(p + 0x058)); // 0x58 ResourceId                  ( ModelPrimitiveType string string string String )
            value.IsPickup                                  = GetBool(new IntPtr(p + 0x060)); // 0x60 IsPickup                    ( ModelPrimitiveType bool bool bool Bool )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x064)); // 0x64 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.IsBonus                                   = GetBool(new IntPtr(p + 0x068)); // 0x68 IsBonus                     ( ModelPrimitiveType bool bool bool Bool )
            value.PrismGaugeId                              = GetString(new IntPtr(p + 0x070)); // 0x70 PrismGaugeId                ( ModelPrimitiveType string string string String )
            value.GashaExchangeId                           = GetString(new IntPtr(p + 0x078)); // 0x78 GashaExchangeId             ( ModelPrimitiveType string string string String )
            value.StepList                                  = GetObjectList<IGashaStepStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IGashaStepStatus.FromPointer); // 0x80 StepList                    ( ModelClassListType IReadOnlyList`1<IGashaStepStatus> IReadOnlyList`1<IGashaStepStatus> List<IGashaStepStatus> Pointer )
            value.IsCompensation                            = GetBool(new IntPtr(p + 0x088)); // 0x88 IsCompensation              ( ModelPrimitiveType bool bool bool Bool )
            value.DetailIdList                              = GetStringList(new IntPtr(p + 0x090)); // 0x90 DetailIdList                ( ModelPrimitiveListType IReadOnlyList`1<string> IReadOnlyList`1<string> List<string> Pointer )
            value.GashaExchanges                            = GetObjectList<GashaExchange>(new IntPtr(p + 0x098), ReversePrism.DataModels.GashaExchange.FromPointer); // 0x98 GashaExchanges              ( ModelClassListType List`1<GashaExchange> List`1<GashaExchange> List<GashaExchange> Pointer )

            return value;
        }
    }
}
