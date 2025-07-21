using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AllMusic                                 ModelClassListType List`1<MusicData> List`1<MusicData> List<MusicData> Pointer
    // 018 rawMusicListDic                          Dictionary`2<int, IList`1<MusicData>> IL2CPP_TYPE_GENERICINST
    // 020 currentCategorySortFilterAppliedMusicList IList`1<MusicData> IL2CPP_TYPE_GENERICINST
    // 028 selectedMusicDic                         Dictionary`2<int, MusicData> IL2CPP_TYPE_GENERICINST
    // 030 SaveData                                 ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer
    // 038 favoriteMusicGroups                      Dictionary`2<FavoriteSongSlot, FavoriteMusicGroup> IL2CPP_TYPE_GENERICINST
    // 040 <MusicCategoryList>k__BackingField       IList`1<MstSongType> IL2CPP_TYPE_GENERICINST
    // 048 SelectedCategoryIndex                    ModelPrimitiveType int int int Int32
    // 050 SortFilterModel                          ModelClassType MusicListSortFilterModel MusicListSortFilterModel MusicListSortFilterModel Pointer
    // 058 SelectedMusicDifficulty                  ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32
    // 060 EventViewModel                           ModelClassType LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel Pointer
    public partial class LiveMusicSelectionModel : DataModel
    {
        public List<MusicData>?                         AllMusic                                { get; set; }
        public LiveMusicSelectionSaveData?              SaveData                                { get; set; }
        public int                                      SelectedCategoryIndex                   { get; set; }
        public MusicListSortFilterModel?                SortFilterModel                         { get; set; }
        public SongDifficultyLevel                      SelectedMusicDifficulty                 { get; set; }
        public LiveMusicSelectionEventViewModel?        EventViewModel                          { get; set; }

        public static LiveMusicSelectionModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveMusicSelectionModel() { Pointer= p0 };

            value.AllMusic                                  = GetObjectList<MusicData>(new IntPtr(p + 0x010), ReversePrism.DataModels.MusicData.FromPointer); // 0x10 AllMusic                    ( ModelClassListType List`1<MusicData> List`1<MusicData> List<MusicData> Pointer )
            value.SaveData                                  = GetObject<LiveMusicSelectionSaveData>(new IntPtr(p + 0x030), ReversePrism.DataModels.LiveMusicSelectionSaveData.FromPointer); // 0x30 SaveData                    ( ModelClassType LiveMusicSelectionSaveData LiveMusicSelectionSaveData LiveMusicSelectionSaveData Pointer )
            value.SelectedCategoryIndex                     = GetInt32(new IntPtr(p + 0x048)); // 0x48 SelectedCategoryIndex       ( ModelPrimitiveType int int int Int32 )
            value.SortFilterModel                           = GetObject<MusicListSortFilterModel>(new IntPtr(p + 0x050), ReversePrism.DataModels.MusicListSortFilterModel.FromPointer); // 0x50 SortFilterModel             ( ModelClassType MusicListSortFilterModel MusicListSortFilterModel MusicListSortFilterModel Pointer )
            value.SelectedMusicDifficulty                   = (SongDifficultyLevel)GetInt32(new IntPtr(p + 0x058)); // 0x58 SelectedMusicDifficulty     ( ModelEnumType SongDifficultyLevel SongDifficultyLevel SongDifficultyLevel Int32 )
            value.EventViewModel                            = GetObject<LiveMusicSelectionEventViewModel>(new IntPtr(p + 0x060), ReversePrism.DataModels.LiveMusicSelectionEventViewModel.FromPointer); // 0x60 EventViewModel              ( ModelClassType LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel LiveMusicSelectionEventViewModel Pointer )

            return value;
        }
    }
}
