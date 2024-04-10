using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ListParent                               0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 028 GoSkillContentView                       0001866C3650 ModelClassType IdolSkillUpgradingContentView IdolSkillUpgradingContentView IdolSkillUpgradingContentView Pointer
    // 030 SkillDetailView                          0001866C3DD0 ModelClassType IdolSkillUpgradingDetailContentView IdolSkillUpgradingDetailContentView IdolSkillUpgradingDetailContentView Pointer
    // 038 CgSkillList                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 040 CgSkillDetail                            000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 048 detailOpen                               Subject`1<int> IL2CPP_TYPE_GENERICINST
    // 050 keyWordTouchId                           Subject`1<List`1<int>> IL2CPP_TYPE_GENERICINST
    public partial class ProduceIdolSkillListView : DataModel
    {
        public Transform?                               ListParent                              { get; set; }
        public IdolSkillUpgradingContentView?           GoSkillContentView                      { get; set; }
        public IdolSkillUpgradingDetailContentView?     SkillDetailView                         { get; set; }
        public CanvasGroup?                             CgSkillList                             { get; set; }
        public CanvasGroup?                             CgSkillDetail                           { get; set; }

        public static ProduceIdolSkillListView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdolSkillListView() { Pointer= p0 };

            value.ListParent                                = GetObject<Transform>(new IntPtr(p + 0x020), ReversePrism.DataModels.Transform.FromPointer); // 02466A352530 0x20 ListParent                  ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.GoSkillContentView                        = GetObject<IdolSkillUpgradingContentView>(new IntPtr(p + 0x028), ReversePrism.DataModels.IdolSkillUpgradingContentView.FromPointer); // 02466A352550 0x28 GoSkillContentView          ( 0001866C3650 ModelClassType IdolSkillUpgradingContentView IdolSkillUpgradingContentView IdolSkillUpgradingContentView Pointer )
            value.SkillDetailView                           = GetObject<IdolSkillUpgradingDetailContentView>(new IntPtr(p + 0x030), ReversePrism.DataModels.IdolSkillUpgradingDetailContentView.FromPointer); // 02466A352570 0x30 SkillDetailView             ( 0001866C3DD0 ModelClassType IdolSkillUpgradingDetailContentView IdolSkillUpgradingDetailContentView IdolSkillUpgradingDetailContentView Pointer )
            value.CgSkillList                               = GetObject<CanvasGroup>(new IntPtr(p + 0x038), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A352590 0x38 CgSkillList                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgSkillDetail                             = GetObject<CanvasGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.CanvasGroup.FromPointer); // 02466A3525B0 0x40 CgSkillDetail               ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )

            return value;
        }
    }
}
