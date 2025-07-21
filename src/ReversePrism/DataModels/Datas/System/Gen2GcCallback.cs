using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 _callback                                Func`2<<object>, bool> IL2CPP_TYPE_GENERICINST
    // 018 WeakTargetObj                            ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class Gen2GcCallback : DataModel
    {
        public GCHandle                                 WeakTargetObj                           { get; set; }

        public static Gen2GcCallback? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Gen2GcCallback() { Pointer= p0 };

            value.WeakTargetObj                             = (GCHandle)GetInt32(new IntPtr(p + 0x018)); // 0x18 WeakTargetObj               ( ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
