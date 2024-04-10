using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 AllowNullItems                           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class JsonArrayAttribute : DataModel
    {
        public bool                                     AllowNullItems                          { get; set; }

        public static JsonArrayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonArrayAttribute() { Pointer= p0 };

            value.AllowNullItems                            = GetBool(new IntPtr(p + 0x068)); // 0245A5FC1108 0x68 AllowNullItems              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
