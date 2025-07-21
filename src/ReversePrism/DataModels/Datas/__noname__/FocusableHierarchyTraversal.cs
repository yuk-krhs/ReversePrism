using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFocusable                         ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 ValidRect                                ModelEnumType Rect Rect Rect Int32
    // 028 FirstPass                                ModelPrimitiveType bool bool bool Bool
    // 030 Direction                                ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    public partial class FocusableHierarchyTraversal : DataModel
    {
        public VisualElement?                           CurrentFocusable                        { get; set; }
        public Rect                                     ValidRect                               { get; set; }
        public bool                                     FirstPass                               { get; set; }
        public ChangeDirection?                         Direction                               { get; set; }

        public static FocusableHierarchyTraversal? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FocusableHierarchyTraversal() { Pointer= p0 };

            value.CurrentFocusable                          = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 CurrentFocusable            ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.ValidRect                                 = (Rect)GetInt32(new IntPtr(p + 0x018)); // 0x18 ValidRect                   ( ModelEnumType Rect Rect Rect Int32 )
            value.FirstPass                                 = GetBool(new IntPtr(p + 0x028)); // 0x28 FirstPass                   ( ModelPrimitiveType bool bool bool Bool )
            value.Direction                                 = GetObject<ChangeDirection>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0x30 Direction                   ( ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )

            return value;
        }
    }
}
