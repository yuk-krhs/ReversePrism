using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 OuterEC                                  000186663E90 ModelEnumType Reader Reader Reader Int32
    // 018 OuterECBelongsToScope                    000186595210 ModelPrimitiveType bool bool bool Bool
    // 020 hecsw                                    <object> IL2CPP_TYPE_OBJECT
    // 028 Thread                                   000186688D10 ModelClassType Thread Thread Thread Pointer
    public partial class ExecutionContextSwitcher
    {
        public Reader                                   OuterEC                                 { get; set; }
        public bool                                     OuterECBelongsToScope                   { get; set; }
        public Thread?                                  Thread                                  { get; set; }

        public static ExecutionContextSwitcher? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExecutionContextSwitcher();

            value.OuterEC                                   = (Reader)GetInt32(new IntPtr(p + 0x010)); // 0270D6ACA9E0 0x10 OuterEC                     ( 000186663E90 ModelEnumType Reader Reader Reader Int32 )
            value.OuterECBelongsToScope                     = GetBool(new IntPtr(p + 0x018)); // 0270D6ACAA00 0x18 OuterECBelongsToScope       ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Thread                                    = GetObject<Thread>(new IntPtr(p + 0x028), ReversePrism.DataModels.Thread.FromPointer); // 0270D6ACAA40 0x28 Thread                      ( 000186688D10 ModelClassType Thread Thread Thread Pointer )

            return value;
        }
    }
}
