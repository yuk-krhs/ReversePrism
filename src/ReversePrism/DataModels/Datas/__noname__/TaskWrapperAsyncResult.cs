using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Task                                     ModelClassType Task Task Task Pointer
    // 018 _state                                   <object> IL2CPP_TYPE_OBJECT
    // 020 CompletedSynchronously                   ModelPrimitiveType bool bool bool Bool
    public partial class TaskWrapperAsyncResult : DataModel
    {
        public Task?                                    Task                                    { get; set; }
        public bool                                     CompletedSynchronously                  { get; set; }

        public static TaskWrapperAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskWrapperAsyncResult() { Pointer= p0 };

            value.Task                                      = GetObject<Task>(new IntPtr(p + 0x010), ReversePrism.DataModels.Task.FromPointer); // 0x10 Task                        ( ModelClassType Task Task Task Pointer )
            value.CompletedSynchronously                    = GetBool(new IntPtr(p + 0x020)); // 0x20 CompletedSynchronously      ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
