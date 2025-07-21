using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 Sb                                       ModelEnumType Utf16ValueStringBuilder Utf16ValueStringBuilder Utf16ValueStringBuilder Int32
    // 040 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    // 048 Encoding                                 ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer
    public partial class ZStringWriter : DataModel
    {
        public Utf16ValueStringBuilder                  Sb                                      { get; set; }
        public bool                                     IsOpen                                  { get; set; }
        public UnicodeEncoding?                         Encoding                                { get; set; }

        public static ZStringWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ZStringWriter() { Pointer= p0 };

            value.Sb                                        = (Utf16ValueStringBuilder)GetInt32(new IntPtr(p + 0x030)); // 0x30 Sb                          ( ModelEnumType Utf16ValueStringBuilder Utf16ValueStringBuilder Utf16ValueStringBuilder Int32 )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x040)); // 0x40 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )
            value.Encoding                                  = GetObject<UnicodeEncoding>(new IntPtr(p + 0x048), ReversePrism.DataModels.UnicodeEncoding.FromPointer); // 0x48 Encoding                    ( ModelClassType UnicodeEncoding UnicodeEncoding UnicodeEncoding Pointer )

            return value;
        }
    }
}
