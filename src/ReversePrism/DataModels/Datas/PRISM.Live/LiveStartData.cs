using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 MusicMaster                              ModelClassType MstSong MstSong MstSong Pointer
    // 018 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 01C MusicLevel                               ModelPrimitiveType int int int Int32
    // 020 TargetScoreRanks                         ModelClassType MstLiveScoreRankTarget MstLiveScoreRankTarget MstLiveScoreRankTarget Pointer
    // 028 LiveIdols                                ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer
    // 030 OnStageIdols                             ModelClassListType UnitIdolWithMstCostume[] UnitIdolWithMstCostume[] List<UnitIdolWithMstCostume> Pointer
    // 038 CameraIndex                              ModelPrimitiveType int int int Int32
    // 03C IsVocalSeparatedOn                       ModelPrimitiveType bool bool bool Bool
    // 040 UnitTotalParameter                       ModelPrimitiveType int int int Int32
    // 044 StartType                                ModelEnumType LiveStartType LiveStartType LiveStartType Int32
    // 048 BackgroundMode                           ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32
    // 050 ViewStack                                ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer
    public partial class LiveStartData : DataModel
    {
        public MstSong?                                 MusicMaster                             { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public int                                      MusicLevel                              { get; set; }
        public MstLiveScoreRankTarget?                  TargetScoreRanks                        { get; set; }
        public List<LiveIdol>?                          LiveIdols                               { get; set; }
        public List<UnitIdolWithMstCostume>?            OnStageIdols                            { get; set; }
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

            value.MusicMaster                               = GetObject<MstSong>(new IntPtr(p + 0x010), ReversePrism.DataModels.MstSong.FromPointer); // 0x10 MusicMaster                 ( ModelClassType MstSong MstSong MstSong Pointer )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x018)); // 0x18 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MusicLevel                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MusicLevel                  ( ModelPrimitiveType int int int Int32 )
            value.TargetScoreRanks                          = GetObject<MstLiveScoreRankTarget>(new IntPtr(p + 0x020), ReversePrism.DataModels.MstLiveScoreRankTarget.FromPointer); // 0x20 TargetScoreRanks            ( ModelClassType MstLiveScoreRankTarget MstLiveScoreRankTarget MstLiveScoreRankTarget Pointer )
            value.LiveIdols                                 = GetObjectList<LiveIdol>(new IntPtr(p + 0x028), ReversePrism.DataModels.LiveIdol.FromPointer); // 0x28 LiveIdols                   ( ModelClassListType LiveIdol[] LiveIdol[] List<LiveIdol> Pointer )
            value.OnStageIdols                              = GetObjectList<UnitIdolWithMstCostume>(new IntPtr(p + 0x030), ReversePrism.DataModels.UnitIdolWithMstCostume.FromPointer); // 0x30 OnStageIdols                ( ModelClassListType UnitIdolWithMstCostume[] UnitIdolWithMstCostume[] List<UnitIdolWithMstCostume> Pointer )
            value.CameraIndex                               = GetInt32(new IntPtr(p + 0x038)); // 0x38 CameraIndex                 ( ModelPrimitiveType int int int Int32 )
            value.IsVocalSeparatedOn                        = GetBool(new IntPtr(p + 0x03C)); // 0x3C IsVocalSeparatedOn          ( ModelPrimitiveType bool bool bool Bool )
            value.UnitTotalParameter                        = GetInt32(new IntPtr(p + 0x040)); // 0x40 UnitTotalParameter          ( ModelPrimitiveType int int int Int32 )
            value.StartType                                 = (LiveStartType)GetInt32(new IntPtr(p + 0x044)); // 0x44 StartType                   ( ModelEnumType LiveStartType LiveStartType LiveStartType Int32 )
            value.BackgroundMode                            = (LiveBackgroundMode)GetInt32(new IntPtr(p + 0x048)); // 0x48 BackgroundMode              ( ModelEnumType LiveBackgroundMode LiveBackgroundMode LiveBackgroundMode Int32 )
            value.ViewStack                                 = GetObjectList<ViewValue>(new IntPtr(p + 0x050), ReversePrism.DataModels.ViewValue.FromPointer); // 0x50 ViewStack                   ( ModelClassListType ViewValue[] ViewValue[] List<ViewValue> Pointer )

            return value;
        }
    }
}
