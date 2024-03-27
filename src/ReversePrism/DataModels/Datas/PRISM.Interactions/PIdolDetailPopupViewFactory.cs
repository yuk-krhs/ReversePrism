using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 SelectFavoriteMarkPopupViewFactory       000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer
    // 038 ProducePreparationIdolSkillSelectPopupViewFactory 00018656FA60 ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer
    // 040 IdolSkillSingleDetailPopupViewFactory    0001866C2780 ModelClassType IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory Pointer
    // 048 IdolSkillDetailListPopupViewFactory      0001866BB9E0 ModelClassType IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory Pointer
    // 050 EfficacyDetailListPopupViewFactory       000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer
    // 058 CostumeDetailPopupViewFactory            00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer
    // 060 LiveSkillDetailPopupViewFactory          00018657C770 ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer
    public partial class PIdolDetailPopupViewFactory
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
            var value   = new PIdolDetailPopupViewFactory();

            value.SelectFavoriteMarkPopupViewFactory        = GetObject<SelectFavoriteMarkPopupViewFactory>(new IntPtr(p + 0x030), ReversePrism.DataModels.SelectFavoriteMarkPopupViewFactory.FromPointer); // 0270DA3074D0 0x30 SelectFavoriteMarkPopupViewFactory ( 000186715A50 ModelClassType SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory SelectFavoriteMarkPopupViewFactory Pointer )
            value.ProducePreparationIdolSkillSelectPopupViewFactory = GetObject<ProducePreparationIdolSkillSelectPopupViewFactory>(new IntPtr(p + 0x038), ReversePrism.DataModels.ProducePreparationIdolSkillSelectPopupViewFactory.FromPointer); // 0270DA3074F0 0x38 ProducePreparationIdolSkillSelectPopupViewFactory ( 00018656FA60 ModelClassType ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory ProducePreparationIdolSkillSelectPopupViewFactory Pointer )
            value.IdolSkillSingleDetailPopupViewFactory     = GetObject<IdolSkillSingleDetailPopupViewFactory>(new IntPtr(p + 0x040), ReversePrism.DataModels.IdolSkillSingleDetailPopupViewFactory.FromPointer); // 0270DA307510 0x40 IdolSkillSingleDetailPopupViewFactory ( 0001866C2780 ModelClassType IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory IdolSkillSingleDetailPopupViewFactory Pointer )
            value.IdolSkillDetailListPopupViewFactory       = GetObject<IdolSkillDetailListPopupViewFactory>(new IntPtr(p + 0x048), ReversePrism.DataModels.IdolSkillDetailListPopupViewFactory.FromPointer); // 0270DA307530 0x48 IdolSkillDetailListPopupViewFactory ( 0001866BB9E0 ModelClassType IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory IdolSkillDetailListPopupViewFactory Pointer )
            value.EfficacyDetailListPopupViewFactory        = GetObject<EfficacyDetailListPopupViewFactory>(new IntPtr(p + 0x050), ReversePrism.DataModels.EfficacyDetailListPopupViewFactory.FromPointer); // 0270DA307550 0x50 EfficacyDetailListPopupViewFactory ( 000186722210 ModelClassType EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory EfficacyDetailListPopupViewFactory Pointer )
            value.CostumeDetailPopupViewFactory             = GetObject<CostumeDetailPopupViewFactory>(new IntPtr(p + 0x058), ReversePrism.DataModels.CostumeDetailPopupViewFactory.FromPointer); // 0270DA307570 0x58 CostumeDetailPopupViewFactory ( 00018662BEB0 ModelClassType CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory CostumeDetailPopupViewFactory Pointer )
            value.LiveSkillDetailPopupViewFactory           = GetObject<LiveSkillDetailPopupViewFactory>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveSkillDetailPopupViewFactory.FromPointer); // 0270DA307590 0x60 LiveSkillDetailPopupViewFactory ( 00018657C770 ModelClassType LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory LiveSkillDetailPopupViewFactory Pointer )

            return value;
        }
    }
}
