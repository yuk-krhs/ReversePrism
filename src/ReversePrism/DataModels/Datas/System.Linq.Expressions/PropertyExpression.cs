using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 Property                                 0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class PropertyExpression
    {
        public PropertyInfo?                            Property                                { get; set; }

        public static PropertyExpression? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PropertyExpression();

            value.Property                                  = GetObject<PropertyInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0270D9F672C0 0x18 Property                    ( 0001865D48B0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
