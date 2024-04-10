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
    // 000 zero                                     int3x2 IL2CPP_TYPE_VALUETYPE
    public partial class int3x2 : DataModel
    {
        public int3                                     C0                                      { get; set; }
        public int3                                     C1                                      { get; set; }

        public static int3x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int3x2() { Pointer= p0 };

            value.C0                                        = (int3)GetInt32(new IntPtr(p + 0x010)); // 024667EDA890 0x10 C0                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )
            value.C1                                        = (int3)GetInt32(new IntPtr(p + 0x01C)); // 024667EDA8B0 0x1C C1                          ( 0001866C91E0 ModelEnumType int3 int3 int3 Int32 )

            return value;
        }
    }
}
