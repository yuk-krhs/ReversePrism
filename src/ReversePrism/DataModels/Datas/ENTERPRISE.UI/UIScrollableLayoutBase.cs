using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnGridClicked                            ModelClassType GridEvent GridEvent GridEvent Pointer
    // 028 OnGridLongPressed                        ModelClassType GridEvent GridEvent GridEvent Pointer
    // 030 OnGridRepeatPressed                      ModelClassType GridEvent GridEvent GridEvent Pointer
    // 038 OnUpdateStateChanged                     ModelClassType LayoutUpdateEvent LayoutUpdateEvent LayoutUpdateEvent Pointer
    // 000 ScrollBarSize                            float IL2CPP_TYPE_R4
    // 040 IsGridUpdating                           ModelPrimitiveType bool bool bool Bool
    // 041 IsInitialized                            ModelPrimitiveType bool bool bool Bool
    // 048 stateBuffer                              DoubleBuffer`1<RenderState> IL2CPP_TYPE_GENERICINST
    // 050 Updatable                                ModelPrimitiveType bool bool bool Bool
    // 054 UpdateHoldingTime                        ModelPrimitiveType float float float Single
    // 058 JestureStartTime                         ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 060 ReloaderAsset                            ModelPrimitiveType string string string String
    // 068 ReloaderUI                               ModelClassType GameObject GameObject GameObject Pointer
    // 070 UpdateState                              ModelEnumType LayoutUpdateState LayoutUpdateState LayoutUpdateState Int32
    // 074 LongPressEnabled                         ModelPrimitiveType bool bool bool Bool
    // 075 RepeatPressEnabled                       ModelPrimitiveType bool bool bool Bool
    // 078 TargetRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 080 EmptyView                                ModelClassType GameObject GameObject GameObject Pointer
    // 088 ItemCount                                ModelPrimitiveType int int int Int32
    // 08C Margin                                   ModelEnumType Vector2 Vector2 Vector2 Int32
    // 094 ContentOffset                            ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0A0 ResourceTag                              ModelPrimitiveType string string string String
    public partial class UIScrollableLayoutBase : DataModel
    {
        public GridEvent?                               OnGridClicked                           { get; set; }
        public GridEvent?                               OnGridLongPressed                       { get; set; }
        public GridEvent?                               OnGridRepeatPressed                     { get; set; }
        public LayoutUpdateEvent?                       OnUpdateStateChanged                    { get; set; }
        public bool                                     IsGridUpdating                          { get; set; }
        public bool                                     IsInitialized                           { get; set; }
        public bool                                     Updatable                               { get; set; }
        public float                                    UpdateHoldingTime                       { get; set; }
        public DateTime                                 JestureStartTime                        { get; set; }
        public string                                   ReloaderAsset                           { get; set; }
        public GameObject?                              ReloaderUI                              { get; set; }
        public LayoutUpdateState                        UpdateState                             { get; set; }
        public bool                                     LongPressEnabled                        { get; set; }
        public bool                                     RepeatPressEnabled                      { get; set; }
        public ScrollRect?                              TargetRect                              { get; set; }
        public GameObject?                              EmptyView                               { get; set; }
        public int                                      ItemCount                               { get; set; }
        public Vector2                                  Margin                                  { get; set; }
        public Vector2                                  ContentOffset                           { get; set; }
        public string                                   ResourceTag                             { get; set; }

        public static UIScrollableLayoutBase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIScrollableLayoutBase() { Pointer= p0 };

            value.OnGridClicked                             = GetObject<GridEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.GridEvent.FromPointer); // 0x20 OnGridClicked               ( ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnGridLongPressed                         = GetObject<GridEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.GridEvent.FromPointer); // 0x28 OnGridLongPressed           ( ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnGridRepeatPressed                       = GetObject<GridEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.GridEvent.FromPointer); // 0x30 OnGridRepeatPressed         ( ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnUpdateStateChanged                      = GetObject<LayoutUpdateEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.LayoutUpdateEvent.FromPointer); // 0x38 OnUpdateStateChanged        ( ModelClassType LayoutUpdateEvent LayoutUpdateEvent LayoutUpdateEvent Pointer )
            value.IsGridUpdating                            = GetBool(new IntPtr(p + 0x040)); // 0x40 IsGridUpdating              ( ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x041)); // 0x41 IsInitialized               ( ModelPrimitiveType bool bool bool Bool )
            value.Updatable                                 = GetBool(new IntPtr(p + 0x050)); // 0x50 Updatable                   ( ModelPrimitiveType bool bool bool Bool )
            value.UpdateHoldingTime                         = GetSingle(new IntPtr(p + 0x054)); // 0x54 UpdateHoldingTime           ( ModelPrimitiveType float float float Single )
            value.JestureStartTime                          = GetDateTime(new IntPtr(p + 0x058)); // 0x58 JestureStartTime            ( ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ReloaderAsset                             = GetString(new IntPtr(p + 0x060)); // 0x60 ReloaderAsset               ( ModelPrimitiveType string string string String )
            value.ReloaderUI                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 0x68 ReloaderUI                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.UpdateState                               = (LayoutUpdateState)GetInt32(new IntPtr(p + 0x070)); // 0x70 UpdateState                 ( ModelEnumType LayoutUpdateState LayoutUpdateState LayoutUpdateState Int32 )
            value.LongPressEnabled                          = GetBool(new IntPtr(p + 0x074)); // 0x74 LongPressEnabled            ( ModelPrimitiveType bool bool bool Bool )
            value.RepeatPressEnabled                        = GetBool(new IntPtr(p + 0x075)); // 0x75 RepeatPressEnabled          ( ModelPrimitiveType bool bool bool Bool )
            value.TargetRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x78 TargetRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 0x80 EmptyView                   ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x088)); // 0x88 ItemCount                   ( ModelPrimitiveType int int int Int32 )
            value.Margin                                    = (Vector2)GetInt32(new IntPtr(p + 0x08C)); // 0x8C Margin                      ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentOffset                             = (Vector2)GetInt32(new IntPtr(p + 0x094)); // 0x94 ContentOffset               ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x0A0)); // 0xA0 ResourceTag                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
