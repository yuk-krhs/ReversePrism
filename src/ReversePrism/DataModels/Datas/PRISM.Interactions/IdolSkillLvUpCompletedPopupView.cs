using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TxtIdolName                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 028 TxtBeforeLv                              0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 030 TxtAfterLv                               0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 038 IdolIconView                             000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer
    // 040 ListParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 048 GoSkillContentView                       0001866B93E0 ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer
    // 050 Animator                                 0001866B8DE0 ModelClassType Animator Animator Animator Pointer
    // 058 onClick                                  Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 060 onDetail                                 Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 068 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    // 070 CueSheetName                             000186671910 ModelPrimitiveType string string string String
    // 078 CueName                                  000186671910 ModelPrimitiveType string string string String
    // 080 Parent                                   0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer
    public partial class IdolSkillLvUpCompletedPopupView : DataModel
    {
        public UITextMeshProUGUI?                       TxtIdolName                             { get; set; }
        public UITextMeshProUGUI?                       TxtBeforeLv                             { get; set; }
        public UITextMeshProUGUI?                       TxtAfterLv                              { get; set; }
        public PFIdolIconRectView?                      IdolIconView                            { get; set; }
        public Transform?                               ListParent                              { get; set; }
        public IdolSkillContentView?                    GoSkillContentView                      { get; set; }
        public Animator?                                Animator                                { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }
        public string                                   CueSheetName                            { get; set; }
        public string                                   CueName                                 { get; set; }
        public IPopupFrameView?                         Parent                                  { get; set; }

        public static IdolSkillLvUpCompletedPopupView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillLvUpCompletedPopupView() { Pointer= p0 };

            value.TxtIdolName                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x020), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A351F58 0x20 TxtIdolName                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtBeforeLv                               = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x028), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A351F78 0x28 TxtBeforeLv                 ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.TxtAfterLv                                = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x030), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 02466A351F98 0x30 TxtAfterLv                  ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.IdolIconView                              = GetObject<PFIdolIconRectView>(new IntPtr(p + 0x038), ReversePrism.DataModels.PFIdolIconRectView.FromPointer); // 02466A351FB8 0x38 IdolIconView                ( 000186703B70 ModelClassType PFIdolIconRectView PFIdolIconRectView PFIdolIconRectView Pointer )
            value.ListParent                                = GetObject<Transform>(new IntPtr(p + 0x040), ReversePrism.DataModels.Transform.FromPointer); // 02466A351FD8 0x40 ListParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoSkillContentView                        = GetObject<IdolSkillContentView>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolSkillContentView.FromPointer); // 02466A351FF8 0x48 GoSkillContentView          ( 0001866B93E0 ModelClassType IdolSkillContentView IdolSkillContentView IdolSkillContentView Pointer )
            value.Animator                                  = GetObject<Animator>(new IntPtr(p + 0x050), ReversePrism.DataModels.Animator.FromPointer); // 02466A352018 0x50 Animator                    ( 0001866B8DE0 ModelClassType Animator Animator Animator Pointer )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x068), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466A352078 0x68 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )
            value.CueSheetName                              = GetString(new IntPtr(p + 0x070)); // 02466A352098 0x70 CueSheetName                ( 000186671910 ModelPrimitiveType string string string String )
            value.CueName                                   = GetString(new IntPtr(p + 0x078)); // 02466A3520B8 0x78 CueName                     ( 000186671910 ModelPrimitiveType string string string String )
            value.Parent                                    = GetObject<IPopupFrameView>(new IntPtr(p + 0x080), ReversePrism.DataModels.IPopupFrameView.FromPointer); // 02466A3520D8 0x80 Parent                      ( 0001865DAC10 ModelClassType IPopupFrameView IPopupFrameView IPopupFrameView Pointer )

            return value;
        }
    }
}
