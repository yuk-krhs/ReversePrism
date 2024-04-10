using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 GiveupMessageText                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    public partial class ProduceGiveUpConfirmationPopupContent : DataModel
    {
        public UITextMeshProUGUI?                       GiveupMessageText                       { get; set; }

        public static ProduceGiveUpConfirmationPopupContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceGiveUpConfirmationPopupContent() { Pointer= p0 };

            value.GiveupMessageText                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x060), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 024665CF3B68 0x60 GiveupMessageText           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
