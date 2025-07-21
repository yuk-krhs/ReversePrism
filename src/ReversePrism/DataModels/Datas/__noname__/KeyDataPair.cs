using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChainUserId                              ModelPrimitiveType int int int Int32
    // 018 Data                                     ModelClassType TypingData TypingData TypingData Pointer
    public partial class KeyDataPair : DataModel
    {
        public int                                      ChainUserId                             { get; set; }
        public TypingData?                              Data                                    { get; set; }

        public static KeyDataPair? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KeyDataPair() { Pointer= p0 };

            value.ChainUserId                               = GetInt32(new IntPtr(p + 0x010)); // 0x10 ChainUserId                 ( ModelPrimitiveType int int int Int32 )
            value.Data                                      = GetObject<TypingData>(new IntPtr(p + 0x018), ReversePrism.DataModels.TypingData.FromPointer); // 0x18 Data                        ( ModelClassType TypingData TypingData TypingData Pointer )

            return value;
        }
    }
}
