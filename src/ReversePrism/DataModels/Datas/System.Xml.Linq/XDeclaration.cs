using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Version                                  ModelPrimitiveType string string string String
    // 018 Encoding                                 ModelPrimitiveType string string string String
    // 020 Standalone                               ModelPrimitiveType string string string String
    public partial class XDeclaration : DataModel
    {
        public string                                   Version                                 { get; set; }
        public string                                   Encoding                                { get; set; }
        public string                                   Standalone                              { get; set; }

        public static XDeclaration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XDeclaration() { Pointer= p0 };

            value.Version                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Version                     ( ModelPrimitiveType string string string String )
            value.Encoding                                  = GetString(new IntPtr(p + 0x018)); // 0x18 Encoding                    ( ModelPrimitiveType string string string String )
            value.Standalone                                = GetString(new IntPtr(p + 0x020)); // 0x20 Standalone                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
