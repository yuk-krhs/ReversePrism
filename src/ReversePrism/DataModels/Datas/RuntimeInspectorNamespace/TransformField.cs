using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 PositionProp                             ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0C8 RotationProp                             ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D0 ScaleProp                                ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    public partial class TransformField : DataModel
    {
        public PropertyInfo?                            PositionProp                            { get; set; }
        public PropertyInfo?                            RotationProp                            { get; set; }
        public PropertyInfo?                            ScaleProp                               { get; set; }

        public static TransformField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TransformField() { Pointer= p0 };

            value.PositionProp                              = GetObject<PropertyInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xC0 PositionProp                ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.RotationProp                              = GetObject<PropertyInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xC8 RotationProp                ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.ScaleProp                                 = GetObject<PropertyInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 0xD0 ScaleProp                   ( ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
