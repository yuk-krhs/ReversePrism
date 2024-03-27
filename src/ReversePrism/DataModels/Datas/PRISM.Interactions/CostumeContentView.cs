using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtStarLv                                0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtDressSetName                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 DressIconParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 IconBase                                 00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer
    // 040 <OnClick>k__BackingField                 IObservable`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    public partial class CostumeContentView
    {
        public UITextMeshProUGUI?                       TxtStarLv                               { get; set; }
        public UITextMeshProUGUI?                       TxtDressSetName                         { get; set; }
        public Transform?                               DressIconParent                         { get; set; }
        public CostumeIconView?                         IconBase                                { get; set; }

        public static CostumeContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeContentView();

            value.TxtStarLv                                 = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7C30 0x20 TxtStarLv                   ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtDressSetName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A7C50 0x28 TxtDressSetName             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIconParent                           = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DA2A7C70 0x30 DressIconParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.IconBase                                  = GetObject<CostumeIconView>(new IntPtr(p + 0x038), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0270DA2A7C90 0x38 IconBase                    ( 00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer )

            return value;
        }
    }
}
