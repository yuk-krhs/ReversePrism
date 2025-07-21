using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Monitoring> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProducerDestinationsFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_producerDestinations_codec     FieldCodec`1<MonitoringDestination> IL2CPP_TYPE_GENERICINST
    // 018 ProducerDestinations                     ModelClassListType RepeatedField`1<MonitoringDestination> RepeatedField`1<MonitoringDestination> List<MonitoringDestination> Pointer
    // 000 ConsumerDestinationsFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_consumerDestinations_codec     FieldCodec`1<MonitoringDestination> IL2CPP_TYPE_GENERICINST
    // 020 ConsumerDestinations                     ModelClassListType RepeatedField`1<MonitoringDestination> RepeatedField`1<MonitoringDestination> List<MonitoringDestination> Pointer
    public partial class Monitoring : DataModel
    {
        public List<MonitoringDestination>?             ProducerDestinations                    { get; set; }
        public List<MonitoringDestination>?             ConsumerDestinations                    { get; set; }

        public static Monitoring? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Monitoring() { Pointer= p0 };

            value.ProducerDestinations                      = GetObjectList<MonitoringDestination>(new IntPtr(p + 0x018), ReversePrism.DataModels.MonitoringDestination.FromPointer); // 0x18 ProducerDestinations        ( ModelClassListType RepeatedField`1<MonitoringDestination> RepeatedField`1<MonitoringDestination> List<MonitoringDestination> Pointer )
            value.ConsumerDestinations                      = GetObjectList<MonitoringDestination>(new IntPtr(p + 0x020), ReversePrism.DataModels.MonitoringDestination.FromPointer); // 0x20 ConsumerDestinations        ( ModelClassListType RepeatedField`1<MonitoringDestination> RepeatedField`1<MonitoringDestination> List<MonitoringDestination> Pointer )

            return value;
        }
    }
}
