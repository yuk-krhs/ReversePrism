using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 HomeReply                                ModelClassType ITmpGetHomeReply ITmpGetHomeReply ITmpGetHomeReply Pointer
    // 018 CacheDateTime                            ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 028 IsCutSceneDone                           ModelPrimitiveType bool bool bool Bool
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

            value.HomeReply                                 = GetObject<ITmpGetHomeReply>(new IntPtr(p + 0x010), ReversePrism.DataModels.ITmpGetHomeReply.FromPointer); // 0x10 HomeReply                   ( ModelClassType ITmpGetHomeReply ITmpGetHomeReply ITmpGetHomeReply Pointer )
            value.CacheDateTime                             = GetDateTime(new IntPtr(p + 0x018)); // 0x18 CacheDateTime               ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.IsCutSceneDone                            = GetBool(new IntPtr(p + 0x028)); // 0x28 IsCutSceneDone              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
