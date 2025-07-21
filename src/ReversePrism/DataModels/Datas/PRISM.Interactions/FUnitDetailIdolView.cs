using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CanvasGroup                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 028 GoMemberPrefab                           ModelClassType UnitMemberView UnitMemberView UnitMemberView Pointer
    // 030 GoSeparator                              ModelClassType GameObject GameObject GameObject Pointer
    // 038 TrMembersParent                          ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 onFIdolDetail                            Subject`1<string> IL2CPP_TYPE_GENERICINST
    // 048 onLiveSkillDetail                        Subject`1<LiveSkillViewModel> IL2CPP_TYPE_GENERICINST
    public partial class FUnitDetailIdolView : DataModel
    {
        public CanvasGroup?                             CanvasGroup                             { get; set; }
        public UnitMemberView?                          GoMemberPrefab                          { get; set; }
        public GameObject?                              GoSeparator                             { get; set; }
        public RectTransform?                           TrMembersParent                         { get; set; }

        public static FUnitDetailIdolView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FUnitDetailIdolView() { Pointer= p0 };

            value.CanvasGroup                               = GetObject<CanvasGroup>(new IntPtr(p + 0x020), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x20 CanvasGroup                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.GoMemberPrefab                            = GetObject<UnitMemberView>(new IntPtr(p + 0x028), ReversePrism.DataModels.UnitMemberView.FromPointer); // 0x28 GoMemberPrefab              ( ModelClassType UnitMemberView UnitMemberView UnitMemberView Pointer )
            value.GoSeparator                               = GetObject<GameObject>(new IntPtr(p + 0x030), ReversePrism.DataModels.GameObject.FromPointer); // 0x30 GoSeparator                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.TrMembersParent                           = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 TrMembersParent             ( ModelClassType RectTransform RectTransform RectTransform Pointer )

            return value;
        }
    }
}
