using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 AssetPath                                string IL2CPP_TYPE_STRING
    // 060 View                                     0001866BA690 ModelClassType IdolSkillDetailListContentView IdolSkillDetailListContentView IdolSkillDetailListContentView Pointer
    // 068 EfficacyDetailListPopupCaller            00018675DD00 ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer
    public partial class IdolSkillDetailListContent
    {
        public IdolSkillDetailListContentView?          View                                    { get; set; }
        public IEfficacyDetailListPopupCaller?          EfficacyDetailListPopupCaller           { get; set; }

        public static IdolSkillDetailListContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IdolSkillDetailListContent();

            value.View                                      = GetObject<IdolSkillDetailListContentView>(new IntPtr(p + 0x060), ReversePrism.DataModels.IdolSkillDetailListContentView.FromPointer); // 0270D5975870 0x60 View                        ( 0001866BA690 ModelClassType IdolSkillDetailListContentView IdolSkillDetailListContentView IdolSkillDetailListContentView Pointer )
            value.EfficacyDetailListPopupCaller             = GetObject<IEfficacyDetailListPopupCaller>(new IntPtr(p + 0x068), ReversePrism.DataModels.IEfficacyDetailListPopupCaller.FromPointer); // 0270D5975890 0x68 EfficacyDetailListPopupCaller ( 00018675DD00 ModelClassType IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller IEfficacyDetailListPopupCaller Pointer )

            return value;
        }
    }
}
