using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Prefix                                   000186671BA0 ModelPrimitiveType string string string String
    // 018 NamespaceUri                             000186671BA0 ModelPrimitiveType string string string String
    // 020 LocalName                                000186671BA0 ModelPrimitiveType string string string String
    // 028 Prev                                     0001865F2F90 ModelPrimitiveType int int int Int32
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

            value.Prefix                                    = GetString(new IntPtr(p + 0x010)); // 024667468498 0x10 Prefix                      ( 000186671BA0 ModelPrimitiveType string string string String )
            value.NamespaceUri                              = GetString(new IntPtr(p + 0x018)); // 0246674684B8 0x18 NamespaceUri                ( 000186671BA0 ModelPrimitiveType string string string String )
            value.LocalName                                 = GetString(new IntPtr(p + 0x020)); // 0246674684D8 0x20 LocalName                   ( 000186671BA0 ModelPrimitiveType string string string String )
            value.Prev                                      = GetInt32(new IntPtr(p + 0x028)); // 0246674684F8 0x28 Prev                        ( 0001865F2F90 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
