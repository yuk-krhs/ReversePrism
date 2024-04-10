using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Device                                 0001866FB0A0 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 018 M_EventPtr                               0001865EF320 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 020 M_Flags                                  0001866271E0 ModelEnumType Enumerate Enumerate Enumerate Int32
    // 024 M_MagnitudeThreshold                     000186665900 ModelPrimitiveType float float float Single
    public partial class InputEventControlCollection : DataModel
    {
        public InputDevice?                             M_Device                                { get; set; }
        public InputEventPtr                            M_EventPtr                              { get; set; }
        public Enumerate                                M_Flags                                 { get; set; }
        public float                                    M_MagnitudeThreshold                    { get; set; }

        public static InputEventControlCollection? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputEventControlCollection() { Pointer= p0 };

            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x010), ReversePrism.DataModels.InputDevice.FromPointer); // 02466771FEC0 0x10 M_Device                    ( 0001866FB0A0 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_EventPtr                                = (InputEventPtr)GetInt32(new IntPtr(p + 0x018)); // 02466771FEE0 0x18 M_EventPtr                  ( 0001865EF320 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.M_Flags                                   = (Enumerate)GetInt32(new IntPtr(p + 0x020)); // 02466771FF00 0x20 M_Flags                     ( 0001866271E0 ModelEnumType Enumerate Enumerate Enumerate Int32 )
            value.M_MagnitudeThreshold                      = GetSingle(new IntPtr(p + 0x024)); // 02466771FF20 0x24 M_MagnitudeThreshold        ( 000186665900 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
