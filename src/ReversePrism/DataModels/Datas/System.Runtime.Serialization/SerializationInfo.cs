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
    // 010 M_members                                ModelPrimitiveListType string[] string[] List<string> Pointer
    // 018 m_data                                   <object>[] IL2CPP_TYPE_SZARRAY
    // 020 M_types                                  ModelClassListType Type[] Type[] List<Type> Pointer
    // 028 m_nameToIndex                            Dictionary`2<string, int> IL2CPP_TYPE_GENERICINST
    // 030 M_currMember                             ModelPrimitiveType int int int Int32
    // 038 M_converter                              ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    // 040 M_fullTypeName                           ModelPrimitiveType string string string String
    // 048 M_assemName                              ModelPrimitiveType string string string String
    // 050 ObjectType                               ModelClassType Type Type Type Pointer
    // 058 IsFullTypeNameSetExplicit                ModelPrimitiveType bool bool bool Bool
    // 059 IsAssemblyNameSetExplicit                ModelPrimitiveType bool bool bool Bool
    // 05A RequireSameTokenInPartialTrust           ModelPrimitiveType bool bool bool Bool
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

            value.M_members                                 = GetStringList(new IntPtr(p + 0x010)); // 0x10 M_members                   ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.M_types                                   = GetObjectList<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 M_types                     ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.M_currMember                              = GetInt32(new IntPtr(p + 0x030)); // 0x30 M_currMember                ( ModelPrimitiveType int int int Int32 )
            value.M_converter                               = GetObject<IFormatterConverter>(new IntPtr(p + 0x038), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0x38 M_converter                 ( ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )
            value.M_fullTypeName                            = GetString(new IntPtr(p + 0x040)); // 0x40 M_fullTypeName              ( ModelPrimitiveType string string string String )
            value.M_assemName                               = GetString(new IntPtr(p + 0x048)); // 0x48 M_assemName                 ( ModelPrimitiveType string string string String )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x050), ReversePrism.DataModels.Type.FromPointer); // 0x50 ObjectType                  ( ModelClassType Type Type Type Pointer )
            value.IsFullTypeNameSetExplicit                 = GetBool(new IntPtr(p + 0x058)); // 0x58 IsFullTypeNameSetExplicit   ( ModelPrimitiveType bool bool bool Bool )
            value.IsAssemblyNameSetExplicit                 = GetBool(new IntPtr(p + 0x059)); // 0x59 IsAssemblyNameSetExplicit   ( ModelPrimitiveType bool bool bool Bool )
            value.RequireSameTokenInPartialTrust            = GetBool(new IntPtr(p + 0x05A)); // 0x5A RequireSameTokenInPartialTrust ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
