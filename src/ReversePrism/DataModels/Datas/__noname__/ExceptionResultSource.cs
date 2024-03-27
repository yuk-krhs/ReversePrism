using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Exception                                0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 018 CalledGet                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ExceptionResultSource
    {
        public ExceptionDispatchInfo?                   Exception                               { get; set; }
        public bool                                     CalledGet                               { get; set; }

        public static ExceptionResultSource? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExceptionResultSource();

            value.Exception                                 = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D8BED2B0 0x10 Exception                   ( 0001865CC020 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.CalledGet                                 = GetBool(new IntPtr(p + 0x018)); // 0270D8BED2D0 0x18 CalledGet                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
