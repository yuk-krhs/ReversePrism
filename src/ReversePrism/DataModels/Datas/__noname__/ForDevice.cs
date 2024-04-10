using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Observer                               IObserver`1<InputEventPtr> IL2CPP_TYPE_GENERICINST
    // 018 M_Device                                 0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 020 M_DeviceType                             000186692850 ModelClassType Type Type Type Pointer
    public partial class ForDevice : DataModel
    {
        public InputDevice?                             M_Device                                { get; set; }
        public Type?                                    M_DeviceType                            { get; set; }

        public static ForDevice? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ForDevice() { Pointer= p0 };

            value.M_Device                                  = GetObject<InputDevice>(new IntPtr(p + 0x018), ReversePrism.DataModels.InputDevice.FromPointer); // 0246679280B0 0x18 M_Device                    ( 0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.M_DeviceType                              = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0246679280D0 0x20 M_DeviceType                ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
