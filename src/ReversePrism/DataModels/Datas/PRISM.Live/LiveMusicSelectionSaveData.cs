using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultMusicId                           int IL2CPP_TYPE_I4
    // 020 CategoryIndex                            ModelPrimitiveType int int int Int32
    // 024 MusicId                                  ModelPrimitiveType int int int Int32
    // 028 MusicDifficulty                          ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 02C SwitchDisplayIndex                       ModelPrimitiveType int int int Int32
    // 030 SortFilterSettings                       ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    // 038 <AlreadyReadMusicIds>k__BackingField     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 040 ListDisplayType                          ModelEnumType MusicListSwitchDisplayType MusicListSwitchDisplayType MusicListSwitchDisplayType Int32
    // 044 RateViewType                             ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 048 AlreadyReadMusicIds                      ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class LiveMusicSelectionSaveData : DataModel
    {
        public int                                      CategoryIndex                           { get; set; }
        public int                                      MusicId                                 { get; set; }
        public SongDifficultyLevel                      MusicDifficulty                         { get; set; }
        public int                                      SwitchDisplayIndex                      { get; set; }
        public SortFilterSettings?                      SortFilterSettings                      { get; set; }
        public MusicListSwitchDisplayType               ListDisplayType                         { get; set; }
        public MusicRateType                            RateViewType                            { get; set; }
        public List<int>?                               AlreadyReadMusicIds                     { get; set; }

        public static LiveMusicSelectionSaveData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionSaveData() { Pointer= p0 };

            value.CategoryIndex                             = GetInt32(new IntPtr(p + 0x020)); // 0x20 CategoryIndex               ( ModelPrimitiveType int int int Int32 )
            value.MusicId                                   = GetInt32(new IntPtr(p + 0x024)); // 0x24 MusicId                     ( ModelPrimitiveType int int int Int32 )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x028)); // 0x28 MusicDifficulty             ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.SwitchDisplayIndex                        = GetInt32(new IntPtr(p + 0x02C)); // 0x2C SwitchDisplayIndex          ( ModelPrimitiveType int int int Int32 )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x030), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0x30 SortFilterSettings          ( ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )
            value.ListDisplayType                           = (MusicListSwitchDisplayType)GetInt32(new IntPtr(p + 0x040)); // 0x40 ListDisplayType             ( ModelEnumType MusicListSwitchDisplayType MusicListSwitchDisplayType MusicListSwitchDisplayType Int32 )
            value.RateViewType                              = (MusicRateType)GetInt32(new IntPtr(p + 0x044)); // 0x44 RateViewType                ( ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.AlreadyReadMusicIds                       = GetInt32List(new IntPtr(p + 0x048)); // 0x48 AlreadyReadMusicIds         ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
