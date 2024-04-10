using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 070 BlockSize                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 Block                                    000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 080 BytesRead                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 088 Stream                                   000186670270 ModelClassType Stream Stream Stream Pointer
    // 090 Operation                                0001865A4010 ModelEnumType Operation Operation Operation Int32
    // 098 StreamProvider                           0001866614E0 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer
    // 0A0 Writer                                   000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer
    // 0A8 writeBlockHandler                        Func`3<IAsyncResult, WriteValueAsyncResult, bool> IL2CPP_TYPE_GENERICINST
    // 000 handleWriteBlock                         Func`3<IAsyncResult, WriteValueAsyncResult, bool> IL2CPP_TYPE_GENERICINST
    // 008 handleWriteBlockAsync                    Func`3<IAsyncResult, WriteValueAsyncResult, bool> IL2CPP_TYPE_GENERICINST
    // 010 OnContinueWork                           0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer
    public partial class WriteValueAsyncResult : DataModel
    {
        public int                                      BlockSize                               { get; set; }
        public List<sbyte>?                             Block                                   { get; set; }
        public int                                      BytesRead                               { get; set; }
        public Stream?                                  Stream                                  { get; set; }
        public Operation                                Operation                               { get; set; }
        public IStreamProvider?                         StreamProvider                          { get; set; }
        public XmlDictionaryWriter?                     Writer                                  { get; set; }
        public AsyncCallback?                           OnContinueWork                          { get; set; }

        public static WriteValueAsyncResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteValueAsyncResult() { Pointer= p0 };

            value.BlockSize                                 = GetInt32(new IntPtr(p + 0x070)); // 024667CBBDC8 0x70 BlockSize                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Block                                     = GetSByteList(new IntPtr(p + 0x078)); // 024667CBBDE8 0x78 Block                       ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.BytesRead                                 = GetInt32(new IntPtr(p + 0x080)); // 024667CBBE08 0x80 BytesRead                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x088), ReversePrism.DataModels.Stream.FromPointer); // 024667CBBE28 0x88 Stream                      ( 000186670270 ModelClassType Stream Stream Stream Pointer )
            value.Operation                                 = (Operation)GetInt32(new IntPtr(p + 0x090)); // 024667CBBE48 0x90 Operation                   ( 0001865A4010 ModelEnumType Operation Operation Operation Int32 )
            value.StreamProvider                            = GetObject<IStreamProvider>(new IntPtr(p + 0x098), ReversePrism.DataModels.IStreamProvider.FromPointer); // 024667CBBE68 0x98 StreamProvider              ( 0001866614E0 ModelClassType IStreamProvider IStreamProvider IStreamProvider Pointer )
            value.Writer                                    = GetObject<XmlDictionaryWriter>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.XmlDictionaryWriter.FromPointer); // 024667CBBE88 0xA0 Writer                      ( 000186595240 ModelClassType XmlDictionaryWriter XmlDictionaryWriter XmlDictionaryWriter Pointer )
            value.OnContinueWork                            = GetObject<AsyncCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncCallback.FromPointer); // 024667CBBF08 0x10 OnContinueWork              ( 0001866EE3E0 ModelClassType AsyncCallback AsyncCallback AsyncCallback Pointer )

            return value;
        }
    }
}
