using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Server                                   000186731B80 ModelClassType Server Server Server Pointer
    // 018 Call                                     00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 020 Method                                   000186672F10 ModelPrimitiveType string string string String
    // 028 Host                                     000186672F10 ModelPrimitiveType string string string String
    // 030 Deadline                                 000186675310 ModelEnumType Timespec Timespec Timespec Int32
    // 040 RequestMetadata                          00018660C830 ModelClassType Metadata Metadata Metadata Pointer
    public partial class ServerRpcNew : DataModel
    {
        public Server?                                  Server                                  { get; set; }
        public CallSafeHandle?                          Call                                    { get; set; }
        public string                                   Method                                  { get; set; }
        public string                                   Host                                    { get; set; }
        public Timespec                                 Deadline                                { get; set; }
        public Metadata?                                RequestMetadata                         { get; set; }

        public static ServerRpcNew? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServerRpcNew() { Pointer= p0 };

            value.Server                                    = GetObject<Server>(new IntPtr(p + 0x010), ReversePrism.DataModels.Server.FromPointer); // 0246693B6E08 0x10 Server                      ( 000186731B80 ModelClassType Server Server Server Pointer )
            value.Call                                      = GetObject<CallSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0246693B6E28 0x18 Call                        ( 00018652DD30 ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0246693B6E48 0x20 Method                      ( 000186672F10 ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0246693B6E68 0x28 Host                        ( 000186672F10 ModelPrimitiveType string string string String )
            value.Deadline                                  = (Timespec)GetInt32(new IntPtr(p + 0x030)); // 0246693B6E88 0x30 Deadline                    ( 000186675310 ModelEnumType Timespec Timespec Timespec Int32 )
            value.RequestMetadata                           = GetObject<Metadata>(new IntPtr(p + 0x040), ReversePrism.DataModels.Metadata.FromPointer); // 0246693B6EA8 0x40 RequestMetadata             ( 00018660C830 ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
