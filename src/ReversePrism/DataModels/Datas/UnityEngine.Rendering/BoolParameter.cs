using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 DisplayType                              ModelEnumType DisplayType DisplayType DisplayType Int32
    public partial class BoolParameter : DataModel
    {
        public DisplayType                              DisplayType                             { get; set; }

        public static BoolParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BoolParameter() { Pointer= p0 };

            value.DisplayType                               = (DisplayType)GetInt32(new IntPtr(p + 0x020)); // 0x20 DisplayType                 ( ModelEnumType DisplayType DisplayType DisplayType Int32 )

            return value;
        }
    }
}
