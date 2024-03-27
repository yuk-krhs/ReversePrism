using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 StartIndex                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Length                                   0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Text                                     0001866722E0 ModelPrimitiveType string string string String
    // 020 Link                                     0001866722E0 ModelPrimitiveType string string string String
    public partial class Attribute
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
            var value   = new Attribute();

            value.StartIndex                                = GetInt32(new IntPtr(p + 0x010)); // 0270D4B1B678 0x10 StartIndex                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x014)); // 0270D4B1B698 0x14 Length                      ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Text                                      = GetString(new IntPtr(p + 0x018)); // 0270D4B1B6B8 0x18 Text                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Link                                      = GetString(new IntPtr(p + 0x020)); // 0270D4B1B6D8 0x20 Link                        ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
