using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 InappPurchaseDataList                    000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 018 ReceiptInfoList                          000185D003F8 ModelEnumListType List`1<ReceiptInfo> List`1<ReceiptInfo> List<ReceiptInfo> Pointer
    // 020 InappDataSignatureList                   000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    public partial class ReceiptList : DataModel
    {
        public List<string>?                            InappPurchaseDataList                   { get; set; }
        public List<ReceiptInfo>?                       ReceiptInfoList                         { get; set; }
        public List<string>?                            InappDataSignatureList                  { get; set; }

        public static ReceiptList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptList() { Pointer= p0 };

            value.InappPurchaseDataList                     = GetStringList(new IntPtr(p + 0x010)); // 0245A4D985A8 0x10 InappPurchaseDataList       ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.ReceiptInfoList                           = GetEnumList<ReceiptInfo>(new IntPtr(p + 0x018)); // 0245A4D985C8 0x18 ReceiptInfoList             ( 000185D003F8 ModelEnumListType List`1<ReceiptInfo> List`1<ReceiptInfo> List<ReceiptInfo> Pointer )
            value.InappDataSignatureList                    = GetStringList(new IntPtr(p + 0x020)); // 0245A4D985E8 0x20 InappDataSignatureList      ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
