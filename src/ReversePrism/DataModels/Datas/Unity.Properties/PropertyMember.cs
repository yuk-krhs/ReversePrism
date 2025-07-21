using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_PropertyInfo                           ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class PropertyMember : DataModel
    {
        public PropertyInfo?                            M_PropertyInfo                          { get; set; }

        public static PropertyMember? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyMember() { Pointer= p0 };

            value.M_PropertyInfo                            = GetObject<PropertyInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0x10 M_PropertyInfo              ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
