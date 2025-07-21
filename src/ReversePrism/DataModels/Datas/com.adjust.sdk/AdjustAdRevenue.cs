using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   ModelPrimitiveType string string string String
    // 018 revenue                                  Nullable`1<double> IL2CPP_TYPE_GENERICINST
    // 028 Currency                                 ModelPrimitiveType string string string String
    // 030 adImpressionsCount                       Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 038 AdRevenueNetwork                         ModelPrimitiveType string string string String
    // 040 AdRevenueUnit                            ModelPrimitiveType string string string String
    // 048 AdRevenuePlacement                       ModelPrimitiveType string string string String
    // 050 PartnerList                              ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 058 CallbackList                             ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class AdjustAdRevenue : DataModel
    {
        public string                                   Source                                  { get; set; }
        public string                                   Currency                                { get; set; }
        public string                                   AdRevenueNetwork                        { get; set; }
        public string                                   AdRevenueUnit                           { get; set; }
        public string                                   AdRevenuePlacement                      { get; set; }
        public List<string>?                            PartnerList                             { get; set; }
        public List<string>?                            CallbackList                            { get; set; }

        public static AdjustAdRevenue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AdjustAdRevenue() { Pointer= p0 };

            value.Source                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Source                      ( ModelPrimitiveType string string string String )
            value.Currency                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Currency                    ( ModelPrimitiveType string string string String )
            value.AdRevenueNetwork                          = GetString(new IntPtr(p + 0x038)); // 0x38 AdRevenueNetwork            ( ModelPrimitiveType string string string String )
            value.AdRevenueUnit                             = GetString(new IntPtr(p + 0x040)); // 0x40 AdRevenueUnit               ( ModelPrimitiveType string string string String )
            value.AdRevenuePlacement                        = GetString(new IntPtr(p + 0x048)); // 0x48 AdRevenuePlacement          ( ModelPrimitiveType string string string String )
            value.PartnerList                               = GetStringList(new IntPtr(p + 0x050)); // 0x50 PartnerList                 ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.CallbackList                              = GetStringList(new IntPtr(p + 0x058)); // 0x58 CallbackList                ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
