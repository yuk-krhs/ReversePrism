using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SheetName                                ModelPrimitiveType string string string String
    // 018 CueName                                  ModelPrimitiveType string string string String
    public partial class SoundKey : DataModel
    {
        public string                                   SheetName                               { get; set; }
        public string                                   CueName                                 { get; set; }

        public static SoundKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SoundKey() { Pointer= p0 };

            value.SheetName                                 = GetString(new IntPtr(p + 0x010)); // 0x10 SheetName                   ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x018)); // 0x18 CueName                     ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
