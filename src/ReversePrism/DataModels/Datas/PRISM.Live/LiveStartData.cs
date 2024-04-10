using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer
    // 018 MusicDifficulty                          00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 01C MusicLevel                               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 TargetScoreRanks                         000185D09FA8 ModelClassListType IReadOnlyList`1<IScoreRankStatus> IReadOnlyList`1<IScoreRankStatus> List<IScoreRankStatus> Pointer
    // 028 LiveIdols                                000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 030 OnStageIdols                             000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer
    // 038 CameraIndex                              0001865F4260 ModelPrimitiveType int int int Int32
    // 03C IsVocalSeparatedOn                       0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 040 UnitTotalParameter                       0001865F4260 ModelPrimitiveType int int int Int32
    // 044 StartType                                0001866020A0 ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 048 BackgroundMode                           00018653FDD0 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 050 ViewStack                                000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LiveStartData : DataModel
    {
        public MstSong?                                 MusicMaster                             { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public int                                      MusicLevel                              { get; set; }
        public List<IScoreRankStatus>?                  TargetScoreRanks                        { get; set; }
        public List<LiveIdol>?                          LiveIdols                               { get; set; }
        public List<UnitIdol>?                          OnStageIdols                            { get; set; }
        public int                                      CameraIndex                             { get; set; }
        public bool                                     IsVocalSeparatedOn                      { get; set; }
        public int                                      UnitTotalParameter                      { get; set; }
        public LiveStartType                            StartType                               { get; set; }
        public LiveBackgroundMode                       BackgroundMode                          { get; set; }
        public List<ViewValue>?                         ViewStack                               { get; set; }

        public static LiveStartData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveStartData() { Pointer= p0 };

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 024664EA7738 0x10 MusicMaster                 ( 00018662C3A0 ModelClassType MstSong MstSong MstSong Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 024664EA7758 0x18 MusicDifficulty             ( 00018661C990 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MusicLevel                                = GetInt32(new IntPtr(p + 0x01C)); // 024664EA7778 0x1C MusicLevel                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.TargetScoreRanks                          = GetObjectList<IScoreRankStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IScoreRankStatus.FromPointer); // 024664EA7798 0x20 TargetScoreRanks            ( 000185D09FA8 ModelClassListType IReadOnlyList`1<IScoreRankStatus> IReadOnlyList`1<IScoreRankStatus> List<IScoreRankStatus> Pointer )
            value.LiveIdols                                 = GetObjectList<LiveIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveIdol.FromPointer); // 024664EA77B8 0x28 LiveIdols                   ( 000185B90A40 ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.OnStageIdols                              = GetObjectList<UnitIdol>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnitIdol.FromPointer); // 024664EA77D8 0x30 OnStageIdols                ( 000185CAF458 ModelClassListType UnitIdol[] UnitIdol[] List<UnitIdol> Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x038)); // 024664EA77F8 0x38 CameraIndex                 ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.IsVocalSeparatedOn                        = GetBool(new IntPtr(p + 0x03C)); // 024664EA7818 0x3C IsVocalSeparatedOn          ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.UnitTotalParameter                        = GetInt32(new IntPtr(p + 0x040)); // 024664EA7838 0x40 UnitTotalParameter          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x044)); // 024664EA7858 0x44 StartType                   ( 0001866020A0 ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x048)); // 024664EA7878 0x48 BackgroundMode              ( 00018653FDD0 ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x050), ReversePrism.DataModels.ViewValue.FromPointer); // 024664EA7898 0x50 ViewStack                   ( 000185CC59D8 ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
