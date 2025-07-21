using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Left                                     ChangeDirection IL2CPP_TYPE_CLASS
    // 008 Right                                    ChangeDirection IL2CPP_TYPE_CLASS
    // 010 Up                                       ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    // 018 Down                                     ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    // 020 Next                                     ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 028 Previous                                 ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 010 M_Root                                   ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 M_Ring                                   ModelClassType VisualElementFocusRing VisualElementFocusRing VisualElementFocusRing Pointer
    public partial class NavigateFocusRing : DataModel
    {
        public ChangeDirection?                         Up                                      { get; set; }
        public ChangeDirection?                         Down                                    { get; set; }
        public FocusChangeDirection?                    Next                                    { get; set; }
        public FocusChangeDirection?                    Previous                                { get; set; }
        public VisualElement?                           M_Root                                  { get; set; }
        public VisualElementFocusRing?                  M_Ring                                  { get; set; }

        public static NavigateFocusRing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NavigateFocusRing() { Pointer= p0 };

            value.Up                                        = GetObject<ChangeDirection>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0x10 Up                          ( ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )
            value.Down                                      = GetObject<ChangeDirection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0x18 Down                        ( ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )
            value.Next                                      = GetObject<FocusChangeDirection>(new IntPtr(p + 0x020), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0x20 Next                        ( ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.Previous                                  = GetObject<FocusChangeDirection>(new IntPtr(p + 0x028), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0x28 Previous                    ( ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.M_Root                                    = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0x10 M_Root                      ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Ring                                    = GetObject<VisualElementFocusRing>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElementFocusRing.FromPointer); // 0x18 M_Ring                      ( ModelClassType VisualElementFocusRing VisualElementFocusRing VisualElementFocusRing Pointer )

            return value;
        }
    }
}
