using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 060 CodeInput                                0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer
    // 068 InfoText                                 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    public partial class TransferInputCodeContent
    {
        public CommonInputFieldTMP?                     CodeInput                               { get; set; }
        public UITextMeshProUGUI?                       InfoText                                { get; set; }

        public static TransferInputCodeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransferInputCodeContent();

            value.CodeInput                                 = GetObject<CommonInputFieldTMP>(new IntPtr(p + 0x060), ReversePrism.DataModels.CommonInputFieldTMP.FromPointer); // 0270043979E0 0x60 CodeInput                   ( 0001865E53E0 ModelClassType CommonInputFieldTMP CommonInputFieldTMP CommonInputFieldTMP Pointer )
            value.InfoText                                  = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x068), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027004397A00 0x68 InfoText                    ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
