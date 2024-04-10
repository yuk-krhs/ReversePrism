using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Priority                                 0001866E43B0 ModelEnumType Priority Priority Priority Int32
    public partial class LoadingPriorityDish : DataModel
    {
        public Priority                                 Priority                                { get; set; }

        public static LoadingPriorityDish? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadingPriorityDish() { Pointer= p0 };

            value.Priority                                  = (Priority)GetInt32(new IntPtr(p + 0x010)); // 02466B732E28 0x10 Priority                    ( 0001866E43B0 ModelEnumType Priority Priority Priority Int32 )

            return value;
        }
    }
}
