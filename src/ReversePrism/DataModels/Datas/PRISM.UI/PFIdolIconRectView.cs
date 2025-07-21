using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 1A8 CgCenter                                 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1B0 CgOnStage                                ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1B8 UnitBonusParent                          ModelClassType GameObject GameObject GameObject Pointer
    // 1C0 CgNoUnitBonus                            ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1C8 CgUnitBonus                              ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1D0 TxtUnitBonusValue                        ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer
    // 1D8 CgIsNotUseParameter                      ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 1E0 ShowUnitBonus                            ModelPrimitiveType bool bool bool Bool
    // 1E1 IsUseTotalParameter                      ModelPrimitiveType bool bool bool Bool
    // 1E2 IsResetOnInitialize                      ModelPrimitiveType bool bool bool Bool
    public partial class PFIdolIconRectView : DataModel
    {
        public CanvasGroup?                             CgCenter                                { get; set; }
        public CanvasGroup?                             CgOnStage                               { get; set; }
        public GameObject?                              UnitBonusParent                         { get; set; }
        public CanvasGroup?                             CgNoUnitBonus                           { get; set; }
        public CanvasGroup?                             CgUnitBonus                             { get; set; }
        public UITextMeshProUGUI?                       TxtUnitBonusValue                       { get; set; }
        public CanvasGroup?                             CgIsNotUseParameter                     { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }
        public bool                                     IsUseTotalParameter                     { get; set; }
        public bool                                     IsResetOnInitialize                     { get; set; }

        public static PFIdolIconRectView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PFIdolIconRectView() { Pointer= p0 };

            value.CgCenter                                  = GetObject<CanvasGroup>(new IntPtr(p + 0x1A8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x1A8 CgCenter                    ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgOnStage                                 = GetObject<CanvasGroup>(new IntPtr(p + 0x1B0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x1B0 CgOnStage                   ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.UnitBonusParent                           = GetObject<GameObject>(new IntPtr(p + 0x1B8), ReversePrism.DataModels.GameObject.FromPointer); // 0x1B8 UnitBonusParent             ( ModelClassType GameObject GameObject GameObject Pointer )
            value.CgNoUnitBonus                             = GetObject<CanvasGroup>(new IntPtr(p + 0x1C0), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x1C0 CgNoUnitBonus               ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.CgUnitBonus                               = GetObject<CanvasGroup>(new IntPtr(p + 0x1C8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x1C8 CgUnitBonus                 ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.TxtUnitBonusValue                         = GetObject<UITextMeshProUGUI>(new IntPtr(p + 0x1D0), ReversePrism.DataModels.UITextMeshProUGUI.FromPointer); // 0x1D0 TxtUnitBonusValue           ( ModelClassType UITextMeshProUGUI UITextMeshProUGUI UITextMeshProUGUI Pointer )
            value.CgIsNotUseParameter                       = GetObject<CanvasGroup>(new IntPtr(p + 0x1D8), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x1D8 CgIsNotUseParameter         ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x1E0)); // 0x1E0 ShowUnitBonus               ( ModelPrimitiveType bool bool bool Bool )
            value.IsUseTotalParameter                       = GetBool(new IntPtr(p + 0x1E1)); // 0x1E1 IsUseTotalParameter         ( ModelPrimitiveType bool bool bool Bool )
            value.IsResetOnInitialize                       = GetBool(new IntPtr(p + 0x1E2)); // 0x1E2 IsResetOnInitialize         ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
