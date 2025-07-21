using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 k_InvalidTemplateError                   string IL2CPP_TYPE_STRING
    // 010 M_Name                                   ModelPrimitiveType string string string String
    // 018 M_Title                                  ModelPrimitiveType string string string String
    // 020 M_Icon                                   ModelEnumType Background Background Background Int32
    // 040 M_Visible                                ModelPrimitiveType bool bool bool Bool
    // 044 M_Width                                  ModelEnumType Length Length Length Int32
    // 04C M_MinWidth                               ModelEnumType Length Length Length Int32
    // 054 M_MaxWidth                               ModelEnumType Length Length Length Int32
    // 05C M_DesiredWidth                           ModelPrimitiveType float float float Single
    // 060 M_Stretchable                            ModelPrimitiveType bool bool bool Bool
    // 061 M_Sortable                               ModelPrimitiveType bool bool bool Bool
    // 062 M_Optional                               ModelPrimitiveType bool bool bool Bool
    // 063 M_Resizable                              ModelPrimitiveType bool bool bool Bool
    // 068 m_MakeHeader                             Func`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 070 m_BindHeader                             Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 078 m_UnbindHeader                           Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 080 m_DestroyHeader                          Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 088 m_MakeCell                               Func`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 090 m_BindCell                               Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 098 m_UnbindCellItem                         Action`2<VisualElement, int> IL2CPP_TYPE_GENERICINST
    // 0A0 <destroyCell>k__BackingField             Action`1<VisualElement> IL2CPP_TYPE_GENERICINST
    // 0A8 Collection                               ModelClassType Columns Columns Columns Pointer
    // 0B0 changed                                  Action`2<Column, ColumnDataType> IL2CPP_TYPE_GENERICINST
    // 0B8 resized                                  Action`1<Column> IL2CPP_TYPE_GENERICINST
    public partial class Column : DataModel
    {
        public string                                   M_Name                                  { get; set; }
        public string                                   M_Title                                 { get; set; }
        public Background                               M_Icon                                  { get; set; }
        public bool                                     M_Visible                               { get; set; }
        public Length                                   M_Width                                 { get; set; }
        public Length                                   M_MinWidth                              { get; set; }
        public Length                                   M_MaxWidth                              { get; set; }
        public float                                    M_DesiredWidth                          { get; set; }
        public bool                                     M_Stretchable                           { get; set; }
        public bool                                     M_Sortable                              { get; set; }
        public bool                                     M_Optional                              { get; set; }
        public bool                                     M_Resizable                             { get; set; }
        public Columns?                                 Collection                              { get; set; }

        public static Column? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Column() { Pointer= p0 };

            value.M_Name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_Name                      ( ModelPrimitiveType string string string String )
            value.M_Title                                   = GetString(new IntPtr(p + 0x018)); // 0x18 M_Title                     ( ModelPrimitiveType string string string String )
            value.M_Icon                                    = (Background)GetInt32(new IntPtr(p + 0x020)); // 0x20 M_Icon                      ( ModelEnumType Background Background Background Int32 )
            value.M_Visible                                 = GetBool(new IntPtr(p + 0x040)); // 0x40 M_Visible                   ( ModelPrimitiveType bool bool bool Bool )
            value.M_Width                                   = (Length)GetInt32(new IntPtr(p + 0x044)); // 0x44 M_Width                     ( ModelEnumType Length Length Length Int32 )
            value.M_MinWidth                                = (Length)GetInt32(new IntPtr(p + 0x04C)); // 0x4C M_MinWidth                  ( ModelEnumType Length Length Length Int32 )
            value.M_MaxWidth                                = (Length)GetInt32(new IntPtr(p + 0x054)); // 0x54 M_MaxWidth                  ( ModelEnumType Length Length Length Int32 )
            value.M_DesiredWidth                            = GetSingle(new IntPtr(p + 0x05C)); // 0x5C M_DesiredWidth              ( ModelPrimitiveType float float float Single )
            value.M_Stretchable                             = GetBool(new IntPtr(p + 0x060)); // 0x60 M_Stretchable               ( ModelPrimitiveType bool bool bool Bool )
            value.M_Sortable                                = GetBool(new IntPtr(p + 0x061)); // 0x61 M_Sortable                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Optional                                = GetBool(new IntPtr(p + 0x062)); // 0x62 M_Optional                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_Resizable                               = GetBool(new IntPtr(p + 0x063)); // 0x63 M_Resizable                 ( ModelPrimitiveType bool bool bool Bool )
            value.Collection                                = GetObject<Columns>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.Columns.FromPointer); // 0xA8 Collection                  ( ModelClassType Columns Columns Columns Pointer )

            return value;
        }
    }
}
