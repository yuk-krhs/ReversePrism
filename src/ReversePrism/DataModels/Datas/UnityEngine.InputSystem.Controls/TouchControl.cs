using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Press                                    000186691670 ModelClassType TouchPressControl TouchPressControl TouchPressControl Pointer
    // 178 DisplayIndex                             000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 180 TouchId                                  000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 188 Position                                 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 190 Delta                                    0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer
    // 198 Pressure                                 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 1A0 Radius                                   000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 1A8 Phase                                    000186691170 ModelClassType TouchPhaseControl TouchPhaseControl TouchPhaseControl Pointer
    // 1B0 IndirectTouch                            0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B8 Tap                                      0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 TapCount                                 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 1C8 StartTime                                0001866ECA80 ModelClassType DoubleControl DoubleControl DoubleControl Pointer
    // 1D0 StartPosition                            000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    public partial class TouchControl : DataModel
    {
        public TouchPressControl?                       Press                                   { get; set; }
        public IntegerControl?                          DisplayIndex                            { get; set; }
        public IntegerControl?                          TouchId                                 { get; set; }
        public Vector2Control?                          Position                                { get; set; }
        public DeltaControl?                            Delta                                   { get; set; }
        public AxisControl?                             Pressure                                { get; set; }
        public Vector2Control?                          Radius                                  { get; set; }
        public TouchPhaseControl?                       Phase                                   { get; set; }
        public ButtonControl?                           IndirectTouch                           { get; set; }
        public ButtonControl?                           Tap                                     { get; set; }
        public IntegerControl?                          TapCount                                { get; set; }
        public DoubleControl?                           StartTime                               { get; set; }
        public Vector2Control?                          StartPosition                           { get; set; }

        public static TouchControl? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TouchControl() { Pointer= p0 };

            value.Press                                     = GetObject<TouchPressControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.TouchPressControl.FromPointer); // 0245A339A5A0 0x170 Press                       ( 000186691670 ModelClassType TouchPressControl TouchPressControl TouchPressControl Pointer )
            value.DisplayIndex                              = GetObject<IntegerControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.IntegerControl.FromPointer); // 0245A339A5C0 0x178 DisplayIndex                ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.TouchId                                   = GetObject<IntegerControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.IntegerControl.FromPointer); // 0245A339A5E0 0x180 TouchId                     ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.Position                                  = GetObject<Vector2Control>(new IntPtr(p + 0x188), ReversePrism.DataModels.Vector2Control.FromPointer); // 0245A339A600 0x188 Position                    ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Delta                                     = GetObject<DeltaControl>(new IntPtr(p + 0x190), ReversePrism.DataModels.DeltaControl.FromPointer); // 0245A339A620 0x190 Delta                       ( 0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer )
            value.Pressure                                  = GetObject<AxisControl>(new IntPtr(p + 0x198), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A339A640 0x198 Pressure                    ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Radius                                    = GetObject<Vector2Control>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Vector2Control.FromPointer); // 0245A339A660 0x1A0 Radius                      ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Phase                                     = GetObject<TouchPhaseControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.TouchPhaseControl.FromPointer); // 0245A339A680 0x1A8 Phase                       ( 000186691170 ModelClassType TouchPhaseControl TouchPhaseControl TouchPhaseControl Pointer )
            value.IndirectTouch                             = GetObject<ButtonControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A339A6A0 0x1B0 IndirectTouch               ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Tap                                       = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A339A6C0 0x1B8 Tap                         ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.TapCount                                  = GetObject<IntegerControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.IntegerControl.FromPointer); // 0245A339A6E0 0x1C0 TapCount                    ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.StartTime                                 = GetObject<DoubleControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DoubleControl.FromPointer); // 0245A339A700 0x1C8 StartTime                   ( 0001866ECA80 ModelClassType DoubleControl DoubleControl DoubleControl Pointer )
            value.StartPosition                             = GetObject<Vector2Control>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Vector2Control.FromPointer); // 0245A339A720 0x1D0 StartPosition               ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )

            return value;
        }
    }
}
