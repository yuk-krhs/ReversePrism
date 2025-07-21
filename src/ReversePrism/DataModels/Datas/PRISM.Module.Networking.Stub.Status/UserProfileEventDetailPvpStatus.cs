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
    // 018 FinalRank                                ModelPrimitiveType int int int Int32
    // 000 HighestRankFieldNumber                   int IL2CPP_TYPE_I4
    // 01C HighestRank                              ModelPrimitiveType int int int Int32
    public partial class UserProfileEventDetailPvpStatus : DataModel
    {
        public int                                      FinalRank                               { get; set; }
        public int                                      HighestRank                             { get; set; }

        public static UserProfileEventDetailPvpStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UserProfileEventDetailPvpStatus() { Pointer= p0 };

            value.FinalRank                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 FinalRank                   ( ModelPrimitiveType int int int Int32 )
            value.HighestRank                               = GetInt32(new IntPtr(p + 0x01C)); // 0x1C HighestRank                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
