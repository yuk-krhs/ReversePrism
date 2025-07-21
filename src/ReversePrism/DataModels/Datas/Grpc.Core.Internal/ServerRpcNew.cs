using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Server                                   ModelClassType Server Server Server Pointer
    // 018 Call                                     ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer
    // 020 Method                                   ModelPrimitiveType string string string String
    // 028 Host                                     ModelPrimitiveType string string string String
    // 030 Deadline                                 ModelEnumType Timespec Timespec Timespec Int32
    // 040 RequestMetadata                          ModelClassType Metadata Metadata Metadata Pointer
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

            value.Server                                    = GetObject<Server>(new IntPtr(p + 0x010), ReversePrism.DataModels.Server.FromPointer); // 0x10 Server                      ( ModelClassType Server Server Server Pointer )
            value.Call                                      = GetObject<CallSafeHandle>(new IntPtr(p + 0x018), ReversePrism.DataModels.CallSafeHandle.FromPointer); // 0x18 Call                        ( ModelClassType CallSafeHandle CallSafeHandle CallSafeHandle Pointer )
            value.Method                                    = GetString(new IntPtr(p + 0x020)); // 0x20 Method                      ( ModelPrimitiveType string string string String )
            value.Host                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Host                        ( ModelPrimitiveType string string string String )
            value.Deadline                                  = (Timespec)GetInt32(new IntPtr(p + 0x030)); // 0x30 Deadline                    ( ModelEnumType Timespec Timespec Timespec Int32 )
            value.RequestMetadata                           = GetObject<Metadata>(new IntPtr(p + 0x040), ReversePrism.DataModels.Metadata.FromPointer); // 0x40 RequestMetadata             ( ModelClassType Metadata Metadata Metadata Pointer )

            return value;
        }
    }
}
