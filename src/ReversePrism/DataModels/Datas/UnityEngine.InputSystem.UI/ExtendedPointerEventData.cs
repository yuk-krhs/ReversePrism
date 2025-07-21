using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 180 Control                                  ModelClassType InputControl InputControl InputControl Pointer
    // 188 Device                                   ModelClassType InputDevice InputDevice InputDevice Pointer
    // 190 TouchId                                  ModelPrimitiveType int int int Int32
    // 194 PointerType                              ModelEnumType UIPointerType UIPointerType UIPointerType Int32
    // 198 UiToolkitPointerId                       ModelPrimitiveType int int int Int32
    // 19C TrackedDevicePosition                    ModelEnumType Vector3 Vector3 Vector3 Int32
    // 1A8 TrackedDeviceOrientation                 ModelEnumType Quaternion Quaternion Quaternion Int32
    public partial class ExtendedPointerEventData : DataModel
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
            var value   = new ExtendedPointerEventData() { Pointer= p0 };

            value.Control                                   = GetObject<InputControl>(new IntPtr(p + 0x180), ReversePrism.DataModels.InputControl.FromPointer); // 0x180 Control                     ( ModelClassType InputControl InputControl InputControl Pointer )
            value.Device                                    = GetObject<InputDevice>(new IntPtr(p + 0x188), ReversePrism.DataModels.InputDevice.FromPointer); // 0x188 Device                      ( ModelClassType InputDevice InputDevice InputDevice Pointer )
            value.TouchId                                   = GetInt32(new IntPtr(p + 0x190)); // 0x190 TouchId                     ( ModelPrimitiveType int int int Int32 )
            value.PointerType                               = (UIPointerType)GetInt32(new IntPtr(p + 0x194)); // 0x194 PointerType                 ( ModelEnumType UIPointerType UIPointerType UIPointerType Int32 )
            value.UiToolkitPointerId                        = GetInt32(new IntPtr(p + 0x198)); // 0x198 UiToolkitPointerId          ( ModelPrimitiveType int int int Int32 )
            value.TrackedDevicePosition                     = (Vector3)GetInt32(new IntPtr(p + 0x19C)); // 0x19C TrackedDevicePosition       ( ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.TrackedDeviceOrientation                  = (Quaternion)GetInt32(new IntPtr(p + 0x1A8)); // 0x1A8 TrackedDeviceOrientation    ( ModelEnumType Quaternion Quaternion Quaternion Int32 )

            return value;
        }
    }
}
