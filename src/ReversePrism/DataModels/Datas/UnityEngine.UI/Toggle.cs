using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 ToggleTransition                         000186621B10 ModelEnumType ToggleTransition ToggleTransition ToggleTransition Int32
    // 108 Graphic                                  000186692590 ModelClassType Graphic Graphic Graphic Pointer
    // 110 M_Group                                  000186685730 ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer
    // 118 OnValueChanged                           000186621630 ModelClassType ToggleEvent ToggleEvent ToggleEvent Pointer
    // 120 M_IsOn                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class Toggle
    {
        public ToggleTransition                         ToggleTransition                        { get; set; }
        public Graphic?                                 Graphic                                 { get; set; }
        public ToggleGroup?                             M_Group                                 { get; set; }
        public ToggleEvent?                             OnValueChanged                          { get; set; }
        public bool                                     M_IsOn                                  { get; set; }

        public static Toggle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Toggle();

            value.ToggleTransition                          = (ToggleTransition)GetInt32(new IntPtr(p + 0x100)); // 027004F4C1C0 0x100 ToggleTransition            ( 000186621B10 ModelEnumType ToggleTransition ToggleTransition ToggleTransition Int32 )
            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x108), ReversePrism.DataModels.Graphic.FromPointer); // 027004F4C1E0 0x108 Graphic                     ( 000186692590 ModelClassType Graphic Graphic Graphic Pointer )
            value.M_Group                                   = GetObject<ToggleGroup>(new IntPtr(p + 0x110), ReversePrism.DataModels.ToggleGroup.FromPointer); // 027004F4C200 0x110 M_Group                     ( 000186685730 ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer )
            value.OnValueChanged                            = GetObject<ToggleEvent>(new IntPtr(p + 0x118), ReversePrism.DataModels.ToggleEvent.FromPointer); // 027004F4C220 0x118 OnValueChanged              ( 000186621630 ModelClassType ToggleEvent ToggleEvent ToggleEvent Pointer )
            value.M_IsOn                                    = GetBool(new IntPtr(p + 0x120)); // 027004F4C240 0x120 M_IsOn                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
