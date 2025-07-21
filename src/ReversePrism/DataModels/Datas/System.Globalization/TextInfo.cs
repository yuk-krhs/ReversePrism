using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 M_listSeparator                          ModelPrimitiveType string string string String
    // 018 M_isReadOnly                             ModelPrimitiveType bool bool bool Bool
    // 020 M_cultureName                            ModelPrimitiveType string string string String
    // 028 M_cultureData                            ModelClassType CultureData CultureData CultureData Pointer
    // 030 M_textInfoName                           ModelPrimitiveType string string string String
    // 038 m_IsAsciiCasingSameAsInvariant           Nullable`1<bool> IL2CPP_TYPE_GENERICINST
    // 000 s_Invariant                              TextInfo IL2CPP_TYPE_CLASS
    // 040 CustomCultureName                        ModelPrimitiveType string string string String
    // 048 M_nDataItem                              ModelPrimitiveType int int int Int32
    // 04C M_useUserOverride                        ModelPrimitiveType bool bool bool Bool
    // 050 M_win32LangID                            ModelPrimitiveType int int int Int32
    // 000 wordSeparatorMask                        int IL2CPP_TYPE_I4
    public partial class TextInfo : DataModel
    {
        public string                                   M_listSeparator                         { get; set; }
        public bool                                     M_isReadOnly                            { get; set; }
        public string                                   M_cultureName                           { get; set; }
        public CultureData?                             M_cultureData                           { get; set; }
        public string                                   M_textInfoName                          { get; set; }
        public string                                   CustomCultureName                       { get; set; }
        public int                                      M_nDataItem                             { get; set; }
        public bool                                     M_useUserOverride                       { get; set; }
        public int                                      M_win32LangID                           { get; set; }

        public static TextInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new TextInfo() { Pointer= p0 };

            value.M_listSeparator                           = GetString(new IntPtr(p + 0x010)); // 0x10 M_listSeparator             ( ModelPrimitiveType string string string String )
            value.M_isReadOnly                              = GetBool(new IntPtr(p + 0x018)); // 0x18 M_isReadOnly                ( ModelPrimitiveType bool bool bool Bool )
            value.M_cultureName                             = GetString(new IntPtr(p + 0x020)); // 0x20 M_cultureName               ( ModelPrimitiveType string string string String )
            value.M_cultureData                             = GetObject<CultureData>(new IntPtr(p + 0x028), ReversePrism.DataModels.CultureData.FromPointer); // 0x28 M_cultureData               ( ModelClassType CultureData CultureData CultureData Pointer )
            value.M_textInfoName                            = GetString(new IntPtr(p + 0x030)); // 0x30 M_textInfoName              ( ModelPrimitiveType string string string String )
            value.CustomCultureName                         = GetString(new IntPtr(p + 0x040)); // 0x40 CustomCultureName           ( ModelPrimitiveType string string string String )
            value.M_nDataItem                               = GetInt32(new IntPtr(p + 0x048)); // 0x48 M_nDataItem                 ( ModelPrimitiveType int int int Int32 )
            value.M_useUserOverride                         = GetBool(new IntPtr(p + 0x04C)); // 0x4C M_useUserOverride           ( ModelPrimitiveType bool bool bool Bool )
            value.M_win32LangID                             = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_win32LangID               ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
