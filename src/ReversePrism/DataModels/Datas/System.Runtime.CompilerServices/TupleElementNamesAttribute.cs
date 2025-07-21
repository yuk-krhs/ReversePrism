using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformNames                           ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class TupleElementNamesAttribute : DataModel
    {
        public List<string>?                            TransformNames                          { get; set; }

        public static TupleElementNamesAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TupleElementNamesAttribute() { Pointer= p0 };

            value.TransformNames                            = GetStringList(new IntPtr(p + 0x010)); // 0x10 TransformNames              ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
