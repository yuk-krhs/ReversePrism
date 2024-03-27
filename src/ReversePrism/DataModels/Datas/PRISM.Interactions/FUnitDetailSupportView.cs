using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 TxtSlotCount                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 SCharaIconRectViews                      000185CA2828 ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer
    // 038 SCharaIconRectViewOfFriendSetting        0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer
    // 040 GoSSkillContentPrefab                    0001865F46A0 ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer
    // 048 TrSSkillParent                           0001866AA150 ModelClassType Transform Transform Transform Pointer
    public partial class FUnitDetailSupportView
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UITextMeshProUGUI?                       TxtSlotCount                            { get; set; }
        public List<SCharaIconRectView>?                SCharaIconRectViews                     { get; set; }
        public SCharaIconRectView?                      SCharaIconRectViewOfFriendSetting       { get; set; }
        public SupportSkillContentView?                 GoSSkillContentPrefab                   { get; set; }
        public Transform?                               TrSSkillParent                          { get; set; }

        public static FUnitDetailSupportView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailSupportView();

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270DA2C8890 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtSlotCount                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DA2C88B0 0x28 TxtSlotCount                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.SCharaIconRectViews                       = GetObjectList<SCharaIconRectView>(new IntPtr(p + 0x030), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0270DA2C88D0 0x30 SCharaIconRectViews         ( 000185CA2828 ModelClassListType SCharaIconRectView[] SCharaIconRectView[] List<SCharaIconRectView> Pointer )
            value.SCharaIconRectViewOfFriendSetting         = GetObject<SCharaIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaIconRectView.FromPointer); // 0270DA2C88F0 0x38 SCharaIconRectViewOfFriendSetting ( 0001866AAC10 ModelClassType SCharaIconRectView SCharaIconRectView SCharaIconRectView Pointer )
            value.GoSSkillContentPrefab                     = GetObject<SupportSkillContentView>(new IntPtr(p + 0x040), ReversePrism.DataModels.SupportSkillContentView.FromPointer); // 0270DA2C8910 0x40 GoSSkillContentPrefab       ( 0001865F46A0 ModelClassType SupportSkillContentView SupportSkillContentView SupportSkillContentView Pointer )
            value.TrSSkillParent                            = GetObject<Transform>(new IntPtr(p + 0x048), ReversePrism.DataModels.Transform.FromPointer); // 0270DA2C8930 0x48 TrSSkillParent              ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )

            return value;
        }
    }
}
