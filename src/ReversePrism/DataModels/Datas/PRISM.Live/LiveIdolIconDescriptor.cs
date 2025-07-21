using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillSummary                             ModelPrimitiveType string string string String
    // 018 IdolIconId                               ModelPrimitiveType string string string String
    // 020 IdolType                                 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 024 FesIdolRank                              ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 028 UnitId                                   ModelPrimitiveType int int int Int32
    // 02C TotalParameter                           ModelPrimitiveType int int int Int32
    // 030 UnitBonusRate                            ModelPrimitiveType float float float Single
    // 034 StarLevel                                ModelPrimitiveType int int int Int32
    // 038 IdolLevel                                ModelPrimitiveType int int int Int32
    // 03C IdolLevelGaugeRate                       ModelPrimitiveType float float float Single
    // 040 DearnessLevel                            ModelPrimitiveType int int int Int32
    // 044 DearnessLevelGaugeRate                   ModelPrimitiveType float float float Single
    // 048 Fan                                      ModelPrimitiveType long long long Int64
    // 050 FavoriteMarkId                           ModelPrimitiveType int int int Int32
    // 054 PositionMark                             ModelEnumType LiveIdolPositionMark LiveIdolPositionMark LiveIdolPositionMark Int32
    // 058 IsInSameUnit                             ModelPrimitiveType bool bool bool Bool
    // 059 IsBeingSet                               ModelPrimitiveType bool bool bool Bool
    // 05A IsGrayOut                                ModelPrimitiveType bool bool bool Bool
    // 05B ShowUnitBonus                            ModelPrimitiveType bool bool bool Bool
    // 05C IsInteractable                           ModelPrimitiveType bool bool bool Bool
    // 05D IsLimitedVocalSeparate                   ModelPrimitiveType bool bool bool Bool
    // 05E IsUseTotalParameter                      ModelPrimitiveType bool bool bool Bool
    // 060 UnitIconOverlayType                      ModelEnumType UnitIconOverlayType UnitIconOverlayType UnitIconOverlayType Int32
    public partial class LiveIdolIconDescriptor : DataModel
    {
        public string                                   SkillSummary                            { get; set; }
        public string                                   IdolIconId                              { get; set; }
        public LiveUnitIdolType                         IdolType                                { get; set; }
        public ProduceParameterRank                     FesIdolRank                             { get; set; }
        public int                                      UnitId                                  { get; set; }
        public int                                      TotalParameter                          { get; set; }
        public float                                    UnitBonusRate                           { get; set; }
        public int                                      StarLevel                               { get; set; }
        public int                                      IdolLevel                               { get; set; }
        public float                                    IdolLevelGaugeRate                      { get; set; }
        public int                                      DearnessLevel                           { get; set; }
        public float                                    DearnessLevelGaugeRate                  { get; set; }
        public long                                     Fan                                     { get; set; }
        public int                                      FavoriteMarkId                          { get; set; }
        public LiveIdolPositionMark                     PositionMark                            { get; set; }
        public bool                                     IsInSameUnit                            { get; set; }
        public bool                                     IsBeingSet                              { get; set; }
        public bool                                     IsGrayOut                               { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }
        public bool                                     IsInteractable                          { get; set; }
        public bool                                     IsLimitedVocalSeparate                  { get; set; }
        public bool                                     IsUseTotalParameter                     { get; set; }
        public UnitIconOverlayType                      UnitIconOverlayType                     { get; set; }

        public static LiveIdolIconDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolIconDescriptor() { Pointer= p0 };

            value.SkillSummary                              = GetString(new IntPtr(p + 0x010)); // 0x10 SkillSummary                ( ModelPrimitiveType string string string String )
            value.IdolIconId                                = GetString(new IntPtr(p + 0x018)); // 0x18 IdolIconId                  ( ModelPrimitiveType string string string String )
            value.IdolType                                  = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x020)); // 0x20 IdolType                    ( ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.FesIdolRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x024)); // 0x24 FesIdolRank                 ( ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnitId                      ( ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TotalParameter              ( ModelPrimitiveType int int int Int32 )
            value.UnitBonusRate                             = GetSingle(new IntPtr(p + 0x030)); // 0x30 UnitBonusRate               ( ModelPrimitiveType float float float Single )
            value.StarLevel                                 = GetInt32(new IntPtr(p + 0x034)); // 0x34 StarLevel                   ( ModelPrimitiveType int int int Int32 )
            value.IdolLevel                                 = GetInt32(new IntPtr(p + 0x038)); // 0x38 IdolLevel                   ( ModelPrimitiveType int int int Int32 )
            value.IdolLevelGaugeRate                        = GetSingle(new IntPtr(p + 0x03C)); // 0x3C IdolLevelGaugeRate          ( ModelPrimitiveType float float float Single )
            value.DearnessLevel                             = GetInt32(new IntPtr(p + 0x040)); // 0x40 DearnessLevel               ( ModelPrimitiveType int int int Int32 )
            value.DearnessLevelGaugeRate                    = GetSingle(new IntPtr(p + 0x044)); // 0x44 DearnessLevelGaugeRate      ( ModelPrimitiveType float float float Single )
            value.Fan                                       = GetInt64(new IntPtr(p + 0x048)); // 0x48 Fan                         ( ModelPrimitiveType long long long Int64 )
            value.FavoriteMarkId                            = GetInt32(new IntPtr(p + 0x050)); // 0x50 FavoriteMarkId              ( ModelPrimitiveType int int int Int32 )
            value.PositionMark                              = (LiveIdolPositionMark)GetInt32(new IntPtr(p + 0x054)); // 0x54 PositionMark                ( ModelEnumType LiveIdolPositionMark LiveIdolPositionMark LiveIdolPositionMark Int32 )
            value.IsInSameUnit                              = GetBool(new IntPtr(p + 0x058)); // 0x58 IsInSameUnit                ( ModelPrimitiveType bool bool bool Bool )
            value.IsBeingSet                                = GetBool(new IntPtr(p + 0x059)); // 0x59 IsBeingSet                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsGrayOut                                 = GetBool(new IntPtr(p + 0x05A)); // 0x5A IsGrayOut                   ( ModelPrimitiveType bool bool bool Bool )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x05B)); // 0x5B ShowUnitBonus               ( ModelPrimitiveType bool bool bool Bool )
            value.IsInteractable                            = GetBool(new IntPtr(p + 0x05C)); // 0x5C IsInteractable              ( ModelPrimitiveType bool bool bool Bool )
            value.IsLimitedVocalSeparate                    = GetBool(new IntPtr(p + 0x05D)); // 0x5D IsLimitedVocalSeparate      ( ModelPrimitiveType bool bool bool Bool )
            value.IsUseTotalParameter                       = GetBool(new IntPtr(p + 0x05E)); // 0x5E IsUseTotalParameter         ( ModelPrimitiveType bool bool bool Bool )
            value.UnitIconOverlayType                       = (UnitIconOverlayType)GetInt32(new IntPtr(p + 0x060)); // 0x60 UnitIconOverlayType         ( ModelEnumType UnitIconOverlayType UnitIconOverlayType UnitIconOverlayType Int32 )

            return value;
        }
    }
}
