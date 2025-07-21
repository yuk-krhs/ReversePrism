using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetMedalGashaArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstMedalGashaIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 MstMedalGashaId                          ModelPrimitiveType int int int Int32
    public partial class GetMedalGashaArgs : DataModel
    {
        public int                                      MstMedalGashaId                         { get; set; }

        public static GetMedalGashaArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetMedalGashaArgs() { Pointer= p0 };

            value.MstMedalGashaId                           = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstMedalGashaId             ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
