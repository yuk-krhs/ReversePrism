using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSeasonMissionRankRewardArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSeasonMissionIdFieldNumber            int IL2CPP_TYPE_I4
    // 018 MstSeasonMissionId                       ModelPrimitiveType int int int Int32
    public partial class ReceiveSeasonMissionRankRewardArgs : DataModel
    {
        public int                                      MstSeasonMissionId                      { get; set; }

        public static ReceiveSeasonMissionRankRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSeasonMissionRankRewardArgs() { Pointer= p0 };

            value.MstSeasonMissionId                        = GetInt32(new IntPtr(p + 0x018)); // 0x18 MstSeasonMissionId          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
