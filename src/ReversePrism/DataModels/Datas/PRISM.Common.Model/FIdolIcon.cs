using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 bottomTypeRP                             ReactiveProperty`1<Bottom> IL2CPP_TYPE_GENERICINST
    // 048 GrayOutRP                                ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 050 inTransferModeRP                         ReactiveProperty`1<ValueTuple`3<bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 058 SelectedFavoriteIconId                   ModelPrimitiveType int int int Int32
    // 05C InFavoriteMode                           ModelPrimitiveType bool bool bool Bool
    // 05D IsSelectedLimit                          ModelPrimitiveType bool bool bool Bool
    // 060 IconId                                   ModelPrimitiveType string string string String
    // 068 FesIdolId                                ModelPrimitiveType string string string String
    // 070 UnitId                                   ModelPrimitiveType int int int Int32
    // 074 Rank                                     ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 078 Star                                     ModelPrimitiveType int int int Int32
    // 080 VoDaViMe                                 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 088 LiveSkill                                ModelClassType IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus Pointer
    // 090 IsUnitMember                             ModelPrimitiveType bool bool bool Bool
    // 098 TransferProductList                      ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class FIdolIcon : DataModel
    {
        public BoolReactiveProperty?                    GrayOutRP                               { get; set; }
        public int                                      SelectedFavoriteIconId                  { get; set; }
        public bool                                     InFavoriteMode                          { get; set; }
        public bool                                     IsSelectedLimit                         { get; set; }
        public string                                   IconId                                  { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public int                                      UnitId                                  { get; set; }
        public ProduceParameterRank                     Rank                                    { get; set; }
        public int                                      Star                                    { get; set; }
        public IProduceParameterStatus?                 VoDaViMe                                { get; set; }
        public IFesIdolAttachedPotentialLiveSkillStatus? LiveSkill                               { get; set; }
        public bool                                     IsUnitMember                            { get; set; }
        public List<IProductWithAmountStatus>?          TransferProductList                     { get; set; }

        public static FIdolIcon? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FIdolIcon() { Pointer= p0 };

            value.GrayOutRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0x48 GrayOutRP                   ( ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SelectedFavoriteIconId                    = GetInt32(new IntPtr(p + 0x058)); // 0x58 SelectedFavoriteIconId      ( ModelPrimitiveType int int int Int32 )
            value.InFavoriteMode                            = GetBool(new IntPtr(p + 0x05C)); // 0x5C InFavoriteMode              ( ModelPrimitiveType bool bool bool Bool )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x05D)); // 0x5D IsSelectedLimit             ( ModelPrimitiveType bool bool bool Bool )
            value.IconId                                    = GetString(new IntPtr(p + 0x060)); // 0x60 IconId                      ( ModelPrimitiveType string string string String )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x068)); // 0x68 FesIdolId                   ( ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x070)); // 0x70 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x074)); // 0x74 Rank                        ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x078)); // 0x78 Star                        ( ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0x80 VoDaViMe                    ( ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkill                                 = GetObject<IFesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IFesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 0x88 LiveSkill                   ( ModelClassType IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.IsUnitMember                              = GetBool(new IntPtr(p + 0x090)); // 0x90 IsUnitMember                ( ModelPrimitiveType bool bool bool Bool )
            value.TransferProductList                       = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0x98 TransferProductList         ( ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
