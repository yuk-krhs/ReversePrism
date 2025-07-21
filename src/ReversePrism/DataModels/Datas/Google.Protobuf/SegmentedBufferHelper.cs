using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 totalLength                              Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 018 readOnlySequenceEnumerator               Enumerator<sbyte> IL2CPP_TYPE_GENERICINST
    // 050 CodedInputStream                         ModelClassType CodedInputStream CodedInputStream CodedInputStream Pointer
    public partial class SegmentedBufferHelper : DataModel
    {
        public CodedInputStream?                        CodedInputStream                        { get; set; }

        public static SegmentedBufferHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SegmentedBufferHelper() { Pointer= p0 };

            value.CodedInputStream                          = GetObject<CodedInputStream>(new IntPtr(p + 0x050), ReversePrism.DataModels.CodedInputStream.FromPointer); // 0x50 CodedInputStream            ( ModelClassType CodedInputStream CodedInputStream CodedInputStream Pointer )

            return value;
        }
    }
}
