using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Names                                    ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class NamedArrayAttribute : DataModel
    {
        public List<string>?                            Names                                   { get; set; }

        public static NamedArrayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamedArrayAttribute() { Pointer= p0 };

            value.Names                                     = GetStringList(new IntPtr(p + 0x010)); // 0x10 Names                       ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
