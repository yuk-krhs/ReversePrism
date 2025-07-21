using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TypingTypeTyping                         ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32
    // 014 TypingTypeThinking                       ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32
    // 018 ThinkingSecond                           ModelPrimitiveType float float float Single
    // 01C SendNonTextSecond                        ModelPrimitiveType float float float Single
    // 020 TypingRate                               ModelPrimitiveType float float float Single
    public partial class TypingData : DataModel
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
            var value   = new TypingData() { Pointer= p0 };

            value.TypingTypeTyping                          = (ChainTalkTypingType)GetInt32(new IntPtr(p + 0x010)); // 0x10 TypingTypeTyping            ( ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32 )
            value.TypingTypeThinking                        = (ChainTalkTypingType)GetInt32(new IntPtr(p + 0x014)); // 0x14 TypingTypeThinking          ( ModelEnumType ChainTalkTypingType ChainTalkTypingType ChainTalkTypingType Int32 )
            value.ThinkingSecond                            = GetSingle(new IntPtr(p + 0x018)); // 0x18 ThinkingSecond              ( ModelPrimitiveType float float float Single )
            value.SendNonTextSecond                         = GetSingle(new IntPtr(p + 0x01C)); // 0x1C SendNonTextSecond           ( ModelPrimitiveType float float float Single )
            value.TypingRate                                = GetSingle(new IntPtr(p + 0x020)); // 0x20 TypingRate                  ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
