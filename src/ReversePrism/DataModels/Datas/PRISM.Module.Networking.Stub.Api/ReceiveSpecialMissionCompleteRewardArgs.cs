using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ReceiveSpecialMissionCompleteRewardArgs> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSpecialMissionStepIdFieldNumber       int IL2CPP_TYPE_I4
    // 018 MstSpecialMissionStepId                  0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class ReceiveSpecialMissionCompleteRewardArgs : DataModel
    {
        public int                                      MstSpecialMissionStepId                 { get; set; }

        public static ReceiveSpecialMissionCompleteRewardArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReceiveSpecialMissionCompleteRewardArgs() { Pointer= p0 };

            value.MstSpecialMissionStepId                   = GetInt32(new IntPtr(p + 0x018)); // 02466283EFA0 0x18 MstSpecialMissionStepId     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
