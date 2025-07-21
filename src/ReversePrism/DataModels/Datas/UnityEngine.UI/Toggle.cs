using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 100 ToggleTransition                         ModelEnumType ToggleTransition ToggleTransition ToggleTransition Int32
    // 108 Graphic                                  ModelClassType Graphic Graphic Graphic Pointer
    // 110 M_Group                                  ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer
    // 118 OnValueChanged                           ModelClassType ToggleEvent ToggleEvent ToggleEvent Pointer
    // 120 M_IsOn                                   ModelPrimitiveType bool bool bool Bool
    public partial class Toggle : DataModel
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
            var value   = new Toggle() { Pointer= p0 };

            value.ToggleTransition                          = (ToggleTransition)GetInt32(new IntPtr(p + 0x100)); // 0x100 ToggleTransition            ( ModelEnumType ToggleTransition ToggleTransition ToggleTransition Int32 )
            value.Graphic                                   = GetObject<Graphic>(new IntPtr(p + 0x108), ReversePrism.DataModels.Graphic.FromPointer); // 0x108 Graphic                     ( ModelClassType Graphic Graphic Graphic Pointer )
            value.M_Group                                   = GetObject<ToggleGroup>(new IntPtr(p + 0x110), ReversePrism.DataModels.ToggleGroup.FromPointer); // 0x110 M_Group                     ( ModelClassType ToggleGroup ToggleGroup ToggleGroup Pointer )
            value.OnValueChanged                            = GetObject<ToggleEvent>(new IntPtr(p + 0x118), ReversePrism.DataModels.ToggleEvent.FromPointer); // 0x118 OnValueChanged              ( ModelClassType ToggleEvent ToggleEvent ToggleEvent Pointer )
            value.M_IsOn                                    = GetBool(new IntPtr(p + 0x120)); // 0x120 M_IsOn                      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
