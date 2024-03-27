using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 068 M_PrevActionTime                         0001866656B0 ModelPrimitiveType float float float Single
    // 06C M_LastMoveVector                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 074 M_ConsecutiveMoveCount                   0001865F2AF0 ModelPrimitiveType int int int Int32
    // 078 M_LastMousePosition                      0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 080 M_MousePosition                          0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 088 M_CurrentFocusedGameObject               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 090 M_InputPointerEvent                      000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer
    // 000 doubleClickTime                          float IL2CPP_TYPE_R4
    // 098 M_HorizontalAxis                         000186671910 ModelPrimitiveType string string string String
    // 0A0 M_VerticalAxis                           000186671910 ModelPrimitiveType string string string String
    // 0A8 M_SubmitButton                           000186671910 ModelPrimitiveType string string string String
    // 0B0 M_CancelButton                           000186671910 ModelPrimitiveType string string string String
    // 0B8 M_InputActionsPerSecond                  0001866656B0 ModelPrimitiveType float float float Single
    // 0BC M_RepeatDelay                            0001866656B0 ModelPrimitiveType float float float Single
    // 0C0 M_ForceModuleActive                      000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class StandaloneInputModule
    {
        public float                                    M_PrevActionTime                        { get; set; }
        public Vector2                                  M_LastMoveVector                        { get; set; }
        public int                                      M_ConsecutiveMoveCount                  { get; set; }
        public Vector2                                  M_LastMousePosition                     { get; set; }
        public Vector2                                  M_MousePosition                         { get; set; }
        public GameObject?                              M_CurrentFocusedGameObject              { get; set; }
        public PointerEventData?                        M_InputPointerEvent                     { get; set; }
        public string                                   M_HorizontalAxis                        { get; set; }
        public string                                   M_VerticalAxis                          { get; set; }
        public string                                   M_SubmitButton                          { get; set; }
        public string                                   M_CancelButton                          { get; set; }
        public float                                    M_InputActionsPerSecond                 { get; set; }
        public float                                    M_RepeatDelay                           { get; set; }
        public bool                                     M_ForceModuleActive                     { get; set; }

        public static StandaloneInputModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StandaloneInputModule();

            value.M_PrevActionTime                          = GetSingle(new IntPtr(p + 0x068)); // 027003EB9160 0x68 M_PrevActionTime            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LastMoveVector                          = (Vector2)GetInt32(new IntPtr(p + 0x06C)); // 027003EB9180 0x6C M_LastMoveVector            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_ConsecutiveMoveCount                    = GetInt32(new IntPtr(p + 0x074)); // 027003EB91A0 0x74 M_ConsecutiveMoveCount      ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_LastMousePosition                       = (Vector2)GetInt32(new IntPtr(p + 0x078)); // 027003EB91C0 0x78 M_LastMousePosition         ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_MousePosition                           = (Vector2)GetInt32(new IntPtr(p + 0x080)); // 027003EB91E0 0x80 M_MousePosition             ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_CurrentFocusedGameObject                = GetObject<GameObject>(new IntPtr(p + 0x088), ReversePrism.DataModels.GameObject.FromPointer); // 027003EB9200 0x88 M_CurrentFocusedGameObject  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.M_InputPointerEvent                       = GetObject<PointerEventData>(new IntPtr(p + 0x090), ReversePrism.DataModels.PointerEventData.FromPointer); // 027003EB9220 0x90 M_InputPointerEvent         ( 000186642240 ModelClassType PointerEventData PointerEventData PointerEventData Pointer )
            value.M_HorizontalAxis                          = GetString(new IntPtr(p + 0x098)); // 027003EB9260 0x98 M_HorizontalAxis            ( 000186671910 ModelPrimitiveType string string string String )
            value.M_VerticalAxis                            = GetString(new IntPtr(p + 0x0A0)); // 027003EB9280 0xA0 M_VerticalAxis              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_SubmitButton                            = GetString(new IntPtr(p + 0x0A8)); // 027003EB92A0 0xA8 M_SubmitButton              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_CancelButton                            = GetString(new IntPtr(p + 0x0B0)); // 027003EB92C0 0xB0 M_CancelButton              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_InputActionsPerSecond                   = GetSingle(new IntPtr(p + 0x0B8)); // 027003EB92E0 0xB8 M_InputActionsPerSecond     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_RepeatDelay                             = GetSingle(new IntPtr(p + 0x0BC)); // 027003EB9300 0xBC M_RepeatDelay               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ForceModuleActive                       = GetBool(new IntPtr(p + 0x0C0)); // 027003EB9320 0xC0 M_ForceModuleActive         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
