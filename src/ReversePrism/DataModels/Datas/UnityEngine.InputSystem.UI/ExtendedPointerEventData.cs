using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 180 Control                                  0001865EB190 ModelClassType InputControl InputControl InputControl Pointer
    // 188 Device                                   0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer
    // 190 TouchId                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 194 PointerType                              0001866ED570 ModelEnumType UIPointerType UIPointerType UIPointerType Int32
    // 198 UiToolkitPointerId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 19C TrackedDevicePosition                    0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1A8 TrackedDeviceOrientation                 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class ExtendedPointerEventData
    {
        public InputControl?                            Control                                 { get; set; }
        public InputDevice?                             Device                                  { get; set; }
        public int                                      TouchId                                 { get; set; }
        public UIPointerType                            PointerType                             { get; set; }
        public int                                      UiToolkitPointerId                      { get; set; }
        public Vector3                                  TrackedDevicePosition                   { get; set; }
        public Quaternion                               TrackedDeviceOrientation                { get; set; }

        public static ExtendedPointerEventData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ExtendedPointerEventData();

            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.InputControl.FromPointer); // 0270D779CE80 0x180 Control                     ( 0001865EB190 ModelClassType InputControl InputControl InputControl Pointer )
            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x188), ReversePrism.DataModels.InputDevice.FromPointer); // 0270D779CEA0 0x188 Device                      ( 0001866FAE50 ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.TouchId                                   = GetInt32(new IntPtr(p + 0x190)); // 0270D779CEC0 0x190 TouchId                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.PointerType                               = (UIPointerType)GetInt32(new IntPtr(p + 0x194)); // 0270D779CEE0 0x194 PointerType                 ( 0001866ED570 ModelEnumType UIPointerType UIPointerType UIPointerType Int32 )
            value.UiToolkitPointerId                        = GetInt32(new IntPtr(p + 0x198)); // 0270D779CF00 0x198 UiToolkitPointerId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TrackedDevicePosition                     = (Vector3)GetInt32(new IntPtr(p + 0x19C)); // 0270D779CF20 0x19C TrackedDevicePosition       ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TrackedDeviceOrientation                  = (Quaternion)GetInt32(new IntPtr(p + 0x1A8)); // 0270D779CF40 0x1A8 TrackedDeviceOrientation    ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
