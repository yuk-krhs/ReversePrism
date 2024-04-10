using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 078 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 080 Encoding                                 00018673CA50 ModelClassType Base64Encoding Base64Encoding Base64Encoding Pointer
    // 088 Writer                                   0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 000 onWriteCharacters                        AsyncCallback IL2CPP_TYPE_CLASS
    // 008 onWriteTrailingCharacters                AsyncCompletion IL2CPP_TYPE_CLASS
    public partial class InternalWriteBase64TextAsyncResult : DataModel
    {
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public Base64Encoding?                          Encoding                                { get; set; }
        public XmlUTF8NodeWriter?                       Writer                                  { get; set; }

        public static InternalWriteBase64TextAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalWriteBase64TextAsyncResult() { Pointer= p0 };

            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x070)); // 024667D0CF78 0x70 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x078)); // 024667D0CF98 0x78 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x07C)); // 024667D0CFB8 0x7C Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Encoding                                  = GetObject<Base64Encoding>(new IntPtr(p + 0x080), ReversePrism.DataModels.Base64Encoding.FromPointer); // 024667D0CFD8 0x80 Encoding                    ( 00018673CA50 ModelClassType Base64Encoding Base64Encoding Base64Encoding Pointer )
            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x088), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 024667D0CFF8 0x88 Writer                      ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )

            return value;
        }
    }
}
