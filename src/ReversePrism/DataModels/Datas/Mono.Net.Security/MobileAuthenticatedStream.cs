using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 XobileTlsContext                         ModelClassType MobileTlsContext MobileTlsContext MobileTlsContext Pointer
    // 040 LastException                            ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 048 AsyncHandshakeRequest                    ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 050 AsyncReadRequest                         ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 058 AsyncWriteRequest                        ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 060 ReadBuffer                               ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer
    // 068 WriteBuffer                              ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer
    // 070 ioLock                                   <object> IL2CPP_TYPE_OBJECT
    // 078 CloseRequested                           ModelPrimitiveType int int int Int32
    // 07C Shutdown                                 ModelPrimitiveType bool bool bool Bool
    // 080 Operation                                ModelEnumType Operation Operation Operation Int32
    // 000 uniqueNameInteger                        int IL2CPP_TYPE_I4
    // 088 SslStream                                ModelClassType SslStream SslStream SslStream Pointer
    // 090 Settings                                 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 098 Provider                                 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 0A0 TargetHost                               ModelPrimitiveType string string string String
    // 004 nextId                                   int IL2CPP_TYPE_I4
    // 0A8 ID                                       ModelPrimitiveType int int int Int32
    public partial class MobileAuthenticatedStream : DataModel
    {
        public MobileTlsContext?                        XobileTlsContext                        { get; set; }
        public ExceptionDispatchInfo?                   LastException                           { get; set; }
        public AsyncProtocolRequest?                    AsyncHandshakeRequest                   { get; set; }
        public AsyncProtocolRequest?                    AsyncReadRequest                        { get; set; }
        public AsyncProtocolRequest?                    AsyncWriteRequest                       { get; set; }
        public BufferOffsetSize2?                       ReadBuffer                              { get; set; }
        public BufferOffsetSize2?                       WriteBuffer                             { get; set; }
        public int                                      CloseRequested                          { get; set; }
        public bool                                     Shutdown                                { get; set; }
        public Operation                                Operation                               { get; set; }
        public SslStream?                               SslStream                               { get; set; }
        public MonoTlsSettings?                         Settings                                { get; set; }
        public MobileTlsProvider?                       Provider                                { get; set; }
        public string                                   TargetHost                              { get; set; }
        public int                                      ID                                      { get; set; }

        public static MobileAuthenticatedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MobileAuthenticatedStream() { Pointer= p0 };

            value.XobileTlsContext                          = GetObject<MobileTlsContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileTlsContext.FromPointer); // 0x38 XobileTlsContext            ( ModelClassType MobileTlsContext MobileTlsContext MobileTlsContext Pointer )
            value.LastException                             = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0x40 LastException               ( ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.AsyncHandshakeRequest                     = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x048), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0x48 AsyncHandshakeRequest       ( ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.AsyncReadRequest                          = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x050), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0x50 AsyncReadRequest            ( ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.AsyncWriteRequest                         = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x058), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0x58 AsyncWriteRequest           ( ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.ReadBuffer                                = GetObject<BufferOffsetSize2>(new IntPtr(p + 0x060), ReversePrism.DataModels.BufferOffsetSize2.FromPointer); // 0x60 ReadBuffer                  ( ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer )
            value.WriteBuffer                               = GetObject<BufferOffsetSize2>(new IntPtr(p + 0x068), ReversePrism.DataModels.BufferOffsetSize2.FromPointer); // 0x68 WriteBuffer                 ( ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer )
            value.CloseRequested                            = GetInt32(new IntPtr(p + 0x078)); // 0x78 CloseRequested              ( ModelPrimitiveType int int int Int32 )
            value.Shutdown                                  = GetBool(new IntPtr(p + 0x07C)); // 0x7C Shutdown                    ( ModelPrimitiveType bool bool bool Bool )
            value.Operation                                 = (Operation)GetInt32(new IntPtr(p + 0x080)); // 0x80 Operation                   ( ModelEnumType Operation Operation Operation Int32 )
            value.SslStream                                 = GetObject<SslStream>(new IntPtr(p + 0x088), ReversePrism.DataModels.SslStream.FromPointer); // 0x88 SslStream                   ( ModelClassType SslStream SslStream SslStream Pointer )
            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x090), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0x90 Settings                    ( ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x098), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0x98 Provider                    ( ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.TargetHost                                = GetString(new IntPtr(p + 0x0A0)); // 0xA0 TargetHost                  ( ModelPrimitiveType string string string String )
            value.ID                                        = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 ID                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
