using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 078 M_Text                                   ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer
    // 080 M_EnableRichText                         ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer
    // 088 M_ParseEscapeSequences                   ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer
    // 090 M_DisplayTooltipWhenElided               ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer
    public partial class UxmlTraits : DataModel
    {
        public UxmlStringAttributeDescription?          M_Text                                  { get; set; }
        public UxmlBoolAttributeDescription?            M_EnableRichText                        { get; set; }
        public UxmlBoolAttributeDescription?            M_ParseEscapeSequences                  { get; set; }
        public UxmlBoolAttributeDescription?            M_DisplayTooltipWhenElided              { get; set; }

        public static UxmlTraits? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UxmlTraits() { Pointer= p0 };

            value.M_Text                                    = GetObject<UxmlStringAttributeDescription>(new IntPtr(p + 0x078), ReversePrism.DataModels.UxmlStringAttributeDescription.FromPointer); // 0x78 M_Text                      ( ModelClassType UxmlStringAttributeDescription UxmlStringAttributeDescription UxmlStringAttributeDescription Pointer )
            value.M_EnableRichText                          = GetObject<UxmlBoolAttributeDescription>(new IntPtr(p + 0x080), ReversePrism.DataModels.UxmlBoolAttributeDescription.FromPointer); // 0x80 M_EnableRichText            ( ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer )
            value.M_ParseEscapeSequences                    = GetObject<UxmlBoolAttributeDescription>(new IntPtr(p + 0x088), ReversePrism.DataModels.UxmlBoolAttributeDescription.FromPointer); // 0x88 M_ParseEscapeSequences      ( ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer )
            value.M_DisplayTooltipWhenElided                = GetObject<UxmlBoolAttributeDescription>(new IntPtr(p + 0x090), ReversePrism.DataModels.UxmlBoolAttributeDescription.FromPointer); // 0x90 M_DisplayTooltipWhenElided  ( ModelClassType UxmlBoolAttributeDescription UxmlBoolAttributeDescription UxmlBoolAttributeDescription Pointer )

            return value;
        }
    }
}
