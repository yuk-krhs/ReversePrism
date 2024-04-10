using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_StartPos                               0001866656B0 ModelPrimitiveType float float float Single
    // 03C M_LastPos                                0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_Active                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 M_Moving                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 042 M_Cancelled                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 048 M_Header                                 00018665DB30 ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer
    // 050 M_PreviewElement                         0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer
    // 058 M_LocationPreviewElement                 00018665EEE0 ModelClassType MultiColumnHeaderColumnMoveLocationPreview MultiColumnHeaderColumnMoveLocationPreview MultiColumnHeaderColumnMoveLocationPreview Pointer
    // 060 M_ColumnToMove                           0001865D5780 ModelClassType Column Column Column Pointer
    // 068 M_ColumnToMovePos                        0001866656B0 ModelPrimitiveType float float float Single
    // 06C M_ColumnToMoveWidth                      0001866656B0 ModelPrimitiveType float float float Single
    // 070 M_DestinationColumn                      0001865D5780 ModelClassType Column Column Column Pointer
    // 078 M_MoveBeforeDestination                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 ColumnLayout                             0001865D65B0 ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer
    // 088 activeChanged                            Action`1<ColumnMover> IL2CPP_TYPE_GENERICINST
    // 090 movingChanged                            Action`1<ColumnMover> IL2CPP_TYPE_GENERICINST
    public partial class ColumnMover : DataModel
    {
        public float                                    M_StartPos                              { get; set; }
        public float                                    M_LastPos                               { get; set; }
        public bool                                     M_Active                                { get; set; }
        public bool                                     M_Moving                                { get; set; }
        public bool                                     M_Cancelled                             { get; set; }
        public MultiColumnCollectionHeader?             M_Header                                { get; set; }
        public VisualElement?                           M_PreviewElement                        { get; set; }
        public MultiColumnHeaderColumnMoveLocationPreview? M_LocationPreviewElement                { get; set; }
        public Column?                                  M_ColumnToMove                          { get; set; }
        public float                                    M_ColumnToMovePos                       { get; set; }
        public float                                    M_ColumnToMoveWidth                     { get; set; }
        public Column?                                  M_DestinationColumn                     { get; set; }
        public bool                                     M_MoveBeforeDestination                 { get; set; }
        public ColumnLayout?                            ColumnLayout                            { get; set; }

        public static ColumnMover? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnMover() { Pointer= p0 };

            value.M_StartPos                                = GetSingle(new IntPtr(p + 0x038)); // 0245A6860158 0x38 M_StartPos                  ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_LastPos                                 = GetSingle(new IntPtr(p + 0x03C)); // 0245A6860178 0x3C M_LastPos                   ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_Active                                  = GetBool(new IntPtr(p + 0x040)); // 0245A6860198 0x40 M_Active                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Moving                                  = GetBool(new IntPtr(p + 0x041)); // 0245A68601B8 0x41 M_Moving                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Cancelled                               = GetBool(new IntPtr(p + 0x042)); // 0245A68601D8 0x42 M_Cancelled                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Header                                  = GetObject<MultiColumnCollectionHeader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MultiColumnCollectionHeader.FromPointer); // 0245A68601F8 0x48 M_Header                    ( 00018665DB30 ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer )
            value.M_PreviewElement                          = GetObject<VisualElement>(new IntPtr(p + 0x050), ReversePrism.DataModels.VisualElement.FromPointer); // 0245A6860218 0x50 M_PreviewElement            ( 0001866B2D70 ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.M_LocationPreviewElement                  = GetObject<MultiColumnHeaderColumnMoveLocationPreview>(new IntPtr(p + 0x058), ReversePrism.DataModels.MultiColumnHeaderColumnMoveLocationPreview.FromPointer); // 0245A6860238 0x58 M_LocationPreviewElement    ( 00018665EEE0 ModelClassType MultiColumnHeaderColumnMoveLocationPreview MultiColumnHeaderColumnMoveLocationPreview MultiColumnHeaderColumnMoveLocationPreview Pointer )
            value.M_ColumnToMove                            = GetObject<Column>(new IntPtr(p + 0x060), ReversePrism.DataModels.Column.FromPointer); // 0245A6860258 0x60 M_ColumnToMove              ( 0001865D5780 ModelClassType Column Column Column Pointer )
            value.M_ColumnToMovePos                         = GetSingle(new IntPtr(p + 0x068)); // 0245A6860278 0x68 M_ColumnToMovePos           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ColumnToMoveWidth                       = GetSingle(new IntPtr(p + 0x06C)); // 0245A6860298 0x6C M_ColumnToMoveWidth         ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DestinationColumn                       = GetObject<Column>(new IntPtr(p + 0x070), ReversePrism.DataModels.Column.FromPointer); // 0245A68602B8 0x70 M_DestinationColumn         ( 0001865D5780 ModelClassType Column Column Column Pointer )
            value.M_MoveBeforeDestination                   = GetBool(new IntPtr(p + 0x078)); // 0245A68602D8 0x78 M_MoveBeforeDestination     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ColumnLayout                              = GetObject<ColumnLayout>(new IntPtr(p + 0x080), ReversePrism.DataModels.ColumnLayout.FromPointer); // 0245A68602F8 0x80 ColumnLayout                ( 0001865D65B0 ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer )

            return value;
        }
    }
}
