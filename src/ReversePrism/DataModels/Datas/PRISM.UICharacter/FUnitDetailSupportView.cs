using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtSlotCount                             ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SCharaIconRectViews                      ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer
    // 038 SCharaIconRectViewOfFriendSetting        ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    public partial class FUnitDetailSupportView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtSlotCount                            { get; set; }
        public List<SCharaIconRectView>?                SCharaIconRectViews                     { get; set; }
        public SCharaIconRectView?                      SCharaIconRectViewOfFriendSetting       { get; set; }

        public static FUnitDetailSupportView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailSupportView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtSlotCount                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtSlotCount                ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SCharaIconRectViews                       = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x30 SCharaIconRectViews         ( ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer )
            value.SCharaIconRectViewOfFriendSetting         = GetObject<SCharaIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0x38 SCharaIconRectViewOfFriendSetting ( ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )

            return value;
        }
    }
}
