using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ParentObject                             ModelClassType GameObject GameObject GameObject Pointer
    // 028 EvasionRateText                          ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class EvasionRateContent : DataModel
    {
        public GameObject?                              ParentObject                            { get; set; }
        public UITextMeshProUGUI?                       EvasionRateText                         { get; set; }

        public static EvasionRateContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EvasionRateContent() { Pointer= p0 };

            value.ParentObject                              = GetObject<GameObject>(new IntPtr(p + 0x020), ReversePrism.DataModels.GameObject.FromPointer); // 0x20 ParentObject                ( ModelClassType GameObject GameObject GameObject Pointer )
            value.EvasionRateText                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 EvasionRateText             ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
