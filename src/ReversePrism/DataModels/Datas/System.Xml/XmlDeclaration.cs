using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Version                                  ModelPrimitiveType string string string String
    // 028 Encoding                                 ModelPrimitiveType string string string String
    // 030 Standalone                               ModelPrimitiveType string string string String
    public partial class XmlDeclaration : DataModel
    {
        public string                                   Version                                 { get; set; }
        public string                                   Encoding                                { get; set; }
        public string                                   Standalone                              { get; set; }

        public static XmlDeclaration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlDeclaration() { Pointer= p0 };

            value.Version                                   = GetString(new IntPtr(p + 0x020)); // 0x20 Version                     ( ModelPrimitiveType string string string String )
            value.Encoding                                  = GetString(new IntPtr(p + 0x028)); // 0x28 Encoding                    ( ModelPrimitiveType string string string String )
            value.Standalone                                = GetString(new IntPtr(p + 0x030)); // 0x30 Standalone                  ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
