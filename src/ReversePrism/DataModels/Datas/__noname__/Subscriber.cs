using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Owner                                    00018664A370 ModelClassType RemoteInputPlayerConnection RemoteInputPlayerConnection RemoteInputPlayerConnection Pointer
    // 018 observer                                 IObserver`1<Message> IL2CPP_TYPE_GENERICINST
    public partial class Subscriber : DataModel
    {
        public RemoteInputPlayerConnection?             Owner                                   { get; set; }

        public static Subscriber? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Subscriber() { Pointer= p0 };

            value.Owner                                     = GetObject<RemoteInputPlayerConnection>(new IntPtr(p + 0x010), ReversePrism.DataModels.RemoteInputPlayerConnection.FromPointer); // 0246677724A8 0x10 Owner                       ( 00018664A370 ModelClassType RemoteInputPlayerConnection RemoteInputPlayerConnection RemoteInputPlayerConnection Pointer )

            return value;
        }
    }
}
