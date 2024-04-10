using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 170 Position                                 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 178 Delta                                    0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer
    // 180 Radius                                   000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 188 Pressure                                 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 190 Press                                    0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 198 DisplayIndex                             000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer
    // 000 <current>k__BackingField                 Pointer IL2CPP_TYPE_CLASS
    public partial class Pointer : DataModel
    {
        public Vector2Control?                          Position                                { get; set; }
        public DeltaControl?                            Delta                                   { get; set; }
        public Vector2Control?                          Radius                                  { get; set; }
        public AxisControl?                             Pressure                                { get; set; }
        public ButtonControl?                           Press                                   { get; set; }
        public IntegerControl?                          DisplayIndex                            { get; set; }

        public static Pointer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pointer() { Pointer= p0 };

            value.Position                                  = GetObject<Vector2Control>(new IntPtr(p + 0x170), ReversePrism.DataModels.Vector2Control.FromPointer); // 0245A33ABA20 0x170 Position                    ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Delta                                     = GetObject<DeltaControl>(new IntPtr(p + 0x178), ReversePrism.DataModels.DeltaControl.FromPointer); // 0245A33ABA40 0x178 Delta                       ( 0001866BE040 ModelClassType DeltaControl DeltaControl DeltaControl Pointer )
            value.Radius                                    = GetObject<Vector2Control>(new IntPtr(p + 0x180), ReversePrism.DataModels.Vector2Control.FromPointer); // 0245A33ABA60 0x180 Radius                      ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Pressure                                  = GetObject<AxisControl>(new IntPtr(p + 0x188), ReversePrism.DataModels.AxisControl.FromPointer); // 0245A33ABA80 0x188 Pressure                    ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )
            value.Press                                     = GetObject<ButtonControl>(new IntPtr(p + 0x190), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A33ABAA0 0x190 Press                       ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.DisplayIndex                              = GetObject<IntegerControl>(new IntPtr(p + 0x198), ReversePrism.DataModels.IntegerControl.FromPointer); // 0245A33ABAC0 0x198 DisplayIndex                ( 000186715740 ModelClassType IntegerControl IntegerControl IntegerControl Pointer )

            return value;
        }
    }
}
