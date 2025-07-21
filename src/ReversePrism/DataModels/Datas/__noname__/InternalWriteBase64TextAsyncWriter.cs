using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 nodeState                                AsyncEventArgs`1<XmlNodeWriterWriteBase64TextArgs> IL2CPP_TYPE_GENERICINST
    // 018 writerState                              AsyncEventArgs`1<XmlWriteBase64AsyncArguments> IL2CPP_TYPE_GENERICINST
    // 020 WriterArgs                               ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer
    // 028 Writer                                   ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 030 GetBufferState                           ModelClassType GetBufferAsyncEventArgs GetBufferAsyncEventArgs GetBufferAsyncEventArgs Pointer
    // 038 GetBufferArgs                            ModelClassType GetBufferArgs GetBufferArgs GetBufferArgs Pointer
    // 000 onTrailByteComplete                      AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    // 008 onWriteComplete                          AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    // 010 OnGetBufferComplete                      ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer
    public partial class InternalWriteBase64TextAsyncWriter : DataModel
    {
        public XmlWriteBase64AsyncArguments?            WriterArgs                              { get; set; }
        public XmlUTF8NodeWriter?                       Writer                                  { get; set; }
        public GetBufferAsyncEventArgs?                 GetBufferState                          { get; set; }
        public GetBufferArgs?                           GetBufferArgs                           { get; set; }
        public AsyncEventArgsCallback?                  OnGetBufferComplete                     { get; set; }

        public static InternalWriteBase64TextAsyncWriter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InternalWriteBase64TextAsyncWriter() { Pointer= p0 };

            value.WriterArgs                                = GetObject<XmlWriteBase64AsyncArguments>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlWriteBase64AsyncArguments.FromPointer); // 0x20 WriterArgs                  ( ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer )
            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0x28 Writer                      ( ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.GetBufferState                            = GetObject<GetBufferAsyncEventArgs>(new IntPtr(p + 0x030), ReversePrism.DataModels.GetBufferAsyncEventArgs.FromPointer); // 0x30 GetBufferState              ( ModelClassType GetBufferAsyncEventArgs GetBufferAsyncEventArgs GetBufferAsyncEventArgs Pointer )
            value.GetBufferArgs                             = GetObject<GetBufferArgs>(new IntPtr(p + 0x038), ReversePrism.DataModels.GetBufferArgs.FromPointer); // 0x38 GetBufferArgs               ( ModelClassType GetBufferArgs GetBufferArgs GetBufferArgs Pointer )
            value.OnGetBufferComplete                       = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 0x10 OnGetBufferComplete         ( ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )

            return value;
        }
    }
}
