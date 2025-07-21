using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Press                                    ModelClassType TouchPressControl TouchPressControl TouchPressControl Pointer
    // 178 DisplayIndex                             ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 180 TouchId                                  ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 188 Position                                 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 190 Delta                                    ModelClassType DeltaControl DeltaControl DeltaControl Pointer
    // 198 Pressure                                 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 1A0 Radius                                   ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 1A8 Phase                                    ModelClassType TouchPhaseControl TouchPhaseControl TouchPhaseControl Pointer
    // 1B0 IndirectTouch                            ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B8 Tap                                      ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 TapCount                                 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 1C8 StartTime                                ModelClassType DoubleControl DoubleControl DoubleControl Pointer
    // 1D0 StartPosition                            ModelClassType Vector2Control Vector2Control Vector2Control Pointer
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

            value.Press                                     = GetObject<TouchPressControl>(new IntPtr(p + 0x170), ReversePrism.DataModels.TouchPressControl.FromPointer); // 0x170 Press                       ( ModelClassType TouchPressControl TouchPressControl TouchPressControl Pointer )
            value.DisplayIndex                              = GetObject<IntegerControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.IntegerControl.FromPointer); // 0x178 DisplayIndex                ( ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.TouchId                                   = GetObject<IntegerControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.IntegerControl.FromPointer); // 0x180 TouchId                     ( ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.Position                                  = GetObject<Vector2Control>(new IntPtr(p + 0x188), ReversePrism.DataModels.Vector2Control.FromPointer); // 0x188 Position                    ( ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Delta                                     = GetObject<DeltaControl>(new IntPtr(p + 0x190), ReversePrism.DataModels.DeltaControl.FromPointer); // 0x190 Delta                       ( ModelClassType DeltaControl DeltaControl DeltaControl Pointer )
            value.Pressure                                  = GetObject<AxisControl>(new IntPtr(p + 0x198), ReversePrism.DataModels.AxisControl.FromPointer); // 0x198 Pressure                    ( ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Radius                                    = GetObject<Vector2Control>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.Vector2Control.FromPointer); // 0x1A0 Radius                      ( ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Phase                                     = GetObject<TouchPhaseControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.TouchPhaseControl.FromPointer); // 0x1A8 Phase                       ( ModelClassType TouchPhaseControl TouchPhaseControl TouchPhaseControl Pointer )
            value.IndirectTouch                             = GetObject<ButtonControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1B0 IndirectTouch               ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Tap                                       = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0x1B8 Tap                         ( ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.TapCount                                  = GetObject<IntegerControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.IntegerControl.FromPointer); // 0x1C0 TapCount                    ( ModelClassType IntegerControl IntegerControl IntegerControl Pointer )
            value.StartTime                                 = GetObject<DoubleControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.DoubleControl.FromPointer); // 0x1C8 StartTime                   ( ModelClassType DoubleControl DoubleControl DoubleControl Pointer )
            value.StartPosition                             = GetObject<Vector2Control>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.Vector2Control.FromPointer); // 0x1D0 StartPosition               ( ModelClassType Vector2Control Vector2Control Vector2Control Pointer )

            return value;
        }
    }
}
