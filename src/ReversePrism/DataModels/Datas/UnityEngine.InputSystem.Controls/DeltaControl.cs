using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 120 Up                                       000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 128 Down                                     000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 130 Left                                     000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 138 Right                                    000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
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

            value.Up                                        = GetObject<AxisControl>(new IntPtr(p + 0x120), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A3390588 0x120 Up                          ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Down                                      = GetObject<AxisControl>(new IntPtr(p + 0x128), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33905A8 0x128 Down                        ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Left                                      = GetObject<AxisControl>(new IntPtr(p + 0x130), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33905C8 0x130 Left                        ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Right                                     = GetObject<AxisControl>(new IntPtr(p + 0x138), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33905E8 0x138 Right                       ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
