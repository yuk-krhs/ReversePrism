using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectInfoId                             ModelPrimitiveType int int int Int32
    // 018 obj                                      <object> IL2CPP_TYPE_OBJECT
    // 020 ObjectType                               ModelClassType Type Type Type Pointer
    // 028 IsSi                                     ModelPrimitiveType bool bool bool Bool
    // 029 IsNamed                                  ModelPrimitiveType bool bool bool Bool
    // 02A IsTyped                                  ModelPrimitiveType bool bool bool Bool
    // 02B IsArray                                  ModelPrimitiveType bool bool bool Bool
    // 030 Si                                       ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 038 Cache                                    ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer
    // 040 memberData                               <object>[] IL2CPP_TYPE_SZARRAY
    // 048 SerializationSurrogate                   ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 050 Context                                  ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 060 SerObjectInfoInit                        ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 068 ObjectId                                 ModelPrimitiveType long long long Int64
    // 070 AssemId                                  ModelPrimitiveType long long long Int64
    // 078 BinderTypeName                           ModelPrimitiveType string string string String
    // 080 BinderAssemblyString                     ModelPrimitiveType string string string String
    public partial class WriteObjectInfo : DataModel
    {
        public int                                      ObjectInfoId                            { get; set; }
        public Type?                                    ObjectType                              { get; set; }
        public bool                                     IsSi                                    { get; set; }
        public bool                                     IsNamed                                 { get; set; }
        public bool                                     IsTyped                                 { get; set; }
        public bool                                     IsArray                                 { get; set; }
        public SerializationInfo?                       Si                                      { get; set; }
        public SerObjectInfoCache?                      Cache                                   { get; set; }
        public ISerializationSurrogate?                 SerializationSurrogate                  { get; set; }
        public StreamingContext                         Context                                 { get; set; }
        public SerObjectInfoInit?                       SerObjectInfoInit                       { get; set; }
        public long                                     ObjectId                                { get; set; }
        public long                                     AssemId                                 { get; set; }
        public string                                   BinderTypeName                          { get; set; }
        public string                                   BinderAssemblyString                    { get; set; }

        public static WriteObjectInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WriteObjectInfo() { Pointer= p0 };

            value.ObjectInfoId                              = GetInt32(new IntPtr(p + 0x010)); // 0x10 ObjectInfoId                ( ModelPrimitiveType int int int Int32 )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 0x20 ObjectType                  ( ModelClassType Type Type Type Pointer )
            value.IsSi                                      = GetBool(new IntPtr(p + 0x028)); // 0x28 IsSi                        ( ModelPrimitiveType bool bool bool Bool )
            value.IsNamed                                   = GetBool(new IntPtr(p + 0x029)); // 0x29 IsNamed                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsTyped                                   = GetBool(new IntPtr(p + 0x02A)); // 0x2A IsTyped                     ( ModelPrimitiveType bool bool bool Bool )
            value.IsArray                                   = GetBool(new IntPtr(p + 0x02B)); // 0x2B IsArray                     ( ModelPrimitiveType bool bool bool Bool )
            value.Si                                        = GetObject<SerializationInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x30 Si                          ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.Cache                                     = GetObject<SerObjectInfoCache>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerObjectInfoCache.FromPointer); // 0x38 Cache                       ( ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer )
            value.SerializationSurrogate                    = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0x48 SerializationSurrogate      ( ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x050)); // 0x50 Context                     ( ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 0x60 SerObjectInfoInit           ( ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.ObjectId                                  = GetInt64(new IntPtr(p + 0x068)); // 0x68 ObjectId                    ( ModelPrimitiveType long long long Int64 )
            value.AssemId                                   = GetInt64(new IntPtr(p + 0x070)); // 0x70 AssemId                     ( ModelPrimitiveType long long long Int64 )
            value.BinderTypeName                            = GetString(new IntPtr(p + 0x078)); // 0x78 BinderTypeName              ( ModelPrimitiveType string string string String )
            value.BinderAssemblyString                      = GetString(new IntPtr(p + 0x080)); // 0x80 BinderAssemblyString        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
