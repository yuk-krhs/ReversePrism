using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C91E0 ModelEnumType int3 int3 int3 Int32
    // 01C C1                                       0001866C91E0 ModelEnumType int3 int3 int3 Int32
    // 028 C2                                       0001866C91E0 ModelEnumType int3 int3 int3 Int32
    // 000 identity                                 int3x3 IL2CPP_TYPE_VALUETYPE
    // 024 Zero                                     0001865F0A10 ModelEnumType int3x3 int3x3 int3x3 Int32
    public partial class int3x3 : DataModel
    {
        public int3                                     C0                                      { get; set; }
        public int3                                     C1                                      { get; set; }
        public int3                                     C2                                      { get; set; }
        public int3x3                                   Zero                                    { get; set; }

        public static int3x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int3x3() { Pointer= p0 };

            value.C0                                        = (int3)GetInt32(new IntPtr(p + 0x010)); // 0245A15ADDD8 0x10 C0                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C1                                        = (int3)GetInt32(new IntPtr(p + 0x01C)); // 0245A15ADDF8 0x1C C1                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C2                                        = (int3)GetInt32(new IntPtr(p + 0x028)); // 0245A15ADE18 0x28 C2                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.Zero                                      = (int3x3)GetInt32(new IntPtr(p + 0x024)); // 0245A15ADE58 0x24 Zero                        ( 0001865F0A10 ModelEnumType int3x3 int3x3 int3x3 Int32 )

            return value;
        }
    }
}
