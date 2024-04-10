using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Speed                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 014 Delay                                    0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Sense                                    0001865F36C0 ModelPrimitiveType int int int Int32
    public partial class AutoNeckParam : DataModel
    {
        public int                                      Speed                                   { get; set; }
        public int                                      Delay                                   { get; set; }
        public int                                      Sense                                   { get; set; }

        public static AutoNeckParam? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoNeckParam() { Pointer= p0 };

            value.Speed                                     = GetInt32(new IntPtr(p + 0x010)); // 0245A6A638C8 0x10 Speed                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Delay                                     = GetInt32(new IntPtr(p + 0x014)); // 0245A6A638E8 0x14 Delay                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Sense                                     = GetInt32(new IntPtr(p + 0x018)); // 0245A6A63908 0x18 Sense                       ( 0001865F36C0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
