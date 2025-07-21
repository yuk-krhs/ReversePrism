using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 PlayerJoinedMessage                      string IL2CPP_TYPE_STRING
    // 000 PlayerLeftMessage                        string IL2CPP_TYPE_STRING
    // 000 <instance>k__BackingField                PlayerInputManager IL2CPP_TYPE_CLASS
    // 020 M_NotificationBehavior                   ModelEnumType PlayerNotifications PlayerNotifications PlayerNotifications Int32
    // 024 M_MaxPlayerCount                         ModelPrimitiveType int int int Int32
    // 028 M_AllowJoining                           ModelPrimitiveType bool bool bool Bool
    // 02C M_JoinBehavior                           ModelEnumType PlayerJoinBehavior PlayerJoinBehavior PlayerJoinBehavior Int32
    // 030 M_PlayerJoinedEvent                      ModelClassType PlayerJoinedEvent PlayerJoinedEvent PlayerJoinedEvent Pointer
    // 038 M_PlayerLeftEvent                        ModelClassType PlayerLeftEvent PlayerLeftEvent PlayerLeftEvent Pointer
    // 040 M_JoinAction                             ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32
    // 058 M_PlayerPrefab                           ModelClassType GameObject GameObject GameObject Pointer
    // 060 M_SplitScreen                            ModelPrimitiveType bool bool bool Bool
    // 061 M_MaintainAspectRatioInSplitScreen       ModelPrimitiveType bool bool bool Bool
    // 064 M_FixedNumberOfSplitScreens              ModelPrimitiveType int int int Int32
    // 068 M_SplitScreenRect                        ModelEnumType Rect Rect Rect Int32
    // 078 M_JoinActionDelegateHooked               ModelPrimitiveType bool bool bool Bool
    // 079 M_UnpairedDeviceUsedDelegateHooked       ModelPrimitiveType bool bool bool Bool
    // 080 m_JoinActionDelegate                     Action`1<CallbackContext> IL2CPP_TYPE_GENERICINST
    // 088 m_UnpairedDeviceUsedDelegate             Action`2<InputControl, InputEventPtr> IL2CPP_TYPE_GENERICINST
    // 090 m_PlayerJoinedCallbacks                  CallbackArray`1<Action`1<PlayerInput>> IL2CPP_TYPE_GENERICINST
    // 0E0 m_PlayerLeftCallbacks                    CallbackArray`1<Action`1<PlayerInput>> IL2CPP_TYPE_GENERICINST
    public partial class PlayerInputManager : DataModel
    {
        public PlayerNotifications                      M_NotificationBehavior                  { get; set; }
        public int                                      M_MaxPlayerCount                        { get; set; }
        public bool                                     M_AllowJoining                          { get; set; }
        public PlayerJoinBehavior                       M_JoinBehavior                          { get; set; }
        public PlayerJoinedEvent?                       M_PlayerJoinedEvent                     { get; set; }
        public PlayerLeftEvent?                         M_PlayerLeftEvent                       { get; set; }
        public InputActionProperty                      M_JoinAction                            { get; set; }
        public GameObject?                              M_PlayerPrefab                          { get; set; }
        public bool                                     M_SplitScreen                           { get; set; }
        public bool                                     M_MaintainAspectRatioInSplitScreen      { get; set; }
        public int                                      M_FixedNumberOfSplitScreens             { get; set; }
        public Rect                                     M_SplitScreenRect                       { get; set; }
        public bool                                     M_JoinActionDelegateHooked              { get; set; }
        public bool                                     M_UnpairedDeviceUsedDelegateHooked      { get; set; }

        public static PlayerInputManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PlayerInputManager() { Pointer= p0 };

            value.M_NotificationBehavior                    = (PlayerNotifications)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_NotificationBehavior      ( ModelEnumType PlayerNotifications PlayerNotifications PlayerNotifications Int32 )
            value.M_MaxPlayerCount                          = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_MaxPlayerCount            ( ModelPrimitiveType int int int Int32 )
            value.M_AllowJoining                            = GetBool(new IntPtr(p + 0x028)); // 0x28 M_AllowJoining              ( ModelPrimitiveType bool bool bool Bool )
            value.M_JoinBehavior                            = (PlayerJoinBehavior)GetInt32(new IntPtr(p + 0x02C)); // 0x2C M_JoinBehavior              ( ModelEnumType PlayerJoinBehavior PlayerJoinBehavior PlayerJoinBehavior Int32 )
            value.M_PlayerJoinedEvent                       = GetObject<PlayerJoinedEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.PlayerJoinedEvent.FromPointer); // 0x30 M_PlayerJoinedEvent         ( ModelClassType PlayerJoinedEvent PlayerJoinedEvent PlayerJoinedEvent Pointer )
            value.M_PlayerLeftEvent                         = GetObject<PlayerLeftEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.PlayerLeftEvent.FromPointer); // 0x38 M_PlayerLeftEvent           ( ModelClassType PlayerLeftEvent PlayerLeftEvent PlayerLeftEvent Pointer )
            value.M_JoinAction                              = (InputActionProperty)GetInt32(new IntPtr(p + 0x040)); // 0x40 M_JoinAction                ( ModelEnumType InputActionProperty InputActionProperty InputActionProperty Int32 )
            value.M_PlayerPrefab                            = GetObject<GameObject>(new IntPtr(p + 0x058), ReversePrism.DataModels.GameObject.FromPointer); // 0x58 M_PlayerPrefab              ( ModelClassType GameObject GameObject GameObject Pointer )
            value.M_SplitScreen                             = GetBool(new IntPtr(p + 0x060)); // 0x60 M_SplitScreen               ( ModelPrimitiveType bool bool bool Bool )
            value.M_MaintainAspectRatioInSplitScreen        = GetBool(new IntPtr(p + 0x061)); // 0x61 M_MaintainAspectRatioInSplitScreen ( ModelPrimitiveType bool bool bool Bool )
            value.M_FixedNumberOfSplitScreens               = GetInt32(new IntPtr(p + 0x064)); // 0x64 M_FixedNumberOfSplitScreens ( ModelPrimitiveType int int int Int32 )
            value.M_SplitScreenRect                         = (Rect)GetInt32(new IntPtr(p + 0x068)); // 0x68 M_SplitScreenRect           ( ModelEnumType Rect Rect Rect Int32 )
            value.M_JoinActionDelegateHooked                = GetBool(new IntPtr(p + 0x078)); // 0x78 M_JoinActionDelegateHooked  ( ModelPrimitiveType bool bool bool Bool )
            value.M_UnpairedDeviceUsedDelegateHooked        = GetBool(new IntPtr(p + 0x079)); // 0x79 M_UnpairedDeviceUsedDelegateHooked ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
