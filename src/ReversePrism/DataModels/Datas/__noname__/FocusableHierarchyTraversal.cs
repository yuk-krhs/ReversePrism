using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentFocusable                         0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 ValidRect                                00018664FAF0 ModelEnumType Rect Rect Rect Int32
    // 028 FirstPass                                000186595960 ModelPrimitiveType bool bool bool Bool
    // 030 Direction                                00018677A190 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    public partial class FocusableHierarchyTraversal
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
            var value   = new FocusableHierarchyTraversal();

            value.CurrentFocusable                          = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067DBEF8 0x10 CurrentFocusable            ( 0001866B3270 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.ValidRect                                 = (Rect)GetInt32(new IntPtr(p + 0x018)); // 0270067DBF18 0x18 ValidRect                   ( 00018664FAF0 ModelEnumType Rect Rect Rect Int32 )
            value.FirstPass                                 = GetBool(new IntPtr(p + 0x028)); // 0270067DBF38 0x28 FirstPass                   ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.Direction                                 = GetObject<ChangeDirection>(new IntPtr(p + 0x030), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0270067DBF58 0x30 Direction                   ( 00018677A190 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )

            return value;
        }
    }
}
