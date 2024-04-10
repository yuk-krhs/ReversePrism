using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 queue                                    ConcurrentQueue`1<ILogRecord> IL2CPP_TYPE_GENERICINST
    // 018 Limit                                    0001865F4260 ModelPrimitiveType int int int Int32
    // 020 Child                                    00018669BE60 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer
    public partial class NetworkLogger : DataModel
    {
        public int                                      Limit                                   { get; set; }
        public NetworkLoggerBase?                       Child                                   { get; set; }

        public static NetworkLogger? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NetworkLogger() { Pointer= p0 };

            value.Limit                                     = GetInt32(new IntPtr(p + 0x018)); // 0246605D8538 0x18 Limit                       ( 0001865F4260 ModelPrimitiveType int int int Int32 )
            value.Child                                     = GetObject<NetworkLoggerBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.NetworkLoggerBase.FromPointer); // 0246605D8558 0x20 Child                       ( 00018669BE60 ModelClassType NetworkLoggerBase NetworkLoggerBase NetworkLoggerBase Pointer )

            return value;
        }
    }
}
