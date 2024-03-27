using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 EpisodeNumber                            0001865F4260 ModelPrimitiveType int int int Int32
    // 018 MstMainStoryChapterId                    0001865F4260 ModelPrimitiveType int int int Int32
    // 01C SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstCharacterInfoIdList                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 UnlockPremiseMstMainStoryId              0001865F4260 ModelPrimitiveType int int int Int32
    // 030 RewardProductList                        000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 PreviousMstMainStoryId                   0001865F4260 ModelPrimitiveType int int int Int32
    // 048 MstMainStoryChapter                      000186625EF0 ModelClassType MstMainStoryChapter MstMainStoryChapter MstMainStoryChapter Pointer
    public partial class MstMainStory
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
            var value   = new MstMainStory();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 027004694ED0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 027004694EF0 0x14 EpisodeNumber               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstMainStoryChapterId                     = GetInt32(new IntPtr(p + 0x018)); // 027004694F10 0x18 MstMainStoryChapterId       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x01C)); // 027004694F30 0x1C SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x020)); // 027004694F50 0x20 MstCharacterInfoIdList      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstMainStoryId               = GetInt32(new IntPtr(p + 0x028)); // 027004694F70 0x28 UnlockPremiseMstMainStoryId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardProductList                         = GetStringList(new IntPtr(p + 0x030)); // 027004694F90 0x30 RewardProductList           ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 027004694FB0 0x38 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PreviousMstMainStoryId                    = GetInt32(new IntPtr(p + 0x040)); // 027004694FD0 0x40 PreviousMstMainStoryId      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstMainStoryChapter                       = GetObject<MstMainStoryChapter>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstMainStoryChapter.FromPointer); // 027004694FF0 0x48 MstMainStoryChapter         ( 000186625EF0 ModelClassType MstMainStoryChapter MstMainStoryChapter MstMainStoryChapter Pointer )

            return value;
        }
    }
}
