using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType int4 int4 int4 Int32
    // 020 C1                                       ModelEnumType int4 int4 int4 Int32
    // 000 zero                                     int4x2 IL2CPP_TYPE_VALUETYPE
    public partial class int4x2 : DataModel
    {
        public int4                                     C0                                      { get; set; }
        public int4                                     C1                                      { get; set; }

        public static int4x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int4x2() { Pointer= p0 };

            value.C0                                        = (int4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType int4 int4 int4 Int32 )
            value.C1                                        = (int4)GetInt32(new IntPtr(p + 0x020)); // 0x20 C1                          ( ModelEnumType int4 int4 int4 Int32 )

            return value;
        }
    }
}
