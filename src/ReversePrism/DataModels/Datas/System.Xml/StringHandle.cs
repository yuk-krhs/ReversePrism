using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferReader                             00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer
    // 018 Type                                     0001865992B0 ModelEnumType StringHandleType StringHandleType StringHandleType Int32
    // 01C Key                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 constStrings                             string[] IL2CPP_TYPE_SZARRAY
    public partial class StringHandle
    {
        public XmlBufferReader?                         BufferReader                            { get; set; }
        public StringHandleType                         Type                                    { get; set; }
        public int                                      Key                                     { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Length                                  { get; set; }

        public static StringHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StringHandle();

            value.BufferReader                              = GetObject<XmlBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlBufferReader.FromPointer); // 027004C53930 0x10 BufferReader                ( 00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer )
            value.Type                                      = (StringHandleType)GetInt32(new IntPtr(p + 0x018)); // 027004C53950 0x18 Type                        ( 0001865992B0 ModelEnumType StringHandleType StringHandleType StringHandleType Int32 )
            value.Key                                       = GetInt32(new IntPtr(p + 0x01C)); // 027004C53970 0x1C Key                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x020)); // 027004C53990 0x20 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x024)); // 027004C539B0 0x24 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
