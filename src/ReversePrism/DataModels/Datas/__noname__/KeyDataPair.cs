using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainUserId                              0001865F36C0 ModelPrimitiveType int int int Int32
    // 018 Data                                     00018673E380 ModelClassType TypingData TypingData TypingData Pointer
    public partial class KeyDataPair
    {
        public int                                      ChainUserId                             { get; set; }
        public TypingData?                              Data                                    { get; set; }

        public static KeyDataPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyDataPair();

            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0270DB1145A0 0x10 ChainUserId                 ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetObject<TypingData>(new IntPtr(p + 0x018), ReversePrism.DataModels.TypingData.FromPointer); // 0270DB1145C0 0x18 Data                        ( 00018673E380 ModelClassType TypingData TypingData TypingData Pointer )

            return value;
        }
    }
}
