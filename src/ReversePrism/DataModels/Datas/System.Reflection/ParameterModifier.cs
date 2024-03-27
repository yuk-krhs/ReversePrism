using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ByRef                                    000185B78FA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer
    public partial class ParameterModifier
    {
        public List<bool>?                              ByRef                                   { get; set; }

        public static ParameterModifier? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ParameterModifier();

            value.ByRef                                     = GetBoolList(new IntPtr(p + 0x010)); // 0270D6A037D8 0x10 ByRef                       ( 000185B78FA0 ModelPrimitiveListType bool[] bool[] List<bool> Pointer )

            return value;
        }
    }
}
