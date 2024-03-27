using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 178 CgCenter                                 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 180 CgOnStage                                000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 188 UnitBonusParent                          0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 190 CgNoUnitBonus                            000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 198 CgUnitBonus                              000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1A0 TxtUnitBonusValue                        0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 1A8 ShowUnitBonus                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 1A9 IsResetOnInitialize                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class PFIdolIconRectView
    {
        public CanvasGroup?                             CgCenter                                { get; set; }
        public CanvasGroup?                             CgOnStage                               { get; set; }
        public GameObject?                              UnitBonusParent                         { get; set; }
        public CanvasGroup?                             CgNoUnitBonus                           { get; set; }
        public CanvasGroup?                             CgUnitBonus                             { get; set; }
        public UITextMeshProUGUI?                       TxtUnitBonusValue                       { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }
        public bool                                     IsResetOnInitialize                     { get; set; }

        public static PFIdolIconRectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconRectView();

            value.CgCenter                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x178), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21EF0 0x178 CgCenter                    ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgOnStage                                 = GetObject<CanvasGroup>(new IntPtr(p + 0x180), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21F10 0x180 CgOnStage                   ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.UnitBonusParent                           = GetObject<GameObject>(new IntPtr(p + 0x188), ReversePrism.DataModels.GameObject.FromPointer); // 027005B21F30 0x188 UnitBonusParent             ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.CgNoUnitBonus                             = GetObject<CanvasGroup>(new IntPtr(p + 0x190), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21F50 0x190 CgNoUnitBonus               ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgUnitBonus                               = GetObject<CanvasGroup>(new IntPtr(p + 0x198), ReversePrism.DataModels.CanvasGroup.FromPointer); // 027005B21F70 0x198 CgUnitBonus                 ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtUnitBonusValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x1A0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 027005B21F90 0x1A0 TxtUnitBonusValue           ( 0001866F90E0 ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x1A8)); // 027005B21FB0 0x1A8 ShowUnitBonus               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsResetOnInitialize                       = GetBool(new IntPtr(p + 0x1A9)); // 027005B21FD0 0x1A9 IsResetOnInitialize         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
