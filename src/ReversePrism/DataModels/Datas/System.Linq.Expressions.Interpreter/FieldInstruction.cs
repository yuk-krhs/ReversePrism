using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Field                                    000186573D70 ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    public partial class FieldInstruction
    {
        public FieldInfo?                               Field                                   { get; set; }

        public static FieldInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FieldInstruction();

            value.Field                                     = GetObject<FieldInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.FieldInfo.FromPointer); // 0270D9FAD618 0x10 Field                       ( 000186573D70 ModelClassType FieldInfo FieldInfo FieldInfo Pointer )

            return value;
        }
    }
}
