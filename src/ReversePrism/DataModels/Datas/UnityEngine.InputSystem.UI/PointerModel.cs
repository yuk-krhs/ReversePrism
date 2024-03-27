using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ChangedThisFrame                         000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 LeftButton                               0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32
    // 0B0 RightButton                              0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32
    // 148 MiddleButton                             0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32
    // 1E0 EventData                                00018652FB60 ModelClassType ExtendedPointerEventData ExtendedPointerEventData ExtendedPointerEventData Pointer
    // 1E8 M_ScreenPosition                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 1F0 M_ScrollDelta                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 1F8 M_WorldPosition                          0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32
    // 204 M_WorldOrientation                       000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32
    // 214 M_Pressure                               0001866656B0 ModelPrimitiveType float float float Single
    // 218 M_AzimuthAngle                           0001866656B0 ModelPrimitiveType float float float Single
    // 21C M_AltitudeAngle                          0001866656B0 ModelPrimitiveType float float float Single
    // 220 M_Twist                                  0001866656B0 ModelPrimitiveType float float float Single
    // 224 M_Radius                                 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    public partial class PointerModel
    {
        public bool                                     ChangedThisFrame                        { get; set; }
        public ButtonState                              LeftButton                              { get; set; }
        public ButtonState                              RightButton                             { get; set; }
        public ButtonState                              MiddleButton                            { get; set; }
        public ExtendedPointerEventData?                EventData                               { get; set; }
        public Vector2                                  M_ScreenPosition                        { get; set; }
        public Vector2                                  M_ScrollDelta                           { get; set; }
        public Vector3                                  M_WorldPosition                         { get; set; }
        public Quaternion                               M_WorldOrientation                      { get; set; }
        public float                                    M_Pressure                              { get; set; }
        public float                                    M_AzimuthAngle                          { get; set; }
        public float                                    M_AltitudeAngle                         { get; set; }
        public float                                    M_Twist                                 { get; set; }
        public Vector2                                  M_Radius                                { get; set; }

        public static PointerModel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PointerModel();

            value.ChangedThisFrame                          = GetBool(new IntPtr(p + 0x010)); // 0270D7725F88 0x10 ChangedThisFrame            ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.LeftButton                                = (ButtonState)GetInt32(new IntPtr(p + 0x018)); // 0270D7725FA8 0x18 LeftButton                  ( 0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32 )
            value.RightButton                               = (ButtonState)GetInt32(new IntPtr(p + 0x0B0)); // 0270D7725FC8 0xB0 RightButton                 ( 0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32 )
            value.MiddleButton                              = (ButtonState)GetInt32(new IntPtr(p + 0x148)); // 0270D7725FE8 0x148 MiddleButton                ( 0001867094C0 ModelEnumType ButtonState ButtonState ButtonState Int32 )
            value.EventData                                 = GetObject<ExtendedPointerEventData>(new IntPtr(p + 0x1E0), ReversePrism.DataModels.ExtendedPointerEventData.FromPointer); // 0270D7726008 0x1E0 EventData                   ( 00018652FB60 ModelClassType ExtendedPointerEventData ExtendedPointerEventData ExtendedPointerEventData Pointer )
            value.M_ScreenPosition                          = (Vector2)GetInt32(new IntPtr(p + 0x1E8)); // 0270D7726028 0x1E8 M_ScreenPosition            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ScrollDelta                             = (Vector2)GetInt32(new IntPtr(p + 0x1F0)); // 0270D7726048 0x1F0 M_ScrollDelta               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_WorldPosition                           = (Vector3)GetInt32(new IntPtr(p + 0x1F8)); // 0270D7726068 0x1F8 M_WorldPosition             ( 0001866AB820 ModelEnumType Vector3 Vector3 Vector3 Int32 )
            value.M_WorldOrientation                        = (Quaternion)GetInt32(new IntPtr(p + 0x204)); // 0270D7726088 0x204 M_WorldOrientation          ( 000186649E40 ModelEnumType Quaternion Quaternion Quaternion Int32 )
            value.M_Pressure                                = GetSingle(new IntPtr(p + 0x214)); // 0270D77260A8 0x214 M_Pressure                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AzimuthAngle                            = GetSingle(new IntPtr(p + 0x218)); // 0270D77260C8 0x218 M_AzimuthAngle              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_AltitudeAngle                           = GetSingle(new IntPtr(p + 0x21C)); // 0270D77260E8 0x21C M_AltitudeAngle             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Twist                                   = GetSingle(new IntPtr(p + 0x220)); // 0270D7726108 0x220 M_Twist                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Radius                                  = (Vector2)GetInt32(new IntPtr(p + 0x224)); // 0270D7726128 0x224 M_Radius                    ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )

            return value;
        }
    }
}
