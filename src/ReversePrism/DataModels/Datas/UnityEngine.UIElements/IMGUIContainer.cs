using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 3C8 M_OnGUIHandler                           ModelClassType Action Action Action Pointer
    // 3D0 M_ObjectGUIState                         ModelClassType ObjectGUIState ObjectGUIState ObjectGUIState Pointer
    // 3D8 UseOwnerObjectGUIState                   ModelPrimitiveType bool bool bool Bool
    // 3DC LastWorldClip                            ModelEnumType Rect Rect Rect Int32
    // 3EC M_CullingEnabled                         ModelPrimitiveType bool bool bool Bool
    // 3ED M_IsFocusDelegated                       ModelPrimitiveType bool bool bool Bool
    // 3EE M_RefreshCachedLayout                    ModelPrimitiveType bool bool bool Bool
    // 3F0 M_Cache                                  ModelClassType LayoutCache LayoutCache LayoutCache Pointer
    // 3F8 M_CachedClippingRect                     ModelEnumType Rect Rect Rect Int32
    // 408 M_CachedTransform                        ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32
    // 448 ContextType                              ModelEnumType ContextType ContextType ContextType Int32
    // 44C LostFocus                                ModelPrimitiveType bool bool bool Bool
    // 44D ReceivedFocus                            ModelPrimitiveType bool bool bool Bool
    // 450 FocusChangeDirection                     ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer
    // 458 HasFocusableControls                     ModelPrimitiveType bool bool bool Bool
    // 45C NewKeyboardFocusControlID                ModelPrimitiveType int int int Int32
    // 460 FocusOnlyIfHasFocusableControls          ModelPrimitiveType bool bool bool Bool
    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 ussFoldoutChildDepthClassName            string IL2CPP_TYPE_STRING
    // 010 UssFoldoutChildDepthClassNames           ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 464 M_GUIGlobals                             ModelEnumType GUIGlobals GUIGlobals GUIGlobals Int32
    // 018 K_OnGUIMarker                            ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 020 K_ImmediateCallbackMarker                ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 028 S_DefaultMeasureEvent                    ModelClassType Event Event Event Pointer
    // 030 S_MeasureEvent                           ModelClassType Event Event Event Pointer
    // 038 S_CurrentEvent                           ModelClassType Event Event Event Pointer
    public partial class IMGUIContainer : DataModel
    {
        public Action?                                  M_OnGUIHandler                          { get; set; }
        public ObjectGUIState?                          M_ObjectGUIState                        { get; set; }
        public bool                                     UseOwnerObjectGUIState                  { get; set; }
        public Rect                                     LastWorldClip                           { get; set; }
        public bool                                     M_CullingEnabled                        { get; set; }
        public bool                                     M_IsFocusDelegated                      { get; set; }
        public bool                                     M_RefreshCachedLayout                   { get; set; }
        public LayoutCache?                             M_Cache                                 { get; set; }
        public Rect                                     M_CachedClippingRect                    { get; set; }
        public Matrix4x4                                M_CachedTransform                       { get; set; }
        public ContextType                              ContextType                             { get; set; }
        public bool                                     LostFocus                               { get; set; }
        public bool                                     ReceivedFocus                           { get; set; }
        public FocusChangeDirection?                    FocusChangeDirection                    { get; set; }
        public bool                                     HasFocusableControls                    { get; set; }
        public int                                      NewKeyboardFocusControlID               { get; set; }
        public bool                                     FocusOnlyIfHasFocusableControls         { get; set; }
        public List<string>?                            UssFoldoutChildDepthClassNames          { get; set; }
        public GUIGlobals                               M_GUIGlobals                            { get; set; }
        public ProfilerMarker                           K_OnGUIMarker                           { get; set; }
        public ProfilerMarker                           K_ImmediateCallbackMarker               { get; set; }
        public Event?                                   S_DefaultMeasureEvent                   { get; set; }
        public Event?                                   S_MeasureEvent                          { get; set; }
        public Event?                                   S_CurrentEvent                          { get; set; }

        public static IMGUIContainer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new IMGUIContainer() { Pointer= p0 };

            value.M_OnGUIHandler                            = GetObject<Action>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.Action.FromPointer); // 0x3C8 M_OnGUIHandler              ( ModelClassType Action Action Action Pointer )
            value.M_ObjectGUIState                          = GetObject<ObjectGUIState>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.ObjectGUIState.FromPointer); // 0x3D0 M_ObjectGUIState            ( ModelClassType ObjectGUIState ObjectGUIState ObjectGUIState Pointer )
            value.UseOwnerObjectGUIState                    = GetBool(new IntPtr(p + 0x3D8)); // 0x3D8 UseOwnerObjectGUIState      ( ModelPrimitiveType bool bool bool Bool )
            value.LastWorldClip                             = (Rect)GetInt32(new IntPtr(p + 0x3DC)); // 0x3DC LastWorldClip               ( ModelEnumType Rect Rect Rect Int32 )
            value.M_CullingEnabled                          = GetBool(new IntPtr(p + 0x3EC)); // 0x3EC M_CullingEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.M_IsFocusDelegated                        = GetBool(new IntPtr(p + 0x3ED)); // 0x3ED M_IsFocusDelegated          ( ModelPrimitiveType bool bool bool Bool )
            value.M_RefreshCachedLayout                     = GetBool(new IntPtr(p + 0x3EE)); // 0x3EE M_RefreshCachedLayout       ( ModelPrimitiveType bool bool bool Bool )
            value.M_Cache                                   = GetObject<LayoutCache>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.LayoutCache.FromPointer); // 0x3F0 M_Cache                     ( ModelClassType LayoutCache LayoutCache LayoutCache Pointer )
            value.M_CachedClippingRect                      = (Rect)GetInt32(new IntPtr(p + 0x3F8)); // 0x3F8 M_CachedClippingRect        ( ModelEnumType Rect Rect Rect Int32 )
            value.M_CachedTransform                         = (Matrix4x4)GetInt32(new IntPtr(p + 0x408)); // 0x408 M_CachedTransform           ( ModelEnumType Matrix4x4 Matrix4x4 Matrix4x4 Int32 )
            value.ContextType                               = (ContextType)GetInt32(new IntPtr(p + 0x448)); // 0x448 ContextType                 ( ModelEnumType ContextType ContextType ContextType Int32 )
            value.LostFocus                                 = GetBool(new IntPtr(p + 0x44C)); // 0x44C LostFocus                   ( ModelPrimitiveType bool bool bool Bool )
            value.ReceivedFocus                             = GetBool(new IntPtr(p + 0x44D)); // 0x44D ReceivedFocus               ( ModelPrimitiveType bool bool bool Bool )
            value.FocusChangeDirection                      = GetObject<FocusChangeDirection>(new IntPtr(p + 0x450), ReversePrism.DataModels.FocusChangeDirection.FromPointer); // 0x450 FocusChangeDirection        ( ModelClassType FocusChangeDirection FocusChangeDirection FocusChangeDirection Pointer )
            value.HasFocusableControls                      = GetBool(new IntPtr(p + 0x458)); // 0x458 HasFocusableControls        ( ModelPrimitiveType bool bool bool Bool )
            value.NewKeyboardFocusControlID                 = GetInt32(new IntPtr(p + 0x45C)); // 0x45C NewKeyboardFocusControlID   ( ModelPrimitiveType int int int Int32 )
            value.FocusOnlyIfHasFocusableControls           = GetBool(new IntPtr(p + 0x460)); // 0x460 FocusOnlyIfHasFocusableControls ( ModelPrimitiveType bool bool bool Bool )
            value.UssFoldoutChildDepthClassNames            = GetStringList(new IntPtr(p + 0x010)); // 0x10 UssFoldoutChildDepthClassNames ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.M_GUIGlobals                              = (GUIGlobals)GetInt32(new IntPtr(p + 0x464)); // 0x464 M_GUIGlobals                ( ModelEnumType GUIGlobals GUIGlobals GUIGlobals Int32 )
            value.K_OnGUIMarker                             = (ProfilerMarker)GetInt32(new IntPtr(p + 0x018)); // 0x18 K_OnGUIMarker               ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.K_ImmediateCallbackMarker                 = (ProfilerMarker)GetInt32(new IntPtr(p + 0x020)); // 0x20 K_ImmediateCallbackMarker   ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.S_DefaultMeasureEvent                     = GetObject<Event>(new IntPtr(p + 0x028), ReversePrism.DataModels.Event.FromPointer); // 0x28 S_DefaultMeasureEvent       ( ModelClassType Event Event Event Pointer )
            value.S_MeasureEvent                            = GetObject<Event>(new IntPtr(p + 0x030), ReversePrism.DataModels.Event.FromPointer); // 0x30 S_MeasureEvent              ( ModelClassType Event Event Event Pointer )
            value.S_CurrentEvent                            = GetObject<Event>(new IntPtr(p + 0x038), ReversePrism.DataModels.Event.FromPointer); // 0x38 S_CurrentEvent              ( ModelClassType Event Event Event Pointer )

            return value;
        }
    }
}
