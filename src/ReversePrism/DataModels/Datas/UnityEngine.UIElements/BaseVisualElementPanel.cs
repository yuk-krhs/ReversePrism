using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 panelDisposed                            Action`1<BaseVisualElementPanel> IL2CPP_TYPE_GENERICINST
    // 018 M_UIElementsBridge                       0001866E5BD0 ModelClassType UIElementsBridge UIElementsBridge UIElementsBridge Pointer
    // 020 M_Scale                                  0001866656B0 ModelPrimitiveType float float float Single
    // 028 YogaConfig                               0001865DB010 ModelClassType YogaConfig YogaConfig YogaConfig Pointer
    // 030 M_PixelsPerPoint                         0001866656B0 ModelPrimitiveType float float float Single
    // 034 ReferenceSpritePixelsPerUnit             0001866656B0 ModelPrimitiveType float float float Single
    // 038 ClearSettings                            000186716130 ModelEnumType PanelClearSettings PanelClearSettings PanelClearSettings Int32
    // 04C DuringLayoutPhase                        000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 RepaintData                              000186661810 ModelClassType RepaintData RepaintData RepaintData Pointer
    // 058 CursorManager                            000186747AF0 ModelClassType ICursorManager ICursorManager ICursorManager Pointer
    // 060 ContextualMenuManager                    000186618780 ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer
    // 068 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 070 M_TopElementUnderPointers                000186723C10 ModelClassType ElementUnderPointer ElementUnderPointer ElementUnderPointer Pointer
    // 078 StandardShaderChanged                    0001866792B0 ModelClassType Action Action Action Pointer
    // 080 StandardWorldSpaceShaderChanged          0001866792B0 ModelClassType Action Action Action Pointer
    // 088 AtlasChanged                             0001866792B0 ModelClassType Action Action Action Pointer
    // 090 updateMaterial                           Action`1<Material> IL2CPP_TYPE_GENERICINST
    // 098 HierarchyChanged                         0001866B5990 ModelClassType HierarchyEvent HierarchyEvent HierarchyEvent Pointer
    // 0A0 beforeUpdate                             Action`1<IPanel> IL2CPP_TYPE_GENERICINST
    public partial class BaseVisualElementPanel
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
            var value   = new BaseVisualElementPanel();

            value.M_UIElementsBridge                        = GetObject<UIElementsBridge>(new IntPtr(p + 0x018), ReversePrism.DataModels.UIElementsBridge.FromPointer); // 027003E9ED08 0x18 M_UIElementsBridge          ( 0001866E5BD0 ModelClassType UIElementsBridge UIElementsBridge UIElementsBridge Pointer )
            value.M_Scale                                   = GetSingle(new IntPtr(p + 0x020)); // 027003E9ED28 0x20 M_Scale                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.YogaConfig                                = GetObject<YogaConfig>(new IntPtr(p + 0x028), ReversePrism.DataModels.YogaConfig.FromPointer); // 027003E9ED48 0x28 YogaConfig                  ( 0001865DB010 ModelClassType YogaConfig YogaConfig YogaConfig Pointer )
            value.M_PixelsPerPoint                          = GetSingle(new IntPtr(p + 0x030)); // 027003E9ED68 0x30 M_PixelsPerPoint            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ReferenceSpritePixelsPerUnit              = GetSingle(new IntPtr(p + 0x034)); // 027003E9ED88 0x34 ReferenceSpritePixelsPerUnit ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ClearSettings                             = (PanelClearSettings)GetInt32(new IntPtr(p + 0x038)); // 027003E9EDA8 0x38 ClearSettings               ( 000186716130 ModelEnumType PanelClearSettings PanelClearSettings PanelClearSettings Int32 )
            value.DuringLayoutPhase                         = GetBool(new IntPtr(p + 0x04C)); // 027003E9EDC8 0x4C DuringLayoutPhase           ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RepaintData                               = GetObject<RepaintData>(new IntPtr(p + 0x050), ReversePrism.DataModels.RepaintData.FromPointer); // 027003E9EDE8 0x50 RepaintData                 ( 000186661810 ModelClassType RepaintData RepaintData RepaintData Pointer )
            value.CursorManager                             = GetObject<ICursorManager>(new IntPtr(p + 0x058), ReversePrism.DataModels.ICursorManager.FromPointer); // 027003E9EE08 0x58 CursorManager               ( 000186747AF0 ModelClassType ICursorManager ICursorManager ICursorManager Pointer )
            value.ContextualMenuManager                     = GetObject<ContextualMenuManager>(new IntPtr(p + 0x060), ReversePrism.DataModels.ContextualMenuManager.FromPointer); // 027003E9EE28 0x60 ContextualMenuManager       ( 000186618780 ModelClassType ContextualMenuManager ContextualMenuManager ContextualMenuManager Pointer )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x068)); // 027003E9EE48 0x68 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_TopElementUnderPointers                 = GetObject<ElementUnderPointer>(new IntPtr(p + 0x070), ReversePrism.DataModels.ElementUnderPointer.FromPointer); // 027003E9EE68 0x70 M_TopElementUnderPointers   ( 000186723C10 ModelClassType ElementUnderPointer ElementUnderPointer ElementUnderPointer Pointer )
            value.StandardShaderChanged                     = GetObject<Action>(new IntPtr(p + 0x078), ReversePrism.DataModels.Action.FromPointer); // 027003E9EE88 0x78 StandardShaderChanged       ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.StandardWorldSpaceShaderChanged           = GetObject<Action>(new IntPtr(p + 0x080), ReversePrism.DataModels.Action.FromPointer); // 027003E9EEA8 0x80 StandardWorldSpaceShaderChanged ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.AtlasChanged                              = GetObject<Action>(new IntPtr(p + 0x088), ReversePrism.DataModels.Action.FromPointer); // 027003E9EEC8 0x88 AtlasChanged                ( 0001866792B0 ModelClassType Action Action Action Pointer )
            value.HierarchyChanged                          = GetObject<HierarchyEvent>(new IntPtr(p + 0x098), ReversePrism.DataModels.HierarchyEvent.FromPointer); // 027003E9EF08 0x98 HierarchyChanged            ( 0001866B5990 ModelClassType HierarchyEvent HierarchyEvent HierarchyEvent Pointer )

            return value;
        }
    }
}
