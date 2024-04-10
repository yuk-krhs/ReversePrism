using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 110 X                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 118 Y                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    public partial class Vector2Control : DataModel
    {
        public AxisControl?                             X                                       { get; set; }
        public AxisControl?                             Y                                       { get; set; }

        public static Vector2Control? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Vector2Control() { Pointer= p0 };

            value.X                                         = GetObject<AxisControl>(new IntPtr(p + 0x110), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A338C7B8 0x110 X                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Y                                         = GetObject<AxisControl>(new IntPtr(p + 0x118), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A338C7D8 0x118 Y                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
