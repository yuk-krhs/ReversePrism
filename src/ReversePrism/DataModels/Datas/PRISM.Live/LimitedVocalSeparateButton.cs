using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ToggleSwitch                             ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer
    // 028 InfoButton                               ModelClassType UIButton UIButton UIButton Pointer
    // 030 LabelNotSatisfy                          ModelClassType GameObject GameObject GameObject Pointer
    // 038 LabelEnabled                             ModelClassType GameObject GameObject GameObject Pointer
    // 040 IsActive                                 ModelPrimitiveType bool bool bool Bool
    public partial class LimitedVocalSeparateButton : DataModel
    {
        public ToggleSwitch?                            ToggleSwitch                            { get; set; }
        public UIButton?                                InfoButton                              { get; set; }
        public GameObject?                              LabelNotSatisfy                         { get; set; }
        public GameObject?                              LabelEnabled                            { get; set; }
        public bool                                     IsActive                                { get; set; }

        public static LimitedVocalSeparateButton? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LimitedVocalSeparateButton() { Pointer= p0 };

            value.ToggleSwitch                              = GetObject<ToggleSwitch>(new IntPtr(p + 0x020), ReversePrism.DataModels.ToggleSwitch.FromPointer); // 0x20 ToggleSwitch                ( ModelClassType ToggleSwitch ToggleSwitch ToggleSwitch Pointer )
            value.InfoButton                                = GetObject<UIButton>(new IntPtr(p + 0x028), ReversePrism.DataModels.UIButton.FromPointer); // 0x28 InfoButton                  ( ModelClassType UIButton UIButton UIButton Pointer )
            value.LabelNotSatisfy                           = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 LabelNotSatisfy             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.LabelEnabled                              = GetObject<GameObject>(new IntPtr(p + 0x038), ReversePrism.DataModels.GameObject.FromPointer); // 0x38 LabelEnabled                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 IsActive                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
