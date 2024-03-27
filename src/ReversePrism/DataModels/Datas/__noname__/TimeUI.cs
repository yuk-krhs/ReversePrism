using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TimeUIArea                               0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 018 TimeText                                 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class TimeUI
    {
        public GameObject?                              TimeUIArea                              { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }

        public static TimeUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeUI();

            value.TimeUIArea                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5C6AD28 0x10 TimeUIArea                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5C6AD48 0x18 TimeText                    ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
