using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 014 Cost                                     ModelPrimitiveType int int int Int32
    // 018 Star                                     ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 020 EvolutionLevel                           ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 028 StarIdolParameterList                    ModelClassListType IReadOnlyList`1<IStarIdolParameterStatus> IReadOnlyList`1<IStarIdolParameterStatus> List<IStarIdolParameterStatus> Pointer
    // 030 SelectedMstIdolSkillId                   ModelPrimitiveType int int int Int32
    // 034 MstFavoriteMarkId                        ModelPrimitiveType int int int Int32
    // 038 IdolSkillList                            ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer
    // 040 ProduceIdolEventList                     ModelClassListType IReadOnlyList`1<IProduceIdolEventStatus> IReadOnlyList`1<IProduceIdolEventStatus> List<IProduceIdolEventStatus> Pointer
    // 048 PotentialLiveSkillList                   ModelClassListType IReadOnlyList`1<IPotentialLiveSkillStatus> IReadOnlyList`1<IPotentialLiveSkillStatus> List<IPotentialLiveSkillStatus> Pointer
    // 050 DressSetList                             ModelClassListType IReadOnlyList`1<IProduceIdolDressSetStatus> IReadOnlyList`1<IProduceIdolDressSetStatus> List<IProduceIdolDressSetStatus> Pointer
    // 058 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 068 LimitBreakRecipeProduct                  ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 070 EvolutionRecipeGroupId                   ModelPrimitiveType int int int Int32
    // 074 MstUnitId                                ModelPrimitiveType int int int Int32
    // 078 MstIdolId                                ModelPrimitiveType int int int Int32
    // 07C MstCharacterInfoId                       ModelPrimitiveType int int int Int32
    // 080 InitialStar                              ModelPrimitiveType int int int Int32
    // 084 CardId                                   ModelPrimitiveType int int int Int32
    public partial class ProduceIdol : DataModel
    {
        public int                                      MstProduceIdolId                        { get; set; }
        public int                                      Cost                                    { get; set; }
        public ILimitedValueStatus?                     Star                                    { get; set; }
        public ILimitedValueStatus?                     EvolutionLevel                          { get; set; }
        public List<IStarIdolParameterStatus>?          StarIdolParameterList                   { get; set; }
        public int                                      SelectedMstIdolSkillId                  { get; set; }
        public int                                      MstFavoriteMarkId                       { get; set; }
        public List<IIdolSkillStatus>?                  IdolSkillList                           { get; set; }
        public List<IProduceIdolEventStatus>?           ProduceIdolEventList                    { get; set; }
        public List<IPotentialLiveSkillStatus>?         PotentialLiveSkillList                  { get; set; }
        public List<IProduceIdolDressSetStatus>?        DressSetList                            { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public IProductStatus?                          LimitBreakRecipeProduct                 { get; set; }
        public int                                      EvolutionRecipeGroupId                  { get; set; }
        public int                                      MstUnitId                               { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      MstCharacterInfoId                      { get; set; }
        public int                                      InitialStar                             { get; set; }
        public int                                      CardId                                  { get; set; }

        public static ProduceIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ProduceIdol() { Pointer= p0 };

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x014)); // 0x14 Cost                        ( ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x18 Star                        ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EvolutionLevel                            = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 0x20 EvolutionLevel              ( ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.StarIdolParameterList                     = GetObjectList<IStarIdolParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStarIdolParameterStatus.FromPointer); // 0x28 StarIdolParameterList       ( ModelClassListType IReadOnlyList`1<IStarIdolParameterStatus> IReadOnlyList`1<IStarIdolParameterStatus> List<IStarIdolParameterStatus> Pointer )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x030)); // 0x30 SelectedMstIdolSkillId      ( ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x034)); // 0x34 MstFavoriteMarkId           ( ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 0x38 IdolSkillList               ( ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer )
            value.ProduceIdolEventList                      = GetObjectList<IProduceIdolEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolEventStatus.FromPointer); // 0x40 ProduceIdolEventList        ( ModelClassListType IReadOnlyList`1<IProduceIdolEventStatus> IReadOnlyList`1<IProduceIdolEventStatus> List<IProduceIdolEventStatus> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<IPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPotentialLiveSkillStatus.FromPointer); // 0x48 PotentialLiveSkillList      ( ModelClassListType IReadOnlyList`1<IPotentialLiveSkillStatus> IReadOnlyList`1<IPotentialLiveSkillStatus> List<IPotentialLiveSkillStatus> Pointer )
            value.DressSetList                              = GetObjectList<IProduceIdolDressSetStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceIdolDressSetStatus.FromPointer); // 0x50 DressSetList                ( ModelClassListType IReadOnlyList`1<IProduceIdolDressSetStatus> IReadOnlyList`1<IProduceIdolDressSetStatus> List<IProduceIdolDressSetStatus> Pointer )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x058)); // 0x58 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LimitBreakRecipeProduct                   = GetObject<IProductStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProductStatus.FromPointer); // 0x68 LimitBreakRecipeProduct     ( ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.EvolutionRecipeGroupId                    = GetInt32(new IntPtr(p + 0x070)); // 0x70 EvolutionRecipeGroupId      ( ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x074)); // 0x74 MstUnitId                   ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x078)); // 0x78 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x07C)); // 0x7C MstCharacterInfoId          ( ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x080)); // 0x80 InitialStar                 ( ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x084)); // 0x84 CardId                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
