using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1F0 Menu                                     0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 1F8 View                                     0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer
    // 200 M_HaveParsedCapabilities                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 204 M_SubType                                00018671DB30 ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32
    // 208 M_Flags                                  00018671D140 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32
    public partial class XInputController : DataModel
    {
        public ButtonControl?                           Menu                                    { get; set; }
        public ButtonControl?                           View                                    { get; set; }
        public bool                                     M_HaveParsedCapabilities                { get; set; }
        public DeviceSubType                            M_SubType                               { get; set; }
        public DeviceFlags                              M_Flags                                 { get; set; }

        public static XInputController? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XInputController() { Pointer= p0 };

            value.Menu                                      = GetObject<ButtonControl>(new IntPtr(p + 0x1F0), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A33CF240 0x1F0 Menu                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.View                                      = GetObject<ButtonControl>(new IntPtr(p + 0x1F8), ReversePrism.DataModels.ButtonControl.FromPointer); // 0245A33CF260 0x1F8 View                        ( 0001865166C0 ModelClassType ButtonControl ButtonControl ButtonControl Pointer )
            value.M_HaveParsedCapabilities                  = GetBool(new IntPtr(p + 0x200)); // 0245A33CF280 0x200 M_HaveParsedCapabilities    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_SubType                                 = (DeviceSubType)GetInt32(new IntPtr(p + 0x204)); // 0245A33CF2A0 0x204 M_SubType                   ( 00018671DB30 ModelEnumType DeviceSubType DeviceSubType DeviceSubType Int32 )
            value.M_Flags                                   = (DeviceFlags)GetInt32(new IntPtr(p + 0x208)); // 0245A33CF2C0 0x208 M_Flags                     ( 00018671D140 ModelEnumType DeviceFlags DeviceFlags DeviceFlags Int32 )

            return value;
        }
    }
}
