using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SelectFavoriteMarkPopupViewFactory       ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 038 ProducePreparationIdolSkillSelectPopupViewFactory ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer
    // 040 IdolSkillSingleDetailPopupViewFactory    ModelClassType IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory Pointer
    // 048 IdolSkillDetailListPopupViewFactory      ModelClassType IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory Pointer
    // 050 EfficacyDetailListPopupViewFactory       ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer
    // 058 CostumeDetailPopupViewFactory            ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    // 060 LiveSkillDetailPopupViewFactory          ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer
    public partial class PIdolDetailPopupViewFactory : DataModel
    {
        public SelectFavoriteMarkPopupViewFactory?      SelectFavoriteMarkPopupViewFactory      { get; set; }
        public ProducePreparationIdolSkillSelectPopupViewFactory? ProducePreparationIdolSkillSelectPopupViewFactory { get; set; }
        public IdolSkillSingleDetailPopupViewFactory?   IdolSkillSingleDetailPopupViewFactory   { get; set; }
        public IdolSkillDetailListPopupViewFactory?     IdolSkillDetailListPopupViewFactory     { get; set; }
        public EfficacyDetailListPopupViewFactory?      EfficacyDetailListPopupViewFactory      { get; set; }
        public CostumeDetailPopupViewFactory?           CostumeDetailPopupViewFactory           { get; set; }
        public LiveSkillDetailPopupViewFactory?         LiveSkillDetailPopupViewFactory         { get; set; }

        public static PIdolDetailPopupViewFactory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PIdolDetailPopupViewFactory() { Pointer= p0 };

            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0x30 SelectFavoriteMarkPopupViewFactory ( ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.ProducePreparationIdolSkillSelectPopupViewFactory = GetObject<ProducePreparationIdolSkillSelectPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupViewFactory.FromPointer); // 0x38 ProducePreparationIdolSkillSelectPopupViewFactory ( ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer )
            value.IdolSkillSingleDetailPopupViewFactory     = GetObject<IdolSkillSingleDetailPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolSkillSingleDetailPopupViewFactory.FromPointer); // 0x40 IdolSkillSingleDetailPopupViewFactory ( ModelClassType IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory Pointer )
            value.IdolSkillDetailListPopupViewFactory       = GetObject<IdolSkillDetailListPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolSkillDetailListPopupViewFactory.FromPointer); // 0x48 IdolSkillDetailListPopupViewFactory ( ModelClassType IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory Pointer )
            value.EfficacyDetailListPopupViewFactory        = GetObject<EfficacyDetailListPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.EfficacyDetailListPopupViewFactory.FromPointer); // 0x50 EfficacyDetailListPopupViewFactory ( ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 0x58 CostumeDetailPopupViewFactory ( ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )
            value.LiveSkillDetailPopupViewFactory           = GetObject<LiveSkillDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveSkillDetailPopupViewFactory.FromPointer); // 0x60 LiveSkillDetailPopupViewFactory ( ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
