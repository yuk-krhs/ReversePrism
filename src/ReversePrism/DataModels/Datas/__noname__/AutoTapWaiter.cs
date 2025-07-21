using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsWaiting                                ModelPrimitiveType bool bool bool Bool
    // 014 StartTime                                ModelPrimitiveType float float float Single
    // 018 WaitSeconds                              ModelPrimitiveType float float float Single
    public partial class AutoTapWaiter : DataModel
    {
        public bool                                     IsWaiting                               { get; set; }
        public float                                    StartTime                               { get; set; }
        public float                                    WaitSeconds                             { get; set; }

        public static AutoTapWaiter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AutoTapWaiter() { Pointer= p0 };

            value.IsWaiting                                 = GetBool(new IntPtr(p + 0x010)); // 0x10 IsWaiting                   ( ModelPrimitiveType bool bool bool Bool )
            value.StartTime                                 = GetSingle(new IntPtr(p + 0x014)); // 0x14 StartTime                   ( ModelPrimitiveType float float float Single )
            value.WaitSeconds                               = GetSingle(new IntPtr(p + 0x018)); // 0x18 WaitSeconds                 ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
