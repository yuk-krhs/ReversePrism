using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectInfoId                             ModelPrimitiveType int int int Int32
    // 000 readObjectInfoCounter                    int IL2CPP_TYPE_I4
    // 018 ObjectType                               ModelClassType Type Type Type Pointer
    // 020 ObjectManager                            ModelClassType ObjectManager ObjectManager ObjectManager Pointer
    // 028 Count                                    ModelPrimitiveType int int int Int32
    // 02C IsSi                                     ModelPrimitiveType bool bool bool Bool
    // 02D IsNamed                                  ModelPrimitiveType bool bool bool Bool
    // 02E IsTyped                                  ModelPrimitiveType bool bool bool Bool
    // 02F BSimpleAssembly                          ModelPrimitiveType bool bool bool Bool
    // 030 Cache                                    ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer
    // 038 WireMemberNames                          ModelPrimitiveListType string[] string[] List<string> Pointer
    // 040 WireMemberTypes                          ModelClassListType Type[] Type[] List<Type> Pointer
    // 048 LastPosition                             ModelPrimitiveType int int int Int32
    // 050 SerializationSurrogate                   ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 058 Context                                  ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 068 MemberTypesList                          ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer
    // 070 SerObjectInfoInit                        ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 078 FormatterConverter                       ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer
    public partial class ReadObjectInfo : DataModel
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
            var value   = new ReadObjectInfo() { Pointer= p0 };

            value.ObjectInfoId                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectInfoId                ( ModelPrimitiveType int int int Int32 )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x018), ReversePrism.DataModels.Type.FromPointer); // 0x18 ObjectType                  ( ModelClassType Type Type Type Pointer )
            value.ObjectManager                             = GetObject<ObjectManager>(new IntPtr(p + 0x020), ReversePrism.DataModels.ObjectManager.FromPointer); // 0x20 ObjectManager               ( ModelClassType ObjectManager ObjectManager ObjectManager Pointer )
            value.Count                                     = GetInt32(new IntPtr(p + 0x028)); // 0x28 Count                       ( ModelPrimitiveType int int int Int32 )
            value.IsSi                                      = GetBool(new IntPtr(p + 0x02C)); // 0x2C IsSi                        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNamed                                   = GetBool(new IntPtr(p + 0x02D)); // 0x2D IsNamed                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsTyped                                   = GetBool(new IntPtr(p + 0x02E)); // 0x2E IsTyped                     ( ModelPrimitiveType bool bool bool Bool )
            value.BSimpleAssembly                           = GetBool(new IntPtr(p + 0x02F)); // 0x2F BSimpleAssembly             ( ModelPrimitiveType bool bool bool Bool )
            value.Cache                                     = GetObject<SerObjectInfoCache>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerObjectInfoCache.FromPointer); // 0x30 Cache                       ( ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer )
            value.WireMemberNames                           = GetStringList(new IntPtr(p + 0x038)); // 0x38 WireMemberNames             ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.WireMemberTypes                           = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 WireMemberTypes             ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.LastPosition                              = GetInt32(new IntPtr(p + 0x048)); // 0x48 LastPosition                ( ModelPrimitiveType int int int Int32 )
            value.SerializationSurrogate                    = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x050), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0x50 SerializationSurrogate      ( ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x058)); // 0x58 Context                     ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.MemberTypesList                           = GetObjectList<Type>(new IntPtr(p + 0x068), ReversePrism.DataModels.Type.FromPointer); // 0x68 MemberTypesList             ( ModelClassListType List`1<Type> List`1<Type> List<Type> Pointer )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x070), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0x70 SerObjectInfoInit           ( ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.FormatterConverter                        = GetObject<IFormatterConverter>(new IntPtr(p + 0x078), ReversePrism.DataModels.IFormatterConverter.FromPointer); // 0x78 FormatterConverter          ( ModelClassType IFormatterConverter IFormatterConverter IFormatterConverter Pointer )

            return value;
        }
    }
}
