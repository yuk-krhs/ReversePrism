using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilePathsData                            000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 TypesData                                000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 TotalTypes                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 024 TotalFiles                               0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 IsEditorOnly                             000186595960 ModelPrimitiveType bool bool bool Bool
    public partial class MonoScriptData
    {
        public List<sbyte>?                             FilePathsData                           { get; set; }
        public List<sbyte>?                             TypesData                               { get; set; }
        public int                                      TotalTypes                              { get; set; }
        public int                                      TotalFiles                              { get; set; }
        public bool                                     IsEditorOnly                            { get; set; }

        public static MonoScriptData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MonoScriptData();

            value.FilePathsData                             = GetSByteList(new IntPtr(p + 0x010)); // 0270DBF69F68 0x10 FilePathsData               ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TypesData                                 = GetSByteList(new IntPtr(p + 0x018)); // 0270DBF69F88 0x18 TypesData                   ( 000185B79C30 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TotalTypes                                = GetInt32(new IntPtr(p + 0x020)); // 0270DBF69FA8 0x20 TotalTypes                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.TotalFiles                                = GetInt32(new IntPtr(p + 0x024)); // 0270DBF69FC8 0x24 TotalFiles                  ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.IsEditorOnly                              = GetBool(new IntPtr(p + 0x028)); // 0270DBF69FE8 0x28 IsEditorOnly                ( 000186595960 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
