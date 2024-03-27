using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CompleteCount                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 014 TasksLength                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 018 core                                     UniTaskCompletionSourceCore`1<AsyncUnit> IL2CPP_TYPE_GENERICINST
    public partial class WhenAllPromise
    {
        public int                                      CompleteCount                           { get; set; }
        public int                                      TasksLength                             { get; set; }

        public static WhenAllPromise? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WhenAllPromise();

            value.CompleteCount                             = GetInt32(new IntPtr(p + 0x010)); // 027003AE2268 0x10 CompleteCount               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TasksLength                               = GetInt32(new IntPtr(p + 0x014)); // 027003AE2288 0x14 TasksLength                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
