using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DontDestroyOnLoad                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 LastIsConnected                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 IsConnected                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 LastDeviceType                           0001865555D0 ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32
    // 038 DeviceType                               0001865555D0 ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32
    // 000 instance                                 CriAtomOutputDeviceObserver IL2CPP_TYPE_CLASS
    // 008 _onDeviceConnectionChanged               DeviceConnectionChangeCallback IL2CPP_TYPE_CLASS
    public partial class CriAtomOutputDeviceObserver
    {
        public bool                                     DontDestroyOnLoad                       { get; set; }
        public bool                                     LastIsConnected                         { get; set; }
        public bool                                     IsConnected                             { get; set; }
        public OutputDeviceType                         LastDeviceType                          { get; set; }
        public OutputDeviceType                         DeviceType                              { get; set; }

        public static CriAtomOutputDeviceObserver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CriAtomOutputDeviceObserver();

            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x030)); // 0270DAC33528 0x30 DontDestroyOnLoad           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastIsConnected                           = GetBool(new IntPtr(p + 0x031)); // 0270DAC33548 0x31 LastIsConnected             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsConnected                               = GetBool(new IntPtr(p + 0x032)); // 0270DAC33568 0x32 IsConnected                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.LastDeviceType                            = (OutputDeviceType)GetInt32(new IntPtr(p + 0x034)); // 0270DAC33588 0x34 LastDeviceType              ( 0001865555D0 ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32 )
            value.DeviceType                                = (OutputDeviceType)GetInt32(new IntPtr(p + 0x038)); // 0270DAC335A8 0x38 DeviceType                  ( 0001865555D0 ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32 )

            return value;
        }
    }
}
