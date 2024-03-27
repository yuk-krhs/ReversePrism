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
    // 010 Up                                       00018677A460 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    // 018 Down                                     00018677A460 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer
    // 020 Next                                     0001865AA400 ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 028 Previous                                 0001865AA400 ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 010 M_Root                                   0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 018 M_Ring                                   00018652B0B0 ModelClassType VisualElementFocusRing VisualElementFocusRing VisualElementFocusRing Pointer
    public partial class NavigateFocusRing
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
            var value   = new NavigateFocusRing();

            value.Up                                        = GetObject<ChangeDirection>(new IntPtr(p + 0x010), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0270067DBB00 0x10 Up                          ( 00018677A460 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )
            value.Down                                      = GetObject<ChangeDirection>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChangeDirection.FromPointer); // 0270067DBB20 0x18 Down                        ( 00018677A460 ModelClassType ChangeDirection ChangeDirection ChangeDirection Pointer )
            value.Next                                      = GetObject<FocusChangeDirection>(new IntPtr(p + 0x020), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0270067DBB40 0x20 Next                        ( 0001865AA400 ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.Previous                                  = GetObject<FocusChangeDirection>(new IntPtr(p + 0x028), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0270067DBB60 0x28 Previous                    ( 0001865AA400 ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.M_Root                                    = GetObject<VisualElement>(new IntPtr(p + 0x010), ReversePrism.DataModels.VisualElement.FromPointer); // 0270067DBB80 0x10 M_Root                      ( 0001866B34A0 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Ring                                    = GetObject<VisualElementFocusRing>(new IntPtr(p + 0x018), ReversePrism.DataModels.VisualElementFocusRing.FromPointer); // 0270067DBBA0 0x18 M_Ring                      ( 00018652B0B0 ModelClassType VisualElementFocusRing VisualElementFocusRing VisualElementFocusRing Pointer )

            return value;
        }
    }
}
