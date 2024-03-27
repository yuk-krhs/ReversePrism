using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_currentCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 M_maxCount                               0001865F4260 ModelPrimitiveType int int int Int32
    // 018 M_waitCount                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 m_lockObj                                <object> IL2CPP_TYPE_OBJECT
    // 028 M_waitHandle                             00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 030 M_asyncHead                              00018675CB60 ModelClassType TaskNode TaskNode TaskNode Pointer
    // 038 M_asyncTail                              00018675CB60 ModelClassType TaskNode TaskNode TaskNode Pointer
    // 000 s_trueTask                               Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 s_falseTask                              Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 NO_MAXIMUM                               int IL2CPP_TYPE_I4
    // 010 s_cancellationTokenCanceledEventHandler  Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class SemaphoreSlim
    {
        public int                                      M_currentCount                          { get; set; }
        public int                                      M_maxCount                              { get; set; }
        public int                                      M_waitCount                             { get; set; }
        public ManualResetEvent?                        M_waitHandle                            { get; set; }
        public TaskNode?                                M_asyncHead                             { get; set; }
        public TaskNode?                                M_asyncTail                             { get; set; }

        public static SemaphoreSlim? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SemaphoreSlim();

            value.M_currentCount                            = GetInt32(new IntPtr(p + 0x010)); // 0270D0EA06A8 0x10 M_currentCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_maxCount                                = GetInt32(new IntPtr(p + 0x014)); // 0270D0EA06C8 0x14 M_maxCount                  ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.M_waitCount                               = GetInt32(new IntPtr(p + 0x018)); // 0270D0EA06E8 0x18 M_waitCount                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_waitHandle                              = GetObject<ManualResetEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0270D0EA0728 0x28 M_waitHandle                ( 00018660A400 ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.M_asyncHead                               = GetObject<TaskNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.TaskNode.FromPointer); // 0270D0EA0748 0x30 M_asyncHead                 ( 00018675CB60 ModelClassType TaskNode TaskNode TaskNode Pointer )
            value.M_asyncTail                               = GetObject<TaskNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.TaskNode.FromPointer); // 0270D0EA0768 0x38 M_asyncTail                 ( 00018675CB60 ModelClassType TaskNode TaskNode TaskNode Pointer )

            return value;
        }
    }
}
