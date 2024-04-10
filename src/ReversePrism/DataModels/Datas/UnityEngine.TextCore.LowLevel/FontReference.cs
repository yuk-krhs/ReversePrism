using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FamilyName                               0001866722E0 ModelPrimitiveType string string string String
    // 018 StyleName                                0001866722E0 ModelPrimitiveType string string string String
    // 020 FaceIndex                                0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 FilePath                                 0001866722E0 ModelPrimitiveType string string string String
    public partial class FontReference : DataModel
    {
        public string                                   FamilyName                              { get; set; }
        public string                                   StyleName                               { get; set; }
        public int                                      FaceIndex                               { get; set; }
        public string                                   FilePath                                { get; set; }

        public static FontReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FontReference() { Pointer= p0 };

            value.FamilyName                                = GetString(new IntPtr(p + 0x010)); // 0245A2161B58 0x10 FamilyName                  ( 0001866722E0 ModelPrimitiveType string string string String )
            value.StyleName                                 = GetString(new IntPtr(p + 0x018)); // 0245A2161B78 0x18 StyleName                   ( 0001866722E0 ModelPrimitiveType string string string String )
            value.FaceIndex                                 = GetInt32(new IntPtr(p + 0x020)); // 0245A2161B98 0x20 FaceIndex                   ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.FilePath                                  = GetString(new IntPtr(p + 0x028)); // 0245A2161BB8 0x28 FilePath                    ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
