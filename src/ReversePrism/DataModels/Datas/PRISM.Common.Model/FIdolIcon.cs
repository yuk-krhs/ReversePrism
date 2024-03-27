using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 040 bottomTypeRP                             ReactiveProperty`1<ValueTuple`3<Bottom, string, string>> IL2CPP_TYPE_GENERICINST
    // 048 GrayOutRP                                0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer
    // 050 inTransferModeRP                         ReactiveProperty`1<ValueTuple`3<bool, bool, bool>> IL2CPP_TYPE_GENERICINST
    // 058 SelectedFavoriteIconId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C InFavoriteMode                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05D IsSelectedLimit                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 IconId                                   000186671910 ModelPrimitiveType string string string String
    // 068 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 070 UnitId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 Rank                                     00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 078 Star                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 VoDaViMe                                 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer
    // 088 LiveSkill                                0001867784A0 ModelClassType IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus Pointer
    // 090 IsUnitMember                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 098 TransferProductList                      000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer
    public partial class FIdolIcon
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
            var value   = new FIdolIcon();

            value.GrayOutRP                                 = GetObject<BoolReactiveProperty>(new IntPtr(p + 0x048), ReversePrism.DataModels.BoolReactiveProperty.FromPointer); // 0270D4C84148 0x48 GrayOutRP                   ( 0001867695E0 ModelClassType BoolReactiveProperty BoolReactiveProperty BoolReactiveProperty Pointer )
            value.SelectedFavoriteIconId                    = GetInt32(new IntPtr(p + 0x058)); // 0270D4C84188 0x58 SelectedFavoriteIconId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InFavoriteMode                            = GetBool(new IntPtr(p + 0x05C)); // 0270D4C841A8 0x5C InFavoriteMode              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSelectedLimit                           = GetBool(new IntPtr(p + 0x05D)); // 0270D4C841C8 0x5D IsSelectedLimit             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IconId                                    = GetString(new IntPtr(p + 0x060)); // 0270D4C841E8 0x60 IconId                      ( 000186671910 ModelPrimitiveType string string string String )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x068)); // 0270D4C84208 0x68 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x070)); // 0270D4C84228 0x70 UnitId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Rank                                      = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x074)); // 0270D4C84248 0x74 Rank                        ( 00018660D900 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.Star                                      = GetInt32(new IntPtr(p + 0x078)); // 0270D4C84268 0x78 Star                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.VoDaViMe                                  = GetObject<IProduceParameterStatus>(new IntPtr(p + 0x080), ReversePrism.DataModels.IProduceParameterStatus.FromPointer); // 0270D4C84288 0x80 VoDaViMe                    ( 0001865EF0E0 ModelClassType IProduceParameterStatus IProduceParameterStatus IProduceParameterStatus Pointer )
            value.LiveSkill                                 = GetObject<IFesIdolAttachedPotentialLiveSkillStatus>(new IntPtr(p + 0x088), ReversePrism.DataModels.IFesIdolAttachedPotentialLiveSkillStatus.FromPointer); // 0270D4C842A8 0x88 LiveSkill                   ( 0001867784A0 ModelClassType IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus IFesIdolAttachedPotentialLiveSkillStatus Pointer )
            value.IsUnitMember                              = GetBool(new IntPtr(p + 0x090)); // 0270D4C842C8 0x90 IsUnitMember                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TransferProductList                       = GetObjectList<IProductWithAmountStatus>(new IntPtr(p + 0x098), ReversePrism.DataModels.IProductWithAmountStatus.FromPointer); // 0270D4C842E8 0x98 TransferProductList         ( 000185D075A8 ModelClassListType IReadOnlyList`1<IProductWithAmountStatus> IReadOnlyList`1<IProductWithAmountStatus> List<IProductWithAmountStatus> Pointer )

            return value;
        }
    }
}
