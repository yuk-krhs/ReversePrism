using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A0 Tip                                      0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1A8 Eraser                                   0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B0 FirstBarrelButton                        0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1B8 SecondBarrelButton                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C0 ThirdBarrelButton                        0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1C8 FourthBarrelButton                       0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1D0 InRange                                  0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1D8 Tilt                                     000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer
    // 1E0 Twist                                    000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer
    // 000 <current>k__BackingField                 Pen IL2CPP_TYPE_CLASS
    public partial class Pen
    {
        public ButtonControl?                           Tip                                     { get; set; }
        public ButtonControl?                           Eraser                                  { get; set; }
        public ButtonControl?                           FirstBarrelButton                       { get; set; }
        public ButtonControl?                           SecondBarrelButton                      { get; set; }
        public ButtonControl?                           ThirdBarrelButton                       { get; set; }
        public ButtonControl?                           FourthBarrelButton                      { get; set; }
        public ButtonControl?                           InRange                                 { get; set; }
        public Vector2Control?                          Tilt                                    { get; set; }
        public AxisControl?                             Twist                                   { get; set; }

        public static Pen? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Pen();

            value.Tip                                       = GetObject<ButtonControl>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD268 0x1A0 Tip                         ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Eraser                                    = GetObject<ButtonControl>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD288 0x1A8 Eraser                      ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.FirstBarrelButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD2A8 0x1B0 FirstBarrelButton           ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.SecondBarrelButton                        = GetObject<ButtonControl>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD2C8 0x1B8 SecondBarrelButton          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.ThirdBarrelButton                         = GetObject<ButtonControl>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD2E8 0x1C0 ThirdBarrelButton           ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.FourthBarrelButton                        = GetObject<ButtonControl>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD308 0x1C8 FourthBarrelButton          ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.InRange                                   = GetObject<ButtonControl>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0270033AD328 0x1D0 InRange                     ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.Tilt                                      = GetObject<Vector2Control>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.Vector2Control.FromPointer); // 0270033AD348 0x1D8 Tilt                        ( 000186774A20 ModelClassType Vector2Control Vector2Control Vector2Control Pointer )
            value.Twist                                     = GetObject<AxisControl>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.AxisControl.FromPointer); // 0270033AD368 0x1E0 Twist                       ( 000186730F50 ModelClassType AxisControl AxisControl AxisControl Pointer )

            return value;
        }
    }
}
