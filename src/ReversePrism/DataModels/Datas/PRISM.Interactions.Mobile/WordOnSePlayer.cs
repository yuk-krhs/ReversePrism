using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DelayTime                                00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32
    // 018 IsPlaying                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class WordOnSePlayer
    {
        public TimeSpan                                 DelayTime                               { get; set; }
        public bool                                     IsPlaying                               { get; set; }

        public static WordOnSePlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WordOnSePlayer();

            value.DelayTime                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 0270DB0E2E38 0x10 DelayTime                   ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x018)); // 0270DB0E2E58 0x18 IsPlaying                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
