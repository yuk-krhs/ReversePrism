using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 Prev                                     ModelClassType TaskNode TaskNode TaskNode Pointer
    // 060 Next                                     ModelClassType TaskNode TaskNode TaskNode Pointer
    public partial class TaskNode : DataModel
    {
        public TaskNode?                                Prev                                    { get; set; }
        public TaskNode?                                Next                                    { get; set; }

        public static TaskNode? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TaskNode() { Pointer= p0 };

            value.Prev                                      = GetObject<TaskNode>(new IntPtr(p + 0x058), ReversePrism.DataModels.TaskNode.FromPointer); // 0x58 Prev                        ( ModelClassType TaskNode TaskNode TaskNode Pointer )
            value.Next                                      = GetObject<TaskNode>(new IntPtr(p + 0x060), ReversePrism.DataModels.TaskNode.FromPointer); // 0x60 Next                        ( ModelClassType TaskNode TaskNode TaskNode Pointer )

            return value;
        }
    }
}
