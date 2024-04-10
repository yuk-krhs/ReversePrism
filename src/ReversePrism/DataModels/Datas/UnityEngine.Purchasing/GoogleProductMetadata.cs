using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 OriginalJson                             000186671910 ModelPrimitiveType string string string String
    // 048 SubscriptionPeriod                       000186671910 ModelPrimitiveType string string string String
    // 050 FreeTrialPeriod                          000186671910 ModelPrimitiveType string string string String
    // 058 IntroductoryPrice                        000186671910 ModelPrimitiveType string string string String
    // 060 IntroductoryPricePeriod                  000186671910 ModelPrimitiveType string string string String
    // 068 IntroductoryPriceCycles                  0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.OriginalJson                              = GetString(new IntPtr(p + 0x040)); // 0245A68CF208 0x40 OriginalJson                ( 000186671910 ModelPrimitiveType string string string String )
            value.SubscriptionPeriod                        = GetString(new IntPtr(p + 0x048)); // 0245A68CF228 0x48 SubscriptionPeriod          ( 000186671910 ModelPrimitiveType string string string String )
            value.FreeTrialPeriod                           = GetString(new IntPtr(p + 0x050)); // 0245A68CF248 0x50 FreeTrialPeriod             ( 000186671910 ModelPrimitiveType string string string String )
            value.IntroductoryPrice                         = GetString(new IntPtr(p + 0x058)); // 0245A68CF268 0x58 IntroductoryPrice           ( 000186671910 ModelPrimitiveType string string string String )
            value.IntroductoryPricePeriod                   = GetString(new IntPtr(p + 0x060)); // 0245A68CF288 0x60 IntroductoryPricePeriod     ( 000186671910 ModelPrimitiveType string string string String )
            value.IntroductoryPriceCycles                   = GetInt32(new IntPtr(p + 0x068)); // 0245A68CF2A8 0x68 IntroductoryPriceCycles     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
