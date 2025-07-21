using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferWriter                             ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer
    // 018 OptionalState                            ModelClassType MemoryPackWriterOptionalState MemoryPackWriterOptionalState MemoryPackWriterOptionalState Pointer
    public partial class SerializerWriterThreadStaticState : DataModel
    {
        public ReusableLinkedArrayBufferWriter?         BufferWriter                            { get; set; }
        public MemoryPackWriterOptionalState?           OptionalState                           { get; set; }

        public static SerializerWriterThreadStaticState? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializerWriterThreadStaticState() { Pointer= p0 };

            value.BufferWriter                              = GetObject<ReusableLinkedArrayBufferWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.ReusableLinkedArrayBufferWriter.FromPointer); // 0x10 BufferWriter                ( ModelClassType ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter ReusableLinkedArrayBufferWriter Pointer )
            value.OptionalState                             = GetObject<MemoryPackWriterOptionalState>(new IntPtr(p + 0x018), ReversePrism.DataModels.MemoryPackWriterOptionalState.FromPointer); // 0x18 OptionalState               ( ModelClassType MemoryPackWriterOptionalState MemoryPackWriterOptionalState MemoryPackWriterOptionalState Pointer )

            return value;
        }
    }
}
