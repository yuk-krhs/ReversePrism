using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IncludeInSchema                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 Ns                                       000186671910 ModelPrimitiveType string string string String
    // 020 TypeName                                 000186671910 ModelPrimitiveType string string string String
    public partial class XmlTypeAttribute : DataModel
    {
        public bool                                     IncludeInSchema                         { get; set; }
        public string                                   Ns                                      { get; set; }
        public string                                   TypeName                                { get; set; }

        public static XmlTypeAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlTypeAttribute() { Pointer= p0 };

            value.IncludeInSchema                           = GetBool(new IntPtr(p + 0x010)); // 0246675186E0 0x10 IncludeInSchema             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Ns                                        = GetString(new IntPtr(p + 0x018)); // 024667518700 0x18 Ns                          ( 000186671910 ModelPrimitiveType string string string String )
            value.TypeName                                  = GetString(new IntPtr(p + 0x020)); // 024667518720 0x20 TypeName                    ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
