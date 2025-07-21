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
    // 018 MstExtraStorySubCategoryId               ModelPrimitiveType int int int Int32
    // 01C SortId                                   ModelPrimitiveType int int int Int32
    // 020 ScenarioId                               ModelPrimitiveType string string string String
    // 028 MstCharacterInfoIdList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 UnlockPremiseMstExtraStoryId             ModelPrimitiveType int int int Int32
    // 038 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 UnlockDate                               ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 048 HasUnlockDate                            ModelPrimitiveType bool bool bool Bool
    // 04C PreviousMstExtraStoryId                  ModelPrimitiveType int int int Int32
    // 050 MstExtraStorySubCategory                 ModelClassType MstExtraStorySubCategory MstExtraStorySubCategory MstExtraStorySubCategory Pointer
    public partial class MstExtraStory : DataModel
    {
        public int                                      Id                                      { get; set; }
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
            var value   = new MstExtraStory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeNumber               ( ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategoryId                = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstExtraStorySubCategoryId  ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SortId                      ( ModelPrimitiveType int int int Int32 )
            value.ScenarioId                                = GetString(new IntPtr(p + 0x020)); // 0x20 ScenarioId                  ( ModelPrimitiveType string string string String )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstCharacterInfoIdList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstExtraStoryId              = GetInt32(new IntPtr(p + 0x030)); // 0x30 UnlockPremiseMstExtraStoryId ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 0x38 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.UnlockDate                                = GetDateTime(new IntPtr(p + 0x040)); // 0x40 UnlockDate                  ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.HasUnlockDate                             = GetBool(new IntPtr(p + 0x048)); // 0x48 HasUnlockDate               ( ModelPrimitiveType bool bool bool Bool )
            value.PreviousMstExtraStoryId                   = GetInt32(new IntPtr(p + 0x04C)); // 0x4C PreviousMstExtraStoryId     ( ModelPrimitiveType int int int Int32 )
            value.MstExtraStorySubCategory                  = GetObject<MstExtraStorySubCategory>(new IntPtr(p + 0x050), ReversePrism.DataModels.MstExtraStorySubCategory.FromPointer); // 0x50 MstExtraStorySubCategory    ( ModelClassType MstExtraStorySubCategory MstExtraStorySubCategory MstExtraStorySubCategory Pointer )

            return value;
        }
    }
}
