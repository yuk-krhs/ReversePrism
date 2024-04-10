using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferReader                             00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer
    // 018 Type                                     000186769EE0 ModelEnumType ValueHandleType ValueHandleType ValueHandleType Int32
    // 01C Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 base64Encoding                           Base64Encoding IL2CPP_TYPE_CLASS
    // 008 constStrings                             string[] IL2CPP_TYPE_SZARRAY
    public partial class ValueHandle : DataModel
    {
        public XmlBufferReader?                         BufferReader                            { get; set; }
        public ValueHandleType                          Type                                    { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Length                                  { get; set; }

        public static ValueHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueHandle() { Pointer= p0 };

            value.BufferReader                              = GetObject<XmlBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlBufferReader.FromPointer); // 0245A4C98A10 0x10 BufferReader                ( 00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer )
            value.Type                                      = (ValueHandleType)GetInt32(new IntPtr(p + 0x018)); // 0245A4C98A30 0x18 Type                        ( 000186769EE0 ModelEnumType ValueHandleType ValueHandleType ValueHandleType Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A4C98A50 0x1C Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x020)); // 0245A4C98A70 0x20 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
