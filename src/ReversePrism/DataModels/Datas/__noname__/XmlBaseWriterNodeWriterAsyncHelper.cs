using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 onWriteComplete                          AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    // 010 Writer                                   00018658BFB0 ModelClassType XmlBaseWriter XmlBaseWriter XmlBaseWriter Pointer
    // 018 Buffer                                   000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Offset                                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ActualByteCount                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 02C TotalByteCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 nodeWriterAsyncState                     AsyncEventArgs`1<XmlNodeWriterWriteBase64TextArgs> IL2CPP_TYPE_GENERICINST
    // 038 NodeWriterArgs                           0001865A48B0 ModelClassType XmlNodeWriterWriteBase64TextArgs XmlNodeWriterWriteBase64TextArgs XmlNodeWriterWriteBase64TextArgs Pointer
    // 040 inputState                               AsyncEventArgs`1<XmlWriteBase64AsyncArguments> IL2CPP_TYPE_GENERICINST
    public partial class XmlBaseWriterNodeWriterAsyncHelper : DataModel
    {
        public XmlBaseWriter?                           Writer                                  { get; set; }
        public List<sbyte>?                             Buffer                                  { get; set; }
        public int                                      Offset                                  { get; set; }
        public int                                      Count                                   { get; set; }
        public int                                      ActualByteCount                         { get; set; }
        public int                                      TotalByteCount                          { get; set; }
        public XmlNodeWriterWriteBase64TextArgs?        NodeWriterArgs                          { get; set; }

        public static XmlBaseWriterNodeWriterAsyncHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlBaseWriterNodeWriterAsyncHelper() { Pointer= p0 };

            value.Writer                                    = GetObject<XmlBaseWriter>(new IntPtr(p + 0x010), ReversePrism.DataModels.XmlBaseWriter.FromPointer); // 024667C6E1A0 0x10 Writer                      ( 00018658BFB0 ModelClassType XmlBaseWriter XmlBaseWriter XmlBaseWriter Pointer )
            value.Buffer                                    = GetSByteList(new IntPtr(p + 0x018)); // 024667C6E1C0 0x18 Buffer                      ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Offset                                    = GetInt32(new IntPtr(p + 0x020)); // 024667C6E1E0 0x20 Offset                      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x024)); // 024667C6E200 0x24 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ActualByteCount                           = GetInt32(new IntPtr(p + 0x028)); // 024667C6E220 0x28 ActualByteCount             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TotalByteCount                            = GetInt32(new IntPtr(p + 0x02C)); // 024667C6E240 0x2C TotalByteCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.NodeWriterArgs                            = GetObject<XmlNodeWriterWriteBase64TextArgs>(new IntPtr(p + 0x038), ReversePrism.DataModels.XmlNodeWriterWriteBase64TextArgs.FromPointer); // 024667C6E280 0x38 NodeWriterArgs              ( 0001865A48B0 ModelClassType XmlNodeWriterWriteBase64TextArgs XmlNodeWriterWriteBase64TextArgs XmlNodeWriterWriteBase64TextArgs Pointer )

            return value;
        }
    }
}
