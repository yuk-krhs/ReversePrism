using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UIArea                                   0001865D8420 ModelClassType GameObject GameObject GameObject Pointer
    // 018 CostText                                 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class CostUI
    {
        public GameObject?                              UIArea                                  { get; set; }
        public UITextMeshProUGUI?                       CostText                                { get; set; }

        public static CostUI? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostUI();

            value.UIArea                                    = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0270D5BC04F0 0x10 UIArea                      ( 0001865D8420 ModelClassType GameObject GameObject GameObject Pointer )
            value.CostText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x018), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270D5BC0510 0x18 CostText                    ( 0001866F95C0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
