using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<UserProfileEventDetailPvpStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FinalRankFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FinalRank                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 HighestRankFieldNumber                   int IL2CPP_TYPE_I4
    // 01C HighestRank                              0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class UserProfileEventDetailPvpStatus
    {
        public int                                      FinalRank                               { get; set; }
        public int                                      HighestRank                             { get; set; }

        public static UserProfileEventDetailPvpStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileEventDetailPvpStatus();

            value.FinalRank                                 = GetInt32(new IntPtr(p + 0x018)); // 0270D27216E0 0x18 FinalRank                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.HighestRank                               = GetInt32(new IntPtr(p + 0x01C)); // 0270D2721720 0x1C HighestRank                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
