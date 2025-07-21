using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SelectFavoriteMarkPopupViewFactory       ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 038 EfficacyDetailListPopupViewFactory       ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer
    // 040 FUnitDetailPopupViewFactory              ModelClassType FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory Pointer
    // 048 LiveSkillDetailPopupViewFactory          ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer
    public partial class FIdolDetailPopupViewFactory : DataModel
    {
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public EfficacyDetailListPopupViewFactory?      EfficacyDetailListPopupViewFactory      { get; set; }
        public FUnitDetailPopupViewFactory?             FUnitDetailPopupViewFactory             { get; set; }
        public LiveSkillDetailPopupViewFactory?         LiveSkillDetailPopupViewFactory         { get; set; }

        public static FIdolDetailPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolDetailPopupViewFactory() { Pointer= p0 };

            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0x30 SelectFavoriteMarkPopupViewFactory ( ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.EfficacyDetailListPopupViewFactory        = GetObject<EfficacyDetailListPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.EfficacyDetailListPopupViewFactory.FromPointer); // 0x38 EfficacyDetailListPopupViewFactory ( ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer )
            value.FUnitDetailPopupViewFactory               = GetObject<FUnitDetailPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.FUnitDetailPopupViewFactory.FromPointer); // 0x40 FUnitDetailPopupViewFactory ( ModelClassType FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory FUnitDetailPopupViewFactory Pointer )
            value.LiveSkillDetailPopupViewFactory           = GetObject<LiveSkillDetailPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.LiveSkillDetailPopupViewFactory.FromPointer); // 0x48 LiveSkillDetailPopupViewFactory ( ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
