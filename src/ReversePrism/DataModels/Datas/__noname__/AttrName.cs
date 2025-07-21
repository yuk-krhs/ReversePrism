using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   ModelPrimitiveType string string string String
    // 018 NamespaceUri                             ModelPrimitiveType string string string String
    // 020 LocalName                                ModelPrimitiveType string string string String
    // 028 Prev                                     ModelPrimitiveType int int int Int32
    public partial class AttrName : DataModel
    {
        public string                                   Prefix                                  { get; set; }
        public string                                   NamespaceUri                            { get; set; }
        public string                                   LocalName                               { get; set; }
        public int                                      Prev                                    { get; set; }

        public static AttrName? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AttrName() { Pointer= p0 };

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Prefix                      ( ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0x18 NamespaceUri                ( ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0x20 LocalName                   ( ModelPrimitiveType string string string String )
            value.Prev                                      = GetInt32(new IntPtr(p + 0x028)); // 0x28 Prev                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
