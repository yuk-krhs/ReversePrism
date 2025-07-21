using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 bufferWriter                             IBufferWriter`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 018 CodedOutputStream                        ModelClassType CodedOutputStream CodedOutputStream CodedOutputStream Pointer
    public partial class WriteBufferHelper : DataModel
    {
        public CodedOutputStream?                       CodedOutputStream                       { get; set; }

        public static WriteBufferHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteBufferHelper() { Pointer= p0 };

            value.CodedOutputStream                         = GetObject<CodedOutputStream>(new IntPtr(p + 0x018), ReversePrism.DataModels.CodedOutputStream.FromPointer); // 0x18 CodedOutputStream           ( ModelClassType CodedOutputStream CodedOutputStream CodedOutputStream Pointer )

            return value;
        }
    }
}
