using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectInfoId                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 000 readObjectInfoCounter                    int IL2CPP_TYPE_I4
    // 018 ObjectType                               000186692A80 ModelClassType Type Type Type Pointer
    // 020 ObjectManager                            0001866C9860 ModelClassType ObjectManager ObjectManager ObjectManager Pointer
    // 028 Count                                    0001865F2F90 ModelPrimitiveType int int int Int32
    // 02C IsSi                                     000186595210 ModelPrimitiveType bool bool bool Bool
    // 02D IsNamed                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 02E IsTyped                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 02F BSimpleAssembly                          000186595210 ModelPrimitiveType bool bool bool Bool
    // 030 Cache                                    000186728880 ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer
    // 038 WireMemberNames                          000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 WireMemberTypes                          000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer
    // 048 LastPosition                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 050 SerializationSurrogate                   000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 058 Context                                  0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 068 MemberTypesList                          000185D16E68 ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer
    // 070 SerObjectInfoInit                        000186729020 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 078 FormatterConverter                       000186518A90 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    public partial class ReadObjectInfo
    {
        public int                                      ObjectInfoId                            { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public ObjectManager?                           ObjectManager                           { get; set; }
        public int                                      Count                                   { get; set; }
        public bool                                     IsSi                                    { get; set; }
        public bool                                     IsNamed                                 { get; set; }
        public bool                                     IsTyped                                 { get; set; }
        public bool                                     BSimpleAssembly                         { get; set; }
        public SerObjectInfoCache?                      Cache                                   { get; set; }
        public List<string>?                            WireMemberNames                         { get; set; }
        public List<Type>?                              WireMemberTypes                         { get; set; }
        public int                                      LastPosition                            { get; set; }
        public ISerializationSurrogate?                 SerializationSurrogate                  { get; set; }
        public StreamingContext                         Context                                 { get; set; }
        public List<Type>?                              MemberTypesList                         { get; set; }
        public SerObjectInfoInit?                       SerObjectInfoInit                       { get; set; }
        public IFormatterConverter?                     FormatterConverter                      { get; set; }

        public static ReadObjectInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReadObjectInfo();

            value.ObjectInfoId                              = GetInt32(new IntPtr(p + 0x010)); // 0270D6C34148 0x10 ObjectInfoId                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0270D6C34188 0x18 ObjectType                  ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.ObjectManager                             = GetObject<ObjectManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ObjectManager.FromPointer); // 0270D6C341A8 0x20 ObjectManager               ( 0001866C9860 ModelClassType ObjectManager ObjectManager ObjectManager Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x028)); // 0270D6C341C8 0x28 Count                       ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.IsSi                                      = GetBool(new IntPtr(p + 0x02C)); // 0270D6C341E8 0x2C IsSi                        ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsNamed                                   = GetBool(new IntPtr(p + 0x02D)); // 0270D6C34208 0x2D IsNamed                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsTyped                                   = GetBool(new IntPtr(p + 0x02E)); // 0270D6C34228 0x2E IsTyped                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.BSimpleAssembly                           = GetBool(new IntPtr(p + 0x02F)); // 0270D6C34248 0x2F BSimpleAssembly             ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Cache                                     = GetObject<SerObjectInfoCache>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerObjectInfoCache.FromPointer); // 0270D6C34268 0x30 Cache                       ( 000186728880 ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer )
            value.WireMemberNames                           = GetStringList(new IntPtr(p + 0x038)); // 0270D6C34288 0x38 WireMemberNames             ( 000185B81660 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.WireMemberTypes                           = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0270D6C342A8 0x40 WireMemberTypes             ( 000185B82D40 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.LastPosition                              = GetInt32(new IntPtr(p + 0x048)); // 0270D6C342C8 0x48 LastPosition                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.SerializationSurrogate                    = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0270D6C342E8 0x50 SerializationSurrogate      ( 000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x058)); // 0270D6C34308 0x58 Context                     ( 0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.MemberTypesList                           = GetObjectList<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 0270D6C34328 0x68 MemberTypesList             ( 000185D16E68 ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x070), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0270D6C34348 0x70 SerObjectInfoInit           ( 000186729020 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.FormatterConverter                        = GetObject<IFormatterConverter>(new IntPtr(p + 0x078), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0270D6C34368 0x78 FormatterConverter          ( 000186518A90 ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )

            return value;
        }
    }
}
