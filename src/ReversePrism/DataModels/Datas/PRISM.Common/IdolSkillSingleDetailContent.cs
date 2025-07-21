using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 View                                     ModelClassType IdolSkillSingleDetailContentView IdolSkillSingleDetailContentView IdolSkillSingleDetailContentView Pointer
    // 068 TmpKeyWordTouchDetector                  ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer
    // 070 EfficacyDetailListPopupCaller            ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer
    public partial class IdolSkillSingleDetailContent : DataModel
    {
        public IdolSkillSingleDetailContentView?        View                                    { get; set; }
        public TMPKeyWordTouchDetector?                 TmpKeyWordTouchDetector                 { get; set; }
        public IEfficacyDetailListPopupCaller?          EfficacyDetailListPopupCaller           { get; set; }

        public static IdolSkillSingleDetailContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillSingleDetailContent() { Pointer= p0 };

            value.View                                      = GetObject<IdolSkillSingleDetailContentView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolSkillSingleDetailContentView.FromPointer); // 0x60 View                        ( ModelClassType IdolSkillSingleDetailContentView IdolSkillSingleDetailContentView IdolSkillSingleDetailContentView Pointer )
            value.TmpKeyWordTouchDetector                   = GetObject<TMPKeyWordTouchDetector>(new IntPtr(p + 0x068), ReversePrism.DataModels.TMPKeyWordTouchDetector.FromPointer); // 0x68 TmpKeyWordTouchDetector     ( ModelClassType TMPKeyWordTouchDetector TMPKeyWordTouchDetector TMPKeyWordTouchDetector Pointer )
            value.EfficacyDetailListPopupCaller             = GetObject<IEfficacyDetailListPopupCaller>(new IntPtr(p + 0x070), ReversePrism.DataModels.IEfficacyDetailListPopupCaller.FromPointer); // 0x70 EfficacyDetailListPopupCaller ( ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer )

            return value;
        }
    }
}
