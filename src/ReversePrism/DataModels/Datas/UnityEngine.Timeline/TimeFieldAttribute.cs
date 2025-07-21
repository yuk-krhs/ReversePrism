using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UseEditMode                              ModelEnumType UseEditMode UseEditMode UseEditMode Int32
    public partial class TimeFieldAttribute : DataModel
    {
        public UseEditMode                              UseEditMode                             { get; set; }

        public static TimeFieldAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TimeFieldAttribute() { Pointer= p0 };

            value.UseEditMode                               = (UseEditMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 UseEditMode                 ( ModelEnumType UseEditMode UseEditMode UseEditMode Int32 )

            return value;
        }
    }
}
