using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 <Date>k__BackingField                    Nullable`1<DateTimeOffset> IL2CPP_TYPE_GENERICINST
    // 028 EntityTag                                ModelClassType EntityTagHeaderValue EntityTagHeaderValue EntityTagHeaderValue Pointer
    public partial class RangeConditionHeaderValue : DataModel
    {
        public EntityTagHeaderValue?                    EntityTag                               { get; set; }

        public static RangeConditionHeaderValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RangeConditionHeaderValue() { Pointer= p0 };

            value.EntityTag                                 = GetObject<EntityTagHeaderValue>(new IntPtr(p + 0x028), ReversePrism.DataModels.EntityTagHeaderValue.FromPointer); // 0x28 EntityTag                   ( ModelClassType EntityTagHeaderValue EntityTagHeaderValue EntityTagHeaderValue Pointer )

            return value;
        }
    }
}
