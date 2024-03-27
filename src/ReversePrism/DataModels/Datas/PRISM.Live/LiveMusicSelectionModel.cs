using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllMusic                                 000185CF5008 ModelClassListType List`1<MusicData> List`1<MusicData> List<MusicData> Pointer
    // 018 rawMusicListDic                          Dictionary`2<int, IList`1<MusicData>> IL2CPP_TYPE_GENERICINST
    // 020 currentCategorySortFilterAppliedMusicList IList`1<MusicData> IL2CPP_TYPE_GENERICINST
    // 028 selectedMusicDic                         Dictionary`2<int, MusicData> IL2CPP_TYPE_GENERICINST
    // 030 SaveData                                 000186565F70 ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer
    // 038 favoriteMusicGroups                      Dictionary`2<FavoriteSongSlot, FavoriteMusicGroup> IL2CPP_TYPE_GENERICINST
    // 040 <MusicCategoryList>k__BackingField       IList`1<MstSongType> IL2CPP_TYPE_GENERICINST
    // 048 SelectedCategoryIndex                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 SortFilterModel                          000186668160 ModelClassType MusicListSortFilterModel MusicListSortFilterModel MusicListSortFilterModel Pointer
    // 058 SelectedMusicDifficulty                  00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 060 MusicRewardHandler                       000186672F40 ModelClassType MusicRewardHandler MusicRewardHandler MusicRewardHandler Pointer
    // 068 EventViewModel                           0001865640F0 ModelClassType LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel Pointer
    public partial class LiveMusicSelectionModel
    {
        public List<MusicData>?                         AllMusic                                { get; set; }
        public LiveMusicSelectionSaveData?              SaveData                                { get; set; }
        public int                                      SelectedCategoryIndex                   { get; set; }
        public MusicListSortFilterModel?                SortFilterModel                         { get; set; }
        public SongDifficultyLevel                      SelectedMusicDifficulty                 { get; set; }
        public MusicRewardHandler?                      MusicRewardHandler                      { get; set; }
        public LiveMusicSelectionEventViewModel?        EventViewModel                          { get; set; }

        public static LiveMusicSelectionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionModel();

            value.AllMusic                                  = GetObjectList<MusicData>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicData.FromPointer); // 0270D5137958 0x10 AllMusic                    ( 000185CF5008 ModelClassListType List`1<MusicData> List`1<MusicData> List<MusicData> Pointer )
            value.SaveData                                  = GetObject<LiveMusicSelectionSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveMusicSelectionSaveData.FromPointer); // 0270D51379D8 0x30 SaveData                    ( 000186565F70 ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer )
            value.SelectedCategoryIndex                     = GetInt32(new IntPtr(p + 0x048)); // 0270D5137A38 0x48 SelectedCategoryIndex       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SortFilterModel                           = GetObject<MusicListSortFilterModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicListSortFilterModel.FromPointer); // 0270D5137A58 0x50 SortFilterModel             ( 000186668160 ModelClassType MusicListSortFilterModel MusicListSortFilterModel MusicListSortFilterModel Pointer )
            value.SelectedMusicDifficulty                   = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x058)); // 0270D5137A78 0x58 SelectedMusicDifficulty     ( 00018661C520 ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.MusicRewardHandler                        = GetObject<MusicRewardHandler>(new IntPtr(p + 0x060), ReversePrism.DataModels.MusicRewardHandler.FromPointer); // 0270D5137A98 0x60 MusicRewardHandler          ( 000186672F40 ModelClassType MusicRewardHandler MusicRewardHandler MusicRewardHandler Pointer )
            value.EventViewModel                            = GetObject<LiveMusicSelectionEventViewModel>(new IntPtr(p + 0x068), ReversePrism.DataModels.LiveMusicSelectionEventViewModel.FromPointer); // 0270D5137AB8 0x68 EventViewModel              ( 0001865640F0 ModelClassType LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel Pointer )

            return value;
        }
    }
}
