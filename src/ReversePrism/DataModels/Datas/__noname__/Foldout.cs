using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Opened                                   ModelPrimitiveType bool bool bool Bool
    // 051 IsHeader                                 ModelPrimitiveType bool bool bool Bool
    // 058 ContextMenuItems                         ModelEnumListType List`1<ContextMenuItem> List`1<ContextMenuItem> List<ContextMenuItem> Pointer
    // 060 ColumnLabels                             ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 ColumnTooltips                           ModelPrimitiveListType string[] string[] List<string> Pointer
    public partial class Foldout : DataModel
    {
        public bool                                     Opened                                  { get; set; }
        public bool                                     IsHeader                                { get; set; }
        public List<ContextMenuItem>?                   ContextMenuItems                        { get; set; }
        public List<string>?                            ColumnLabels                            { get; set; }
        public List<string>?                            ColumnTooltips                          { get; set; }

        public static Foldout? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Foldout() { Pointer= p0 };

            value.Opened                                    = GetBool(new IntPtr(p + 0x050)); // 0x50 Opened                      ( ModelPrimitiveType bool bool bool Bool )
            value.IsHeader                                  = GetBool(new IntPtr(p + 0x051)); // 0x51 IsHeader                    ( ModelPrimitiveType bool bool bool Bool )
            value.ContextMenuItems                          = GetEnumList<ContextMenuItem>(new IntPtr(p + 0x058)); // 0x58 ContextMenuItems            ( ModelEnumListType List`1<ContextMenuItem> List`1<ContextMenuItem> List<ContextMenuItem> Pointer )
            value.ColumnLabels                              = GetStringList(new IntPtr(p + 0x060)); // 0x60 ColumnLabels                ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ColumnTooltips                            = GetStringList(new IntPtr(p + 0x068)); // 0x68 ColumnTooltips              ( ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
