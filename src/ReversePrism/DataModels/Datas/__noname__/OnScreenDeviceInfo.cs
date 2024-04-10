using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 EventPtr                                 0001865EF560 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32
    // 018 buffer                                   NativeArray`1<sbyte> IL2CPP_TYPE_GENERICINST
    // 028 Device                                   0001866FB2E0 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 030 FirstControl                             0001866DC020 ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer
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

            value.EventPtr                                  = (InputEventPtr)GetInt32(new IntPtr(p + 0x010)); // 024667814748 0x10 EventPtr                    ( 0001865EF560 ModelEnumType InputEventPtr InputEventPtr InputEventPtr Int32 )
            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x028), ReversePrism.DataModels.InputDevice.FromPointer); // 024667814788 0x28 Device                      ( 0001866FB2E0 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.FirstControl                              = GetObject<OnScreenControl>(new IntPtr(p + 0x030), ReversePrism.DataModels.OnScreenControl.FromPointer); // 0246678147A8 0x30 FirstControl                ( 0001866DC020 ModelClassType OnScreenControl OnScreenControl OnScreenControl Pointer )

            return value;
        }
    }
}
