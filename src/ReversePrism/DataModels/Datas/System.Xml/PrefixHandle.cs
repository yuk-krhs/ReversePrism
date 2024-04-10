using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 BufferReader                             00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer
    // 018 Type                                     0001866435D0 ModelEnumType PrefixHandleType PrefixHandleType PrefixHandleType Int32
    // 01C Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Length                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 prefixStrings                            string[] IL2CPP_TYPE_SZARRAY
    // 008 prefixBuffer                             sbyte[] IL2CPP_TYPE_SZARRAY
    public partial class PrefixHandle : DataModel
    {
        public XmlBufferReader?                         BufferReader                            { get; set; }
        public PrefixHandleType                         Type                                    { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Length                                  { get; set; }

        public static PrefixHandle? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PrefixHandle() { Pointer= p0 };

            value.BufferReader                              = GetObject<XmlBufferReader>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlBufferReader.FromPointer); // 0245A4C96730 0x10 BufferReader                ( 00018658E370 ModelClassType XmlBufferReader XmlBufferReader XmlBufferReader Pointer )
            value.Type                                      = (PrefixHandleType)GetInt32(new IntPtr(p + 0x018)); // 0245A4C96750 0x18 Type                        ( 0001866435D0 ModelEnumType PrefixHandleType PrefixHandleType PrefixHandleType Int32 )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x01C)); // 0245A4C96770 0x1C Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Length                                    = GetInt32(new IntPtr(p + 0x020)); // 0245A4C96790 0x20 Length                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
