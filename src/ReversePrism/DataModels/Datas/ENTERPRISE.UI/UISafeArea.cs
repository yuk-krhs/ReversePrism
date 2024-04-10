using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ScreenHeight                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 ScreenWidth                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 ExecType                                 000186666690 ModelEnumType ViewType ViewType ViewType Int32
    // 030 RectTransform                            000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 038 CurrentSafeArea                          00018664F620 ModelEnumType Rect Rect Rect Int32
    // 048 isLastLeft                               Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 04C LastSafeArea                             00018664F620 ModelEnumType Rect Rect Rect Int32
    // 05C LastResolution                           0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32
    // 064 DeviceOrientation                        0001866CB0E0 ModelEnumType DeviceOrientation DeviceOrientation DeviceOrientation Int32
    // 068 IsDebug                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 06C PaddingRight                             0001866656B0 ModelPrimitiveType float float float Single
    // 070 PaddingLeft                              0001866656B0 ModelPrimitiveType float float float Single
    // 074 PaddingBottom                            0001866656B0 ModelPrimitiveType float float float Single
    public partial class UISafeArea : DataModel
    {
        public int                                      ScreenHeight                            { get; set; }
        public int                                      ScreenWidth                             { get; set; }
        public ViewType                                 ExecType                                { get; set; }
        public RectTransform?                           RectTransform                           { get; set; }
        public Rect                                     CurrentSafeArea                         { get; set; }
        public Rect                                     LastSafeArea                            { get; set; }
        public Vector2Int                               LastResolution                          { get; set; }
        public DeviceOrientation                        DeviceOrientation                       { get; set; }
        public bool                                     IsDebug                                 { get; set; }
        public float                                    PaddingRight                            { get; set; }
        public float                                    PaddingLeft                             { get; set; }
        public float                                    PaddingBottom                           { get; set; }

        public static UISafeArea? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UISafeArea() { Pointer= p0 };

            value.ScreenHeight                              = GetInt32(new IntPtr(p + 0x020)); // 0245A3F99F60 0x20 ScreenHeight                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ScreenWidth                               = GetInt32(new IntPtr(p + 0x024)); // 0245A3F99F80 0x24 ScreenWidth                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ExecType                                  = (ViewType)GetInt32(new IntPtr(p + 0x028)); // 0245A3F99FA0 0x28 ExecType                    ( 000186666690 ModelEnumType ViewType ViewType ViewType Int32 )
            value.RectTransform                             = GetObject<RectTransform>(new IntPtr(p + 0x030), ReversePrism.DataModels.RectTransform.FromPointer); // 0245A3F99FC0 0x30 RectTransform               ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.CurrentSafeArea                           = (Rect)GetInt32(new IntPtr(p + 0x038)); // 0245A3F99FE0 0x38 CurrentSafeArea             ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.LastSafeArea                              = (Rect)GetInt32(new IntPtr(p + 0x04C)); // 0245A3F9A020 0x4C LastSafeArea                ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.LastResolution                            = (Vector2Int)GetInt32(new IntPtr(p + 0x05C)); // 0245A3F9A040 0x5C LastResolution              ( 0001866AA380 ModelEnumType Vector2Int Vector2Int Vector2Int Int32 )
            value.DeviceOrientation                         = (DeviceOrientation)GetInt32(new IntPtr(p + 0x064)); // 0245A3F9A060 0x64 DeviceOrientation           ( 0001866CB0E0 ModelEnumType DeviceOrientation DeviceOrientation DeviceOrientation Int32 )
            value.IsDebug                                   = GetBool(new IntPtr(p + 0x068)); // 0245A3F9A080 0x68 IsDebug                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PaddingRight                              = GetSingle(new IntPtr(p + 0x06C)); // 0245A3F9A0A0 0x6C PaddingRight                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PaddingLeft                               = GetSingle(new IntPtr(p + 0x070)); // 0245A3F9A0C0 0x70 PaddingLeft                 ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.PaddingBottom                             = GetSingle(new IntPtr(p + 0x074)); // 0245A3F9A0E0 0x74 PaddingBottom               ( 0001866656B0 ModelPrimitiveType float float float Single )

            return value;
        }
    }
}
