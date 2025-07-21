using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 TargetType                               ModelEnumType TargetType TargetType TargetType Int32
    public partial class NativePropertyAttribute : DataModel
    {
        public TargetType                               TargetType                              { get; set; }

        public static NativePropertyAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativePropertyAttribute() { Pointer= p0 };

            value.TargetType                                = (TargetType)GetInt32(new IntPtr(p + 0x020)); // 0x20 TargetType                  ( ModelEnumType TargetType TargetType TargetType Int32 )

            return value;
        }
    }
}
