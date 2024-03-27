using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C9B90 ModelEnumType int4 int4 int4 Int32
    // 020 C1                                       0001866C9B90 ModelEnumType int4 int4 int4 Int32
    // 030 C2                                       0001866C9B90 ModelEnumType int4 int4 int4 Int32
    // 040 C3                                       0001866C9B90 ModelEnumType int4 int4 int4 Int32
    // 000 identity                                 int4x4 IL2CPP_TYPE_VALUETYPE
    // 040 Zero                                     0001865F1CA0 ModelEnumType int4x4 int4x4 int4x4 Int32
    public partial class int4x4
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
            var value   = new int4x4();

            value.C0                                        = (int4)GetInt32(new IntPtr(p + 0x010)); // 0270015B6748 0x10 C0                          ( 0001866C9B90 ModelEnumType int4 int4 int4 Int32 )
            value.C1                                        = (int4)GetInt32(new IntPtr(p + 0x020)); // 0270015B6768 0x20 C1                          ( 0001866C9B90 ModelEnumType int4 int4 int4 Int32 )
            value.C2                                        = (int4)GetInt32(new IntPtr(p + 0x030)); // 0270015B6788 0x30 C2                          ( 0001866C9B90 ModelEnumType int4 int4 int4 Int32 )
            value.C3                                        = (int4)GetInt32(new IntPtr(p + 0x040)); // 0270015B67A8 0x40 C3                          ( 0001866C9B90 ModelEnumType int4 int4 int4 Int32 )
            value.Zero                                      = (int4x4)GetInt32(new IntPtr(p + 0x040)); // 0270015B67E8 0x40 Zero                        ( 0001865F1CA0 ModelEnumType int4x4 int4x4 int4x4 Int32 )

            return value;
        }
    }
}
