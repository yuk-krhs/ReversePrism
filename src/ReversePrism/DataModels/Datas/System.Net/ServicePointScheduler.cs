using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ServicePoint                             000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer
    // 018 Running                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 01C MaxIdleTime                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 SchedulerEvent                           000186762EA0 ModelClassType AsyncManualResetEvent AsyncManualResetEvent AsyncManualResetEvent Pointer
    // 028 DefaultGroup                             0001867633A0 ModelClassType ConnectionGroup ConnectionGroup ConnectionGroup Pointer
    // 030 groups                                   Dictionary`2<string, ConnectionGroup> IL2CPP_TYPE_GENERICINST
    // 038 operations                               LinkedList`1<ValueTuple`2<ConnectionGroup, WebOperation>> IL2CPP_TYPE_GENERICINST
    // 040 idleConnections                          LinkedList`1<ValueTuple`3<ConnectionGroup, WebConnection, Task>> IL2CPP_TYPE_GENERICINST
    // 048 CurrentConnections                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 04C ConnectionLimit                          0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 IdleSince                                0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 000 nextId                                   int IL2CPP_TYPE_I4
    // 058 ID                                       0001865F4940 ModelPrimitiveType int int int Int32
    public partial class ServicePointScheduler : DataModel
    {
        public ServicePoint?                            ServicePoint                            { get; set; }
        public int                                      Running                                 { get; set; }
        public int                                      MaxIdleTime                             { get; set; }
        public AsyncManualResetEvent?                   SchedulerEvent                          { get; set; }
        public ConnectionGroup?                         DefaultGroup                            { get; set; }
        public int                                      CurrentConnections                      { get; set; }
        public int                                      ConnectionLimit                         { get; set; }
        public DateTime                                 IdleSince                               { get; set; }
        public int                                      ID                                      { get; set; }

        public static ServicePointScheduler? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ServicePointScheduler() { Pointer= p0 };

            value.ServicePoint                              = GetObject<ServicePoint>(new IntPtr(p + 0x010), ReversePrism.DataModels.ServicePoint.FromPointer); // 024667AE9930 0x10 ServicePoint                ( 000186738E90 ModelClassType ServicePoint ServicePoint ServicePoint Pointer )
            value.Running                                   = GetInt32(new IntPtr(p + 0x018)); // 024667AE9950 0x18 Running                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxIdleTime                               = GetInt32(new IntPtr(p + 0x01C)); // 024667AE9970 0x1C MaxIdleTime                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SchedulerEvent                            = GetObject<AsyncManualResetEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.AsyncManualResetEvent.FromPointer); // 024667AE9990 0x20 SchedulerEvent              ( 000186762EA0 ModelClassType AsyncManualResetEvent AsyncManualResetEvent AsyncManualResetEvent Pointer )
            value.DefaultGroup                              = GetObject<ConnectionGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.ConnectionGroup.FromPointer); // 024667AE99B0 0x28 DefaultGroup                ( 0001867633A0 ModelClassType ConnectionGroup ConnectionGroup ConnectionGroup Pointer )
            value.CurrentConnections                        = GetInt32(new IntPtr(p + 0x048)); // 024667AE9A30 0x48 CurrentConnections          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ConnectionLimit                           = GetInt32(new IntPtr(p + 0x04C)); // 024667AE9A50 0x4C ConnectionLimit             ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.IdleSince                                 = GetDateTime(new IntPtr(p + 0x050)); // 024667AE9A70 0x50 IdleSince                   ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ID                                        = GetInt32(new IntPtr(p + 0x058)); // 024667AE9AB0 0x58 ID                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
