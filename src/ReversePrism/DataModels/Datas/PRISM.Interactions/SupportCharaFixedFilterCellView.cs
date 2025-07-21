using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 CellHeight                               ModelPrimitiveType float float float Single
    // 040 FavoriteFilterRow                        ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 048 CharaFilterRow                           ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer
    // 050 GoodScheduleFilterRow                    ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 058 RarityFilterRow                          ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 060 DiamondFilterRow                         ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 068 SupportSkillSlotFilterRow                ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 070 PotentialSupportSkillFilterRow           ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer
    // 078 Setup                                    ModelPrimitiveType bool bool bool Bool
    public partial class SupportCharaFixedFilterCellView : DataModel
    {
        public float                                    CellHeight                              { get; set; }
        public UIFilterGroup?                           FavoriteFilterRow                       { get; set; }
        public UIFilterCharacterGroup?                  CharaFilterRow                          { get; set; }
        public UIFilterGroup?                           GoodScheduleFilterRow                   { get; set; }
        public UIFilterGroup?                           RarityFilterRow                         { get; set; }
        public UIFilterGroup?                           DiamondFilterRow                        { get; set; }
        public UIFilterGroup?                           SupportSkillSlotFilterRow               { get; set; }
        public UIFilterGroup?                           PotentialSupportSkillFilterRow          { get; set; }
        public bool                                     Setup                                   { get; set; }

        public static SupportCharaFixedFilterCellView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SupportCharaFixedFilterCellView() { Pointer= p0 };

            value.CellHeight                                = GetSingle(new IntPtr(p + 0x038)); // 0x38 CellHeight                  ( ModelPrimitiveType float float float Single )
            value.FavoriteFilterRow                         = GetObject<UIFilterGroup>(new IntPtr(p + 0x040), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x40 FavoriteFilterRow           ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.CharaFilterRow                            = GetObject<UIFilterCharacterGroup>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIFilterCharacterGroup.FromPointer); // 0x48 CharaFilterRow              ( ModelClassType UIFilterCharacterGroup UIFilterCharacterGroup UIFilterCharacterGroup Pointer )
            value.GoodScheduleFilterRow                     = GetObject<UIFilterGroup>(new IntPtr(p + 0x050), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x50 GoodScheduleFilterRow       ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.RarityFilterRow                           = GetObject<UIFilterGroup>(new IntPtr(p + 0x058), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x58 RarityFilterRow             ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.DiamondFilterRow                          = GetObject<UIFilterGroup>(new IntPtr(p + 0x060), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x60 DiamondFilterRow            ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.SupportSkillSlotFilterRow                 = GetObject<UIFilterGroup>(new IntPtr(p + 0x068), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x68 SupportSkillSlotFilterRow   ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.PotentialSupportSkillFilterRow            = GetObject<UIFilterGroup>(new IntPtr(p + 0x070), ReversePrism.DataModels.UIFilterGroup.FromPointer); // 0x70 PotentialSupportSkillFilterRow ( ModelClassType UIFilterGroup UIFilterGroup UIFilterGroup Pointer )
            value.Setup                                     = GetBool(new IntPtr(p + 0x078)); // 0x78 Setup                       ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
