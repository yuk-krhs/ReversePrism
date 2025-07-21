using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<ScheduleRewardStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceRewardTypeFieldNumber             int IL2CPP_TYPE_I4
    // 018 ProduceRewardType                        ModelEnumType ProduceRewardType ProduceRewardType ProduceRewardType Int32
    public partial class ScheduleRewardStatus : DataModel
    {
        public ProduceRewardType                        ProduceRewardType                       { get; set; }

        public static ScheduleRewardStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScheduleRewardStatus() { Pointer= p0 };

            value.ProduceRewardType                         = (ProduceRewardType)GetInt32(new IntPtr(p + 0x018)); // 0x18 ProduceRewardType           ( ModelEnumType ProduceRewardType ProduceRewardType ProduceRewardType Int32 )

            return value;
        }
    }
}
