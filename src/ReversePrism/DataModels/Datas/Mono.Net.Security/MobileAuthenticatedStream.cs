using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 XobileTlsContext                         000186637810 ModelClassType MobileTlsContext MobileTlsContext MobileTlsContext Pointer
    // 040 LastException                            0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer
    // 048 AsyncHandshakeRequest                    0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 050 AsyncReadRequest                         0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 058 AsyncWriteRequest                        0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer
    // 060 ReadBuffer                               00018650A990 ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer
    // 068 WriteBuffer                              00018650A990 ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer
    // 070 ioLock                                   <object> IL2CPP_TYPE_OBJECT
    // 078 CloseRequested                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C Shutdown                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 Operation                                00018672E6C0 ModelEnumType Operation Operation Operation Int32
    // 000 uniqueNameInteger                        int IL2CPP_TYPE_I4
    // 088 SslStream                                00018655E470 ModelClassType SslStream SslStream SslStream Pointer
    // 090 Settings                                 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer
    // 098 Provider                                 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer
    // 0A0 TargetHost                               000186671910 ModelPrimitiveType string string string String
    // 004 nextId                                   int IL2CPP_TYPE_I4
    // 0A8 ID                                       0001865F44E0 ModelPrimitiveType int int int Int32
    public partial class MobileAuthenticatedStream
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
            var value   = new MobileAuthenticatedStream();

            value.XobileTlsContext                          = GetObject<MobileTlsContext>(new IntPtr(p + 0x038), ReversePrism.DataModels.MobileTlsContext.FromPointer); // 0270D78F0478 0x38 XobileTlsContext            ( 000186637810 ModelClassType MobileTlsContext MobileTlsContext MobileTlsContext Pointer )
            value.LastException                             = GetObject<ExceptionDispatchInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.ExceptionDispatchInfo.FromPointer); // 0270D78F0498 0x40 LastException               ( 0001865CBD80 ModelClassType ExceptionDispatchInfo ExceptionDispatchInfo ExceptionDispatchInfo Pointer )
            value.AsyncHandshakeRequest                     = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x048), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0270D78F04B8 0x48 AsyncHandshakeRequest       ( 0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.AsyncReadRequest                          = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x050), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0270D78F04D8 0x50 AsyncReadRequest            ( 0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.AsyncWriteRequest                         = GetObject<AsyncProtocolRequest>(new IntPtr(p + 0x058), ReversePrism.DataModels.AsyncProtocolRequest.FromPointer); // 0270D78F04F8 0x58 AsyncWriteRequest           ( 0001866FF140 ModelClassType AsyncProtocolRequest AsyncProtocolRequest AsyncProtocolRequest Pointer )
            value.ReadBuffer                                = GetObject<BufferOffsetSize2>(new IntPtr(p + 0x060), ReversePrism.DataModels.BufferOffsetSize2.FromPointer); // 0270D78F0518 0x60 ReadBuffer                  ( 00018650A990 ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer )
            value.WriteBuffer                               = GetObject<BufferOffsetSize2>(new IntPtr(p + 0x068), ReversePrism.DataModels.BufferOffsetSize2.FromPointer); // 0270D78F0538 0x68 WriteBuffer                 ( 00018650A990 ModelClassType BufferOffsetSize2 BufferOffsetSize2 BufferOffsetSize2 Pointer )
            value.CloseRequested                            = GetInt32(new IntPtr(p + 0x078)); // 0270D78F0578 0x78 CloseRequested              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Shutdown                                  = GetBool(new IntPtr(p + 0x07C)); // 0270D78F0598 0x7C Shutdown                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Operation                                 = (Operation)GetInt32(new IntPtr(p + 0x080)); // 0270D78F05B8 0x80 Operation                   ( 00018672E6C0 ModelEnumType Operation Operation Operation Int32 )
            value.SslStream                                 = GetObject<SslStream>(new IntPtr(p + 0x088), ReversePrism.DataModels.SslStream.FromPointer); // 0270D78F05F8 0x88 SslStream                   ( 00018655E470 ModelClassType SslStream SslStream SslStream Pointer )
            value.Settings                                  = GetObject<MonoTlsSettings>(new IntPtr(p + 0x090), ReversePrism.DataModels.MonoTlsSettings.FromPointer); // 0270D78F0618 0x90 Settings                    ( 000186617640 ModelClassType MonoTlsSettings MonoTlsSettings MonoTlsSettings Pointer )
            value.Provider                                  = GetObject<MobileTlsProvider>(new IntPtr(p + 0x098), ReversePrism.DataModels.MobileTlsProvider.FromPointer); // 0270D78F0638 0x98 Provider                    ( 000186638170 ModelClassType MobileTlsProvider MobileTlsProvider MobileTlsProvider Pointer )
            value.TargetHost                                = GetString(new IntPtr(p + 0x0A0)); // 0270D78F0658 0xA0 TargetHost                  ( 000186671910 ModelPrimitiveType string string string String )
            value.ID                                        = GetInt32(new IntPtr(p + 0x0A8)); // 0270D78F0698 0xA8 ID                          ( 0001865F44E0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
