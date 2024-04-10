using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ScoreDetail                              000186553EE0 ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer
    // 018 NextStoryTitle                           000186672F10 ModelPrimitiveType string string string String
    // 020 NextStoryChapterPoint                    0001865F8300 ModelPrimitiveType long long long Int64
    // 028 NextStoryStatus                          0001866A0BD0 ModelEnumType NextStoryStatus NextStoryStatus NextStoryStatus Int32
    public partial class LiveResultEventPhaseViewModel : DataModel
    {
        public LiveEventScoreDetailData?                ScoreDetail                             { get; set; }
        public string                                   NextStoryTitle                          { get; set; }
        public long                                     NextStoryChapterPoint                   { get; set; }
        public NextStoryStatus                          NextStoryStatus                         { get; set; }

        public static LiveResultEventPhaseViewModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveResultEventPhaseViewModel() { Pointer= p0 };

            value.ScoreDetail                               = GetObject<LiveEventScoreDetailData>(new IntPtr(p + 0x010), ReversePrism.DataModels.LiveEventScoreDetailData.FromPointer); // 0246652ACBC8 0x10 ScoreDetail                 ( 000186553EE0 ModelClassType LiveEventScoreDetailData LiveEventScoreDetailData LiveEventScoreDetailData Pointer )
            value.NextStoryTitle                            = GetString(new IntPtr(p + 0x018)); // 0246652ACBE8 0x18 NextStoryTitle              ( 000186672F10 ModelPrimitiveType string string string String )
            value.NextStoryChapterPoint                     = GetInt64(new IntPtr(p + 0x020)); // 0246652ACC08 0x20 NextStoryChapterPoint       ( 0001865F8300 ModelPrimitiveType long long long Int64 )
            value.NextStoryStatus                           = (NextStoryStatus)GetInt32(new IntPtr(p + 0x028)); // 0246652ACC28 0x28 NextStoryStatus             ( 0001866A0BD0 ModelEnumType NextStoryStatus NextStoryStatus NextStoryStatus Int32 )

            return value;
        }
    }
}
