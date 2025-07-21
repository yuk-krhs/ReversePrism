using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 m_encoding                               UnicodeEncoding IL2CPP_TYPE_CLASS
    // 030 Sb                                       ModelClassType StringBuilder StringBuilder StringBuilder Pointer
    // 038 IsOpen                                   ModelPrimitiveType bool bool bool Bool
    public partial class StringWriter : DataModel
    {
        public StringBuilder?                           Sb                                      { get; set; }
        public bool                                     IsOpen                                  { get; set; }

        public static StringWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringWriter() { Pointer= p0 };

            value.Sb                                        = GetObject<StringBuilder>(new IntPtr(p + 0x030), ReversePrism.DataModels.StringBuilder.FromPointer); // 0x30 Sb                          ( ModelClassType StringBuilder StringBuilder StringBuilder Pointer )
            value.IsOpen                                    = GetBool(new IntPtr(p + 0x038)); // 0x38 IsOpen                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
