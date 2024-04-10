using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 _object                                  Nullable`1<LocalDefinition> IL2CPP_TYPE_GENERICINST
    // 030 Property                                 0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class PropertyByRefUpdater : DataModel
    {
        public PropertyInfo?                            Property                                { get; set; }

        public static PropertyByRefUpdater? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyByRefUpdater() { Pointer= p0 };

            value.Property                                  = GetObject<PropertyInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.PropertyInfo.FromPointer); // 02466A070E88 0x30 Property                    ( 0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
