using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0A8 M_RootContainer                          ModelClassType VisualElement VisualElement VisualElement Pointer
    // 0B0 M_VisualTreeUpdater                      ModelClassType VisualTreeUpdater VisualTreeUpdater VisualTreeUpdater Pointer
    // 0B8 M_StylePropertyAnimationSystem           ModelClassType IStylePropertyAnimationSystem IStylePropertyAnimationSystem IStylePropertyAnimationSystem Pointer
    // 0C0 M_PanelName                              ModelPrimitiveType string string string String
    // 0C8 M_Version                                ModelPrimitiveType uint uint uint UInt32
    // 0CC M_RepaintVersion                         ModelPrimitiveType uint uint uint UInt32
    // 0D0 M_HierarchyVersion                       ModelPrimitiveType uint uint uint UInt32
    // 0D8 M_MarkerBeforeUpdate                     ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 0E0 M_MarkerUpdate                           ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 0E8 M_MarkerLayout                           ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 0F0 M_MarkerBindings                         ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 0F8 M_MarkerAnimations                       ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32
    // 000 s_MarkerPickAll                          ProfilerMarker IL2CPP_TYPE_VALUETYPE
    // 100 Dispatcher                               ModelClassType EventDispatcher EventDispatcher EventDispatcher Pointer
    // 108 M_Scheduler                              ModelClassType TimerEventScheduler TimerEventScheduler TimerEventScheduler Pointer
    // 110 OwnerObject                              ModelClassType ScriptableObject ScriptableObject ScriptableObject Pointer
    // 118 ContextType                              ModelEnumType ContextType ContextType ContextType Int32
    // 120 SaveViewData                             ModelClassType SavePersistentViewData SavePersistentViewData SavePersistentViewData Pointer
    // 128 GetViewDataDictionary                    ModelClassType GetViewDataDictionary GetViewDataDictionary GetViewDataDictionary Pointer
    // 130 FocusController                          ModelClassType FocusController FocusController FocusController Pointer
    // 138 IMGUIEventInterests                      ModelEnumType EventInterests EventInterests EventInterests Int32
    // 008 <loadResourceFunc>k__BackingField        LoadResourceFunction IL2CPP_TYPE_CLASS
    // 13B M_JustReceivedFocus                      ModelPrimitiveType bool bool bool Bool
    // 010 TimeSinceStartup                         ModelClassType TimeMsFunction TimeMsFunction TimeMsFunction Pointer
    // 13C IMGUIContainersCount                     ModelPrimitiveType int int int Int32
    // 140 RootIMGUIContainer                       ModelClassType IMGUIContainer IMGUIContainer IMGUIContainer Pointer
    // 148 M_StandardShader                         ModelClassType Shader Shader Shader Pointer
    // 150 M_Atlas                                  ModelClassType AtlasBase AtlasBase AtlasBase Pointer
    // 158 M_ValidatingLayout                       ModelPrimitiveType bool bool bool Bool
    // 018 beforeAnyRepaint                         Action`1<Panel> IL2CPP_TYPE_GENERICINST
    public partial class Panel : DataModel
    {
        public VisualElement?                           M_RootContainer                         { get; set; }
        public VisualTreeUpdater?                       M_VisualTreeUpdater                     { get; set; }
        public IStylePropertyAnimationSystem?           M_StylePropertyAnimationSystem          { get; set; }
        public string                                   M_PanelName                             { get; set; }
        public uint                                     M_Version                               { get; set; }
        public uint                                     M_RepaintVersion                        { get; set; }
        public uint                                     M_HierarchyVersion                      { get; set; }
        public ProfilerMarker                           M_MarkerBeforeUpdate                    { get; set; }
        public ProfilerMarker                           M_MarkerUpdate                          { get; set; }
        public ProfilerMarker                           M_MarkerLayout                          { get; set; }
        public ProfilerMarker                           M_MarkerBindings                        { get; set; }
        public ProfilerMarker                           M_MarkerAnimations                      { get; set; }
        public EventDispatcher?                         Dispatcher                              { get; set; }
        public TimerEventScheduler?                     M_Scheduler                             { get; set; }
        public ScriptableObject?                        OwnerObject                             { get; set; }
        public ContextType                              ContextType                             { get; set; }
        public SavePersistentViewData?                  SaveViewData                            { get; set; }
        public GetViewDataDictionary?                   GetViewDataDictionary                   { get; set; }
        public FocusController?                         FocusController                         { get; set; }
        public EventInterests                           IMGUIEventInterests                     { get; set; }
        public bool                                     M_JustReceivedFocus                     { get; set; }
        public TimeMsFunction?                          TimeSinceStartup                        { get; set; }
        public int                                      IMGUIContainersCount                    { get; set; }
        public IMGUIContainer?                          RootIMGUIContainer                      { get; set; }
        public Shader?                                  M_StandardShader                        { get; set; }
        public AtlasBase?                               M_Atlas                                 { get; set; }
        public bool                                     M_ValidatingLayout                      { get; set; }

        public static Panel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Panel() { Pointer= p0 };

            value.M_RootContainer                           = GetObject<VisualElement>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.VisualElement.FromPointer); // 0xA8 M_RootContainer             ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_VisualTreeUpdater                       = GetObject<VisualTreeUpdater>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.VisualTreeUpdater.FromPointer); // 0xB0 M_VisualTreeUpdater         ( ModelClassType VisualTreeUpdater VisualTreeUpdater VisualTreeUpdater Pointer )
            value.M_StylePropertyAnimationSystem            = GetObject<IStylePropertyAnimationSystem>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.IStylePropertyAnimationSystem.FromPointer); // 0xB8 M_StylePropertyAnimationSystem ( ModelClassType IStylePropertyAnimationSystem IStylePropertyAnimationSystem IStylePropertyAnimationSystem Pointer )
            value.M_PanelName                               = GetString(new IntPtr(p + 0x0C0)); // 0xC0 M_PanelName                 ( ModelPrimitiveType string string string String )
            value.M_Version                                 = GetUInt32(new IntPtr(p + 0x0C8)); // 0xC8 M_Version                   ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_RepaintVersion                          = GetUInt32(new IntPtr(p + 0x0CC)); // 0xCC M_RepaintVersion            ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_HierarchyVersion                        = GetUInt32(new IntPtr(p + 0x0D0)); // 0xD0 M_HierarchyVersion          ( ModelPrimitiveType uint uint uint UInt32 )
            value.M_MarkerBeforeUpdate                      = (ProfilerMarker)GetInt32(new IntPtr(p + 0x0D8)); // 0xD8 M_MarkerBeforeUpdate        ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.M_MarkerUpdate                            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x0E0)); // 0xE0 M_MarkerUpdate              ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.M_MarkerLayout                            = (ProfilerMarker)GetInt32(new IntPtr(p + 0x0E8)); // 0xE8 M_MarkerLayout              ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.M_MarkerBindings                          = (ProfilerMarker)GetInt32(new IntPtr(p + 0x0F0)); // 0xF0 M_MarkerBindings            ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.M_MarkerAnimations                        = (ProfilerMarker)GetInt32(new IntPtr(p + 0x0F8)); // 0xF8 M_MarkerAnimations          ( ModelEnumType ProfilerMarker ProfilerMarker ProfilerMarker Int32 )
            value.Dispatcher                                = GetObject<EventDispatcher>(new IntPtr(p + 0x100), ReversePrism.DataModels.EventDispatcher.FromPointer); // 0x100 Dispatcher                  ( ModelClassType EventDispatcher EventDispatcher EventDispatcher Pointer )
            value.M_Scheduler                               = GetObject<TimerEventScheduler>(new IntPtr(p + 0x108), ReversePrism.DataModels.TimerEventScheduler.FromPointer); // 0x108 M_Scheduler                 ( ModelClassType TimerEventScheduler TimerEventScheduler TimerEventScheduler Pointer )
            value.OwnerObject                               = GetObject<ScriptableObject>(new IntPtr(p + 0x110), ReversePrism.DataModels.ScriptableObject.FromPointer); // 0x110 OwnerObject                 ( ModelClassType ScriptableObject ScriptableObject ScriptableObject Pointer )
            value.ContextType                               = (ContextType)GetInt32(new IntPtr(p + 0x118)); // 0x118 ContextType                 ( ModelEnumType ContextType ContextType ContextType Int32 )
            value.SaveViewData                              = GetObject<SavePersistentViewData>(new IntPtr(p + 0x120), ReversePrism.DataModels.SavePersistentViewData.FromPointer); // 0x120 SaveViewData                ( ModelClassType SavePersistentViewData SavePersistentViewData SavePersistentViewData Pointer )
            value.GetViewDataDictionary                     = GetObject<GetViewDataDictionary>(new IntPtr(p + 0x128), ReversePrism.DataModels.GetViewDataDictionary.FromPointer); // 0x128 GetViewDataDictionary       ( ModelClassType GetViewDataDictionary GetViewDataDictionary GetViewDataDictionary Pointer )
            value.FocusController                           = GetObject<FocusController>(new IntPtr(p + 0x130), ReversePrism.DataModels.FocusController.FromPointer); // 0x130 FocusController             ( ModelClassType FocusController FocusController FocusController Pointer )
            value.IMGUIEventInterests                       = (EventInterests)GetInt32(new IntPtr(p + 0x138)); // 0x138 IMGUIEventInterests         ( ModelEnumType EventInterests EventInterests EventInterests Int32 )
            value.M_JustReceivedFocus                       = GetBool(new IntPtr(p + 0x13B)); // 0x13B M_JustReceivedFocus         ( ModelPrimitiveType bool bool bool Bool )
            value.TimeSinceStartup                          = GetObject<TimeMsFunction>(new IntPtr(p + 0x010), ReversePrism.DataModels.TimeMsFunction.FromPointer); // 0x10 TimeSinceStartup            ( ModelClassType TimeMsFunction TimeMsFunction TimeMsFunction Pointer )
            value.IMGUIContainersCount                      = GetInt32(new IntPtr(p + 0x13C)); // 0x13C IMGUIContainersCount        ( ModelPrimitiveType int int int Int32 )
            value.RootIMGUIContainer                        = GetObject<IMGUIContainer>(new IntPtr(p + 0x140), ReversePrism.DataModels.IMGUIContainer.FromPointer); // 0x140 RootIMGUIContainer          ( ModelClassType IMGUIContainer IMGUIContainer IMGUIContainer Pointer )
            value.M_StandardShader                          = GetObject<Shader>(new IntPtr(p + 0x148), ReversePrism.DataModels.Shader.FromPointer); // 0x148 M_StandardShader            ( ModelClassType Shader Shader Shader Pointer )
            value.M_Atlas                                   = GetObject<AtlasBase>(new IntPtr(p + 0x150), ReversePrism.DataModels.AtlasBase.FromPointer); // 0x150 M_Atlas                     ( ModelClassType AtlasBase AtlasBase AtlasBase Pointer )
            value.M_ValidatingLayout                        = GetBool(new IntPtr(p + 0x158)); // 0x158 M_ValidatingLayout          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
