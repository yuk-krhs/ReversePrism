using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoContent                                0001866A7130 ModelClassType SCharaEditPotentialSupportSkillContentView SCharaEditPotentialSupportSkillContentView SCharaEditPotentialSupportSkillContentView Pointer
    // 030 ContentParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 038 ContentList                              000185D04FA8 ModelClassListType List`1<SCharaEditPotentialSupportSkillContentView> List`1<SCharaEditPotentialSupportSkillContentView> List<SCharaEditPotentialSupportSkillContentView> Pointer
    public partial class SCharaEditPotentialSupportSkillContentListView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public SCharaEditPotentialSupportSkillContentView? GoContent                               { get; set; }
        public Transform?                               ContentParent                           { get; set; }
        public List<SCharaEditPotentialSupportSkillContentView>? ContentList                             { get; set; }

        public static SCharaEditPotentialSupportSkillContentListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SCharaEditPotentialSupportSkillContentListView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466B60BE08 0x20 CanvasGroup                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoContent                                 = GetObject<SCharaEditPotentialSupportSkillContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.SCharaEditPotentialSupportSkillContentView.FromPointer); // 02466B60BE28 0x28 GoContent                   ( 0001866A7130 ModelClassType SCharaEditPotentialSupportSkillContentView SCharaEditPotentialSupportSkillContentView SCharaEditPotentialSupportSkillContentView Pointer )
            value.ContentParent                             = GetObject<Transform>(new IntPtr(p + 0x030), ReversePrism.DataModels.Transform.FromPointer); // 02466B60BE48 0x30 ContentParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.ContentList                               = GetObjectList<SCharaEditPotentialSupportSkillContentView>(new IntPtr(p + 0x038), ReversePrism.DataModels.SCharaEditPotentialSupportSkillContentView.FromPointer); // 02466B60BE68 0x38 ContentList                 ( 000185D04FA8 ModelClassListType List`1<SCharaEditPotentialSupportSkillContentView> List`1<SCharaEditPotentialSupportSkillContentView> List<SCharaEditPotentialSupportSkillContentView> Pointer )

            return value;
        }
    }
}
