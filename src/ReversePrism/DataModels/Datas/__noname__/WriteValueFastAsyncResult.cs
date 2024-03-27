using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Completed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 074 BlockSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 Block                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 BytesRead                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 090 NextOperation                            0001865A4740 ModelEnumType Operation Operation Operation Int32
    // 098 StreamProvider                           0001866614E0 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer
    // 0A0 Writer                                   000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer
    // 0A8 writerAsyncState                         AsyncEventArgs`1<XmlWriteBase64AsyncArguments> IL2CPP_TYPE_GENERICINST
    // 0B0 WriterAsyncArgs                          0001865D6280 ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer
    // 000 onReadComplete                           AsyncCallback IL2CPP_TYPE_CLASS
    // 008 onWriteComplete                          AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    public partial class WriteValueFastAsyncResult
    {
        public bool                                     Completed                               { get; set; }
        public int                                      BlockSize                               { get; set; }
        public List<sbyte>?                             Block                                   { get; set; }
        public int                                      BytesRead                               { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public Operation                                NextOperation                           { get; set; }
        public IStreamProvider?                         StreamProvider                          { get; set; }
        public XmlDictionaryWriter?                     Writer                                  { get; set; }
        public XmlWriteBase64AsyncArguments?            WriterAsyncArgs                         { get; set; }

        public static WriteValueFastAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteValueFastAsyncResult();

            value.Completed                                 = GetBool(new IntPtr(p + 0x070)); // 0270D7C63770 0x70 Completed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BlockSize                                 = GetInt32(new IntPtr(p + 0x074)); // 0270D7C63790 0x74 BlockSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Block                                     = GetSByteList(new IntPtr(p + 0x078)); // 0270D7C637B0 0x78 Block                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x080)); // 0270D7C637D0 0x80 BytesRead                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stream.FromPointer); // 0270D7C637F0 0x88 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.NextOperation                             = (Operation)GetInt32(new IntPtr(p + 0x090)); // 0270D7C63810 0x90 NextOperation               ( 0001865A4740 ModelEnumType Operation Operation Operation Int32 )
            value.StreamProvider                            = GetObject<IStreamProvider>(new IntPtr(p + 0x098), ReversePrism.DataModels.IStreamProvider.FromPointer); // 0270D7C63830 0x98 StreamProvider              ( 0001866614E0 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer )
            value.Writer                                    = GetObject<XmlDictionaryWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlDictionaryWriter.FromPointer); // 0270D7C63850 0xA0 Writer                      ( 000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer )
            value.WriterAsyncArgs                           = GetObject<XmlWriteBase64AsyncArguments>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlWriteBase64AsyncArguments.FromPointer); // 0270D7C63890 0xB0 WriterAsyncArgs             ( 0001865D6280 ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer )

            return value;
        }
    }
}
