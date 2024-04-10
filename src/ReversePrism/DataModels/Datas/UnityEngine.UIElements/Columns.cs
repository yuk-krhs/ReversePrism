using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_Columns                                IList`1<Column> IL2CPP_TYPE_GENERICINST
    // 018 M_DisplayColumns                         000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 020 M_VisibleColumns                         000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer
    // 028 M_VisibleColumnsDirty                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 02C M_StretchMode                            000186779F40 ModelEnumType StretchMode StretchMode StretchMode Int32
    // 030 M_Reorderable                            000186594D10 ModelPrimitiveType bool bool bool Bool
    // 031 M_Resizable                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 032 M_ResizePreview                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 038 M_PrimaryColumnName                      000186671910 ModelPrimitiveType string string string String
    // 040 changed                                  Action`1<ColumnsDataType> IL2CPP_TYPE_GENERICINST
    // 048 columnAdded                              Action`2<Column, int> IL2CPP_TYPE_GENERICINST
    // 050 columnRemoved                            Action`1<Column> IL2CPP_TYPE_GENERICINST
    // 058 columnChanged                            Action`2<Column, ColumnDataType> IL2CPP_TYPE_GENERICINST
    // 060 columnResized                            Action`1<Column> IL2CPP_TYPE_GENERICINST
    // 068 columnReordered                          Action`3<Column, int, int> IL2CPP_TYPE_GENERICINST
    public partial class Columns : DataModel
    {
        public List<Column>?                            M_DisplayColumns                        { get; set; }
        public List<Column>?                            M_VisibleColumns                        { get; set; }
        public bool                                     M_VisibleColumnsDirty                   { get; set; }
        public StretchMode                              M_StretchMode                           { get; set; }
        public bool                                     M_Reorderable                           { get; set; }
        public bool                                     M_Resizable                             { get; set; }
        public bool                                     M_ResizePreview                         { get; set; }
        public string                                   M_PrimaryColumnName                     { get; set; }

        public static Columns? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Columns() { Pointer= p0 };

            value.M_DisplayColumns                          = GetObjectList<Column>(new IntPtr(p + 0x018), ReversePrism.DataModels.Column.FromPointer); // 0245A66EA290 0x18 M_DisplayColumns            ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.M_VisibleColumns                          = GetObjectList<Column>(new IntPtr(p + 0x020), ReversePrism.DataModels.Column.FromPointer); // 0245A66EA2B0 0x20 M_VisibleColumns            ( 000185CD38B8 ModelClassListType List`1<Column> List`1<Column> List<Column> Pointer )
            value.M_VisibleColumnsDirty                     = GetBool(new IntPtr(p + 0x028)); // 0245A66EA2D0 0x28 M_VisibleColumnsDirty       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_StretchMode                             = (StretchMode)GetInt32(new IntPtr(p + 0x02C)); // 0245A66EA2F0 0x2C M_StretchMode               ( 000186779F40 ModelEnumType StretchMode StretchMode StretchMode Int32 )
            value.M_Reorderable                             = GetBool(new IntPtr(p + 0x030)); // 0245A66EA310 0x30 M_Reorderable               ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_Resizable                               = GetBool(new IntPtr(p + 0x031)); // 0245A66EA330 0x31 M_Resizable                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_ResizePreview                           = GetBool(new IntPtr(p + 0x032)); // 0245A66EA350 0x32 M_ResizePreview             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_PrimaryColumnName                       = GetString(new IntPtr(p + 0x038)); // 0245A66EA370 0x38 M_PrimaryColumnName         ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
