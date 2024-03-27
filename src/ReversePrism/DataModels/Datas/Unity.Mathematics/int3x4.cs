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
    // 034 C3                                       0001866C91E0 ModelEnumType int3 int3 int3 Int32
    // 000 zero                                     int3x4 IL2CPP_TYPE_VALUETYPE
    public partial class int3x4
    {
        public int3                                     C0                                      { get; set; }
        public int3                                     C1                                      { get; set; }
        public int3                                     C2                                      { get; set; }
        public int3                                     C3                                      { get; set; }

        public static int3x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int3x4();

            value.C0                                        = (int3)GetInt32(new IntPtr(p + 0x010)); // 0270D7E7A180 0x10 C0                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C1                                        = (int3)GetInt32(new IntPtr(p + 0x01C)); // 0270D7E7A1A0 0x1C C1                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C2                                        = (int3)GetInt32(new IntPtr(p + 0x028)); // 0270D7E7A1C0 0x28 C2                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C3                                        = (int3)GetInt32(new IntPtr(p + 0x034)); // 0270D7E7A1E0 0x34 C3                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )

            return value;
        }
    }
}
