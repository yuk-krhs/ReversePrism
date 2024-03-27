using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 SequenceBuilder                          00018667B4D0 ModelClassType ReusableReadOnlySequenceBuilder ReusableReadOnlySequenceBuilder ReusableReadOnlySequenceBuilder Pointer
    public partial class BrotliDecompressor
    {
        public ReusableReadOnlySequenceBuilder?         SequenceBuilder                         { get; set; }

        public static BrotliDecompressor? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BrotliDecompressor();

            value.SequenceBuilder                           = GetObject<ReusableReadOnlySequenceBuilder>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReusableReadOnlySequenceBuilder.FromPointer); // 0270DAFEC870 0x10 SequenceBuilder             ( 00018667B4D0 ModelClassType ReusableReadOnlySequenceBuilder ReusableReadOnlySequenceBuilder ReusableReadOnlySequenceBuilder Pointer )

            return value;
        }
    }
}
