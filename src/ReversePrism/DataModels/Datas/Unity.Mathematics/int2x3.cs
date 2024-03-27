using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C88A0 ModelEnumType int2 int2 int2 Int32
    // 018 C1                                       0001866C88A0 ModelEnumType int2 int2 int2 Int32
    // 020 C2                                       0001866C88A0 ModelEnumType int2 int2 int2 Int32
    // 000 zero                                     int2x3 IL2CPP_TYPE_VALUETYPE
    public partial class int2x3
    {
        public int2                                     C0                                      { get; set; }
        public int2                                     C1                                      { get; set; }
        public int2                                     C2                                      { get; set; }

        public static int2x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int2x3();

            value.C0                                        = (int2)GetInt32(new IntPtr(p + 0x010)); // 0270D7E53338 0x10 C0                          ( 0001866C88A0 ModelEnumType int2 int2 int2 Int32 )
            value.C1                                        = (int2)GetInt32(new IntPtr(p + 0x018)); // 0270D7E53358 0x18 C1                          ( 0001866C88A0 ModelEnumType int2 int2 int2 Int32 )
            value.C2                                        = (int2)GetInt32(new IntPtr(p + 0x020)); // 0270D7E53378 0x20 C2                          ( 0001866C88A0 ModelEnumType int2 int2 int2 Int32 )

            return value;
        }
    }
}
