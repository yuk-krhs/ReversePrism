using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 hexChars                                 char[] IL2CPP_TYPE_SZARRAY
    // 008 entitiesLock                             <object> IL2CPP_TYPE_OBJECT
    // 010 entities                                 SortedDictionary`2<string, char> IL2CPP_TYPE_GENERICINST
    // 018 defaultEncoder                           Lazy`1<HttpEncoder> IL2CPP_TYPE_GENERICINST
    // 020 currentEncoderLazy                       Lazy`1<HttpEncoder> IL2CPP_TYPE_GENERICINST
    // 028 CurrentEncoder                           0001866DE820 ModelClassType HttpEncoder HttpEncoder HttpEncoder Pointer
    public partial class HttpEncoder : DataModel
    {
        public HttpEncoder?                             CurrentEncoder                          { get; set; }

        public static HttpEncoder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new HttpEncoder() { Pointer= p0 };

            value.CurrentEncoder                            = GetObject<HttpEncoder>(new IntPtr(p + 0x028), ReversePrism.DataModels.HttpEncoder.FromPointer); // 024667A019E0 0x28 CurrentEncoder              ( 0001866DE820 ModelClassType HttpEncoder HttpEncoder HttpEncoder Pointer )

            return value;
        }
    }
}
