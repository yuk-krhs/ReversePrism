using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DefaultThinkingSecond                    ModelPrimitiveListType float[] float[] List<float> Pointer
    // 020 DefaultTypeNonTextSecond                 ModelPrimitiveListType float[] float[] List<float> Pointer
    // 028 DefaultTypingRate                        ModelPrimitiveListType float[] float[] List<float> Pointer
    // 030 TypingSecondLimitsMin                    ModelPrimitiveType float float float Single
    // 034 TypingSecondLimitsMax                    ModelPrimitiveType float float float Single
    // 038 TypingDataArray                          ModelClassListType KeyDataPair[] KeyDataPair[] List<KeyDataPair> Pointer
    public partial class ChainTalkUserTypingData : DataModel
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
            var value   = new ChainTalkUserTypingData() { Pointer= p0 };

            value.DefaultThinkingSecond                     = GetSingleList(new IntPtr(p + 0x018)); // 0x18 DefaultThinkingSecond       ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.DefaultTypeNonTextSecond                  = GetSingleList(new IntPtr(p + 0x020)); // 0x20 DefaultTypeNonTextSecond    ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.DefaultTypingRate                         = GetSingleList(new IntPtr(p + 0x028)); // 0x28 DefaultTypingRate           ( ModelPrimitiveListType float[] float[] List<float> Pointer )
            value.TypingSecondLimitsMin                     = GetSingle(new IntPtr(p + 0x030)); // 0x30 TypingSecondLimitsMin       ( ModelPrimitiveType float float float Single )
            value.TypingSecondLimitsMax                     = GetSingle(new IntPtr(p + 0x034)); // 0x34 TypingSecondLimitsMax       ( ModelPrimitiveType float float float Single )
            value.TypingDataArray                           = GetObjectList<KeyDataPair>(new IntPtr(p + 0x038), ReversePrism.DataModels.KeyDataPair.FromPointer); // 0x38 TypingDataArray             ( ModelClassListType KeyDataPair[] KeyDataPair[] List<KeyDataPair> Pointer )

            return value;
        }
    }
}
