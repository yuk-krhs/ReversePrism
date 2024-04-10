using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<GetChallengeTourArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ChallengeTourIdFieldNumber               int IL2CPP_TYPE_I4
    // 018 ChallengeTourId                          0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class GetChallengeTourArgs : DataModel
    {
        public int                                      ChallengeTourId                         { get; set; }

        public static GetChallengeTourArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GetChallengeTourArgs() { Pointer= p0 };

            value.ChallengeTourId                           = GetInt32(new IntPtr(p + 0x018)); // 024660B2B030 0x18 ChallengeTourId             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
