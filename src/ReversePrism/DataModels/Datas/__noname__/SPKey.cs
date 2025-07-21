using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Uri                                      ModelClassType Uri Uri Uri Pointer
    // 018 Proxy                                    ModelClassType Uri Uri Uri Pointer
    // 020 Use_connect                              ModelPrimitiveType bool bool bool Bool
    public partial class SPKey : DataModel
    {
        public Uri?                                     Uri                                     { get; set; }
        public Uri?                                     Proxy                                   { get; set; }
        public bool                                     Use_connect                             { get; set; }

        public static SPKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SPKey() { Pointer= p0 };

            value.Uri                                       = GetObject<Uri>(new IntPtr(p + 0x010), ReversePrism.DataModels.Uri.FromPointer); // 0x10 Uri                         ( ModelClassType Uri Uri Uri Pointer )
            value.Proxy                                     = GetObject<Uri>(new IntPtr(p + 0x018), ReversePrism.DataModels.Uri.FromPointer); // 0x18 Proxy                       ( ModelClassType Uri Uri Uri Pointer )
            value.Use_connect                               = GetBool(new IntPtr(p + 0x020)); // 0x20 Use_connect                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
