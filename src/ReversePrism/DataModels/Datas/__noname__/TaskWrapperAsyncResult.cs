using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Task                                     000186681890 ModelClassType Task Task Task Pointer
    // 018 _state                                   <object> IL2CPP_TYPE_OBJECT
    // 020 CompletedSynchronously                   0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class TaskWrapperAsyncResult
    {
        public Task?                                    Task                                    { get; set; }
        public bool                                     CompletedSynchronously                  { get; set; }

        public static TaskWrapperAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskWrapperAsyncResult();

            value.Task                                      = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 0270D6AF57D0 0x10 Task                        ( 000186681890 ModelClassType Task Task Task Pointer )
            value.CompletedSynchronously                    = GetBool(new IntPtr(p + 0x020)); // 0270D6AF5810 0x20 CompletedSynchronously      ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
