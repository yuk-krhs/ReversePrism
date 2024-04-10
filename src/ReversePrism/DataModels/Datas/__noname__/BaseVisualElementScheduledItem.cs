using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 Element                                  0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 040 IsScheduled                              000186595960 ModelPrimitiveType bool bool bool Bool
    // 048 M_Activator                              00018652B820 ModelClassType VisualElementPanelActivator VisualElementPanelActivator VisualElementPanelActivator Pointer
    public partial class BaseVisualElementScheduledItem : DataModel
    {
        public VisualElement?                           Element                                 { get; set; }
        public bool                                     IsScheduled                             { get; set; }
        public VisualElementPanelActivator?             M_Activator                             { get; set; }

        public static BaseVisualElementScheduledItem? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseVisualElementScheduledItem() { Pointer= p0 };

            value.Element                                   = GetObject<VisualElement>(new IntPtr(p + 0x038), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A67B5F28 0x38 Element                     ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.IsScheduled                               = GetBool(new IntPtr(p + 0x040)); // 0245A67B5F48 0x40 IsScheduled                 ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.M_Activator                               = GetObject<VisualElementPanelActivator>(new IntPtr(p + 0x048), ReversePrism.DataModels.VisualElementPanelActivator.FromPointer); // 0245A67B5F68 0x48 M_Activator                 ( 00018652B820 ModelClassType VisualElementPanelActivator VisualElementPanelActivator VisualElementPanelActivator Pointer )

            return value;
        }
    }
}
