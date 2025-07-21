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
    // 030 C2                                       ModelEnumType int4 int4 int4 Int32
    // 040 C3                                       ModelEnumType int4 int4 int4 Int32
    // 000 identity                                 int4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Zero                                     ModelEnumType int4x4 int4x4 int4x4 Int32
    public partial class int4x4 : DataModel
    {
        public int4                                     C0                                      { get; set; }
        public int4                                     C1                                      { get; set; }
        public int4                                     C2                                      { get; set; }
        public int4                                     C3                                      { get; set; }
        public int4x4                                   Zero                                    { get; set; }

        public static int4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int4x4() { Pointer= p0 };

            value.C0                                        = (int4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType int4 int4 int4 Int32 )
            value.C1                                        = (int4)GetInt32(new IntPtr(p + 0x020)); // 0x20 C1                          ( ModelEnumType int4 int4 int4 Int32 )
            value.C2                                        = (int4)GetInt32(new IntPtr(p + 0x030)); // 0x30 C2                          ( ModelEnumType int4 int4 int4 Int32 )
            value.C3                                        = (int4)GetInt32(new IntPtr(p + 0x040)); // 0x40 C3                          ( ModelEnumType int4 int4 int4 Int32 )
            value.Zero                                      = (int4x4)GetInt32(new IntPtr(p + 0x040)); // 0x40 Zero                        ( ModelEnumType int4x4 int4x4 int4x4 Int32 )

            return value;
        }
    }
}
