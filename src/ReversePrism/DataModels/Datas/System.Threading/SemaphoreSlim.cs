using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_currentCount                           ModelPrimitiveType int int int Int32
    // 014 M_maxCount                               ModelPrimitiveType int int int Int32
    // 018 M_waitCount                              ModelPrimitiveType int int int Int32
    // 020 m_lockObj                                <object> IL2CPP_TYPE_OBJECT
    // 028 M_waitHandle                             ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer
    // 030 M_asyncHead                              ModelClassType TaskNode TaskNode TaskNode Pointer
    // 038 M_asyncTail                              ModelClassType TaskNode TaskNode TaskNode Pointer
    // 000 s_trueTask                               Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 008 s_falseTask                              Task`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 NO_MAXIMUM                               int IL2CPP_TYPE_I4
    // 010 s_cancellationTokenCanceledEventHandler  Action`1<<object>> IL2CPP_TYPE_GENERICINST
    public partial class SemaphoreSlim : DataModel
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
            var value   = new SemaphoreSlim() { Pointer= p0 };

            value.M_currentCount                            = GetInt32(new IntPtr(p + 0x010)); // 0x10 M_currentCount              ( ModelPrimitiveType int int int Int32 )
            value.M_maxCount                                = GetInt32(new IntPtr(p + 0x014)); // 0x14 M_maxCount                  ( ModelPrimitiveType int int int Int32 )
            value.M_waitCount                               = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_waitCount                 ( ModelPrimitiveType int int int Int32 )
            value.M_waitHandle                              = GetObject<ManualResetEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.ManualResetEvent.FromPointer); // 0x28 M_waitHandle                ( ModelClassType ManualResetEvent ManualResetEvent ManualResetEvent Pointer )
            value.M_asyncHead                               = GetObject<TaskNode>(new IntPtr(p + 0x030), ReversePrism.DataModels.TaskNode.FromPointer); // 0x30 M_asyncHead                 ( ModelClassType TaskNode TaskNode TaskNode Pointer )
            value.M_asyncTail                               = GetObject<TaskNode>(new IntPtr(p + 0x038), ReversePrism.DataModels.TaskNode.FromPointer); // 0x38 M_asyncTail                 ( ModelClassType TaskNode TaskNode TaskNode Pointer )

            return value;
        }
    }
}
