using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompleteCount                            ModelPrimitiveType int int int Int32
    // 014 TasksLength                              ModelPrimitiveType int int int Int32
    // 018 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class WhenAllPromise : DataModel
    {
        public int                                      CompleteCount                           { get; set; }
        public int                                      TasksLength                             { get; set; }

        public static WhenAllPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAllPromise() { Pointer= p0 };

            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x010)); // 0x10 CompleteCount               ( ModelPrimitiveType int int int Int32 )
            value.TasksLength                               = GetInt32(new IntPtr(p + 0x014)); // 0x14 TasksLength                 ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
