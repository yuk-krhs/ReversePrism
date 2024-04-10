using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SchedulerLoopSystem                      000186641630 ModelEnumType PlayerLoopSystem PlayerLoopSystem PlayerLoopSystem Int32
    // 038 M_TimeProvider                           000186672480 ModelClassType ITimeProvider ITimeProvider ITimeProvider Pointer
    // 040 m_Lock                                   <object> IL2CPP_TYPE_OBJECT
    // 048 m_ScheduledActions                       MinimumBinaryHeap`1<ScheduledInvocation> IL2CPP_TYPE_GENERICINST
    // 050 m_IdScheduledInvocationMap               Dictionary`2<long, ScheduledInvocation> IL2CPP_TYPE_GENERICINST
    // 058 M_ExpiredActions                         000185D063B8 ModelClassListType List`1<ScheduledInvocation> List`1<ScheduledInvocation> List<ScheduledInvocation> Pointer
    // 060 M_NextId                                 0001865F7700 ModelPrimitiveType long long long Int64
    public partial class ActionScheduler : DataModel
    {
        public PlayerLoopSystem                         SchedulerLoopSystem                     { get; set; }
        public ITimeProvider?                           M_TimeProvider                          { get; set; }
        public List<ScheduledInvocation>?               M_ExpiredActions                        { get; set; }
        public long                                     M_NextId                                { get; set; }

        public static ActionScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ActionScheduler() { Pointer= p0 };

            value.SchedulerLoopSystem                       = (PlayerLoopSystem)GetInt32(new IntPtr(p + 0x010)); // 0245A65F1B98 0x10 SchedulerLoopSystem         ( 000186641630 ModelEnumType PlayerLoopSystem PlayerLoopSystem PlayerLoopSystem Int32 )
            value.M_TimeProvider                            = GetObject<ITimeProvider>(new IntPtr(p + 0x038), ReversePrism.DataModels.ITimeProvider.FromPointer); // 0245A65F1BB8 0x38 M_TimeProvider              ( 000186672480 ModelClassType ITimeProvider ITimeProvider ITimeProvider Pointer )
            value.M_ExpiredActions                          = GetObjectList<ScheduledInvocation>(new IntPtr(p + 0x058), ReversePrism.DataModels.ScheduledInvocation.FromPointer); // 0245A65F1C38 0x58 M_ExpiredActions            ( 000185D063B8 ModelClassListType List`1<ScheduledInvocation> List`1<ScheduledInvocation> List<ScheduledInvocation> Pointer )
            value.M_NextId                                  = GetInt64(new IntPtr(p + 0x060)); // 0245A65F1C58 0x60 M_NextId                    ( 0001865F7700 ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
