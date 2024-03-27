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
    // 000 identity                                 int2x2 IL2CPP_TYPE_VALUETYPE
    // 010 Zero                                     0001865EF720 ModelEnumType int2x2 int2x2 int2x2 Int32
    public partial class int2x2
    {
        public int2                                     C0                                      { get; set; }
        public int2                                     C1                                      { get; set; }
        public int2x2                                   Zero                                    { get; set; }

        public static int2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new int2x2();

            value.C0                                        = (int2)GetInt32(new IntPtr(p + 0x010)); // 0270015A8928 0x10 C0                          ( 0001866C88A0 ModelEnumType int2 int2 int2 Int32 )
            value.C1                                        = (int2)GetInt32(new IntPtr(p + 0x018)); // 0270015A8948 0x18 C1                          ( 0001866C88A0 ModelEnumType int2 int2 int2 Int32 )
            value.Zero                                      = (int2x2)GetInt32(new IntPtr(p + 0x010)); // 0270015A8988 0x10 Zero                        ( 0001865EF720 ModelEnumType int2x2 int2x2 int2x2 Int32 )

            return value;
        }
    }
}
