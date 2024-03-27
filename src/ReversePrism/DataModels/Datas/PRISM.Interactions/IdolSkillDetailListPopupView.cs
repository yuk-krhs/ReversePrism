using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 GoElement                                0001866BAFE0 ModelClassType IdolSkillDetailListElementView IdolSkillDetailListElementView IdolSkillDetailListElementView Pointer
    // 030 ImgSkillIcon                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtSkillLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 050 <KeyWordTouchIdList>k__BackingField      IObservable`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    // 058 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class IdolSkillDetailListPopupView
    {
        public Transform?                               ContentParent                           { get; set; }
        public IdolSkillDetailListElementView?          GoElement                               { get; set; }
        public RawImage?                                ImgSkillIcon                            { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtSkillLv                              { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static IdolSkillDetailListPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailListPopupView();

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0270DB562760 0x20 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoElement                                 = GetObject<IdolSkillDetailListElementView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillDetailListElementView.FromPointer); // 0270DB562780 0x28 GoElement                   ( 0001866BAFE0 ModelClassType IdolSkillDetailListElementView IdolSkillDetailListElementView IdolSkillDetailListElementView Pointer )
            value.ImgSkillIcon                              = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0270DB5627A0 0x30 ImgSkillIcon                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB5627C0 0x38 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkillLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0270DB5627E0 0x40 TxtSkillLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x058), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0270DB562840 0x58 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
