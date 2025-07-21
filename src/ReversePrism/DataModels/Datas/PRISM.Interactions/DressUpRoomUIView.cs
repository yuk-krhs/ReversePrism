using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CgUIView                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoBackButton                             ModelClassType GameObject GameObject GameObject Pointer
    public partial class DressUpRoomUIView : DataModel
    {
        public CanvasGroup?                             CgUIView                                { get; set; }
        public GameObject?                              GoBackButton                            { get; set; }

        public static DressUpRoomUIView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DressUpRoomUIView() { Pointer= p0 };

            value.CgUIView                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CgUIView                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoBackButton                              = GetObject<GameObject>(new IntPtr(p + 0x028), ReversePrism.DataModels.GameObject.FromPointer); // 0x28 GoBackButton                ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
