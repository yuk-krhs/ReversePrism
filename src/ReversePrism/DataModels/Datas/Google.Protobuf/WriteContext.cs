using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 buffer                                   Span`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 020 State                                    0001866B7680 ModelEnumType WriterInternalState WriterInternalState WriterInternalState Int32
    public partial class WriteContext : DataModel
    {
        public WriterInternalState                      State                                   { get; set; }

        public static WriteContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteContext() { Pointer= p0 };

            value.State                                     = (WriterInternalState)GetInt32(new IntPtr(p + 0x020)); // 024663995F60 0x20 State                       ( 0001866B7680 ModelEnumType WriterInternalState WriterInternalState WriterInternalState Int32 )

            return value;
        }
    }
}
