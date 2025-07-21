using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartIndex                               ModelPrimitiveType int int int Int32
    // 014 Length                                   ModelPrimitiveType int int int Int32
    // 018 Text                                     ModelPrimitiveType string string string String
    // 020 Link                                     ModelPrimitiveType string string string String
    public partial class Attribute : DataModel
    {
        public int                                      StartIndex                              { get; set; }
        public int                                      Length                                  { get; set; }
        public string                                   Text                                    { get; set; }
        public string                                   Link                                    { get; set; }

        public static Attribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Attribute() { Pointer= p0 };

            value.StartIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0x10 StartIndex                  ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0x14 Length                      ( ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Text                        ( ModelPrimitiveType string string string String )
            value.Link                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Link                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
