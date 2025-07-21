using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 M_Start                                  ModelEnumType Vector2 Vector2 Vector2 Int32
    // 040 M_Active                                 ModelPrimitiveType bool bool bool Bool
    // 041 M_Resizing                               ModelPrimitiveType bool bool bool Bool
    // 048 M_Header                                 ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer
    // 050 M_Column                                 ModelClassType Column Column Column Pointer
    // 058 M_PreviewElement                         ModelClassType VisualElement VisualElement VisualElement Pointer
    // 060 ColumnLayout                             ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer
    // 068 Preview                                  ModelPrimitiveType bool bool bool Bool
    public partial class ColumnResizer : DataModel
    {
        public Vector2                                  M_Start                                 { get; set; }
        public bool                                     M_Active                                { get; set; }
        public bool                                     M_Resizing                              { get; set; }
        public MultiColumnCollectionHeader?             M_Header                                { get; set; }
        public Column?                                  M_Column                                { get; set; }
        public VisualElement?                           M_PreviewElement                        { get; set; }
        public ColumnLayout?                            ColumnLayout                            { get; set; }
        public bool                                     Preview                                 { get; set; }

        public static ColumnResizer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnResizer() { Pointer= p0 };

            value.M_Start                                   = (Vector2)GetInt32(new IntPtr(p + 0x038)); // 0x38 M_Start                     ( ModelEnumType Vector2 Vector2 Vector2 Int32 )
            value.M_Active                                  = GetBool(new IntPtr(p + 0x040)); // 0x40 M_Active                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_Resizing                                = GetBool(new IntPtr(p + 0x041)); // 0x41 M_Resizing                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Header                                  = GetObject<MultiColumnCollectionHeader>(new IntPtr(p + 0x048), ReversePrism.DataModels.MultiColumnCollectionHeader.FromPointer); // 0x48 M_Header                    ( ModelClassType MultiColumnCollectionHeader MultiColumnCollectionHeader MultiColumnCollectionHeader Pointer )
            value.M_Column                                  = GetObject<Column>(new IntPtr(p + 0x050), ReversePrism.DataModels.Column.FromPointer); // 0x50 M_Column                    ( ModelClassType Column Column Column Pointer )
            value.M_PreviewElement                          = GetObject<VisualElement>(new IntPtr(p + 0x058), ReversePrism.DataModels.VisualElement.FromPointer); // 0x58 M_PreviewElement            ( ModelClassType VisualElement VisualElement VisualElement Pointer )
            value.ColumnLayout                              = GetObject<ColumnLayout>(new IntPtr(p + 0x060), ReversePrism.DataModels.ColumnLayout.FromPointer); // 0x60 ColumnLayout                ( ModelClassType ColumnLayout ColumnLayout ColumnLayout Pointer )
            value.Preview                                   = GetBool(new IntPtr(p + 0x068)); // 0x68 Preview                     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
