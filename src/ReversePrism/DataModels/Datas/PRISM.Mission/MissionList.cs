using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 OnClickButton                            Action`1<int> IL2CPP_TYPE_GENERICINST
    // 098 EmptyText                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 0A0 FilterButtonRootObject                   0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    public partial class MissionList : DataModel
    {
        public UITextMeshProUGUI?                       EmptyText                               { get; set; }
        public GameObject?                              FilterButtonRootObject                  { get; set; }

        public static MissionList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MissionList() { Pointer= p0 };

            value.EmptyText                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x098), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246655C8168 0x98 EmptyText                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.FilterButtonRootObject                    = GetObject<GameObject>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.GameObject.FromPointer); // 0246655C8188 0xA0 FilterButtonRootObject      ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
