using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsLongReference                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 018 GcHandle                                 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32
    public partial class WeakReference
    {
        public bool                                     IsLongReference                         { get; set; }
        public GCHandle                                 GcHandle                                { get; set; }

        public static WeakReference? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WeakReference();

            value.IsLongReference                           = GetBool(new IntPtr(p + 0x010)); // 027004CFCA18 0x10 IsLongReference             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.GcHandle                                  = (GCHandle)GetInt32(new IntPtr(p + 0x018)); // 027004CFCA38 0x18 GcHandle                    ( 0001865D9120 ModelEnumType GCHandle GCHandle GCHandle Int32 )

            return value;
        }
    }
}
