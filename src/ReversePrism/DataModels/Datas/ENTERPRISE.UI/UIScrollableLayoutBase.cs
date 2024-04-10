using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 OnGridClicked                            000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer
    // 028 OnGridLongPressed                        000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer
    // 030 OnGridRepeatPressed                      000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer
    // 038 OnUpdateStateChanged                     00018650D4A0 ModelClassType LayoutUpdateEvent LayoutUpdateEvent LayoutUpdateEvent Pointer
    // 000 ScrollBarSize                            float IL2CPP_TYPE_R4
    // 040 IsGridUpdating                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 IsInitialized                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 stateBuffer                              DoubleBuffer`1<RenderState> IL2CPP_TYPE_GENERICINST
    // 050 Updatable                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 054 UpdateHoldingTime                        0001866656B0 ModelPrimitiveType float float float Single
    // 058 JestureStartTime                         0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime
    // 060 ReloaderAsset                            000186671910 ModelPrimitiveType string string string String
    // 068 ReloaderUI                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 070 UpdateState                              00018650D990 ModelEnumType LayoutUpdateState LayoutUpdateState LayoutUpdateState Int32
    // 074 LongPressEnabled                         000186594D10 ModelPrimitiveType bool bool bool Bool
    // 075 RepeatPressEnabled                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 078 TargetRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 080 EmptyView                                0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 088 ItemCount                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 08C Margin                                   0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 094 ContentOffset                            0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0A0 ResourceTag                              000186671910 ModelPrimitiveType string string string String
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

            value.OnGridClicked                             = GetObject<GridEvent>(new IntPtr(p + 0x020), ReversePrism.DataModels.GridEvent.FromPointer); // 024664D22940 0x20 OnGridClicked               ( 000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnGridLongPressed                         = GetObject<GridEvent>(new IntPtr(p + 0x028), ReversePrism.DataModels.GridEvent.FromPointer); // 024664D22960 0x28 OnGridLongPressed           ( 000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnGridRepeatPressed                       = GetObject<GridEvent>(new IntPtr(p + 0x030), ReversePrism.DataModels.GridEvent.FromPointer); // 024664D22980 0x30 OnGridRepeatPressed         ( 000186699E20 ModelClassType GridEvent GridEvent GridEvent Pointer )
            value.OnUpdateStateChanged                      = GetObject<LayoutUpdateEvent>(new IntPtr(p + 0x038), ReversePrism.DataModels.LayoutUpdateEvent.FromPointer); // 024664D229A0 0x38 OnUpdateStateChanged        ( 00018650D4A0 ModelClassType LayoutUpdateEvent LayoutUpdateEvent LayoutUpdateEvent Pointer )
            value.IsGridUpdating                            = GetBool(new IntPtr(p + 0x040)); // 024664D229E0 0x40 IsGridUpdating              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsInitialized                             = GetBool(new IntPtr(p + 0x041)); // 024664D22A00 0x41 IsInitialized               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Updatable                                 = GetBool(new IntPtr(p + 0x050)); // 024664D22A40 0x50 Updatable                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.UpdateHoldingTime                         = GetSingle(new IntPtr(p + 0x054)); // 024664D22A60 0x54 UpdateHoldingTime           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.JestureStartTime                          = GetDateTime(new IntPtr(p + 0x058)); // 024664D22A80 0x58 JestureStartTime            ( 0001865B9010 ModelPrimitiveType DateTime DateTime DateTime DateTime )
            value.ReloaderAsset                             = GetString(new IntPtr(p + 0x060)); // 024664D22AA0 0x60 ReloaderAsset               ( 000186671910 ModelPrimitiveType string string string String )
            value.ReloaderUI                                = GetObject<GameObject>(new IntPtr(p + 0x068), ReversePrism.DataModels.GameObject.FromPointer); // 024664D22AC0 0x68 ReloaderUI                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.UpdateState                               = (LayoutUpdateState)GetInt32(new IntPtr(p + 0x070)); // 024664D22AE0 0x70 UpdateState                 ( 00018650D990 ModelEnumType LayoutUpdateState LayoutUpdateState LayoutUpdateState Int32 )
            value.LongPressEnabled                          = GetBool(new IntPtr(p + 0x074)); // 024664D22B00 0x74 LongPressEnabled            ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RepeatPressEnabled                        = GetBool(new IntPtr(p + 0x075)); // 024664D22B20 0x75 RepeatPressEnabled          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.TargetRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x078), ReversePrism.DataModels.ScrollRect.FromPointer); // 024664D22B40 0x78 TargetRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.EmptyView                                 = GetObject<GameObject>(new IntPtr(p + 0x080), ReversePrism.DataModels.GameObject.FromPointer); // 024664D22B60 0x80 EmptyView                   ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ItemCount                                 = GetInt32(new IntPtr(p + 0x088)); // 024664D22B80 0x88 ItemCount                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Margin                                    = (Vector2)GetInt32(new IntPtr(p + 0x08C)); // 024664D22BA0 0x8C Margin                      ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ContentOffset                             = (Vector2)GetInt32(new IntPtr(p + 0x094)); // 024664D22BC0 0x94 ContentOffset               ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ResourceTag                               = GetString(new IntPtr(p + 0x0A0)); // 024664D22BE0 0xA0 ResourceTag                 ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
