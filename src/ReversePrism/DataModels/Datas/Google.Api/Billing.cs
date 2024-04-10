using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Billing> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ConsumerDestinationsFieldNumber          int IL2CPP_TYPE_I4
    // 008 _repeated_consumerDestinations_codec     FieldCodec`1<BillingDestination> IL2CPP_TYPE_GENERICINST
    // 018 ConsumerDestinations                     000185CF8278 ModelClassListType RepeatedField`1<BillingDestination> RepeatedField`1<BillingDestination> List<BillingDestination> Pointer
    public partial class Billing : DataModel
    {
        public List<BillingDestination>?                ConsumerDestinations                    { get; set; }

        public static Billing? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Billing() { Pointer= p0 };

            value.ConsumerDestinations                      = GetObjectList<BillingDestination>(new IntPtr(p + 0x018), ReversePrism.DataModels.BillingDestination.FromPointer); // 02466A7C6E48 0x18 ConsumerDestinations        ( 000185CF8278 ModelClassListType RepeatedField`1<BillingDestination> RepeatedField`1<BillingDestination> List<BillingDestination> Pointer )

            return value;
        }
    }
}
