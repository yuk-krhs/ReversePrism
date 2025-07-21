using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 panelDisposed                            Action`1<BaseVisualElementPanel> IL2CPP_TYPE_GENERICINST
    // 018 M_UIElementsBridge                       ModelClassType UIElementsBridge UIElementsBridge UIElementsBridge Pointer
    // 020 M_Scale                                  ModelPrimitiveType float float float Single
    // 028 YogaConfig                               ModelClassType YogaConfig YogaConfig YogaConfig Pointer
    // 030 M_PixelsPerPoint                         ModelPrimitiveType float float float Single
    // 034 ReferenceSpritePixelsPerUnit             ModelPrimitiveType float float float Single
    // 038 ClearSettings                            ModelEnumType PanelClearSettings PanelClearSettings PanelClearSettings Int32
    // 04C DuringLayoutPhase                        ModelPrimitiveType bool bool bool Bool
    // 050 RepaintData                              ModelClassType RepaintData RepaintData RepaintData Pointer
    // 058 CursorManager                            ModelClassType ICursorManager ICursorManager ICursorManager Pointer
    // 060 ContextualMenuManager                    ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer
    // 068 Disposed                                 ModelPrimitiveType bool bool bool Bool
    // 070 M_TopElementUnderPointers                ModelClassType ElementUnderPointer ElementUnderPointer ElementUnderPointer Pointer
    // 078 StandardShaderChanged                    ModelClassType Action Action Action Pointer
    // 080 StandardWorldSpaceShaderChanged          ModelClassType Action Action Action Pointer
    // 088 AtlasChanged                             ModelClassType Action Action Action Pointer
    // 090 updateMaterial                           Action`1<Material> IL2CPP_TYPE_GENERICINST
    // 098 HierarchyChanged                         ModelClassType HierarchyEvent HierarchyEvent HierarchyEvent Pointer
    // 0A0 beforeUpdate                             Action`1<IPanel> IL2CPP_TYPE_GENERICINST
    public partial class BaseVisualElementPanel : DataModel
    {
        public UIElementsBridge?                        M_UIElementsBridge                      { get; set; }
        public float                                    M_Scale                                 { get; set; }
        public YogaConfig?                              YogaConfig                              { get; set; }
        public float                                    M_PixelsPerPoint                        { get; set; }
        public float                                    ReferenceSpritePixelsPerUnit            { get; set; }
        public PanelClearSettings                       ClearSettings                           { get; set; }
        public bool                                     DuringLayoutPhase                       { get; set; }
        public RepaintData?                             RepaintData                             { get; set; }
        public ICursorManager?                          CursorManager                           { get; set; }
        public ContextualMenuManager?                   ContextualMenuManager                   { get; set; }
        public bool                                     Disposed                                { get; set; }
        public ElementUnderPointer?                     M_TopElementUnderPointers               { get; set; }
        public Action?                                  StandardShaderChanged                   { get; set; }
        public Action?                                  StandardWorldSpaceShaderChanged         { get; set; }
        public Action?                                  AtlasChanged                            { get; set; }
        public HierarchyEvent?                          HierarchyChanged                        { get; set; }

        public static BaseVisualElementPanel? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BaseVisualElementPanel() { Pointer= p0 };

            value.M_UIElementsBridge                        = GetObject<UIElementsBridge>(new IntPtr(p + 0x018), ReversePrism.DataModels.UIElementsBridge.FromPointer); // 0x18 M_UIElementsBridge          ( ModelClassType UIElementsBridge UIElementsBridge UIElementsBridge Pointer )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x020)); // 0x20 M_Scale                     ( ModelPrimitiveType float float float Single )
            value.YogaConfig                                = GetObject<YogaConfig>(new IntPtr(p + 0x028), ReversePrism.DataModels.YogaConfig.FromPointer); // 0x28 YogaConfig                  ( ModelClassType YogaConfig YogaConfig YogaConfig Pointer )
            value.M_PixelsPerPoint                          = GetSingle(new IntPtr(p + 0x030)); // 0x30 M_PixelsPerPoint            ( ModelPrimitiveType float float float Single )
            value.ReferenceSpritePixelsPerUnit              = GetSingle(new IntPtr(p + 0x034)); // 0x34 ReferenceSpritePixelsPerUnit ( ModelPrimitiveType float float float Single )
            value.ClearSettings                             = (PanelClearSettings)GetInt32(new IntPtr(p + 0x038)); // 0x38 ClearSettings               ( ModelEnumType PanelClearSettings PanelClearSettings PanelClearSettings Int32 )
            value.DuringLayoutPhase                         = GetBool(new IntPtr(p + 0x04C)); // 0x4C DuringLayoutPhase           ( ModelPrimitiveType bool bool bool Bool )
            value.RepaintData                               = GetObject<RepaintData>(new IntPtr(p + 0x050), ReversePrism.DataModels.RepaintData.FromPointer); // 0x50 RepaintData                 ( ModelClassType RepaintData RepaintData RepaintData Pointer )
            value.CursorManager                             = GetObject<ICursorManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.ICursorManager.FromPointer); // 0x58 CursorManager               ( ModelClassType ICursorManager ICursorManager ICursorManager Pointer )
            value.ContextualMenuManager                     = GetObject<ContextualMenuManager>(new IntPtr(p + 0x060), ReversePrism.DataModels.ContextualMenuManager.FromPointer); // 0x60 ContextualMenuManager       ( ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x068)); // 0x68 Disposed                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_TopElementUnderPointers                 = GetObject<ElementUnderPointer>(new IntPtr(p + 0x070), ReversePrism.DataModels.ElementUnderPointer.FromPointer); // 0x70 M_TopElementUnderPointers   ( ModelClassType ElementUnderPointer ElementUnderPointer ElementUnderPointer Pointer )
            value.StandardShaderChanged                     = GetObject<Action>(new IntPtr(p + 0x078), ReversePrism.DataModels.Action.FromPointer); // 0x78 StandardShaderChanged       ( ModelClassType Action Action Action Pointer )
            value.StandardWorldSpaceShaderChanged           = GetObject<Action>(new IntPtr(p + 0x080), ReversePrism.DataModels.Action.FromPointer); // 0x80 StandardWorldSpaceShaderChanged ( ModelClassType Action Action Action Pointer )
            value.AtlasChanged                              = GetObject<Action>(new IntPtr(p + 0x088), ReversePrism.DataModels.Action.FromPointer); // 0x88 AtlasChanged                ( ModelClassType Action Action Action Pointer )
            value.HierarchyChanged                          = GetObject<HierarchyEvent>(new IntPtr(p + 0x098), ReversePrism.DataModels.HierarchyEvent.FromPointer); // 0x98 HierarchyChanged            ( ModelClassType HierarchyEvent HierarchyEvent HierarchyEvent Pointer )

            return value;
        }
    }
}
