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
    public partial class WordOnSePlayer : DataModel
    {
        public TimeSpan                                 DelayTime                               { get; set; }
        public bool                                     IsPlaying                               { get; set; }

        public static WordOnSePlayer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WordOnSePlayer() { Pointer= p0 };

            value.DelayTime                                 = (TimeSpan)GetInt32(new IntPtr(p + 0x010)); // 02466B14AE38 0x10 DelayTime                   ( 00018668B520 ModelEnumType TimeSpan TimeSpan TimeSpan Int32 )
            value.IsPlaying                                 = GetBool(new IntPtr(p + 0x018)); // 02466B14AE58 0x18 IsPlaying                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
