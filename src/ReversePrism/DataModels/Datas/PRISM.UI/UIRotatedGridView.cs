using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScrollBarSize                            float IL2CPP_TYPE_R4
    // 020 ScrollRect                               0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 Cg                                       000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 FadeDuration                             0001866656B0 ModelPrimitiveType float float float Single
    // 038 RectViewPort                             000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 RectContent                              000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 RowPrefab                                0001866F13C0 ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer
    // 050 RowPoolParent                            0001866AA150 ModelClassType Transform Transform Transform Pointer
    // 058 SpacingInContent                         0001866656B0 ModelPrimitiveType float float float Single
    // 05C RequiredSpacingInRow                     0001866656B0 ModelPrimitiveType float float float Single
    // 060 MaxBufferRowCount                        0001865F2AF0 ModelPrimitiveType int int int Int32
    // 064 OverrideItemSize                         0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 06C AdditionalBottomMargin                   0001866656B0 ModelPrimitiveType float float float Single
    // 070 GoEmptyView                              0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 078 ViewPortRect                             00018664F620 ModelEnumType Rect Rect Rect Int32
    // 088 uiRotatedGridRowViews                    LinkedList`1<UIRotatedGridRowView> IL2CPP_TYPE_GENERICINST
    // 090 ContentWidth                             0001866656B0 ModelPrimitiveType float float float Single
    // 094 ActualDataRowCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 098 rowIndexLocation                         ValueTuple`2<float, float>[] IL2CPP_TYPE_SZARRAY
    // 0A0 TopRowIndex                              0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A4 LastRowIndex                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0A8 MaxVisibleRowCount                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0AC FirstVisibleRowIndex                     0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B0 BufferRowCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0B4 RowRectSize                              0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0BC ItemCountInRow                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0C0 ItemWidth                                0001866656B0 ModelPrimitiveType float float float Single
    // 0C4 ItemHeight                               0001866656B0 ModelPrimitiveType float float float Single
    // 0C8 MarginLRInRow                            0001866656B0 ModelPrimitiveType float float float Single
    // 0CC ItemTotalCount                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 0D0 RowPool                                  000186666190 ModelClassType RotatedGridViewRowPool RotatedGridViewRowPool RotatedGridViewRowPool Pointer
    // 0D8 setupItemViewSubject                     Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E0 addRowSubject                            Subject`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    // 0E8 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F8 AddRowDisposable                         0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    // 100 ResetInProgress                          000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class UIRotatedGridView
    {
        public ScrollRect?                              ScrollRect                              { get; set; }
        public CanvasGroup?                             Cg                                      { get; set; }
        public float                                    FadeDuration                            { get; set; }
        public RectTransform?                           RectViewPort                            { get; set; }
        public RectTransform?                           RectContent                             { get; set; }
        public UIRotatedGridRowView?                    RowPrefab                               { get; set; }
        public Transform?                               RowPoolParent                           { get; set; }
        public float                                    SpacingInContent                        { get; set; }
        public float                                    RequiredSpacingInRow                    { get; set; }
        public int                                      MaxBufferRowCount                       { get; set; }
        public Vector2                                  OverrideItemSize                        { get; set; }
        public float                                    AdditionalBottomMargin                  { get; set; }
        public GameObject?                              GoEmptyView                             { get; set; }
        public Rect                                     ViewPortRect                            { get; set; }
        public float                                    ContentWidth                            { get; set; }
        public int                                      ActualDataRowCount                      { get; set; }
        public int                                      TopRowIndex                             { get; set; }
        public int                                      LastRowIndex                            { get; set; }
        public int                                      MaxVisibleRowCount                      { get; set; }
        public int                                      FirstVisibleRowIndex                    { get; set; }
        public int                                      BufferRowCount                          { get; set; }
        public Vector2                                  RowRectSize                             { get; set; }
        public int                                      ItemCountInRow                          { get; set; }
        public float                                    ItemWidth                               { get; set; }
        public float                                    ItemHeight                              { get; set; }
        public float                                    MarginLRInRow                           { get; set; }
        public int                                      ItemTotalCount                          { get; set; }
        public RotatedGridViewRowPool?                  RowPool                                 { get; set; }
        public IDisposable?                             AddRowDisposable                        { get; set; }
        public bool                                     ResetInProgress                         { get; set; }

        public static UIRotatedGridView? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new UIRotatedGridView();

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0270D54AB138 0x20 ScrollRect                  ( 0001866F7FA0 ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0270D54AB158 0x28 Cg                          ( 000186540EE0 ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x030)); // 0270D54AB178 0x30 FadeDuration                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RectViewPort                              = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D54AB198 0x38 RectViewPort                ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0270D54AB1B8 0x40 RectContent                 ( 000186630450 ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RowPrefab                                 = GetObject<UIRotatedGridRowView>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRotatedGridRowView.FromPointer); // 0270D54AB1D8 0x48 RowPrefab                   ( 0001866F13C0 ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer )
            value.RowPoolParent                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0270D54AB1F8 0x50 RowPoolParent               ( 0001866AA150 ModelClassType Transform Transform Transform Pointer )
            value.SpacingInContent                          = GetSingle(new IntPtr(p + 0x058)); // 0270D54AB218 0x58 SpacingInContent            ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.RequiredSpacingInRow                      = GetSingle(new IntPtr(p + 0x05C)); // 0270D54AB238 0x5C RequiredSpacingInRow        ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MaxBufferRowCount                         = GetInt32(new IntPtr(p + 0x060)); // 0270D54AB258 0x60 MaxBufferRowCount           ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.OverrideItemSize                          = (Vector2)GetInt32(new IntPtr(p + 0x064)); // 0270D54AB278 0x64 OverrideItemSize            ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AdditionalBottomMargin                    = GetSingle(new IntPtr(p + 0x06C)); // 0270D54AB298 0x6C AdditionalBottomMargin      ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.GoEmptyView                               = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0270D54AB2B8 0x70 GoEmptyView                 ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewPortRect                              = (Rect)GetInt32(new IntPtr(p + 0x078)); // 0270D54AB2D8 0x78 ViewPortRect                ( 00018664F620 ModelEnumType Rect Rect Rect Int32 )
            value.ContentWidth                              = GetSingle(new IntPtr(p + 0x090)); // 0270D54AB318 0x90 ContentWidth                ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ActualDataRowCount                        = GetInt32(new IntPtr(p + 0x094)); // 0270D54AB338 0x94 ActualDataRowCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.TopRowIndex                               = GetInt32(new IntPtr(p + 0x0A0)); // 0270D54AB378 0xA0 TopRowIndex                 ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.LastRowIndex                              = GetInt32(new IntPtr(p + 0x0A4)); // 0270D54AB398 0xA4 LastRowIndex                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MaxVisibleRowCount                        = GetInt32(new IntPtr(p + 0x0A8)); // 0270D54AB3B8 0xA8 MaxVisibleRowCount          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.FirstVisibleRowIndex                      = GetInt32(new IntPtr(p + 0x0AC)); // 0270D54AB3D8 0xAC FirstVisibleRowIndex        ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.BufferRowCount                            = GetInt32(new IntPtr(p + 0x0B0)); // 0270D54AB3F8 0xB0 BufferRowCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RowRectSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0B4)); // 0270D54AB418 0xB4 RowRectSize                 ( 0001866A7FB0 ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ItemCountInRow                            = GetInt32(new IntPtr(p + 0x0BC)); // 0270D54AB438 0xBC ItemCountInRow              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ItemWidth                                 = GetSingle(new IntPtr(p + 0x0C0)); // 0270D54AB458 0xC0 ItemWidth                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ItemHeight                                = GetSingle(new IntPtr(p + 0x0C4)); // 0270D54AB478 0xC4 ItemHeight                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.MarginLRInRow                             = GetSingle(new IntPtr(p + 0x0C8)); // 0270D54AB498 0xC8 MarginLRInRow               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.ItemTotalCount                            = GetInt32(new IntPtr(p + 0x0CC)); // 0270D54AB4B8 0xCC ItemTotalCount              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.RowPool                                   = GetObject<RotatedGridViewRowPool>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RotatedGridViewRowPool.FromPointer); // 0270D54AB4D8 0xD0 RowPool                     ( 000186666190 ModelClassType RotatedGridViewRowPool RotatedGridViewRowPool RotatedGridViewRowPool Pointer )
            value.AddRowDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.IDisposable.FromPointer); // 0270D54AB578 0xF8 AddRowDisposable            ( 0001867532E0 ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResetInProgress                           = GetBool(new IntPtr(p + 0x100)); // 0270D54AB598 0x100 ResetInProgress             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
