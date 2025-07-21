using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 C0                                       ModelEnumType double4 double4 double4 Int32
    // 030 C1                                       ModelEnumType double4 double4 double4 Int32
    // 050 C2                                       ModelEnumType double4 double4 double4 Int32
    // 070 C3                                       ModelEnumType double4 double4 double4 Int32
    // 000 identity                                 double4x4 IL2CPP_TYPE_VALUETYPE
    // 080 Zero                                     ModelEnumType double4x4 double4x4 double4x4 Int32
    public partial class double4x4 : DataModel
    {
        public double4                                  C0                                      { get; set; }
        public double4                                  C1                                      { get; set; }
        public double4                                  C2                                      { get; set; }
        public double4                                  C3                                      { get; set; }
        public double4x4                                Zero                                    { get; set; }

        public static double4x4? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new double4x4() { Pointer= p0 };

            value.C0                                        = (double4)GetInt32(new IntPtr(p + 0x010)); // 0x10 C0                          ( ModelEnumType double4 double4 double4 Int32 )
            value.C1                                        = (double4)GetInt32(new IntPtr(p + 0x030)); // 0x30 C1                          ( ModelEnumType double4 double4 double4 Int32 )
            value.C2                                        = (double4)GetInt32(new IntPtr(p + 0x050)); // 0x50 C2                          ( ModelEnumType double4 double4 double4 Int32 )
            value.C3                                        = (double4)GetInt32(new IntPtr(p + 0x070)); // 0x70 C3                          ( ModelEnumType double4 double4 double4 Int32 )
            value.Zero                                      = (double4x4)GetInt32(new IntPtr(p + 0x080)); // 0x80 Zero                        ( ModelEnumType double4x4 double4x4 double4x4 Int32 )

            return value;
        }
    }
}
