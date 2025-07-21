using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Scheduler                                ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 nextId                                   int IL2CPP_TYPE_I4
    // 020 ID                                       ModelPrimitiveType int int int Int32
    // 028 connections                              LinkedList`1<WebConnection> IL2CPP_TYPE_GENERICINST
    // 030 queue                                    LinkedList`1<WebOperation> IL2CPP_TYPE_GENERICINST
    public partial class ConnectionGroup : DataModel
    {
        public ServicePointScheduler?                   Scheduler                               { get; set; }
        public string                                   Name                                    { get; set; }
        public int                                      ID                                      { get; set; }

        public static ConnectionGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ConnectionGroup() { Pointer= p0 };

            value.Scheduler                                 = GetObject<ServicePointScheduler>(new IntPtr(p + 0x010), ReversePrism.DataModels.ServicePointScheduler.FromPointer); // 0x10 Scheduler                   ( ModelClassType ServicePointScheduler ServicePointScheduler ServicePointScheduler Pointer )
            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.ID                                        = GetInt32(new IntPtr(p + 0x020)); // 0x20 ID                          ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
