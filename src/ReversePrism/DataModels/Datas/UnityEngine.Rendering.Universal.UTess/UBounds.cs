using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Min                                      ModelEnumType double2 double2 double2 Int32
    // 020 Max                                      ModelEnumType double2 double2 double2 Int32
    public partial class UBounds : DataModel
    {
        public double2                                  Min                                     { get; set; }
        public double2                                  Max                                     { get; set; }

        public static UBounds? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UBounds() { Pointer= p0 };

            value.Min                                       = (double2)GetInt32(new IntPtr(p + 0x010)); // 0x10 Min                         ( ModelEnumType double2 double2 double2 Int32 )
            value.Max                                       = (double2)GetInt32(new IntPtr(p + 0x020)); // 0x20 Max                         ( ModelEnumType double2 double2 double2 Int32 )

            return value;
        }
    }
}
