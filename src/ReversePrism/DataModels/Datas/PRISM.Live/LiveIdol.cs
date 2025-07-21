using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Type                                     ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 014 CharacterId                              ModelPrimitiveType int int int Int32
    // 018 MstProduceIdolId                         ModelPrimitiveType int int int Int32
    // 020 FesIdolId                                ModelPrimitiveType string string string String
    // 028 FesIdolRank                              ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 02C UnitId                                   ModelPrimitiveType int int int Int32
    // 030 Parameter                                ModelEnumType LiveIdolParameter LiveIdolParameter LiveIdolParameter Int32
    // 04C UnitBonusRate                            ModelPrimitiveType float float float Single
    // 050 StarLevel                                ModelPrimitiveType int int int Int32
    // 054 IdolLevel                                ModelPrimitiveType int int int Int32
    // 058 IdolLevelGaugeRate                       ModelPrimitiveType float float float Single
    // 05C DearnessLevel                            ModelPrimitiveType int int int Int32
    // 060 DearnessLevelGaugeRate                   ModelPrimitiveType float float float Single
    // 068 Fan                                      ModelPrimitiveType long long long Int64
    // 070 FavoriteMarkId                           ModelPrimitiveType int int int Int32
    // 078 Skill                                    ModelClassType MstPotentialLiveSkillLevel MstPotentialLiveSkillLevel MstPotentialLiveSkillLevel Pointer
    // 080 CreateDate                               ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime
    // 090 Costume                                  ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer
    // 098 ShowUnitBonus                            ModelPrimitiveType bool bool bool Bool
    public partial class LiveIdol : DataModel
    {
        public LiveUnitIdolType                         Type                                    { get; set; }
        public int                                      CharacterId                             { get; set; }
        public int                                      MstProduceIdolId                        { get; set; }
        public string                                   FesIdolId                               { get; set; }
        public ProduceParameterRank                     FesIdolRank                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public LiveIdolParameter                        Parameter                               { get; set; }
        public float                                    UnitBonusRate                           { get; set; }
        public int                                      StarLevel                               { get; set; }
        public int                                      IdolLevel                               { get; set; }
        public float                                    IdolLevelGaugeRate                      { get; set; }
        public int                                      DearnessLevel                           { get; set; }
        public float                                    DearnessLevelGaugeRate                  { get; set; }
        public long                                     Fan                                     { get; set; }
        public int                                      FavoriteMarkId                          { get; set; }
        public MstPotentialLiveSkillLevel?              Skill                                   { get; set; }
        public DateTime                                 CreateDate                              { get; set; }
        public CharacterCostume?                        Costume                                 { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }

        public static LiveIdol? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdol() { Pointer= p0 };

            value.Type                                      = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x010)); // 0x10 Type                        ( ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.CharacterId                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 CharacterId                 ( ModelPrimitiveType int int int Int32 )
            value.MstProduceIdolId                          = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstProduceIdolId            ( ModelPrimitiveType int int int Int32 )
            value.FesIdolId                                 = GetString(new IntPtr(p + 0x020)); // 0x20 FesIdolId                   ( ModelPrimitiveType string string string String )
            value.FesIdolRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x028)); // 0x28 FesIdolRank                 ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x02C)); // 0x2C UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.Parameter                                 = (LiveIdolParameter)GetInt32(new IntPtr(p + 0x030)); // 0x30 Parameter                   ( ModelEnumType LiveIdolParameter LiveIdolParameter LiveIdolParameter Int32 )
            value.UnitBonusRate                             = GetSingle(new IntPtr(p + 0x04C)); // 0x4C UnitBonusRate               ( ModelPrimitiveType float float float Single )
            value.StarLevel                                 = GetInt32(new IntPtr(p + 0x050)); // 0x50 StarLevel                   ( ModelPrimitiveType int int int Int32 )
            value.IdolLevel                                 = GetInt32(new IntPtr(p + 0x054)); // 0x54 IdolLevel                   ( ModelPrimitiveType int int int Int32 )
            value.IdolLevelGaugeRate                        = GetSingle(new IntPtr(p + 0x058)); // 0x58 IdolLevelGaugeRate          ( ModelPrimitiveType float float float Single )
            value.DearnessLevel                             = GetInt32(new IntPtr(p + 0x05C)); // 0x5C DearnessLevel               ( ModelPrimitiveType int int int Int32 )
            value.DearnessLevelGaugeRate                    = GetSingle(new IntPtr(p + 0x060)); // 0x60 DearnessLevelGaugeRate      ( ModelPrimitiveType float float float Single )
            value.Fan                                       = GetInt64(new IntPtr(p + 0x068)); // 0x68 Fan                         ( ModelPrimitiveType long long long Int64 )
            value.FavoriteMarkId                            = GetInt32(new IntPtr(p + 0x070)); // 0x70 FavoriteMarkId              ( ModelPrimitiveType int int int Int32 )
            value.Skill                                     = GetObject<MstPotentialLiveSkillLevel>(new IntPtr(p + 0x078), ReversePrism.DataModels.MstPotentialLiveSkillLevel.FromPointer); // 0x78 Skill                       ( ModelClassType MstPotentialLiveSkillLevel MstPotentialLiveSkillLevel MstPotentialLiveSkillLevel Pointer )
            value.CreateDate                                = GetDateTime(new IntPtr(p + 0x080)); // 0x80 CreateDate                  ( ModelPrimitiveType Nullable`1<DateTime> Nullable`1<DateTime> DateTime DateTime )
            value.Costume                                   = GetObject<CharacterCostume>(new IntPtr(p + 0x090), ReversePrism.DataModels.CharacterCostume.FromPointer); // 0x90 Costume                     ( ModelClassType CharacterCostume CharacterCostume CharacterCostume Pointer )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x098)); // 0x98 ShowUnitBonus               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
