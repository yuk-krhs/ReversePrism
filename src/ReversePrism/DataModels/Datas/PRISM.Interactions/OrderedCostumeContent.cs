using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtCostumeName                           ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 CostumeIconView                          ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer
    public partial class OrderedCostumeContent : DataModel
    {
        public UITextMeshProUGUI?                       TxtCostumeName                          { get; set; }
        public CostumeIconView?                         CostumeIconView                         { get; set; }

        public static OrderedCostumeContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OrderedCostumeContent() { Pointer= p0 };

            value.TxtCostumeName                            = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtCostumeName              ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CostumeIconView                           = GetObject<CostumeIconView>(new IntPtr(p + 0x028), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0x28 CostumeIconView             ( ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer )

            return value;
        }
    }
}
