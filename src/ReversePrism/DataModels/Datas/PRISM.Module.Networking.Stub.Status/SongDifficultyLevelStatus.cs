using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SongDifficultyLevelStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 DifficultyLevelFieldNumber               int IL2CPP_TYPE_I4
    // 018 DifficultyLevel                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 ComboRankFieldNumber                     int IL2CPP_TYPE_I4
    // 01C ComboRank                                ModelEnumType ComboRank ComboRank ComboRank Int32
    // 000 ScoreRankFieldNumber                     int IL2CPP_TYPE_I4
    // 020 ScoreRank                                ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 024 HighScore                                ModelPrimitiveType int int int Int32
    // 000 HighScoreRatingFieldNumber               int IL2CPP_TYPE_I4
    // 028 HighScoreRating                          ModelPrimitiveType int int int Int32
    // 000 TechnicalScoreFieldNumber                int IL2CPP_TYPE_I4
    // 02C TechnicalScore                           ModelPrimitiveType int int int Int32
    // 000 TechnicalRatingFieldNumber               int IL2CPP_TYPE_I4
    // 030 TechnicalRating                          ModelPrimitiveType float float float Single
    // 000 IsFullComboFieldNumber                   int IL2CPP_TYPE_I4
    // 034 IsFullCombo                              ModelPrimitiveType bool bool bool Bool
    // 000 IsAllGreatFieldNumber                    int IL2CPP_TYPE_I4
    // 035 IsAllGreat                               ModelPrimitiveType bool bool bool Bool
    // 000 IsAllPerfectFieldNumber                  int IL2CPP_TYPE_I4
    // 036 IsAllPerfect                             ModelPrimitiveType bool bool bool Bool
    // 000 IsClearedFieldNumber                     int IL2CPP_TYPE_I4
    // 037 IsCleared                                ModelPrimitiveType bool bool bool Bool
    // 000 IsAutoLiveClearedFieldNumber             int IL2CPP_TYPE_I4
    // 038 IsAutoLiveCleared                        ModelPrimitiveType bool bool bool Bool
    // 000 IsSkipLiveClearedFieldNumber             int IL2CPP_TYPE_I4
    // 039 IsSkipLiveCleared                        ModelPrimitiveType bool bool bool Bool
    // 000 ClearInfoFieldNumber                     int IL2CPP_TYPE_I4
    // 03C ClearInfo                                ModelEnumType LiveClearInfo LiveClearInfo LiveClearInfo Int32
    // 000 ComboFieldNumber                         int IL2CPP_TYPE_I4
    // 040 Combo                                    ModelPrimitiveType int int int Int32
    public partial class SongDifficultyLevelStatus : DataModel
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public ComboRank                                ComboRank                               { get; set; }
        public ScoreRank                                ScoreRank                               { get; set; }
        public int                                      HighScore                               { get; set; }
        public int                                      HighScoreRating                         { get; set; }
        public int                                      TechnicalScore                          { get; set; }
        public float                                    TechnicalRating                         { get; set; }
        public bool                                     IsFullCombo                             { get; set; }
        public bool                                     IsAllGreat                              { get; set; }
        public bool                                     IsAllPerfect                            { get; set; }
        public bool                                     IsCleared                               { get; set; }
        public bool                                     IsAutoLiveCleared                       { get; set; }
        public bool                                     IsSkipLiveCleared                       { get; set; }
        public LiveClearInfo                            ClearInfo                               { get; set; }
        public int                                      Combo                                   { get; set; }

        public static SongDifficultyLevelStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongDifficultyLevelStatus() { Pointer= p0 };

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 DifficultyLevel             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.ComboRank                                 = (ComboRank)GetInt32(new IntPtr(p + 0x01C)); // 0x1C ComboRank                   ( ModelEnumType ComboRank ComboRank ComboRank Int32 )
            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x020)); // 0x20 ScoreRank                   ( ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x024)); // 0x24 HighScore                   ( ModelPrimitiveType int int int Int32 )
            value.HighScoreRating                           = GetInt32(new IntPtr(p + 0x028)); // 0x28 HighScoreRating             ( ModelPrimitiveType int int int Int32 )
            value.TechnicalScore                            = GetInt32(new IntPtr(p + 0x02C)); // 0x2C TechnicalScore              ( ModelPrimitiveType int int int Int32 )
            value.TechnicalRating                           = GetSingle(new IntPtr(p + 0x030)); // 0x30 TechnicalRating             ( ModelPrimitiveType float float float Single )
            value.IsFullCombo                               = GetBool(new IntPtr(p + 0x034)); // 0x34 IsFullCombo                 ( ModelPrimitiveType bool bool bool Bool )
            value.IsAllGreat                                = GetBool(new IntPtr(p + 0x035)); // 0x35 IsAllGreat                  ( ModelPrimitiveType bool bool bool Bool )
            value.IsAllPerfect                              = GetBool(new IntPtr(p + 0x036)); // 0x36 IsAllPerfect                ( ModelPrimitiveType bool bool bool Bool )
            value.IsCleared                                 = GetBool(new IntPtr(p + 0x037)); // 0x37 IsCleared                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsAutoLiveCleared                         = GetBool(new IntPtr(p + 0x038)); // 0x38 IsAutoLiveCleared           ( ModelPrimitiveType bool bool bool Bool )
            value.IsSkipLiveCleared                         = GetBool(new IntPtr(p + 0x039)); // 0x39 IsSkipLiveCleared           ( ModelPrimitiveType bool bool bool Bool )
            value.ClearInfo                                 = (LiveClearInfo)GetInt32(new IntPtr(p + 0x03C)); // 0x3C ClearInfo                   ( ModelEnumType LiveClearInfo LiveClearInfo LiveClearInfo Int32 )
            value.Combo                                     = GetInt32(new IntPtr(p + 0x040)); // 0x40 Combo                       ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
