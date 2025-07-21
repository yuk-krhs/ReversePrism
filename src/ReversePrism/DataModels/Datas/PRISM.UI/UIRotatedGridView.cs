using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ScrollBarSize                            float IL2CPP_TYPE_R4
    // 020 ScrollRect                               ModelClassType ScrollRect ScrollRect ScrollRect Pointer
    // 028 Cg                                       ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer
    // 030 FadeDuration                             ModelPrimitiveType float float float Single
    // 038 RectViewPort                             ModelClassType RectTransform RectTransform RectTransform Pointer
    // 040 RectContent                              ModelClassType RectTransform RectTransform RectTransform Pointer
    // 048 RowPrefab                                ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer
    // 050 RowPoolParent                            ModelClassType Transform Transform Transform Pointer
    // 058 SpacingInContent                         ModelPrimitiveType float float float Single
    // 05C RequiredSpacingInRow                     ModelPrimitiveType float float float Single
    // 060 MaxBufferRowCount                        ModelPrimitiveType int int int Int32
    // 064 OverrideItemSize                         ModelEnumType Vector2 Vector2 Vector2 Int32
    // 06C AdditionalBottomMargin                   ModelPrimitiveType float float float Single
    // 070 GoEmptyView                              ModelClassType GameObject GameObject GameObject Pointer
    // 078 ViewPortRect                             ModelEnumType Rect Rect Rect Int32
    // 088 uiRotatedGridRowViews                    LinkedList`1<UIRotatedGridRowView> IL2CPP_TYPE_GENERICINST
    // 090 ContentWidth                             ModelPrimitiveType float float float Single
    // 094 ActualDataRowCount                       ModelPrimitiveType int int int Int32
    // 098 rowIndexLocation                         ValueTuple`2<float, float>[] IL2CPP_TYPE_SZARRAY
    // 0A0 TopRowIndex                              ModelPrimitiveType int int int Int32
    // 0A4 LastRowIndex                             ModelPrimitiveType int int int Int32
    // 0A8 MaxVisibleRowCount                       ModelPrimitiveType int int int Int32
    // 0AC FirstVisibleRowIndex                     ModelPrimitiveType int int int Int32
    // 0B0 BufferRowCount                           ModelPrimitiveType int int int Int32
    // 0B4 RowRectSize                              ModelEnumType Vector2 Vector2 Vector2 Int32
    // 0BC ItemCountInRow                           ModelPrimitiveType int int int Int32
    // 0C0 ItemWidth                                ModelPrimitiveType float float float Single
    // 0C4 ItemHeight                               ModelPrimitiveType float float float Single
    // 0C8 MarginLRInRow                            ModelPrimitiveType float float float Single
    // 0CC ItemTotalCount                           ModelPrimitiveType int int int Int32
    // 0D0 RowPool                                  ModelClassType RotatedGridViewRowPool RotatedGridViewRowPool RotatedGridViewRowPool Pointer
    // 0D8 setupItemViewSubject                     Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0E0 addRowSubject                            Subject`1<ValueTuple`2<bool, int>> IL2CPP_TYPE_GENERICINST
    // 0E8 onClickSubject                           Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F0 onLongPressSubject                       Subject`1<ValueTuple`2<int, GameObject>> IL2CPP_TYPE_GENERICINST
    // 0F8 AddRowDisposable                         ModelClassType IDisposable IDisposable IDisposable Pointer
    // 100 ResetInProgress                          ModelPrimitiveType bool bool bool Bool
    public partial class UIRotatedGridView : DataModel
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
            var value   = new UIRotatedGridView() { Pointer= p0 };

            value.ScrollRect                                = GetObject<ScrollRect>(new IntPtr(p + 0x020), ReversePrism.DataModels.ScrollRect.FromPointer); // 0x20 ScrollRect                  ( ModelClassType ScrollRect ScrollRect ScrollRect Pointer )
            value.Cg                                        = GetObject<CanvasGroup>(new IntPtr(p + 0x028), ReversePrism.DataModels.CanvasGroup.FromPointer); // 0x28 Cg                          ( ModelClassType CanvasGroup CanvasGroup CanvasGroup Pointer )
            value.FadeDuration                              = GetSingle(new IntPtr(p + 0x030)); // 0x30 FadeDuration                ( ModelPrimitiveType float float float Single )
            value.RectViewPort                              = GetObject<RectTransform>(new IntPtr(p + 0x038), ReversePrism.DataModels.RectTransform.FromPointer); // 0x38 RectViewPort                ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RectContent                               = GetObject<RectTransform>(new IntPtr(p + 0x040), ReversePrism.DataModels.RectTransform.FromPointer); // 0x40 RectContent                 ( ModelClassType RectTransform RectTransform RectTransform Pointer )
            value.RowPrefab                                 = GetObject<UIRotatedGridRowView>(new IntPtr(p + 0x048), ReversePrism.DataModels.UIRotatedGridRowView.FromPointer); // 0x48 RowPrefab                   ( ModelClassType UIRotatedGridRowView UIRotatedGridRowView UIRotatedGridRowView Pointer )
            value.RowPoolParent                             = GetObject<Transform>(new IntPtr(p + 0x050), ReversePrism.DataModels.Transform.FromPointer); // 0x50 RowPoolParent               ( ModelClassType Transform Transform Transform Pointer )
            value.SpacingInContent                          = GetSingle(new IntPtr(p + 0x058)); // 0x58 SpacingInContent            ( ModelPrimitiveType float float float Single )
            value.RequiredSpacingInRow                      = GetSingle(new IntPtr(p + 0x05C)); // 0x5C RequiredSpacingInRow        ( ModelPrimitiveType float float float Single )
            value.MaxBufferRowCount                         = GetInt32(new IntPtr(p + 0x060)); // 0x60 MaxBufferRowCount           ( ModelPrimitiveType int int int Int32 )
            value.OverrideItemSize                          = (Vector2)GetInt32(new IntPtr(p + 0x064)); // 0x64 OverrideItemSize            ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.AdditionalBottomMargin                    = GetSingle(new IntPtr(p + 0x06C)); // 0x6C AdditionalBottomMargin      ( ModelPrimitiveType float float float Single )
            value.GoEmptyView                               = GetObject<GameObject>(new IntPtr(p + 0x070), ReversePrism.DataModels.GameObject.FromPointer); // 0x70 GoEmptyView                 ( ModelClassType GameObject GameObject GameObject Pointer )
            value.ViewPortRect                              = (Rect)GetInt32(new IntPtr(p + 0x078)); // 0x78 ViewPortRect                ( ModelEnumType Rect Rect Rect Int32 )
            value.ContentWidth                              = GetSingle(new IntPtr(p + 0x090)); // 0x90 ContentWidth                ( ModelPrimitiveType float float float Single )
            value.ActualDataRowCount                        = GetInt32(new IntPtr(p + 0x094)); // 0x94 ActualDataRowCount          ( ModelPrimitiveType int int int Int32 )
            value.TopRowIndex                               = GetInt32(new IntPtr(p + 0x0A0)); // 0xA0 TopRowIndex                 ( ModelPrimitiveType int int int Int32 )
            value.LastRowIndex                              = GetInt32(new IntPtr(p + 0x0A4)); // 0xA4 LastRowIndex                ( ModelPrimitiveType int int int Int32 )
            value.MaxVisibleRowCount                        = GetInt32(new IntPtr(p + 0x0A8)); // 0xA8 MaxVisibleRowCount          ( ModelPrimitiveType int int int Int32 )
            value.FirstVisibleRowIndex                      = GetInt32(new IntPtr(p + 0x0AC)); // 0xAC FirstVisibleRowIndex        ( ModelPrimitiveType int int int Int32 )
            value.BufferRowCount                            = GetInt32(new IntPtr(p + 0x0B0)); // 0xB0 BufferRowCount              ( ModelPrimitiveType int int int Int32 )
            value.RowRectSize                               = (Vector2)GetInt32(new IntPtr(p + 0x0B4)); // 0xB4 RowRectSize                 ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.ItemCountInRow                            = GetInt32(new IntPtr(p + 0x0BC)); // 0xBC ItemCountInRow              ( ModelPrimitiveType int int int Int32 )
            value.ItemWidth                                 = GetSingle(new IntPtr(p + 0x0C0)); // 0xC0 ItemWidth                   ( ModelPrimitiveType float float float Single )
            value.ItemHeight                                = GetSingle(new IntPtr(p + 0x0C4)); // 0xC4 ItemHeight                  ( ModelPrimitiveType float float float Single )
            value.MarginLRInRow                             = GetSingle(new IntPtr(p + 0x0C8)); // 0xC8 MarginLRInRow               ( ModelPrimitiveType float float float Single )
            value.ItemTotalCount                            = GetInt32(new IntPtr(p + 0x0CC)); // 0xCC ItemTotalCount              ( ModelPrimitiveType int int int Int32 )
            value.RowPool                                   = GetObject<RotatedGridViewRowPool>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.RotatedGridViewRowPool.FromPointer); // 0xD0 RowPool                     ( ModelClassType RotatedGridViewRowPool RotatedGridViewRowPool RotatedGridViewRowPool Pointer )
            value.AddRowDisposable                          = GetObject<IDisposable>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.IDisposable.FromPointer); // 0xF8 AddRowDisposable            ( ModelClassType IDisposable IDisposable IDisposable Pointer )
            value.ResetInProgress                           = GetBool(new IntPtr(p + 0x100)); // 0x100 ResetInProgress             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
