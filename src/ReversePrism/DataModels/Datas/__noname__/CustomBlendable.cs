using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_Custom                                 ModelClassType Object Object Object Pointer
    // 018 M_Weight                                 ModelPrimitiveType float float float Single
    public partial class CustomBlendable : DataModel
    {
        public Object?                                  M_Custom                                { get; set; }
        public float                                    M_Weight                                { get; set; }

        public static CustomBlendable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CustomBlendable() { Pointer= p0 };

            value.M_Custom                                  = GetObject<Object>(new IntPtr(p + 0x010), ReversePrism.DataModels.Object.FromPointer); // 0x10 M_Custom                    ( ModelClassType Object Object Object Pointer )
            value.M_Weight                                  = GetSingle(new IntPtr(p + 0x018)); // 0x18 M_Weight                    ( ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
