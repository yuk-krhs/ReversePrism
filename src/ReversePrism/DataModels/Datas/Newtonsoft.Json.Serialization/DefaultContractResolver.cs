using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _instance                                IContractResolver IL2CPP_TYPE_CLASS
    // 008 BlacklistedTypeNames                     string[] IL2CPP_TYPE_SZARRAY
    // 010 BuiltInConverters                        ModelClassListType JsonConverter[] JsonConverter[] List<JsonConverter> Pointer
    // 010 NameTable                                ModelClassType DefaultJsonNameTable DefaultJsonNameTable DefaultJsonNameTable Pointer
    // 018 _contractCache                           ThreadSafeStore`2<Type, JsonContract> IL2CPP_TYPE_GENERICINST
    // 020 DefaultMembersSearchFlags                ModelEnumType BindingFlags BindingFlags BindingFlags Int32
    // 024 SerializeCompilerGeneratedMembers        ModelPrimitiveType bool bool bool Bool
    // 025 IgnoreSerializableInterface              ModelPrimitiveType bool bool bool Bool
    // 026 IgnoreSerializableAttribute              ModelPrimitiveType bool bool bool Bool
    // 027 IgnoreIsSpecifiedMembers                 ModelPrimitiveType bool bool bool Bool
    // 028 IgnoreShouldSerializeMembers             ModelPrimitiveType bool bool bool Bool
    // 030 NamingStrategy                           ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer
    public partial class DefaultContractResolver : DataModel
    {
        public List<JsonConverter>?                     BuiltInConverters                       { get; set; }
        public DefaultJsonNameTable?                    NameTable                               { get; set; }
        public BindingFlags                             DefaultMembersSearchFlags               { get; set; }
        public bool                                     SerializeCompilerGeneratedMembers       { get; set; }
        public bool                                     IgnoreSerializableInterface             { get; set; }
        public bool                                     IgnoreSerializableAttribute             { get; set; }
        public bool                                     IgnoreIsSpecifiedMembers                { get; set; }
        public bool                                     IgnoreShouldSerializeMembers            { get; set; }
        public NamingStrategy?                          NamingStrategy                          { get; set; }

        public static DefaultContractResolver? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DefaultContractResolver() { Pointer= p0 };

            value.BuiltInConverters                         = GetObjectList<JsonConverter>(new IntPtr(p + 0x010), ReversePrism.DataModels.JsonConverter.FromPointer); // 0x10 BuiltInConverters           ( ModelClassListType JsonConverter[] JsonConverter[] List<JsonConverter> Pointer )
            value.NameTable                                 = GetObject<DefaultJsonNameTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DefaultJsonNameTable.FromPointer); // 0x10 NameTable                   ( ModelClassType DefaultJsonNameTable DefaultJsonNameTable DefaultJsonNameTable Pointer )
            value.DefaultMembersSearchFlags                 = (BindingFlags)GetInt32(new IntPtr(p + 0x020)); // 0x20 DefaultMembersSearchFlags   ( ModelEnumType BindingFlags BindingFlags BindingFlags Int32 )
            value.SerializeCompilerGeneratedMembers         = GetBool(new IntPtr(p + 0x024)); // 0x24 SerializeCompilerGeneratedMembers ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreSerializableInterface               = GetBool(new IntPtr(p + 0x025)); // 0x25 IgnoreSerializableInterface ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreSerializableAttribute               = GetBool(new IntPtr(p + 0x026)); // 0x26 IgnoreSerializableAttribute ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreIsSpecifiedMembers                  = GetBool(new IntPtr(p + 0x027)); // 0x27 IgnoreIsSpecifiedMembers    ( ModelPrimitiveType bool bool bool Bool )
            value.IgnoreShouldSerializeMembers              = GetBool(new IntPtr(p + 0x028)); // 0x28 IgnoreShouldSerializeMembers ( ModelPrimitiveType bool bool bool Bool )
            value.NamingStrategy                            = GetObject<NamingStrategy>(new IntPtr(p + 0x030), ReversePrism.DataModels.NamingStrategy.FromPointer); // 0x30 NamingStrategy              ( ModelClassType NamingStrategy NamingStrategy NamingStrategy Pointer )

            return value;
        }
    }
}
