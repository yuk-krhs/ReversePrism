using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Logging> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProducerDestinationsFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_producerDestinations_codec     FieldCodec`1<LoggingDestination> IL2CPP_TYPE_GENERICINST
    // 018 ProducerDestinations                     000185CF9238 ModelClassListType RepeatedField`1<LoggingDestination> RepeatedField`1<LoggingDestination> List<LoggingDestination> Pointer
    // 000 ConsumerDestinationsFieldNumber          int IL2CPP_TYPE_I4
    // 010 _repeated_consumerDestinations_codec     FieldCodec`1<LoggingDestination> IL2CPP_TYPE_GENERICINST
    // 020 ConsumerDestinations                     000185CF9238 ModelClassListType RepeatedField`1<LoggingDestination> RepeatedField`1<LoggingDestination> List<LoggingDestination> Pointer
    public partial class Logging : DataModel
    {
        public List<LoggingDestination>?                ProducerDestinations                    { get; set; }
        public List<LoggingDestination>?                ConsumerDestinations                    { get; set; }

        public static Logging? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Logging() { Pointer= p0 };

            value.ProducerDestinations                      = GetObjectList<LoggingDestination>(new IntPtr(p + 0x018), ReversePrism.DataModels.LoggingDestination.FromPointer); // 02466A856528 0x18 ProducerDestinations        ( 000185CF9238 ModelClassListType RepeatedField`1<LoggingDestination> RepeatedField`1<LoggingDestination> List<LoggingDestination> Pointer )
            value.ConsumerDestinations                      = GetObjectList<LoggingDestination>(new IntPtr(p + 0x020), ReversePrism.DataModels.LoggingDestination.FromPointer); // 02466A856588 0x20 ConsumerDestinations        ( 000185CF9238 ModelClassListType RepeatedField`1<LoggingDestination> RepeatedField`1<LoggingDestination> List<LoggingDestination> Pointer )

            return value;
        }
    }
}
