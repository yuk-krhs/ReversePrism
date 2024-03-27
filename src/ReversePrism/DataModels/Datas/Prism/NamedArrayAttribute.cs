using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Names                                    000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class NamedArrayAttribute
    {
        public List<string>?                            Names                                   { get; set; }

        public static NamedArrayAttribute? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NamedArrayAttribute();

            value.Names                                     = GetStringList(new IntPtr(p + 0x010)); // 0270D4C329E0 0x10 Names                       ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
