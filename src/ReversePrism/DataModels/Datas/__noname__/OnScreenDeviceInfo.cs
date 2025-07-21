using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventPtr                                 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 018 buffer                                   NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 Device                                   ModelClassType InputDevice InputDevice InputDevice Pointer
    // 030 FirstControl                             ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer
    public partial class OnScreenDeviceInfo : DataModel
    {
        public InputEventPtr                            EventPtr                                { get; set; }
        public InputDevice?                             Device                                  { get; set; }
        public OnScreenControl?                         FirstControl                            { get; set; }

        public static OnScreenDeviceInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new OnScreenDeviceInfo() { Pointer= p0 };

            value.EventPtr                                  = (InputEventPtr)GetInt32(new IntPtr(p + 0x010)); // 0x10 EventPtr                    ( ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputDevice.FromPointer); // 0x28 Device                      ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.FirstControl                              = GetObject<OnScreenControl>(new IntPtr(p + 0x030), ReversePrism.DataModels.OnScreenControl.FromPointer); // 0x30 FirstControl                ( ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer )

            return value;
        }
    }
}
