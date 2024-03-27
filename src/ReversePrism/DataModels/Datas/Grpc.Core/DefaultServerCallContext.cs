using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CallHandle                               00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 020 Method                                   000186672F10 ModelPrimitiveType string string string String
    // 028 Host                                     000186672F10 ModelPrimitiveType string string string String
    // 030 Deadline                                 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 RequestHeaders                           00018660C830 ModelClassType Metadata Metadata Metadata Pointer
    // 040 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 ResponseTrailers                         00018660C830 ModelClassType Metadata Metadata Metadata Pointer
    // 050 Status                                   0001865855D0 ModelEnumType Status Status Status Int32
    // 068 ServerResponseStream                     000186638640 ModelClassType IServerResponseStream IServerResponseStream IServerResponseStream Pointer
    // 070 LazyAuthContext                          00018671EE90 ModelClassType AuthContext AuthContext AuthContext Pointer
    public partial class DefaultServerCallContext
    {
        public CallSafeHandle?                          CallHandle                              { get; set; }
        public string                                   Method                                  { get; set; }
        public string                                   Host                                    { get; set; }
        public DateTime                                 Deadline                                { get; set; }
        public Metadata?                                RequestHeaders                          { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public Metadata?                                ResponseTrailers                        { get; set; }
        public Status                                   Status                                  { get; set; }
        public IServerResponseStream?                   ServerResponseStream                    { get; set; }
        public AuthContext?                             LazyAuthContext                         { get; set; }

        public static DefaultServerCallContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultServerCallContext();

            value.CallHandle                                = GetObject<CallSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0270D9362060 0x18 CallHandle                  ( 00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0270D9362080 0x20 Method                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0270D93620A0 0x28 Host                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x030)); // 0270D93620C0 0x30 Deadline                    ( 0001865BA1C0 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.RequestHeaders                            = GetObject<Metadata>(new IntPtr(p + 0x038), ReversePrism.DataModels.Metadata.FromPointer); // 0270D93620E0 0x38 RequestHeaders              ( 00018660C830 ModelClassType Metadata Metadata Metadata Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0270D9362100 0x40 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.ResponseTrailers                          = GetObject<Metadata>(new IntPtr(p + 0x048), ReversePrism.DataModels.Metadata.FromPointer); // 0270D9362120 0x48 ResponseTrailers            ( 00018660C830 ModelClassType Metadata Metadata Metadata Pointer )
            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x050)); // 0270D9362140 0x50 Status                      ( 0001865855D0 ModelEnumType Status Status Status Int32 )
            value.ServerResponseStream                      = GetObject<IServerResponseStream>(new IntPtr(p + 0x068), ReversePrism.DataModels.IServerResponseStream.FromPointer); // 0270D9362160 0x68 ServerResponseStream        ( 000186638640 ModelClassType IServerResponseStream IServerResponseStream IServerResponseStream Pointer )
            value.LazyAuthContext                           = GetObject<AuthContext>(new IntPtr(p + 0x070), ReversePrism.DataModels.AuthContext.FromPointer); // 0270D9362180 0x70 LazyAuthContext             ( 00018671EE90 ModelClassType AuthContext AuthContext AuthContext Pointer )

            return value;
        }
    }
}
