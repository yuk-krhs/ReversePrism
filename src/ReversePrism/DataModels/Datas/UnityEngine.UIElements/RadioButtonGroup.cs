using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 containerUssClassName                    string IL2CPP_TYPE_STRING
    // 430 M_RadioButtons                           000185CFF0D8 ModelClassListType List`1<RadioButton> List`1<RadioButton> List<RadioButton> Pointer
    // 438 m_RadioButtonValueChangedCallback        EventCallback`1<ChangeEvent`1<bool>> IL2CPP_TYPE_GENERICINST
    // 440 M_RadioButtonContainer                   0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    public partial class RadioButtonGroup : DataModel
    {
        public List<RadioButton>?                       M_RadioButtons                          { get; set; }
        public VisualElement?                           M_RadioButtonContainer                  { get; set; }

        public static RadioButtonGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RadioButtonGroup() { Pointer= p0 };

            value.M_RadioButtons                            = GetObjectList<RadioButton>(new IntPtr(p + 0x430), ReversePrism.DataModels.RadioButton.FromPointer); // 0245A66F3098 0x430 M_RadioButtons              ( 000185CFF0D8 ModelClassListType List`1<RadioButton> List`1<RadioButton> List<RadioButton> Pointer )
            value.M_RadioButtonContainer                    = GetObject<VisualElement>(new IntPtr(p + 0x440), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A66F30D8 0x440 M_RadioButtonContainer      ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )

            return value;
        }
    }
}
