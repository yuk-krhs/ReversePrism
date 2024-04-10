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
    // 000 identity                                 double2x2 IL2CPP_TYPE_VALUETYPE
    // 020 Zero                                     0001865E8B80 ModelEnumType double2x2 double2x2 double2x2 Int32
    public partial class double2x2 : DataModel
    {
        public double2                                  C0                                      { get; set; }
        public double2                                  C1                                      { get; set; }
        public double2x2                                Zero                                    { get; set; }

        public static double2x2? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double2x2() { Pointer= p0 };

            value.C0                                        = (double2)GetInt32(new IntPtr(p + 0x010)); // 0245A155FAA0 0x10 C0                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.C1                                        = (double2)GetInt32(new IntPtr(p + 0x020)); // 0245A155FAC0 0x20 C1                          ( 0001866C32F0 ModelEnumType double2 double2 double2 Int32 )
            value.Zero                                      = (double2x2)GetInt32(new IntPtr(p + 0x020)); // 0245A155FB00 0x20 Zero                        ( 0001865E8B80 ModelEnumType double2x2 double2x2 double2x2 Int32 )

            return value;
        }
    }
}
