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
    // 018 ScenarioNumber                           ModelPrimitiveType int int int Int32
    // 01C MstEventId                               ModelPrimitiveType int int int Int32
    // 020 EpisodeType                              ModelPrimitiveType int int int Int32
    // 024 SortId                                   ModelPrimitiveType int int int Int32
    // 028 MstCharacterInfoIdList                   ModelPrimitiveListType int[] int[] List<int> Pointer
    // 030 UnlockPremiseMstEventStoryId             ModelPrimitiveType int int int Int32
    // 034 UnlockPremiseEventPoint                  ModelPrimitiveType int int int Int32
    // 038 ReleaseDate                              ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 040 PreviousMstEventStoryId                  ModelPrimitiveType int int int Int32
    // 048 MstEvent                                 ModelClassType MstEvent MstEvent MstEvent Pointer
    public partial class MstEventStory : DataModel
    {
        public int                                      Id                                      { get; set; }
        public int                                      EpisodeNumber                           { get; set; }
        public int                                      ScenarioNumber                          { get; set; }
        public int                                      MstEventId                              { get; set; }
        public int                                      EpisodeType                             { get; set; }
        public int                                      SortId                                  { get; set; }
        public List<int>?                               MstCharacterInfoIdList                  { get; set; }
        public int                                      UnlockPremiseMstEventStoryId            { get; set; }
        public int                                      UnlockPremiseEventPoint                 { get; set; }
        public DateTime                                 ReleaseDate                             { get; set; }
        public int                                      PreviousMstEventStoryId                 { get; set; }
        public MstEvent?                                MstEvent                                { get; set; }

        public static MstEventStory? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MstEventStory() { Pointer= p0 };

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0x10 Id                          ( ModelPrimitiveType int int int Int32 )
            value.EpisodeNumber                             = GetInt32(new IntPtr(p + 0x014)); // 0x14 EpisodeNumber               ( ModelPrimitiveType int int int Int32 )
            value.ScenarioNumber                            = GetInt32(new IntPtr(p + 0x018)); // 0x18 ScenarioNumber              ( ModelPrimitiveType int int int Int32 )
            value.MstEventId                                = GetInt32(new IntPtr(p + 0x01C)); // 0x1C MstEventId                  ( ModelPrimitiveType int int int Int32 )
            value.EpisodeType                               = GetInt32(new IntPtr(p + 0x020)); // 0x20 EpisodeType                 ( ModelPrimitiveType int int int Int32 )
            value.SortId                                    = GetInt32(new IntPtr(p + 0x024)); // 0x24 SortId                      ( ModelPrimitiveType int int int Int32 )
            value.MstCharacterInfoIdList                    = GetInt32List(new IntPtr(p + 0x028)); // 0x28 MstCharacterInfoIdList      ( ModelPrimitiveListType int[] int[] List<int> Pointer )
            value.UnlockPremiseMstEventStoryId              = GetInt32(new IntPtr(p + 0x030)); // 0x30 UnlockPremiseMstEventStoryId ( ModelPrimitiveType int int int Int32 )
            value.UnlockPremiseEventPoint                   = GetInt32(new IntPtr(p + 0x034)); // 0x34 UnlockPremiseEventPoint     ( ModelPrimitiveType int int int Int32 )
            value.ReleaseDate                               = GetDateTime(new IntPtr(p + 0x038)); // 0x38 ReleaseDate                 ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.PreviousMstEventStoryId                   = GetInt32(new IntPtr(p + 0x040)); // 0x40 PreviousMstEventStoryId     ( ModelPrimitiveType int int int Int32 )
            value.MstEvent                                  = GetObject<MstEvent>(new IntPtr(p + 0x048), ReversePrism.DataModels.MstEvent.FromPointer); // 0x48 MstEvent                    ( ModelClassType MstEvent MstEvent MstEvent Pointer )

            return value;
        }
    }
}
