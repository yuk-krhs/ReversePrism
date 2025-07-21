using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_cookies                                ModelClassType CookieCollection CookieCollection CookieCollection Pointer
    // 018 M_count                                  ModelPrimitiveType int int int Int32
    // 01C M_index                                  ModelPrimitiveType int int int Int32
    // 020 M_version                                ModelPrimitiveType int int int Int32
    public partial class CookieCollectionEnumerator : DataModel
    {
        public CookieCollection?                        M_cookies                               { get; set; }
        public int                                      M_count                                 { get; set; }
        public int                                      M_index                                 { get; set; }
        public int                                      M_version                               { get; set; }

        public static CookieCollectionEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CookieCollectionEnumerator() { Pointer= p0 };

            value.M_cookies                                 = GetObject<CookieCollection>(new IntPtr(p + 0x010), ReversePrism.DataModels.CookieCollection.FromPointer); // 0x10 M_cookies                   ( ModelClassType CookieCollection CookieCollection CookieCollection Pointer )
            value.M_count                                   = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_count                     ( ModelPrimitiveType int int int Int32 )
            value.M_index                                   = GetInt32(new IntPtr(p + 0x01C)); // 0x1C M_index                     ( ModelPrimitiveType int int int Int32 )
            value.M_version                                 = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_version                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
