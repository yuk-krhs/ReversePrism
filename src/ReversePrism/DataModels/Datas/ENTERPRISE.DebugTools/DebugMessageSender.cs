using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SendBytes                                000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class DebugMessageSender : DataModel
    {
        public List<sbyte>?                             SendBytes                               { get; set; }

        public static DebugMessageSender? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DebugMessageSender() { Pointer= p0 };

            value.SendBytes                                 = GetSByteList(new IntPtr(p + 0x010)); // 02466B76C370 0x10 SendBytes                   ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
