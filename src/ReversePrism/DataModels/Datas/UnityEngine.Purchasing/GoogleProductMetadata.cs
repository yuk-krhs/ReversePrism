using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 OriginalJson                             ModelPrimitiveType string string string String
    // 048 SubscriptionPeriod                       ModelPrimitiveType string string string String
    // 050 FreeTrialPeriod                          ModelPrimitiveType string string string String
    // 058 IntroductoryPrice                        ModelPrimitiveType string string string String
    // 060 IntroductoryPricePeriod                  ModelPrimitiveType string string string String
    // 068 IntroductoryPriceCycles                  ModelPrimitiveType int int int Int32
    public partial class GoogleProductMetadata : DataModel
    {
        public string                                   OriginalJson                            { get; set; }
        public string                                   SubscriptionPeriod                      { get; set; }
        public string                                   FreeTrialPeriod                         { get; set; }
        public string                                   IntroductoryPrice                       { get; set; }
        public string                                   IntroductoryPricePeriod                 { get; set; }
        public int                                      IntroductoryPriceCycles                 { get; set; }

        public static GoogleProductMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GoogleProductMetadata() { Pointer= p0 };

            value.OriginalJson                              = GetString(new IntPtr(p + 0x040)); // 0x40 OriginalJson                ( ModelPrimitiveType string string string String )
            value.SubscriptionPeriod                        = GetString(new IntPtr(p + 0x048)); // 0x48 SubscriptionPeriod          ( ModelPrimitiveType string string string String )
            value.FreeTrialPeriod                           = GetString(new IntPtr(p + 0x050)); // 0x50 FreeTrialPeriod             ( ModelPrimitiveType string string string String )
            value.IntroductoryPrice                         = GetString(new IntPtr(p + 0x058)); // 0x58 IntroductoryPrice           ( ModelPrimitiveType string string string String )
            value.IntroductoryPricePeriod                   = GetString(new IntPtr(p + 0x060)); // 0x60 IntroductoryPricePeriod     ( ModelPrimitiveType string string string String )
            value.IntroductoryPriceCycles                   = GetInt32(new IntPtr(p + 0x068)); // 0x68 IntroductoryPriceCycles     ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
