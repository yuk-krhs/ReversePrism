using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 Completed                                ModelPrimitiveType bool bool bool Bool
    // 074 BlockSize                                ModelPrimitiveType int int int Int32
    // 078 Block                                    ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 BytesRead                                ModelPrimitiveType int int int Int32
    // 088 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 090 NextOperation                            ModelEnumType Operation Operation Operation Int32
    // 098 StreamProvider                           ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer
    // 0A0 Writer                                   ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer
    // 0A8 writerAsyncState                         AsyncEventArgs`1<XmlWriteBase64AsyncArguments> IL2CPP_TYPE_GENERICINST
    // 0B0 WriterAsyncArgs                          ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer
    // 000 onReadComplete                           AsyncCallback IL2CPP_TYPE_CLASS
    // 008 onWriteComplete                          AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    public partial class WriteValueFastAsyncResult : DataModel
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
            var value   = new WriteValueFastAsyncResult() { Pointer= p0 };

            value.Completed                                 = GetBool(new IntPtr(p + 0x070)); // 0x70 Completed                   ( ModelPrimitiveType bool bool bool Bool )
            value.BlockSize                                 = GetInt32(new IntPtr(p + 0x074)); // 0x74 BlockSize                   ( ModelPrimitiveType int int int Int32 )
            value.Block                                     = GetSByteList(new IntPtr(p + 0x078)); // 0x78 Block                       ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x080)); // 0x80 BytesRead                   ( ModelPrimitiveType int int int Int32 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stream.FromPointer); // 0x88 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.NextOperation                             = (Operation)GetInt32(new IntPtr(p + 0x090)); // 0x90 NextOperation               ( ModelEnumType Operation Operation Operation Int32 )
            value.StreamProvider                            = GetObject<IStreamProvider>(new IntPtr(p + 0x098), ReversePrism.DataModels.IStreamProvider.FromPointer); // 0x98 StreamProvider              ( ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer )
            value.Writer                                    = GetObject<XmlDictionaryWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlDictionaryWriter.FromPointer); // 0xA0 Writer                      ( ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer )
            value.WriterAsyncArgs                           = GetObject<XmlWriteBase64AsyncArguments>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.XmlWriteBase64AsyncArguments.FromPointer); // 0xB0 WriterAsyncArgs             ( ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer )

            return value;
        }
    }
}
