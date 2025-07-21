using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtIdolName                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtBeforeLv                              ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtAfterLv                               ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IdolIconView                             ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 040 ListParent                               ModelClassType Transform Transform Transform Pointer
    // 048 GoSkillContentView                       ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer
    // 050 Animator                                 ModelClassType Animator Animator Animator Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 CueSheetName                             ModelPrimitiveType string string string String
    // 070 CueName                                  ModelPrimitiveType string string string String
    // 078 Parent                                   ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class IdolSkillLvUpCompletedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TxtIdolName                             { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public PFIdolIconRectView?                      IdolIconView                            { get; set; }
        public Transform?                               ListParent                              { get; set; }
        public IdolSkillContentView?                    GoSkillContentView                      { get; set; }
        public Animator?                                Animator                                { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static IdolSkillLvUpCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvUpCompletedPopupView() { Pointer= p0 };

            value.TxtIdolName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x20 TxtIdolName                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x28 TxtBeforeLv                 ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x30 TxtAfterLv                  ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 0x38 IdolIconView                ( ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ListParent                                = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 0x40 ListParent                  ( ModelClassType Transform Transform Transform Pointer )
            value.GoSkillContentView                        = GetObject<IdolSkillContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolSkillContentView.FromPointer); // 0x48 GoSkillContentView          ( ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 0x50 Animator                    ( ModelClassType Animator Animator Animator Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x068)); // 0x68 CueSheetName                ( ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x070)); // 0x70 CueName                     ( ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x078), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 0x78 Parent                      ( ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
