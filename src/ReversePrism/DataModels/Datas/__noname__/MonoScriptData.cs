using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 FilePathsData                            ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 TypesData                                ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 TotalTypes                               ModelPrimitiveType int int int Int32
    // 024 TotalFiles                               ModelPrimitiveType int int int Int32
    // 028 IsEditorOnly                             ModelPrimitiveType bool bool bool Bool
    public partial class MonoScriptData : DataModel
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
            var value   = new MonoScriptData() { Pointer= p0 };

            value.FilePathsData                             = GetSByteList(new IntPtr(p + 0x010)); // 0x10 FilePathsData               ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TypesData                                 = GetSByteList(new IntPtr(p + 0x018)); // 0x18 TypesData                   ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.TotalTypes                                = GetInt32(new IntPtr(p + 0x020)); // 0x20 TotalTypes                  ( ModelPrimitiveType int int int Int32 )
            value.TotalFiles                                = GetInt32(new IntPtr(p + 0x024)); // 0x24 TotalFiles                  ( ModelPrimitiveType int int int Int32 )
            value.IsEditorOnly                              = GetBool(new IntPtr(p + 0x028)); // 0x28 IsEditorOnly                ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
