using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoPCardPrefab                            ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 030 TrCardParent                             ModelClassType Transform Transform Transform Pointer
    // 038 CardCountText                            ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 PCardDetailPUPrefab                      ModelClassType ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent Pointer
    // 048 onEfficacyDetail                         Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class FUnitDetailDeckView : DataModel
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
            var value   = new FUnitDetailDeckView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoPCardPrefab                             = GetObject<ProduceCardContent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x28 GoPCardPrefab               ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TrCardParent                              = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 0x30 TrCardParent                ( ModelClassType Transform Transform Transform Pointer )
            value.CardCountText                             = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x38 CardCountText               ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.PCardDetailPUPrefab                       = GetObject<ProduceCardOutGameDetailPopupContent>(new IntPtr(p + 0x040), ReversePrism.DataModels.ProduceCardOutGameDetailPopupContent.FromPointer); // 0x40 PCardDetailPUPrefab         ( ModelClassType ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent ProduceCardOutGameDetailPopupContent Pointer )

            return value;
        }
    }
}
