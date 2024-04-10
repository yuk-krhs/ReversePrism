using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HomeReply                                000186675B20 ModelClassType ITmpGetHomeReply ITmpGetHomeReply ITmpGetHomeReply Pointer
    // 018 CacheDateTime                            000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 IsCutSceneDone                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class HomeCashe : DataModel
    {
        public ITmpGetHomeReply?                        HomeReply                               { get; set; }
        public DateTime                                 CacheDateTime                           { get; set; }
        public bool                                     IsCutSceneDone                          { get; set; }

        public static HomeCashe? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HomeCashe() { Pointer= p0 };

            value.HomeReply                                 = GetObject<ITmpGetHomeReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITmpGetHomeReply.FromPointer); // 0245A4ADEBC8 0x10 HomeReply                   ( 000186675B20 ModelClassType ITmpGetHomeReply ITmpGetHomeReply ITmpGetHomeReply Pointer )
            value.CacheDateTime                             = GetDateTime(new IntPtr(p + 0x018)); // 0245A4ADEBE8 0x18 CacheDateTime               ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsCutSceneDone                            = GetBool(new IntPtr(p + 0x028)); // 0245A4ADEC08 0x28 IsCutSceneDone              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
