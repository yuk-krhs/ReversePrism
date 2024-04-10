using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Action                                   0001865C3810 ModelEnumType CollectionChangeAction CollectionChangeAction CollectionChangeAction Int32
    // 018 <Element>k__BackingField                 <object> IL2CPP_TYPE_OBJECT
    public partial class CollectionChangeEventArgs : DataModel
    {
        public CollectionChangeAction                   Action                                  { get; set; }

        public static CollectionChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CollectionChangeEventArgs() { Pointer= p0 };

            value.Action                                    = (CollectionChangeAction)GetInt32(new IntPtr(p + 0x010)); // 024667B7FE00 0x10 Action                      ( 0001865C3810 ModelEnumType CollectionChangeAction CollectionChangeAction CollectionChangeAction Int32 )

            return value;
        }
    }
}
