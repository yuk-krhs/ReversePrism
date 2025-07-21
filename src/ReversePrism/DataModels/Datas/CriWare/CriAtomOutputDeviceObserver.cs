using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 030 DontDestroyOnLoad                        ModelPrimitiveType bool bool bool Bool
    // 031 LastIsConnected                          ModelPrimitiveType bool bool bool Bool
    // 032 IsConnected                              ModelPrimitiveType bool bool bool Bool
    // 034 LastDeviceType                           ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32
    // 038 DeviceType                               ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32
    // 000 instance                                 CriAtomOutputDeviceObserver IL2CPP_TYPE_CLASS
    // 008 _onDeviceConnectionChanged               DeviceConnectionChangeCallback IL2CPP_TYPE_CLASS
    public partial class CriAtomOutputDeviceObserver : DataModel
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
            var value   = new CriAtomOutputDeviceObserver() { Pointer= p0 };

            value.DontDestroyOnLoad                         = GetBool(new IntPtr(p + 0x030)); // 0x30 DontDestroyOnLoad           ( ModelPrimitiveType bool bool bool Bool )
            value.LastIsConnected                           = GetBool(new IntPtr(p + 0x031)); // 0x31 LastIsConnected             ( ModelPrimitiveType bool bool bool Bool )
            value.IsConnected                               = GetBool(new IntPtr(p + 0x032)); // 0x32 IsConnected                 ( ModelPrimitiveType bool bool bool Bool )
            value.LastDeviceType                            = (OutputDeviceType)GetInt32(new IntPtr(p + 0x034)); // 0x34 LastDeviceType              ( ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32 )
            value.DeviceType                                = (OutputDeviceType)GetInt32(new IntPtr(p + 0x038)); // 0x38 DeviceType                  ( ModelEnumType OutputDeviceType OutputDeviceType OutputDeviceType Int32 )

            return value;
        }
    }
}
