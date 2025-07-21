using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       ModelPrimitiveType int int int Int32
    // 014 EpisodeNumber                            ModelPrimitiveType int int int Int32
    // 018 MstMainStoryChapterId                    ModelPrimitiveType int int int Int32
    // 01C SortId                                   ModelPrimitiveType int int int Int32
    // 020 MstCharacterInfoIdList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 UnlockPremiseMstMainStoryId              ModelPrimitiveType int int int Int32
    // 030 RewardProductList                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 PreviousMstMainStoryId                   ModelPrimitiveType int int int Int32
    // 048 MstMainStoryChapter                      ModelClassType MstMainStoryChapter MstMainStoryChapter MstMainStoryChapter Pointer
    public partial class MstMainStory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      EpisodeNumber                           { get; set; }
        public int                                      MstMainStoryChapterId                   { get; set; }
        public int                                      SortId                                  { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public int                                      UnlockPremiseMstMainStoryId             { get; set; }
        public List<string>?                            RewardProductList                       { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public int                                      PreviousMstMainStoryId                  { get; set; }
        public MstMainStoryChapter?                     MstMainStoryChapter                     { get; set; }

        public static MstMainStory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstMainStory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeNumber               ( ModelPrimitiveType int int int Int32 )
            value.MstMainStoryChapterId                     = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstMainStoryChapterId       ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstCharacterInfoIdList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstMainStoryId               = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnlockPremiseMstMainStoryId ( ModelPrimitiveType int int int Int32 )
            value.RewardProductList                         = GetStringList(new IntPtr(p + 0x030)); // 0x30 RewardProductList           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 0x38 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PreviousMstMainStoryId                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 PreviousMstMainStoryId      ( ModelPrimitiveType int int int Int32 )
            value.MstMainStoryChapter                       = GetObject<MstMainStoryChapter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstMainStoryChapter.FromPointer); // 0x48 MstMainStoryChapter         ( ModelClassType MstMainStoryChapter MstMainStoryChapter MstMainStoryChapter Pointer )

            return value;
        }
    }
}
