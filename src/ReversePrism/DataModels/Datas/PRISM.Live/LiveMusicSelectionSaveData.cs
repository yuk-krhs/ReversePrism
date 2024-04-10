using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 DefaultMusicId                           int IL2CPP_TYPE_I4
    // 020 CategoryIndex                            0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 MusicId                                  0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 MusicDifficulty                          00018661C730 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 02C SwitchDisplayIndex                       0001865F36C0 ModelPrimitiveType int int int Int32
    // 030 SortFilterSettings                       0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer
    // 038 <AlreadyReadMusicIds>k__BackingField     HashSet`1<int> IL2CPP_TYPE_GENERICINST
    // 040 ListDisplayType                          000186668640 ModelEnumType MusicListSwitchDisplayType MusicListSwitchDisplayType MusicListSwitchDisplayType Int32
    // 044 RateViewType                             000186670EE0 ModelEnumType MusicRateType MusicRateType MusicRateType Int32
    // 048 AlreadyReadMusicIds                      000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer
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

            value.CategoryIndex                             = GetInt32(new IntPtr(p + 0x020)); // 0245A3A7D800 0x20 CategoryIndex               ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MusicId                                   = GetInt32(new IntPtr(p + 0x024)); // 0245A3A7D820 0x24 MusicId                     ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.MusicDifficulty                           = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x028)); // 0245A3A7D840 0x28 MusicDifficulty             ( 00018661C730 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.SwitchDisplayIndex                        = GetInt32(new IntPtr(p + 0x02C)); // 0245A3A7D860 0x2C SwitchDisplayIndex          ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.SortFilterSettings                        = GetObject<SortFilterSettings>(new IntPtr(p + 0x030), ReversePrism.DataModels.SortFilterSettings.FromPointer); // 0245A3A7D880 0x30 SortFilterSettings          ( 0001865300A0 ModelClassType SortFilterSettings SortFilterSettings SortFilterSettings Pointer )
            value.ListDisplayType                           = (MusicListSwitchDisplayType)GetInt32(new IntPtr(p + 0x040)); // 0245A3A7D8C0 0x40 ListDisplayType             ( 000186668640 ModelEnumType MusicListSwitchDisplayType MusicListSwitchDisplayType MusicListSwitchDisplayType Int32 )
            value.RateViewType                              = (MusicRateType)GetInt32(new IntPtr(p + 0x044)); // 0245A3A7D8E0 0x44 RateViewType                ( 000186670EE0 ModelEnumType MusicRateType MusicRateType MusicRateType Int32 )
            value.AlreadyReadMusicIds                       = GetInt32List(new IntPtr(p + 0x048)); // 0245A3A7D900 0x48 AlreadyReadMusicIds         ( 000185B7D2C0 ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
