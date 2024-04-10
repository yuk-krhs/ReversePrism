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
    // 018 MstIdolId                                0001865F4260 ModelPrimitiveType int int int Int32
    // 01C SortId                                   0001865F4260 ModelPrimitiveType int int int Int32
    // 020 MstCharacterInfoIdList                   000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer
    // 028 UnlockPremiseMstIdolStoryId              0001865F4260 ModelPrimitiveType int int int Int32
    // 02C UnlockPremiseIdolBaseDearness            0001865F4260 ModelPrimitiveType int int int Int32
    // 030 RewardProductList                        000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 ReleaseDate                              0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 PreviousMstIdolStoryId                   0001865F4260 ModelPrimitiveType int int int Int32
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

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0245A466BEA0 0x10 Id                          ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 0245A466BEC0 0x14 EpisodeNumber               ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstIdolId                                 = GetInt32(new IntPtr(p + 0x018)); // 0245A466BEE0 0x18 MstIdolId                   ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A466BF00 0x1C SortId                      ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x020)); // 0245A466BF20 0x20 MstCharacterInfoIdList      ( 000185B7D9E0 ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstIdolStoryId               = GetInt32(new IntPtr(p + 0x028)); // 0245A466BF40 0x28 UnlockPremiseMstIdolStoryId ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseIdolBaseDearness             = GetInt32(new IntPtr(p + 0x02C)); // 0245A466BF60 0x2C UnlockPremiseIdolBaseDearness ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.RewardProductList                         = GetStringList(new IntPtr(p + 0x030)); // 0245A466BF80 0x30 RewardProductList           ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 0245A466BFA0 0x38 ReleaseDate                 ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PreviousMstIdolStoryId                    = GetInt32(new IntPtr(p + 0x040)); // 0245A466BFC0 0x40 PreviousMstIdolStoryId      ( 0001865F4260 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
