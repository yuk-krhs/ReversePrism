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
    public partial class TimeUI : DataModel
    {
        public GameObject?                              TimeUIArea                              { get; set; }
        public UITextMeshProUGUI?                       TimeText                                { get; set; }

        public static TimeUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeUI() { Pointer= p0 };

            value.TimeUIArea                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 024665CDB690 0x10 TimeUIArea                  ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.TimeText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665CDB6B0 0x18 TimeText                    ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
