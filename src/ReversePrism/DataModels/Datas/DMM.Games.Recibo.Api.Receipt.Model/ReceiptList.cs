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
    public partial class ReceiptList
    {
        public List<string>?                            InappPurchaseDataList                   { get; set; }
        public List<ReceiptInfo>?                       ReceiptInfoList                         { get; set; }
        public List<string>?                            InappDataSignatureList                  { get; set; }

        public static ReceiptList? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiptList();

            value.InappPurchaseDataList                     = GetStringList(new IntPtr(p + 0x010)); // 027004D5B660 0x10 InappPurchaseDataList       ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.ReceiptInfoList                           = GetEnumList<ReceiptInfo>(new IntPtr(p + 0x018)); // 027004D5B680 0x18 ReceiptInfoList             ( 000185D003F8 ModelEnumListType List`1<ReceiptInfo> List`1<ReceiptInfo> List<ReceiptInfo> Pointer )
            value.InappDataSignatureList                    = GetStringList(new IntPtr(p + 0x020)); // 027004D5B6A0 0x20 InappDataSignatureList      ( 000185D0D518 ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )

            return value;
        }
    }
}
