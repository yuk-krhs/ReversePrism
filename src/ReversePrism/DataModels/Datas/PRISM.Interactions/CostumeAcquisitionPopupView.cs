using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtDressSetName                          0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 DressIconParent                          0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 030 IconBase                                 00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer
    // 038 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 onCostumeDetail                          Subject`1<ValueTuple`2<CostumePartType, int>> IL2CPP_TYPE_GENERICINST
    // 048 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class CostumeAcquisitionPopupView
    {
        public UITextMeshProUGUI?                       TxtDressSetName                         { get; set; }
        public Transform?                               DressIconParent                         { get; set; }
        public CostumeIconView?                         IconBase                                { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static CostumeAcquisitionPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CostumeAcquisitionPopupView();

            value.TxtDressSetName                           = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2A78C0 0x20 TxtDressSetName             ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.DressIconParent                           = GetObject<Transform>(new IntPtr(p + 0x028), ReversePrism.DataModels.Transform.FromPointer); // 0270DA2A78E0 0x28 DressIconParent             ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.IconBase                                  = GetObject<CostumeIconView>(new IntPtr(p + 0x030), ReversePrism.DataModels.CostumeIconView.FromPointer); // 0270DA2A7900 0x30 IconBase                    ( 00018662D530 ModelClassType CostumeIconView CostumeIconView CostumeIconView Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DA2A7960 0x48 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
