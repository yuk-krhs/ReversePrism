using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_StretchableColumns                     000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 018 M_FixedColumns                           000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 020 M_Columns                                0001865D7890 ModelClassType Columns Columns Columns Pointer
    // 028 M_ColumnsWidth                           0001866656B0 ModelPrimitiveType float float float Single
    // 02C M_ColumnsWidthDirty                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 M_MaxColumnsWidth                        0001866656B0 ModelPrimitiveType float float float Single
    // 034 M_MinColumnsWidth                        0001866656B0 ModelPrimitiveType float float float Single
    // 038 M_IsDirty                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 03C M_PreviousWidth                          0001866656B0 ModelPrimitiveType float float float Single
    // 040 M_DragResizeInPreviewMode                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 041 M_DragResizing                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 044 M_DragStartPos                           0001866656B0 ModelPrimitiveType float float float Single
    // 048 M_DragLastPos                            0001866656B0 ModelPrimitiveType float float float Single
    // 04C M_DragInitialColumnWidth                 0001866656B0 ModelPrimitiveType float float float Single
    // 050 M_DragStretchableColumns                 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 058 M_DragFixedColumns                       000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 060 m_PreviewDesiredWidths                   Dictionary`2<Column, float> IL2CPP_TYPE_GENERICINST
    // 068 LayoutRequested                          0001866792B0 ModelClassType Action Action Action Pointer
    public partial class ColumnLayout : DataModel
    {
        public List<Column>?                            M_StretchableColumns                    { get; set; }
        public List<Column>?                            M_FixedColumns                          { get; set; }
        public Columns?                                 M_Columns                               { get; set; }
        public float                                    M_ColumnsWidth                          { get; set; }
        public bool                                     M_ColumnsWidthDirty                     { get; set; }
        public float                                    M_MaxColumnsWidth                       { get; set; }
        public float                                    M_MinColumnsWidth                       { get; set; }
        public bool                                     M_IsDirty                               { get; set; }
        public float                                    M_PreviousWidth                         { get; set; }
        public bool                                     M_DragResizeInPreviewMode               { get; set; }
        public bool                                     M_DragResizing                          { get; set; }
        public float                                    M_DragStartPos                          { get; set; }
        public float                                    M_DragLastPos                           { get; set; }
        public float                                    M_DragInitialColumnWidth                { get; set; }
        public List<Column>?                            M_DragStretchableColumns                { get; set; }
        public List<Column>?                            M_DragFixedColumns                      { get; set; }
        public Action?                                  LayoutRequested                         { get; set; }

        public static ColumnLayout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ColumnLayout() { Pointer= p0 };

            value.M_StretchableColumns                      = GetObjectList<Column>(new IntPtr(p + 0x010), ReversePrism.DataModels.Column.FromPointer); // 0245A66E8680 0x10 M_StretchableColumns        ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.M_FixedColumns                            = GetObjectList<Column>(new IntPtr(p + 0x018), ReversePrism.DataModels.Column.FromPointer); // 0245A66E86A0 0x18 M_FixedColumns              ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.M_Columns                                 = GetObject<Columns>(new IntPtr(p + 0x020), ReversePrism.DataModels.Columns.FromPointer); // 0245A66E86C0 0x20 M_Columns                   ( 0001865D7890 ModelClassType Columns Columns Columns Pointer )
            value.M_ColumnsWidth                            = GetSingle(new IntPtr(p + 0x028)); // 0245A66E86E0 0x28 M_ColumnsWidth              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_ColumnsWidthDirty                       = GetBool(new IntPtr(p + 0x02C)); // 0245A66E8700 0x2C M_ColumnsWidthDirty         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_MaxColumnsWidth                         = GetSingle(new IntPtr(p + 0x030)); // 0245A66E8720 0x30 M_MaxColumnsWidth           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_MinColumnsWidth                         = GetSingle(new IntPtr(p + 0x034)); // 0245A66E8740 0x34 M_MinColumnsWidth           ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_IsDirty                                 = GetBool(new IntPtr(p + 0x038)); // 0245A66E8760 0x38 M_IsDirty                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PreviousWidth                           = GetSingle(new IntPtr(p + 0x03C)); // 0245A66E8780 0x3C M_PreviousWidth             ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DragResizeInPreviewMode                 = GetBool(new IntPtr(p + 0x040)); // 0245A66E87A0 0x40 M_DragResizeInPreviewMode   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragResizing                            = GetBool(new IntPtr(p + 0x041)); // 0245A66E87C0 0x41 M_DragResizing              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_DragStartPos                            = GetSingle(new IntPtr(p + 0x044)); // 0245A66E87E0 0x44 M_DragStartPos              ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DragLastPos                             = GetSingle(new IntPtr(p + 0x048)); // 0245A66E8800 0x48 M_DragLastPos               ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DragInitialColumnWidth                  = GetSingle(new IntPtr(p + 0x04C)); // 0245A66E8820 0x4C M_DragInitialColumnWidth    ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.M_DragStretchableColumns                  = GetObjectList<Column>(new IntPtr(p + 0x050), ReversePrism.DataModels.Column.FromPointer); // 0245A66E8840 0x50 M_DragStretchableColumns    ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.M_DragFixedColumns                        = GetObjectList<Column>(new IntPtr(p + 0x058), ReversePrism.DataModels.Column.FromPointer); // 0245A66E8860 0x58 M_DragFixedColumns          ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.LayoutRequested                           = GetObject<Action>(new IntPtr(p + 0x068), ReversePrism.DataModels.Action.FromPointer); // 0245A66E88A0 0x68 LayoutRequested             ( 0001866792B0 ModelClassType Action Action Action Pointer )

            return value;
        }
    }
}
