using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 0001866E43B0 ModelEnumType Priority Priority Priority Int32
    public partial class LoadingPriorityDish
    {
        public Priority                                 Priority                                { get; set; }

        public static LoadingPriorityDish? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingPriorityDish();

            value.Priority                                  = (Priority)GetInt32(new IntPtr(p + 0x010)); // 0270DB696B68 0x10 Priority                    ( 0001866E43B0 ModelEnumType Priority Priority Priority Int32 )

            return value;
        }
    }
}
