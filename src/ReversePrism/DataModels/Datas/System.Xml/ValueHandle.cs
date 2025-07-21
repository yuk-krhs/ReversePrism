using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferReader                             ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer
    // 018 Type                                     ModelEnumType ValueHandleType ValueHandleType ValueHandleType Int32
    // 01C Offset                                   ModelPrimitiveType int int int Int32
    // 020 Length                                   ModelPrimitiveType int int int Int32
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

            value.BufferReader                              = GetObject<XmlBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlBufferReader.FromPointer); // 0x10 BufferReader                ( ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer )
            value.Type                                      = (ValueHandleType)GetInt32(new IntPtr(p + 0x018)); // 0x18 Type                        ( ModelEnumType ValueHandleType ValueHandleType ValueHandleType Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Offset                      ( ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x020)); // 0x20 Length                      ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
