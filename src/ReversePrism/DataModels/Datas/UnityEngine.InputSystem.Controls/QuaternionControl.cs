using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 X                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 128 Y                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 130 Z                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 138 W                                        000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    public partial class QuaternionControl
    {
        public AxisControl?                             X                                       { get; set; }
        public AxisControl?                             Y                                       { get; set; }
        public AxisControl?                             Z                                       { get; set; }
        public AxisControl?                             W                                       { get; set; }

        public static QuaternionControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QuaternionControl();

            value.X                                         = GetObject<AxisControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.AxisControl.FromPointer); // 027003393F90 0x120 X                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Y                                         = GetObject<AxisControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.AxisControl.FromPointer); // 027003393FB0 0x128 Y                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Z                                         = GetObject<AxisControl>(new IntPtr(p + 0x130), ReversePrism.DataModels.AxisControl.FromPointer); // 027003393FD0 0x130 Z                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.W                                         = GetObject<AxisControl>(new IntPtr(p + 0x138), ReversePrism.DataModels.AxisControl.FromPointer); // 027003393FF0 0x138 W                           ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
