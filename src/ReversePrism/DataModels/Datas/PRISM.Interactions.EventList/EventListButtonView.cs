using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 Button                                   ModelClassType UIButton UIButton UIButton Pointer
    // 028 NewBadge                                 ModelClassType GameObject GameObject GameObject Pointer
    public partial class EventListButtonView : DataModel
    {
        public UIButton?                                Button                                  { get; set; }
        public GameObject?                              NewBadge                                { get; set; }

        public static EventListButtonView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EventListButtonView() { Pointer= p0 };

            value.Button                                    = GetObject<UIButton>(new IntPtr(p + 0x020), ReversePrism.DataModels.UIButton.FromPointer); // 0x20 Button                      ( ModelClassType UIButton UIButton UIButton Pointer )
            value.NewBadge                                  = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 NewBadge                    ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
