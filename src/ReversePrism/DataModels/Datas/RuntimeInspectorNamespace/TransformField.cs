using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 PositionProp                             0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0C8 RotationProp                             0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
    // 0D0 ScaleProp                                0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer
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

            value.PositionProp                              = GetObject<PropertyInfo>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 02466B248578 0xC0 PositionProp                ( 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.RotationProp                              = GetObject<PropertyInfo>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.PropertyInfo.FromPointer); // 02466B248598 0xC8 RotationProp                ( 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )
            value.ScaleProp                                 = GetObject<PropertyInfo>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.PropertyInfo.FromPointer); // 02466B2485B8 0xD0 ScaleProp                   ( 0001865D41C0 ModelClassType PropertyInfo PropertyInfo PropertyInfo Pointer )

            return value;
        }
    }
}
