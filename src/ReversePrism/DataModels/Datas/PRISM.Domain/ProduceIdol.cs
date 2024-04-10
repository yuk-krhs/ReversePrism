using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MstProduceIdolId                         0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 Cost                                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 Star                                     0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 020 EvolutionLevel                           0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer
    // 028 StarIdolParameterList                    000185D0C2F8 ModelClassListType IReadOnlyList`1<IStarIdolParameterStatus> IReadOnlyList`1<IStarIdolParameterStatus> List<IStarIdolParameterStatus> Pointer
    // 030 SelectedMstIdolSkillId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 034 MstFavoriteMarkId                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 038 IdolSkillList                            000185CFE0F8 ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer
    // 040 ProduceIdolEventList                     000185D06948 ModelClassListType IReadOnlyList`1<IProduceIdolEventStatus> IReadOnlyList`1<IProduceIdolEventStatus> List<IProduceIdolEventStatus> Pointer
    // 048 PotentialLiveSkillList                   000185D04938 ModelClassListType IReadOnlyList`1<IPotentialLiveSkillStatus> IReadOnlyList`1<IPotentialLiveSkillStatus> List<IPotentialLiveSkillStatus> Pointer
    // 050 DressSetList                             000185D066F8 ModelClassListType IReadOnlyList`1<IProduceIdolDressSetStatus> IReadOnlyList`1<IProduceIdolDressSetStatus> List<IProduceIdolDressSetStatus> Pointer
    // 058 CreateDate                               000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 068 LimitBreakRecipeProduct                  0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer
    // 070 EvolutionRecipeGroupId                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 074 MstUnitId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 MstIdolId                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C MstCharacterInfoId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 InitialStar                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 084 CardId                                   0001865F2AF0 ModelPrimitiveType int int int Int32
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

            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x010)); // 024664CE1070 0x10 MstProduceIdolId            ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Cost                                      = GetInt32(new IntPtr(p + 0x014)); // 024664CE1090 0x14 Cost                        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Star                                      = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 024664CE10B0 0x18 Star                        ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.EvolutionLevel                            = GetObject<ILimitedValueStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ILimitedValueStatus.FromPointer); // 024664CE10D0 0x20 EvolutionLevel              ( 0001865913D0 ModelClassType ILimitedValueStatus ILimitedValueStatus ILimitedValueStatus Pointer )
            value.StarIdolParameterList                     = GetObjectList<IStarIdolParameterStatus>(new IntPtr(p + 0x028), ReversePrism.DataModels.IStarIdolParameterStatus.FromPointer); // 024664CE10F0 0x28 StarIdolParameterList       ( 000185D0C2F8 ModelClassListType IReadOnlyList`1<IStarIdolParameterStatus> IReadOnlyList`1<IStarIdolParameterStatus> List<IStarIdolParameterStatus> Pointer )
            value.SelectedMstIdolSkillId                    = GetInt32(new IntPtr(p + 0x030)); // 024664CE1110 0x30 SelectedMstIdolSkillId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstFavoriteMarkId                         = GetInt32(new IntPtr(p + 0x034)); // 024664CE1130 0x34 MstFavoriteMarkId           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdolSkillList                             = GetObjectList<IIdolSkillStatus>(new IntPtr(p + 0x038), ReversePrism.DataModels.IIdolSkillStatus.FromPointer); // 024664CE1150 0x38 IdolSkillList               ( 000185CFE0F8 ModelClassListType IReadOnlyList`1<IIdolSkillStatus> IReadOnlyList`1<IIdolSkillStatus> List<IIdolSkillStatus> Pointer )
            value.ProduceIdolEventList                      = GetObjectList<IProduceIdolEventStatus>(new IntPtr(p + 0x040), ReversePrism.DataModels.IProduceIdolEventStatus.FromPointer); // 024664CE1170 0x40 ProduceIdolEventList        ( 000185D06948 ModelClassListType IReadOnlyList`1<IProduceIdolEventStatus> IReadOnlyList`1<IProduceIdolEventStatus> List<IProduceIdolEventStatus> Pointer )
            value.PotentialLiveSkillList                    = GetObjectList<IPotentialLiveSkillStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.IPotentialLiveSkillStatus.FromPointer); // 024664CE1190 0x48 PotentialLiveSkillList      ( 000185D04938 ModelClassListType IReadOnlyList`1<IPotentialLiveSkillStatus> IReadOnlyList`1<IPotentialLiveSkillStatus> List<IPotentialLiveSkillStatus> Pointer )
            value.DressSetList                              = GetObjectList<IProduceIdolDressSetStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.IProduceIdolDressSetStatus.FromPointer); // 024664CE11B0 0x50 DressSetList                ( 000185D066F8 ModelClassListType IReadOnlyList`1<IProduceIdolDressSetStatus> IReadOnlyList`1<IProduceIdolDressSetStatus> List<IProduceIdolDressSetStatus> Pointer )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x058)); // 024664CE11D0 0x58 CreateDate                  ( 000185D00A08 ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.LimitBreakRecipeProduct                   = GetObject<IProductStatus>(new IntPtr(p + 0x068), ReversePrism.DataModels.IProductStatus.FromPointer); // 024664CE11F0 0x68 LimitBreakRecipeProduct     ( 0001865F9470 ModelClassType IProductStatus IProductStatus IProductStatus Pointer )
            value.EvolutionRecipeGroupId                    = GetInt32(new IntPtr(p + 0x070)); // 024664CE1210 0x70 EvolutionRecipeGroupId      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstUnitId                                 = GetInt32(new IntPtr(p + 0x074)); // 024664CE1230 0x74 MstUnitId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x078)); // 024664CE1250 0x78 MstIdolId                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoId                        = GetInt32(new IntPtr(p + 0x07C)); // 024664CE1270 0x7C MstCharacterInfoId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.InitialStar                               = GetInt32(new IntPtr(p + 0x080)); // 024664CE1290 0x80 InitialStar                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.CardId                                    = GetInt32(new IntPtr(p + 0x084)); // 024664CE12B0 0x84 CardId                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
