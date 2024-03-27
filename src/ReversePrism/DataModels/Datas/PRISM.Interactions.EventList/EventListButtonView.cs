using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer
    // 028 NewBadge                                 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 030 eventListOverlayViewFactory              OverlayViewFactory`1<IEventListOverlayView> IL2CPP_TYPE_GENERICINST
    public partial class EventListButtonView
    {
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              NewBadge                                { get; set; }

        public static EventListButtonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListButtonView();

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 027004F78860 0x20 Button                      ( 0001866E0F30 ModelClassType UIButton UIButton UIButton Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 027004F78880 0x28 NewBadge                    ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
