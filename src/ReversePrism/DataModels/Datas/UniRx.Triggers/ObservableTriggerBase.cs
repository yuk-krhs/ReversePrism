using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 CalledAwake                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 028 awake                                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 030 CalledStart                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 start                                    Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    // 040 CalledDestroy                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 onDestroy                                Subject`1<Unit> IL2CPP_TYPE_GENERICINST
    public partial class ObservableTriggerBase : DataModel
    {
        public bool                                     CalledAwake                             { get; set; }
        public bool                                     CalledStart                             { get; set; }
        public bool                                     CalledDestroy                           { get; set; }

        public static ObservableTriggerBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObservableTriggerBase() { Pointer= p0 };

            value.CalledAwake                               = GetBool(new IntPtr(p + 0x020)); // 0245A439C518 0x20 CalledAwake                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CalledStart                               = GetBool(new IntPtr(p + 0x030)); // 0245A439C558 0x30 CalledStart                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CalledDestroy                             = GetBool(new IntPtr(p + 0x040)); // 0245A439C598 0x40 CalledDestroy               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
