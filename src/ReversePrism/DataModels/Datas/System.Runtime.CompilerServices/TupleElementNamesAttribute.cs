using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformNames                           000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class TupleElementNamesAttribute
    {
        public List<string>?                            TransformNames                          { get; set; }

        public static TupleElementNamesAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TupleElementNamesAttribute();

            value.TransformNames                            = GetStringList(new IntPtr(p + 0x010)); // 0270D6CA77D8 0x10 TransformNames              ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
