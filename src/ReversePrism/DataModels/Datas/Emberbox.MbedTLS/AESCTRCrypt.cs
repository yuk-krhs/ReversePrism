using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ctx                                      <int> IL2CPP_TYPE_I
    // 018 Keybits                                  0001865F4260 ModelPrimitiveType int int int Int32
    public partial class AESCTRCrypt : DataModel
    {
        public int                                      Keybits                                 { get; set; }

        public static AESCTRCrypt? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AESCTRCrypt() { Pointer= p0 };

            value.Keybits                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A3E1CD30 0x18 Keybits                     ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
