using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CodeInput                                ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 068 InfoText                                 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class TransferInputCodeContent : DataModel
    {
        public CommonInputFieldTMP?                     CodeInput                               { get; set; }
        public UITextMeshProUGUI?                       InfoText                                { get; set; }

        public static TransferInputCodeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferInputCodeContent() { Pointer= p0 };

            value.CodeInput                                 = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0x60 CodeInput                   ( ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InfoText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x68 InfoText                    ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
