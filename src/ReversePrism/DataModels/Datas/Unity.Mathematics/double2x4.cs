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
    // 040 C3                                       0001866C32F0 ModelEnumType double2 double2 double2 Int32
    // 000 zero                                     double2x4 IL2CPP_TYPE_VALUETYPE
    public partial class double2x4 : DataModel
    {
        public double2                                  C0                                      { get; set; }
        public double2                                  C1                                      { get; set; }
        public double2                                  C2                                      { get; set; }
        public double2                                  C3                                      { get; set; }

        public static double2x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double2x4() { Pointer= p0 };

            value.C0                                        = (double2)GetInt32(new IntPtr(p + 0x010)); // 024667ECB4C0 0x10 C0                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C1                                        = (double2)GetInt32(new IntPtr(p + 0x020)); // 024667ECB4E0 0x20 C1                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C2                                        = (double2)GetInt32(new IntPtr(p + 0x030)); // 024667ECB500 0x30 C2                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C3                                        = (double2)GetInt32(new IntPtr(p + 0x040)); // 024667ECB520 0x40 C3                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )

            return value;
        }
    }
}
