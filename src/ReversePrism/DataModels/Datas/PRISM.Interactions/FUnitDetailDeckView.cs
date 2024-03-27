using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoPCardPrefab                            0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 030 TrCardParent                             0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 CardCountText                            0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PCardDetailPUPrefab                      000186537770 ModelClassType ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent Pointer
    // 048 onEfficacyDetail                         Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class FUnitDetailDeckView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public ProduceCardContent?                      GoPCardPrefab                           { get; set; }
        public Transform?                               TrCardParent                            { get; set; }
        public UITextMeshProUGUI?                       CardCountText                           { get; set; }
        public ProduceCardOutGameDetailPopupContent?    PCardDetailPUPrefab                     { get; set; }

        public static FUnitDetailDeckView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailDeckView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA2C57F0 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoPCardPrefab                             = GetObject<ProduceCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0270DA2C5810 0x28 GoPCardPrefab               ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TrCardParent                              = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0270DA2C5830 0x30 TrCardParent                ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.CardCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2C5850 0x38 CardCountText               ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PCardDetailPUPrefab                       = GetObject<ProduceCardOutGameDetailPopupContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardOutGameDetailPopupContent.FromPointer); // 0270DA2C5870 0x40 PCardDetailPUPrefab         ( 000186537770 ModelClassType ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent Pointer )

            return value;
        }
    }
}
