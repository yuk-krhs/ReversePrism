using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Mode                                   ModelEnumType EasingMode EasingMode EasingMode Int32
    public partial class EasingFunction : DataModel
    {
        public EasingMode                               M_Mode                                  { get; set; }

        public static EasingFunction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EasingFunction() { Pointer= p0 };

            value.M_Mode                                    = (EasingMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 M_Mode                      ( ModelEnumType EasingMode EasingMode EasingMode Int32 )

            return value;
        }
    }
}
