using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 GoElement                                0001866BAB30 ModelClassType IdolSkillDetailListElement IdolSkillDetailListElement IdolSkillDetailListElement Pointer
    // 030 ImgSkillIcon                             000186613190 ModelClassType RawImage RawImage RawImage Pointer
    // 038 TxtSkillName                             0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 040 TxtSkillLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 048 KeyWordTouchId                           IObservable`1<IReadOnlyList`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class IdolSkillDetailListContentView : DataModel
    {
        public Transform?                               ContentParent                           { get; set; }
        public IdolSkillDetailListElement?              GoElement                               { get; set; }
        public RawImage?                                ImgSkillIcon                            { get; set; }
        public UITextMeshProUGUI?                       TxtSkillName                            { get; set; }
        public UITextMeshProUGUI?                       TxtSkillLv                              { get; set; }

        public static IdolSkillDetailListContentView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailListContentView() { Pointer= p0 };

            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 0246659E6A40 0x20 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoElement                                 = GetObject<IdolSkillDetailListElement>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillDetailListElement.FromPointer); // 0246659E6A60 0x28 GoElement                   ( 0001866BAB30 ModelClassType IdolSkillDetailListElement IdolSkillDetailListElement IdolSkillDetailListElement Pointer )
            value.ImgSkillIcon                              = GetObject<RawImage>(new IntPtr(p + 0x030), ReversePrism.DataModels.RawImage.FromPointer); // 0246659E6A80 0x30 ImgSkillIcon                ( 000186613190 ModelClassType RawImage RawImage RawImage Pointer )
            value.TxtSkillName                              = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x038), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246659E6AA0 0x38 TxtSkillName                ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtSkillLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x040), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0246659E6AC0 0x40 TxtSkillLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )

            return value;
        }
    }
}
