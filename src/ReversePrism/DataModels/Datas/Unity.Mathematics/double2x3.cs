using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       0001866C32F0 ModelEnumType double2 double2 double2 Int32
    // 020 C1                                       0001866C32F0 ModelEnumType double2 double2 double2 Int32
    // 030 C2                                       0001866C32F0 ModelEnumType double2 double2 double2 Int32
    // 000 zero                                     double2x3 IL2CPP_TYPE_VALUETYPE
    public partial class double2x3
    {
        public double2                                  C0                                      { get; set; }
        public double2                                  C1                                      { get; set; }
        public double2                                  C2                                      { get; set; }

        public static double2x3? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double2x3();

            value.C0                                        = (double2)GetInt32(new IntPtr(p + 0x010)); // 0270D7E51268 0x10 C0                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C1                                        = (double2)GetInt32(new IntPtr(p + 0x020)); // 0270D7E51288 0x20 C1                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C2                                        = (double2)GetInt32(new IntPtr(p + 0x030)); // 0270D7E512A8 0x30 C2                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )

            return value;
        }
    }
}
