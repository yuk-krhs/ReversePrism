using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 118 X                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 120 Y                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 128 Z                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    public partial class Vector3Control : DataModel
    {
        public AxisControl?                             X                                       { get; set; }
        public AxisControl?                             Y                                       { get; set; }
        public AxisControl?                             Z                                       { get; set; }

        public static Vector3Control? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector3Control() { Pointer= p0 };

            value.X                                         = GetObject<AxisControl>(new IntPtr(p + 0x118), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33900D0 0x118 X                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Y                                         = GetObject<AxisControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33900F0 0x120 Y                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Z                                         = GetObject<AxisControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A3390110 0x128 Z                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
