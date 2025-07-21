using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 Up                                       ModelClassType AxisControl AxisControl AxisControl Pointer
    // 128 Down                                     ModelClassType AxisControl AxisControl AxisControl Pointer
    // 130 Left                                     ModelClassType AxisControl AxisControl AxisControl Pointer
    // 138 Right                                    ModelClassType AxisControl AxisControl AxisControl Pointer
    public partial class DeltaControl : DataModel
    {
        public AxisControl?                             Up                                      { get; set; }
        public AxisControl?                             Down                                    { get; set; }
        public AxisControl?                             Left                                    { get; set; }
        public AxisControl?                             Right                                   { get; set; }

        public static DeltaControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DeltaControl() { Pointer= p0 };

            value.Up                                        = GetObject<AxisControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.AxisControl.FromPointer); // 0x120 Up                          ( ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Down                                      = GetObject<AxisControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.AxisControl.FromPointer); // 0x128 Down                        ( ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Left                                      = GetObject<AxisControl>(new IntPtr(p + 0x130), ReversePrism.DataModels.AxisControl.FromPointer); // 0x130 Left                        ( ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Right                                     = GetObject<AxisControl>(new IntPtr(p + 0x138), ReversePrism.DataModels.AxisControl.FromPointer); // 0x138 Right                       ( ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
