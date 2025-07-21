using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 CallHandle                               ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 020 Method                                   ModelPrimitiveType string string string String
    // 028 Host                                     ModelPrimitiveType string string string String
    // 030 Deadline                                 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 038 RequestHeaders                           ModelClassType Metadata Metadata Metadata Pointer
    // 040 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 ResponseTrailers                         ModelClassType Metadata Metadata Metadata Pointer
    // 050 Status                                   ModelEnumType Status Status Status Int32
    // 068 ServerResponseStream                     ModelClassType IServerResponseStream IServerResponseStream IServerResponseStream Pointer
    // 070 LazyAuthContext                          ModelClassType AuthContext AuthContext AuthContext Pointer
    public partial class DefaultServerCallContext : DataModel
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
            var value   = new DefaultServerCallContext() { Pointer= p0 };

            value.CallHandle                                = GetObject<CallSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0x18 CallHandle                  ( ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Method                      ( ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Host                        ( ModelPrimitiveType string string string String )
            value.Deadline                                  = GetDateTime(new IntPtr(p + 0x030)); // 0x30 Deadline                    ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.RequestHeaders                            = GetObject<Metadata>(new IntPtr(p + 0x038), ReversePrism.DataModels.Metadata.FromPointer); // 0x38 RequestHeaders              ( ModelClassType Metadata Metadata Metadata Pointer )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0x40 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.ResponseTrailers                          = GetObject<Metadata>(new IntPtr(p + 0x048), ReversePrism.DataModels.Metadata.FromPointer); // 0x48 ResponseTrailers            ( ModelClassType Metadata Metadata Metadata Pointer )
            value.Status                                    = (Status)GetInt32(new IntPtr(p + 0x050)); // 0x50 Status                      ( ModelEnumType Status Status Status Int32 )
            value.ServerResponseStream                      = GetObject<IServerResponseStream>(new IntPtr(p + 0x068), ReversePrism.DataModels.IServerResponseStream.FromPointer); // 0x68 ServerResponseStream        ( ModelClassType IServerResponseStream IServerResponseStream IServerResponseStream Pointer )
            value.LazyAuthContext                           = GetObject<AuthContext>(new IntPtr(p + 0x070), ReversePrism.DataModels.AuthContext.FromPointer); // 0x70 LazyAuthContext             ( ModelClassType AuthContext AuthContext AuthContext Pointer )

            return value;
        }
    }
}
