using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4260 ModelPrimitiveType int int int Int32
    // 014 ExtraStoryType                           0001865F4260 ModelPrimitiveType int int int Int32
    // 018 EpisodeNumber                            0001865F4260 ModelPrimitiveType int int int Int32
    // 01C MstExtraStorySubCategoryId               0001865F4260 ModelPrimitiveType int int int Int32
    // 020 SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 028 ScenarioId                               000186672F10 ModelPrimitiveType string string string String
    // 030 MstCharacterInfoIdList                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 038 UnlockPremiseMstExtraStoryId             0001865F4260 ModelPrimitiveType int int int Int32
    // 040 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 UnlockDate                               0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 050 HasUnlockDate                            0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 054 PreviousMstExtraStoryId                  0001865F4260 ModelPrimitiveType int int int Int32
    // 058 MstExtraStorySubCategory                 000186620620 ModelClassType MstExtraStorySubCategory MstExtraStorySubCategory MstExtraStorySubCategory Pointer
    public partial class MstExtraStory
    {
        public int                                      Id                                      { get; set; }
        public int                                      ExtraStoryType                          { get; set; }
        public int                                      EpisodeNumber                           { get; set; }
        public int                                      MstExtraStorySubCategoryId              { get; set; }
        public int                                      SortId                                  { get; set; }
        public string                                   ScenarioId                              { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public int                                      UnlockPremiseMstExtraStoryId            { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public DateTime                                 UnlockDate                              { get; set; }
        public bool                                     HasUnlockDate                           { get; set; }
        public int                                      PreviousMstExtraStoryId                 { get; set; }
        public MstExtraStorySubCategory?                MstExtraStorySubCategory                { get; set; }

        public static MstExtraStory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstExtraStory();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270046003C0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ExtraStoryType                            = GetInt32(new IntPtr(p + 0x014)); // 0270046003E0 0x14 ExtraStoryType              ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x018)); // 027004600400 0x18 EpisodeNumber               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategoryId                = GetInt32(new IntPtr(p + 0x01C)); // 027004600420 0x1C MstExtraStorySubCategoryId  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x020)); // 027004600440 0x20 SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x028)); // 027004600460 0x28 ScenarioId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x030)); // 027004600480 0x30 MstCharacterInfoIdList      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstExtraStoryId              = GetInt32(new IntPtr(p + 0x038)); // 0270046004A0 0x38 UnlockPremiseMstExtraStoryId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x040)); // 0270046004C0 0x40 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.UnlockDate                                = GetDateTime(new IntPtr(p + 0x048)); // 0270046004E0 0x48 UnlockDate                  ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.HasUnlockDate                             = GetBool(new IntPtr(p + 0x050)); // 027004600500 0x50 HasUnlockDate               ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.PreviousMstExtraStoryId                   = GetInt32(new IntPtr(p + 0x054)); // 027004600520 0x54 PreviousMstExtraStoryId     ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategory                  = GetObject<MstExtraStorySubCategory>(new IntPtr(p + 0x058), ReversePrism.DataModels.MstExtraStorySubCategory.FromPointer); // 027004600540 0x58 MstExtraStorySubCategory    ( 000186620620 ModelClassType MstExtraStorySubCategory MstExtraStorySubCategory MstExtraStorySubCategory Pointer )

            return value;
        }
    }
}
