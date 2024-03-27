using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypingTypeTyping                         000186567730 ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32
    // 014 TypingTypeThinking                       000186567730 ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32
    // 018 ThinkingSecond                           000186666050 ModelPrimitiveType float float float Single
    // 01C SendNonTextSecond                        000186666050 ModelPrimitiveType float float float Single
    // 020 TypingRate                               000186666050 ModelPrimitiveType float float float Single
    public partial class TypingData
    {
        public ChainTalkTypingType                      TypingTypeTyping                        { get; set; }
        public ChainTalkTypingType                      TypingTypeThinking                      { get; set; }
        public float                                    ThinkingSecond                          { get; set; }
        public float                                    SendNonTextSecond                       { get; set; }
        public float                                    TypingRate                              { get; set; }

        public static TypingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TypingData();

            value.TypingTypeTyping                          = (ChainTalkTypingType)GetInt32(new IntPtr(p + 0x010)); // 0270DB1143B0 0x10 TypingTypeTyping            ( 000186567730 ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32 )
            value.TypingTypeThinking                        = (ChainTalkTypingType)GetInt32(new IntPtr(p + 0x014)); // 0270DB1143D0 0x14 TypingTypeThinking          ( 000186567730 ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32 )
            value.ThinkingSecond                            = GetSingle(new IntPtr(p + 0x018)); // 0270DB1143F0 0x18 ThinkingSecond              ( 000186666050 ModelPrimitiveType float float float Single )
            value.SendNonTextSecond                         = GetSingle(new IntPtr(p + 0x01C)); // 0270DB114410 0x1C SendNonTextSecond           ( 000186666050 ModelPrimitiveType float float float Single )
            value.TypingRate                                = GetSingle(new IntPtr(p + 0x020)); // 0270DB114430 0x20 TypingRate                  ( 000186666050 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
