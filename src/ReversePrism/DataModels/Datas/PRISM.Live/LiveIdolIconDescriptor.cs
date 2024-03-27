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
    public partial class LiveIdolIconDescriptor
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
            var value   = new LiveIdolIconDescriptor();

            value.SkillSummary                              = GetString(new IntPtr(p + 0x010)); // 0270D50EDAD8 0x10 SkillSummary                ( 000186671910 ModelPrimitiveType string string string String )
            value.IdolIconId                                = GetString(new IntPtr(p + 0x018)); // 0270D50EDAF8 0x18 IdolIconId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.IdolType                                  = (LiveUnitIdolType)GetInt32(new IntPtr(p + 0x020)); // 0270D50EDB18 0x20 IdolType                    ( 000186603140 ModelEnumType LiveUnitIdolType LiveUnitIdolType LiveUnitIdolType Int32 )
            value.FesIdolRank                               = (ProduceParameterRank)GetInt32(new IntPtr(p + 0x024)); // 0270D50EDB38 0x24 FesIdolRank                 ( 00018660DDC0 ModelEnumType ProduceParameterRank ProduceParameterRank ProduceParameterRank Int32 )
            value.UnitId                                    = GetInt32(new IntPtr(p + 0x028)); // 0270D50EDB58 0x28 UnitId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TotalParameter                            = GetInt32(new IntPtr(p + 0x02C)); // 0270D50EDB78 0x2C TotalParameter              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.UnitBonusRate                             = GetSingle(new IntPtr(p + 0x030)); // 0270D50EDB98 0x30 UnitBonusRate               ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.StarLevel                                 = GetInt32(new IntPtr(p + 0x034)); // 0270D50EDBB8 0x34 StarLevel                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.FavoriteMarkId                            = GetInt32(new IntPtr(p + 0x038)); // 0270D50EDBD8 0x38 FavoriteMarkId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PositionMark                              = (LiveIdolPositionMark)GetInt32(new IntPtr(p + 0x03C)); // 0270D50EDBF8 0x3C PositionMark                ( 000186559440 ModelEnumType LiveIdolPositionMark LiveIdolPositionMark LiveIdolPositionMark Int32 )
            value.IsInSameUnit                              = GetBool(new IntPtr(p + 0x040)); // 0270D50EDC18 0x40 IsInSameUnit                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsBeingSet                                = GetBool(new IntPtr(p + 0x041)); // 0270D50EDC38 0x41 IsBeingSet                  ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsGrayOut                                 = GetBool(new IntPtr(p + 0x042)); // 0270D50EDC58 0x42 IsGrayOut                   ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.ShowUnitBonus                             = GetBool(new IntPtr(p + 0x043)); // 0270D50EDC78 0x43 ShowUnitBonus               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsInteractable                            = GetBool(new IntPtr(p + 0x044)); // 0270D50EDC98 0x44 IsInteractable              ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.IsSoloMarkOn                              = GetBool(new IntPtr(p + 0x045)); // 0270D50EDCB8 0x45 IsSoloMarkOn                ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
