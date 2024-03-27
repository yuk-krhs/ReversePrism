using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DefaultThinkingSecond                    000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 DefaultTypeNonTextSecond                 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 DefaultTypingRate                        000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 TypingSecondLimitsMin                    0001866656B0 ModelPrimitiveType float float float Single
    // 034 TypingSecondLimitsMax                    0001866656B0 ModelPrimitiveType float float float Single
    // 038 TypingDataArray                          000185CB7368 ModelClassListType KeyDataPair[] KeyDataPair[] List<KeyDataPair> Pointer
    public partial class ChainTalkUserTypingData
    {
        public List<float>?                             DefaultThinkingSecond                   { get; set; }
        public List<float>?                             DefaultTypeNonTextSecond                { get; set; }
        public List<float>?                             DefaultTypingRate                       { get; set; }
        public float                                    TypingSecondLimitsMin                   { get; set; }
        public float                                    TypingSecondLimitsMax                   { get; set; }
        public List<KeyDataPair>?                       TypingDataArray                         { get; set; }

        public static ChainTalkUserTypingData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChainTalkUserTypingData();

            value.DefaultThinkingSecond                     = GetSingleList(new IntPtr(p + 0x018)); // 0270DB1145F0 0x18 DefaultThinkingSecond       ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.DefaultTypeNonTextSecond                  = GetSingleList(new IntPtr(p + 0x020)); // 0270DB114610 0x20 DefaultTypeNonTextSecond    ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.DefaultTypingRate                         = GetSingleList(new IntPtr(p + 0x028)); // 0270DB114630 0x28 DefaultTypingRate           ( 000185B80520 ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.TypingSecondLimitsMin                     = GetSingle(new IntPtr(p + 0x030)); // 0270DB114650 0x30 TypingSecondLimitsMin       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TypingSecondLimitsMax                     = GetSingle(new IntPtr(p + 0x034)); // 0270DB114670 0x34 TypingSecondLimitsMax       ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.TypingDataArray                           = GetObjectList<KeyDataPair>(new IntPtr(p + 0x038), ReversePrism.DataModels.KeyDataPair.FromPointer); // 0270DB114690 0x38 TypingDataArray             ( 000185CB7368 ModelClassListType KeyDataPair[] KeyDataPair[] List<KeyDataPair> Pointer )

            return value;
        }
    }
}
