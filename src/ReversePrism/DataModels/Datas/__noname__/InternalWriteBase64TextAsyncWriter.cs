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
    // 020 WriterArgs                               0001865D6280 ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer
    // 028 Writer                                   0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer
    // 030 GetBufferState                           0001867420E0 ModelClassType GetBufferAsyncEventArgs GetBufferAsyncEventArgs GetBufferAsyncEventArgs Pointer
    // 038 GetBufferArgs                            000186741C20 ModelClassType GetBufferArgs GetBufferArgs GetBufferArgs Pointer
    // 000 onTrailByteComplete                      AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    // 008 onWriteComplete                          AsyncEventArgsCallback IL2CPP_TYPE_CLASS
    // 010 OnGetBufferComplete                      0001866F40D0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer
    public partial class InternalWriteBase64TextAsyncWriter
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
            var value   = new InternalWriteBase64TextAsyncWriter();

            value.WriterArgs                                = GetObject<XmlWriteBase64AsyncArguments>(new IntPtr(p + 0x020), ReversePrism.DataModels.XmlWriteBase64AsyncArguments.FromPointer); // 0270D7CB4738 0x20 WriterArgs                  ( 0001865D6280 ModelClassType XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments XmlWriteBase64AsyncArguments Pointer )
            value.Writer                                    = GetObject<XmlUTF8NodeWriter>(new IntPtr(p + 0x028), ReversePrism.DataModels.XmlUTF8NodeWriter.FromPointer); // 0270D7CB4758 0x28 Writer                      ( 0001865D2480 ModelClassType XmlUTF8NodeWriter XmlUTF8NodeWriter XmlUTF8NodeWriter Pointer )
            value.GetBufferState                            = GetObject<GetBufferAsyncEventArgs>(new IntPtr(p + 0x030), ReversePrism.DataModels.GetBufferAsyncEventArgs.FromPointer); // 0270D7CB4778 0x30 GetBufferState              ( 0001867420E0 ModelClassType GetBufferAsyncEventArgs GetBufferAsyncEventArgs GetBufferAsyncEventArgs Pointer )
            value.GetBufferArgs                             = GetObject<GetBufferArgs>(new IntPtr(p + 0x038), ReversePrism.DataModels.GetBufferArgs.FromPointer); // 0270D7CB4798 0x38 GetBufferArgs               ( 000186741C20 ModelClassType GetBufferArgs GetBufferArgs GetBufferArgs Pointer )
            value.OnGetBufferComplete                       = GetObject<AsyncEventArgsCallback>(new IntPtr(p + 0x010), ReversePrism.DataModels.AsyncEventArgsCallback.FromPointer); // 0270D7CB47F8 0x10 OnGetBufferComplete         ( 0001866F40D0 ModelClassType AsyncEventArgsCallback AsyncEventArgsCallback AsyncEventArgsCallback Pointer )

            return value;
        }
    }
}
