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
    // 018 MstIdolId                                ModelPrimitiveType int int int Int32
    // 01C SortId                                   ModelPrimitiveType int int int Int32
    // 020 MstCharacterInfoIdList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 UnlockPremiseMstIdolStoryId              ModelPrimitiveType int int int Int32
    // 02C UnlockPremiseIdolBaseDearness            ModelPrimitiveType int int int Int32
    // 030 RewardProductList                        ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 PreviousMstIdolStoryId                   ModelPrimitiveType int int int Int32
    public partial class MstIdolStory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      EpisodeNumber                           { get; set; }
        public int                                      MstIdolId                               { get; set; }
        public int                                      SortId                                  { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public int                                      UnlockPremiseMstIdolStoryId             { get; set; }
        public int                                      UnlockPremiseIdolBaseDearness           { get; set; }
        public List<string>?                            RewardProductList                       { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public int                                      PreviousMstIdolStoryId                  { get; set; }

        public static MstIdolStory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstIdolStory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeNumber               ( ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstIdolId                   ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x020)); // 0x20 MstCharacterInfoIdList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstIdolStoryId               = GetInt32(new IntPtr(p + 0x028)); // 0x28 UnlockPremiseMstIdolStoryId ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseIdolBaseDearness             = GetInt32(new IntPtr(p + 0x02C)); // 0x2C UnlockPremiseIdolBaseDearness ( ModelPrimitiveType int int int Int32 )
            value.RewardProductList                         = GetStringList(new IntPtr(p + 0x030)); // 0x30 RewardProductList           ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 0x38 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PreviousMstIdolStoryId                    = GetInt32(new IntPtr(p + 0x040)); // 0x40 PreviousMstIdolStoryId      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
