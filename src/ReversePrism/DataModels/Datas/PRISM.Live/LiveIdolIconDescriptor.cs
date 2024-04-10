using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SkillSummary                             000186671910 ModelPrimitiveType string string string String
    // 018 IdolIconId                               000186672F10 ModelPrimitiveType string string string String
    // 020 IdolType                                 000186603140 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32
    // 024 FesIdolRank                              00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32
    // 028 UnitId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 02C TotalParameter                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 UnitBonusRate                            000186666CB0 ModelPrimitiveType float float float Single
    // 034 StarLevel                                0001865F4260 ModelPrimitiveType int int int Int32
    // 038 FavoriteMarkId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C PositionMark                             000186559440 ModelEnumType LiveIdolPositionMark LiveIdolPositionMark LiveIdolPositionMark Int32
    // 040 IsInSameUnit                             0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 041 IsBeingSet                               0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 042 IsGrayOut                                0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 043 ShowUnitBonus                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 044 IsInteractable                           0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 045 IsSoloMarkOn                             0001865965D0 ModelPrimitiveType bool bool bool Bool
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
        public int                                      FavoriteMarkId                          { get; set; }
        public LiveIdolPositionMark                     PositionMark                            { get; set; }
        public bool                                     IsInSameUnit                            { get; set; }
        public bool                                     IsBeingSet                              { get; set; }
        public bool                                     IsGrayOut                               { get; set; }
        public bool                                     ShowUnitBonus                           { get; set; }
        public bool                                     IsInteractable                          { get; set; }
        public bool                                     IsSoloMarkOn                            { get; set; }

        public static LiveIdolIconDescriptor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveIdolIconDescriptor() { Pointer= p0 };

            value.SkillSummary                              = GetString(new IntPtr(p + 0x010)); // 0246651592E8 0x10 SkillSummary                ( 000186671910 ModelPrimitiveType string string string String )
            value.IdolIconId                                = GetString(new IntPtr(p + 0x018)); // 024665159308 0x18 IdolIconId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.IdolType                                  = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x020)); // 024665159328 0x20 IdolType                    ( 000186603140 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.FesIdolRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x024)); // 024665159348 0x24 FesIdolRank                 ( 00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 024665159368 0x28 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x02C)); // 024665159388 0x2C TotalParameter              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitBonusRate                             = GetSingle(new IntPtr(p + 0x030)); // 0246651593A8 0x30 UnitBonusRate               ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.StarLevel                                 = GetInt32(new IntPtr(p + 0x034)); // 0246651593C8 0x34 StarLevel                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FavoriteMarkId                            = GetInt32(new IntPtr(p + 0x038)); // 0246651593E8 0x38 FavoriteMarkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PositionMark                              = (LiveIdolPositionMark)GetInt32(new IntPtr(p + 0x03C)); // 024665159408 0x3C PositionMark                ( 000186559440 ModelEnumType LiveIdolPositionMark LiveIdolPositionMark LiveIdolPositionMark Int32 )
            value.IsInSameUnit                              = GetBool(new IntPtr(p + 0x040)); // 024665159428 0x40 IsInSameUnit                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsBeingSet                                = GetBool(new IntPtr(p + 0x041)); // 024665159448 0x41 IsBeingSet                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsGrayOut                                 = GetBool(new IntPtr(p + 0x042)); // 024665159468 0x42 IsGrayOut                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x043)); // 024665159488 0x43 ShowUnitBonus               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsInteractable                            = GetBool(new IntPtr(p + 0x044)); // 0246651594A8 0x44 IsInteractable              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsSoloMarkOn                              = GetBool(new IntPtr(p + 0x045)); // 0246651594C8 0x45 IsSoloMarkOn                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
