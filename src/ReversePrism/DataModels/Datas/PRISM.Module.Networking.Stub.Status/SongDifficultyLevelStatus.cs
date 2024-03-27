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
    // 018 DifficultyLevel                          000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 000 SongLevelFieldNumber                     int IL2CPP_TYPE_I4
    // 01C SongLevel                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NotesFieldNumber                         int IL2CPP_TYPE_I4
    // 020 Notes                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ClearedFieldNumber                       int IL2CPP_TYPE_I4
    // 024 Cleared                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ComboRankFieldNumber                     int IL2CPP_TYPE_I4
    // 028 ComboRank                                0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32
    // 000 ScoreRankFieldNumber                     int IL2CPP_TYPE_I4
    // 02C ScoreRank                                0001866EDE40 ModelEnumType ScoreRank ScoreRank ScoreRank Int32
    // 000 HighScoreFieldNumber                     int IL2CPP_TYPE_I4
    // 030 HighScore                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighScoreRatingFieldNumber               int IL2CPP_TYPE_I4
    // 034 HighScoreRating                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TechnicalScoreFieldNumber                int IL2CPP_TYPE_I4
    // 038 TechnicalScore                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 TechnicalRatingFieldNumber               int IL2CPP_TYPE_I4
    // 03C TechnicalRating                          0001866656B0 ModelPrimitiveType float float float Single
    // 000 IsFullComboFieldNumber                   int IL2CPP_TYPE_I4
    // 040 IsFullCombo                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsAllGreatFieldNumber                    int IL2CPP_TYPE_I4
    // 041 IsAllGreat                               000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsAllPerfectFieldNumber                  int IL2CPP_TYPE_I4
    // 042 IsAllPerfect                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ScoreRankListFieldNumber                 int IL2CPP_TYPE_I4
    // 008 _repeated_scoreRankList_codec            FieldCodec`1<ScoreRankStatus> IL2CPP_TYPE_GENERICINST
    // 048 ScoreRankList                            000185CEFF18 ModelClassListType RepeatedField`1<ScoreRankStatus> RepeatedField`1<ScoreRankStatus> List<ScoreRankStatus> Pointer
    // 000 ComboRankListFieldNumber                 int IL2CPP_TYPE_I4
    // 010 _repeated_comboRankList_codec            FieldCodec`1<ComboRankStatus> IL2CPP_TYPE_GENERICINST
    // 050 ComboRankList                            000185CD22B8 ModelClassListType RepeatedField`1<ComboRankStatus> RepeatedField`1<ComboRankStatus> List<ComboRankStatus> Pointer
    // 000 IsClearedFieldNumber                     int IL2CPP_TYPE_I4
    // 058 IsCleared                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsAutoLiveClearedFieldNumber             int IL2CPP_TYPE_I4
    // 059 IsAutoLiveCleared                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 IsSkipLiveClearedFieldNumber             int IL2CPP_TYPE_I4
    // 05A IsSkipLiveCleared                        000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SongDifficultyLevelStatus
    {
        public SongDifficultyLevel                      DifficultyLevel                         { get; set; }
        public int                                      SongLevel                               { get; set; }
        public int                                      Notes                                   { get; set; }
        public int                                      Cleared                                 { get; set; }
        public ComboRank                                ComboRank                               { get; set; }
        public ScoreRank                                ScoreRank                               { get; set; }
        public int                                      HighScore                               { get; set; }
        public int                                      HighScoreRating                         { get; set; }
        public int                                      TechnicalScore                          { get; set; }
        public float                                    TechnicalRating                         { get; set; }
        public bool                                     IsFullCombo                             { get; set; }
        public bool                                     IsAllGreat                              { get; set; }
        public bool                                     IsAllPerfect                            { get; set; }
        public List<ScoreRankStatus>?                   ScoreRankList                           { get; set; }
        public List<ComboRankStatus>?                   ComboRankList                           { get; set; }
        public bool                                     IsCleared                               { get; set; }
        public bool                                     IsAutoLiveCleared                       { get; set; }
        public bool                                     IsSkipLiveCleared                       { get; set; }

        public static SongDifficultyLevelStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SongDifficultyLevelStatus();

            value.DifficultyLevel                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0270D1370F18 0x18 DifficultyLevel             ( 000186529820 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.SongLevel                                 = GetInt32(new IntPtr(p + 0x01C)); // 0270D1370F58 0x1C SongLevel                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Notes                                     = GetInt32(new IntPtr(p + 0x020)); // 0270D1370F98 0x20 Notes                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Cleared                                   = GetInt32(new IntPtr(p + 0x024)); // 0270D1370FD8 0x24 Cleared                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ComboRank                                 = (ComboRank)GetInt32(new IntPtr(p + 0x028)); // 0270D1371018 0x28 ComboRank                   ( 0001865DE690 ModelEnumType ComboRank ComboRank ComboRank Int32 )
            value.ScoreRank                                 = (ScoreRank)GetInt32(new IntPtr(p + 0x02C)); // 0270D1371058 0x2C ScoreRank                   ( 0001866EDE40 ModelEnumType ScoreRank ScoreRank ScoreRank Int32 )
            value.HighScore                                 = GetInt32(new IntPtr(p + 0x030)); // 0270D1371098 0x30 HighScore                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighScoreRating                           = GetInt32(new IntPtr(p + 0x034)); // 0270D13710D8 0x34 HighScoreRating             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TechnicalScore                            = GetInt32(new IntPtr(p + 0x038)); // 0270D1371118 0x38 TechnicalScore              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TechnicalRating                           = GetSingle(new IntPtr(p + 0x03C)); // 0270D1371158 0x3C TechnicalRating             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.IsFullCombo                               = GetBool(new IntPtr(p + 0x040)); // 0270D1371198 0x40 IsFullCombo                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAllGreat                                = GetBool(new IntPtr(p + 0x041)); // 0270D13711D8 0x41 IsAllGreat                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAllPerfect                              = GetBool(new IntPtr(p + 0x042)); // 0270D1371218 0x42 IsAllPerfect                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ScoreRankList                             = GetObjectList<ScoreRankStatus>(new IntPtr(p + 0x048), ReversePrism.DataModels.ScoreRankStatus.FromPointer); // 0270D1371278 0x48 ScoreRankList               ( 000185CEFF18 ModelClassListType RepeatedField`1<ScoreRankStatus> RepeatedField`1<ScoreRankStatus> List<ScoreRankStatus> Pointer )
            value.ComboRankList                             = GetObjectList<ComboRankStatus>(new IntPtr(p + 0x050), ReversePrism.DataModels.ComboRankStatus.FromPointer); // 0270D13712D8 0x50 ComboRankList               ( 000185CD22B8 ModelClassListType RepeatedField`1<ComboRankStatus> RepeatedField`1<ComboRankStatus> List<ComboRankStatus> Pointer )
            value.IsCleared                                 = GetBool(new IntPtr(p + 0x058)); // 0270D1371318 0x58 IsCleared                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAutoLiveCleared                         = GetBool(new IntPtr(p + 0x059)); // 0270D1371358 0x59 IsAutoLiveCleared           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsSkipLiveCleared                         = GetBool(new IntPtr(p + 0x05A)); // 0270D1371398 0x5A IsSkipLiveCleared           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
