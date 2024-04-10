using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 050 Opened                                   000186595960 ModelPrimitiveType bool bool bool Bool
    // 051 IsHeader                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 058 ContextMenuItems                         000185D31C58 ModelEnumListType List`1<ContextMenuItem> List`1<ContextMenuItem> List<ContextMenuItem> Pointer
    // 060 ColumnLabels                             000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 068 ColumnTooltips                           000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer
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

            value.Opened                                    = GetBool(new IntPtr(p + 0x050)); // 0246691BA788 0x50 Opened                      ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.IsHeader                                  = GetBool(new IntPtr(p + 0x051)); // 0246691BA7A8 0x51 IsHeader                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ContextMenuItems                          = GetEnumList<ContextMenuItem>(new IntPtr(p + 0x058)); // 0246691BA7C8 0x58 ContextMenuItems            ( 000185D31C58 ModelEnumListType List`1<ContextMenuItem> List`1<ContextMenuItem> List<ContextMenuItem> Pointer )
            value.ColumnLabels                              = GetStringList(new IntPtr(p + 0x060)); // 0246691BA7E8 0x60 ColumnLabels                ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.ColumnTooltips                            = GetStringList(new IntPtr(p + 0x068)); // 0246691BA808 0x68 ColumnTooltips              ( 000185B815B0 ModelPrimitiveListType string[] string[] List<string> Pointer )

            return value;
        }
    }
}
