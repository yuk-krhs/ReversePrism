using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ussClassName                             string IL2CPP_TYPE_STRING
    // 008 sortableUssClassName                     string IL2CPP_TYPE_STRING
    // 010 SortedAscendingUssClassName              000186674040 ModelPrimitiveType string string string String
    // 018 SortedDescendingUssClassName             000186674040 ModelPrimitiveType string string string String
    // 020 MovingUssClassName                       000186674040 ModelPrimitiveType string string string String
    // 028 ContentContainerUssClassName             000186674040 ModelPrimitiveType string string string String
    // 030 ContentUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 038 DefaultContentUssClassName               000186674040 ModelPrimitiveType string string string String
    // 040 HasIconUssClassName                      000186674040 ModelPrimitiveType string string string String
    // 048 HasTitleUssClassName                     000186674040 ModelPrimitiveType string string string String
    // 050 TitleUssClassName                        000186674040 ModelPrimitiveType string string string String
    // 058 IconElementName                          000186674040 ModelPrimitiveType string string string String
    // 060 TitleElementName                         000186674040 ModelPrimitiveType string string string String
    // 068 S_BoundVEPropertyName                    0001866738F0 ModelPrimitiveType string string string String
    // 070 S_BindingCallbackVEPropertyName          0001866738F0 ModelPrimitiveType string string string String
    // 078 S_UnbindingCallbackVEPropertyName        0001866738F0 ModelPrimitiveType string string string String
    // 080 S_DestroyCallbackVEPropertyName          0001866738F0 ModelPrimitiveType string string string String
    // 3C8 M_ContentContainer                       0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D0 M_Content                                0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 3D8 M_SortIndicatorContainer                 00018665FD90 ModelClassType MultiColumnHeaderColumnSortIndicator MultiColumnHeaderColumnSortIndicator MultiColumnHeaderColumnSortIndicator Pointer
    // 3E0 M_ScheduledHeaderTemplateUpdate          000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer
    // 3E8 Clickable                                0001865B4AC0 ModelClassType Clickable Clickable Clickable Pointer
    // 3F0 Mover                                    0001865D6EF0 ModelClassType ColumnMover ColumnMover ColumnMover Pointer
    // 3F8 Column                                   0001865D5780 ModelClassType Column Column Column Pointer
    public partial class MultiColumnHeaderColumn : DataModel
    {
        public string                                   SortedAscendingUssClassName             { get; set; }
        public string                                   SortedDescendingUssClassName            { get; set; }
        public string                                   MovingUssClassName                      { get; set; }
        public string                                   ContentContainerUssClassName            { get; set; }
        public string                                   ContentUssClassName                     { get; set; }
        public string                                   DefaultContentUssClassName              { get; set; }
        public string                                   HasIconUssClassName                     { get; set; }
        public string                                   HasTitleUssClassName                    { get; set; }
        public string                                   TitleUssClassName                       { get; set; }
        public string                                   IconElementName                         { get; set; }
        public string                                   TitleElementName                        { get; set; }
        public string                                   S_BoundVEPropertyName                   { get; set; }
        public string                                   S_BindingCallbackVEPropertyName         { get; set; }
        public string                                   S_UnbindingCallbackVEPropertyName       { get; set; }
        public string                                   S_DestroyCallbackVEPropertyName         { get; set; }
        public VisualElement?                           M_ContentContainer                      { get; set; }
        public VisualElement?                           M_Content                               { get; set; }
        public MultiColumnHeaderColumnSortIndicator?    M_SortIndicatorContainer                { get; set; }
        public IVisualElementScheduledItem?             M_ScheduledHeaderTemplateUpdate         { get; set; }
        public Clickable?                               Clickable                               { get; set; }
        public ColumnMover?                             Mover                                   { get; set; }
        public Column?                                  Column                                  { get; set; }

        public static MultiColumnHeaderColumn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MultiColumnHeaderColumn() { Pointer= p0 };

            value.SortedAscendingUssClassName               = GetString(new IntPtr(p + 0x010)); // 0245A6863C70 0x10 SortedAscendingUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.SortedDescendingUssClassName              = GetString(new IntPtr(p + 0x018)); // 0245A6863C90 0x18 SortedDescendingUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.MovingUssClassName                        = GetString(new IntPtr(p + 0x020)); // 0245A6863CB0 0x20 MovingUssClassName          ( 000186674040 ModelPrimitiveType string string string String )
            value.ContentContainerUssClassName              = GetString(new IntPtr(p + 0x028)); // 0245A6863CD0 0x28 ContentContainerUssClassName ( 000186674040 ModelPrimitiveType string string string String )
            value.ContentUssClassName                       = GetString(new IntPtr(p + 0x030)); // 0245A6863CF0 0x30 ContentUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.DefaultContentUssClassName                = GetString(new IntPtr(p + 0x038)); // 0245A6863D10 0x38 DefaultContentUssClassName  ( 000186674040 ModelPrimitiveType string string string String )
            value.HasIconUssClassName                       = GetString(new IntPtr(p + 0x040)); // 0245A6863D30 0x40 HasIconUssClassName         ( 000186674040 ModelPrimitiveType string string string String )
            value.HasTitleUssClassName                      = GetString(new IntPtr(p + 0x048)); // 0245A6863D50 0x48 HasTitleUssClassName        ( 000186674040 ModelPrimitiveType string string string String )
            value.TitleUssClassName                         = GetString(new IntPtr(p + 0x050)); // 0245A6863D70 0x50 TitleUssClassName           ( 000186674040 ModelPrimitiveType string string string String )
            value.IconElementName                           = GetString(new IntPtr(p + 0x058)); // 0245A6863D90 0x58 IconElementName             ( 000186674040 ModelPrimitiveType string string string String )
            value.TitleElementName                          = GetString(new IntPtr(p + 0x060)); // 0245A6863DB0 0x60 TitleElementName            ( 000186674040 ModelPrimitiveType string string string String )
            value.S_BoundVEPropertyName                     = GetString(new IntPtr(p + 0x068)); // 0245A6863DD0 0x68 S_BoundVEPropertyName       ( 0001866738F0 ModelPrimitiveType string string string String )
            value.S_BindingCallbackVEPropertyName           = GetString(new IntPtr(p + 0x070)); // 0245A6863DF0 0x70 S_BindingCallbackVEPropertyName ( 0001866738F0 ModelPrimitiveType string string string String )
            value.S_UnbindingCallbackVEPropertyName         = GetString(new IntPtr(p + 0x078)); // 0245A6863E10 0x78 S_UnbindingCallbackVEPropertyName ( 0001866738F0 ModelPrimitiveType string string string String )
            value.S_DestroyCallbackVEPropertyName           = GetString(new IntPtr(p + 0x080)); // 0245A6863E30 0x80 S_DestroyCallbackVEPropertyName ( 0001866738F0 ModelPrimitiveType string string string String )
            value.M_ContentContainer                        = GetObject<VisualElement>(new IntPtr(p + 0x3C8), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6863E50 0x3C8 M_ContentContainer          ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_Content                                 = GetObject<VisualElement>(new IntPtr(p + 0x3D0), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6863E70 0x3D0 M_Content                   ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_SortIndicatorContainer                  = GetObject<MultiColumnHeaderColumnSortIndicator>(new IntPtr(p + 0x3D8), ReversePrism.DataModels.MultiColumnHeaderColumnSortIndicator.FromPointer); // 0245A6863E90 0x3D8 M_SortIndicatorContainer    ( 00018665FD90 ModelClassType MultiColumnHeaderColumnSortIndicator MultiColumnHeaderColumnSortIndicator MultiColumnHeaderColumnSortIndicator Pointer )
            value.M_ScheduledHeaderTemplateUpdate           = GetObject<IVisualElementScheduledItem>(new IntPtr(p + 0x3E0), ReversePrism.DataModels.IVisualElementScheduledItem.FromPointer); // 0245A6863EB0 0x3E0 M_ScheduledHeaderTemplateUpdate ( 000186697790 ModelClassType IVisualElementScheduledItem IVisualElementScheduledItem IVisualElementScheduledItem Pointer )
            value.Clickable                                 = GetObject<Clickable>(new IntPtr(p + 0x3E8), ReversePrism.DataModels.Clickable.FromPointer); // 0245A6863ED0 0x3E8 Clickable                   ( 0001865B4AC0 ModelClassType Clickable Clickable Clickable Pointer )
            value.Mover                                     = GetObject<ColumnMover>(new IntPtr(p + 0x3F0), ReversePrism.DataModels.ColumnMover.FromPointer); // 0245A6863EF0 0x3F0 Mover                       ( 0001865D6EF0 ModelClassType ColumnMover ColumnMover ColumnMover Pointer )
            value.Column                                    = GetObject<Column>(new IntPtr(p + 0x3F8), ReversePrism.DataModels.Column.FromPointer); // 0245A6863F10 0x3F8 Column                      ( 0001865D5780 ModelClassType Column Column Column Pointer )

            return value;
        }
    }
}
