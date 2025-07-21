using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kClickSpeed                              float IL2CPP_TYPE_R4
    // 058 M_MoveRepeatDelay                        ModelPrimitiveType float float float Single
    // 05C M_MoveRepeatRate                         ModelPrimitiveType float float float Single
    // 060 M_TrackedDeviceDragThresholdMultiplier   ModelPrimitiveType float float float Single
    // 068 M_XRTrackingOrigin                       ModelClassType Transform Transform Transform Pointer
    // 000 kPixelPerLine                            float IL2CPP_TYPE_R4
    // 070 M_ActionsAsset                           ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer
    // 078 M_PointAction                            ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 080 M_MoveAction                             ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 088 M_SubmitAction                           ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 090 M_CancelAction                           ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 098 M_LeftClickAction                        ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0A0 M_MiddleClickAction                      ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0A8 M_RightClickAction                       ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0B0 M_ScrollWheelAction                      ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0B8 M_TrackedDevicePositionAction            ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0C0 M_TrackedDeviceOrientationAction         ModelClassType InputActionReference InputActionReference InputActionReference Pointer
    // 0C8 M_DeselectOnBackgroundClick              ModelPrimitiveType bool bool bool Bool
    // 0CC M_PointerBehavior                        ModelEnumType UIPointerBehavior UIPointerBehavior UIPointerBehavior Int32
    // 0D0 M_CursorLockBehavior                     ModelEnumType CursorLockBehavior CursorLockBehavior CursorLockBehavior Int32
    // 000 s_InputActionReferenceCounts             Dictionary`2<InputAction, InputActionReferenceState> IL2CPP_TYPE_GENERICINST
    // 0D4 M_ActionsHooked                          ModelPrimitiveType bool bool bool Bool
    // 0D5 M_NeedToPurgeStalePointers               ModelPrimitiveType bool bool bool Bool
    // 0D8 m_OnPointDelegate                        Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0E0 m_OnMoveDelegate                         Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0E8 m_OnLeftClickDelegate                    Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0F0 m_OnRightClickDelegate                   Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 0F8 m_OnMiddleClickDelegate                  Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 100 m_OnScrollWheelDelegate                  Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 108 m_OnTrackedDevicePositionDelegate        Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 110 m_OnTrackedDeviceOrientationDelegate     Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 118 m_OnControlsChangedDelegate              Action`1<<object>> IL2CPP_TYPE_GENERICINST
    // 120 M_CurrentPointerId                       ModelPrimitiveType int int int Int32
    // 124 M_CurrentPointerIndex                    ModelPrimitiveType int int int Int32
    // 128 M_CurrentPointerType                     ModelEnumType UIPointerType UIPointerType UIPointerType Int32
    // 130 m_PointerIds                             InlinedArray`1<int> IL2CPP_TYPE_GENERICINST
    // 140 m_PointerTouchControls                   InlinedArray`1<InputControl> IL2CPP_TYPE_GENERICINST
    // 158 m_PointerStates                          InlinedArray`1<PointerModel> IL2CPP_TYPE_GENERICINST
    // 388 M_NavigationState                        ModelEnumType NavigationModel NavigationModel NavigationModel Int32
    // 3A8 M_LocalMultiPlayerRoot                   ModelClassType GameObject GameObject GameObject Pointer
    public partial class InputSystemUIInputModule : DataModel
    {
        public float                                    M_MoveRepeatDelay                       { get; set; }
        public float                                    M_MoveRepeatRate                        { get; set; }
        public float                                    M_TrackedDeviceDragThresholdMultiplier  { get; set; }
        public Transform?                               M_XRTrackingOrigin                      { get; set; }
        public InputActionAsset?                        M_ActionsAsset                          { get; set; }
        public InputActionReference?                    M_PointAction                           { get; set; }
        public InputActionReference?                    M_MoveAction                            { get; set; }
        public InputActionReference?                    M_SubmitAction                          { get; set; }
        public InputActionReference?                    M_CancelAction                          { get; set; }
        public InputActionReference?                    M_LeftClickAction                       { get; set; }
        public InputActionReference?                    M_MiddleClickAction                     { get; set; }
        public InputActionReference?                    M_RightClickAction                      { get; set; }
        public InputActionReference?                    M_ScrollWheelAction                     { get; set; }
        public InputActionReference?                    M_TrackedDevicePositionAction           { get; set; }
        public InputActionReference?                    M_TrackedDeviceOrientationAction        { get; set; }
        public bool                                     M_DeselectOnBackgroundClick             { get; set; }
        public UIPointerBehavior                        M_PointerBehavior                       { get; set; }
        public CursorLockBehavior                       M_CursorLockBehavior                    { get; set; }
        public bool                                     M_ActionsHooked                         { get; set; }
        public bool                                     M_NeedToPurgeStalePointers              { get; set; }
        public int                                      M_CurrentPointerId                      { get; set; }
        public int                                      M_CurrentPointerIndex                   { get; set; }
        public UIPointerType                            M_CurrentPointerType                    { get; set; }
        public NavigationModel                          M_NavigationState                       { get; set; }
        public GameObject?                              M_LocalMultiPlayerRoot                  { get; set; }

        public static InputSystemUIInputModule? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputSystemUIInputModule() { Pointer= p0 };

            value.M_MoveRepeatDelay                         = GetSingle(new IntPtr(p + 0x058)); // 0x58 M_MoveRepeatDelay           ( ModelPrimitiveType float float float Single )
            value.M_MoveRepeatRate                          = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_MoveRepeatRate            ( ModelPrimitiveType float float float Single )
            value.M_TrackedDeviceDragThresholdMultiplier    = GetSingle(new IntPtr(p + 0x060)); // 0x60 M_TrackedDeviceDragThresholdMultiplier ( ModelPrimitiveType float float float Single )
            value.M_XRTrackingOrigin                        = GetObject<Transform>(new IntPtr(p + 0x068), ReversePrism.DataModels.Transform.FromPointer); // 0x68 M_XRTrackingOrigin          ( ModelClassType Transform Transform Transform Pointer )
            value.M_ActionsAsset                            = GetObject<InputActionAsset>(new IntPtr(p + 0x070), ReversePrism.DataModels.InputActionAsset.FromPointer); // 0x70 M_ActionsAsset              ( ModelClassType InputActionAsset InputActionAsset InputActionAsset Pointer )
            value.M_PointAction                             = GetObject<InputActionReference>(new IntPtr(p + 0x078), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x78 M_PointAction               ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_MoveAction                              = GetObject<InputActionReference>(new IntPtr(p + 0x080), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x80 M_MoveAction                ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_SubmitAction                            = GetObject<InputActionReference>(new IntPtr(p + 0x088), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x88 M_SubmitAction              ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_CancelAction                            = GetObject<InputActionReference>(new IntPtr(p + 0x090), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x90 M_CancelAction              ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_LeftClickAction                         = GetObject<InputActionReference>(new IntPtr(p + 0x098), ReversePrism.DataModels.InputActionReference.FromPointer); // 0x98 M_LeftClickAction           ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_MiddleClickAction                       = GetObject<InputActionReference>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.InputActionReference.FromPointer); // 0xA0 M_MiddleClickAction         ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_RightClickAction                        = GetObject<InputActionReference>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.InputActionReference.FromPointer); // 0xA8 M_RightClickAction          ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_ScrollWheelAction                       = GetObject<InputActionReference>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.InputActionReference.FromPointer); // 0xB0 M_ScrollWheelAction         ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_TrackedDevicePositionAction             = GetObject<InputActionReference>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.InputActionReference.FromPointer); // 0xB8 M_TrackedDevicePositionAction ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_TrackedDeviceOrientationAction          = GetObject<InputActionReference>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.InputActionReference.FromPointer); // 0xC0 M_TrackedDeviceOrientationAction ( ModelClassType InputActionReference InputActionReference InputActionReference Pointer )
            value.M_DeselectOnBackgroundClick               = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 M_DeselectOnBackgroundClick ( ModelPrimitiveType bool bool bool Bool )
            value.M_PointerBehavior                         = (UIPointerBehavior)GetInt32(new IntPtr(p + 0x0CC)); // 0xCC M_PointerBehavior           ( ModelEnumType UIPointerBehavior UIPointerBehavior UIPointerBehavior Int32 )
            value.M_CursorLockBehavior                      = (CursorLockBehavior)GetInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_CursorLockBehavior        ( ModelEnumType CursorLockBehavior CursorLockBehavior CursorLockBehavior Int32 )
            value.M_ActionsHooked                           = GetBool(new IntPtr(p + 0x0D4)); // 0xD4 M_ActionsHooked             ( ModelPrimitiveType bool bool bool Bool )
            value.M_NeedToPurgeStalePointers                = GetBool(new IntPtr(p + 0x0D5)); // 0xD5 M_NeedToPurgeStalePointers  ( ModelPrimitiveType bool bool bool Bool )
            value.M_CurrentPointerId                        = GetInt32(new IntPtr(p + 0x120)); // 0x120 M_CurrentPointerId          ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentPointerIndex                     = GetInt32(new IntPtr(p + 0x124)); // 0x124 M_CurrentPointerIndex       ( ModelPrimitiveType int int int Int32 )
            value.M_CurrentPointerType                      = (UIPointerType)GetInt32(new IntPtr(p + 0x128)); // 0x128 M_CurrentPointerType        ( ModelEnumType UIPointerType UIPointerType UIPointerType Int32 )
            value.M_NavigationState                         = (NavigationModel)GetInt32(new IntPtr(p + 0x388)); // 0x388 M_NavigationState           ( ModelEnumType NavigationModel NavigationModel NavigationModel Int32 )
            value.M_LocalMultiPlayerRoot                    = GetObject<GameObject>(new IntPtr(p + 0x3A8), ReversePrism.DataModels.GameObject.FromPointer); // 0x3A8 M_LocalMultiPlayerRoot      ( ModelClassType GameObject GameObject GameObject Pointer )

            return value;
        }
    }
}
