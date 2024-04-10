using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 defaultSize                              int IL2CPP_TYPE_I4
    // 000 s_mscorlibAssemblySimpleName             string IL2CPP_TYPE_STRING
    // 000 s_mscorlibFileName                       string IL2CPP_TYPE_STRING
    // 010 M_members                                000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 m_data                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 020 M_types                                  000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer
    // 028 m_nameToIndex                            Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 030 M_currMember                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 038 M_converter                              000186518A90 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    // 040 M_fullTypeName                           000186671910 ModelPrimitiveType string string string String
    // 048 M_assemName                              000186671910 ModelPrimitiveType string string string String
    // 050 ObjectType                               000186692850 ModelClassType Type Type Type Pointer
    // 058 IsFullTypeNameSetExplicit                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 059 IsAssemblyNameSetExplicit                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05A RequireSameTokenInPartialTrust           000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class SerializationInfo : DataModel
    {
        public List<string>?                            M_members                               { get; set; }
        public List<Type>?                              M_types                                 { get; set; }
        public int                                      M_currMember                            { get; set; }
        public IFormatterConverter?                     M_converter                             { get; set; }
        public string                                   M_fullTypeName                          { get; set; }
        public string                                   M_assemName                             { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public bool                                     IsFullTypeNameSetExplicit               { get; set; }
        public bool                                     IsAssemblyNameSetExplicit               { get; set; }
        public bool                                     RequireSameTokenInPartialTrust          { get; set; }

        public static SerializationInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SerializationInfo() { Pointer= p0 };

            value.M_members                                 = GetStringList(new IntPtr(p + 0x010)); // 0246669D8500 0x10 M_members                   ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_types                                   = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0246669D8540 0x20 M_types                     ( 000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.M_currMember                              = GetInt32(new IntPtr(p + 0x030)); // 0246669D8580 0x30 M_currMember                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_converter                               = GetObject<IFormatterConverter>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0246669D85A0 0x38 M_converter                 ( 000186518A90 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )
            value.M_fullTypeName                            = GetString(new IntPtr(p + 0x040)); // 0246669D85C0 0x40 M_fullTypeName              ( 000186671910 ModelPrimitiveType string string string String )
            value.M_assemName                               = GetString(new IntPtr(p + 0x048)); // 0246669D85E0 0x48 M_assemName                 ( 000186671910 ModelPrimitiveType string string string String )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0246669D8600 0x50 ObjectType                  ( 000186692850 ModelClassType Type Type Type Pointer )
            value.IsFullTypeNameSetExplicit                 = GetBool(new IntPtr(p + 0x058)); // 0246669D8620 0x58 IsFullTypeNameSetExplicit   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsAssemblyNameSetExplicit                 = GetBool(new IntPtr(p + 0x059)); // 0246669D8640 0x59 IsAssemblyNameSetExplicit   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequireSameTokenInPartialTrust            = GetBool(new IntPtr(p + 0x05A)); // 0246669D8660 0x5A RequireSameTokenInPartialTrust ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
