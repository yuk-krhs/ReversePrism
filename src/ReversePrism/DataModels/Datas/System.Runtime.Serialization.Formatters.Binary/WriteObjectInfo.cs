using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectInfoId                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 obj                                      <object> IL2CPP_TYPE_OBJECT
    // 020 ObjectType                               000186692A80 ModelClassType Type Type Type Pointer
    // 028 IsSi                                     000186595210 ModelPrimitiveType bool bool bool Bool
    // 029 IsNamed                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 02A IsTyped                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 02B IsArray                                  000186595210 ModelPrimitiveType bool bool bool Bool
    // 030 Si                                       000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 038 Cache                                    000186728880 ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer
    // 040 memberData                               <object>[] IL2CPP_TYPE_SZARRAY
    // 048 SerializationSurrogate                   000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 050 Context                                  0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32
    // 060 SerObjectInfoInit                        000186729020 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer
    // 068 ObjectId                                 0001865F79C0 ModelPrimitiveType long long long Int64
    // 070 AssemId                                  0001865F79C0 ModelPrimitiveType long long long Int64
    // 078 BinderTypeName                           000186671910 ModelPrimitiveType string string string String
    // 080 BinderAssemblyString                     000186671910 ModelPrimitiveType string string string String
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

            value.ObjectInfoId                              = GetInt32(new IntPtr(p + 0x010)); // 024666C9B7E8 0x10 ObjectInfoId                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.ObjectType                                = GetObject<Type>(new IntPtr(p + 0x020), ReversePrism.DataModels.Type.FromPointer); // 024666C9B828 0x20 ObjectType                  ( 000186692A80 ModelClassType Type Type Type Pointer )
            value.IsSi                                      = GetBool(new IntPtr(p + 0x028)); // 024666C9B848 0x28 IsSi                        ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsNamed                                   = GetBool(new IntPtr(p + 0x029)); // 024666C9B868 0x29 IsNamed                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsTyped                                   = GetBool(new IntPtr(p + 0x02A)); // 024666C9B888 0x2A IsTyped                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.IsArray                                   = GetBool(new IntPtr(p + 0x02B)); // 024666C9B8A8 0x2B IsArray                     ( 000186595210 ModelPrimitiveType bool bool bool Bool )
            value.Si                                        = GetObject<SerializationInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.SerializationInfo.FromPointer); // 024666C9B8C8 0x30 Si                          ( 000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.Cache                                     = GetObject<SerObjectInfoCache>(new IntPtr(p + 0x038), ReversePrism.DataModels.SerObjectInfoCache.FromPointer); // 024666C9B8E8 0x38 Cache                       ( 000186728880 ModelClassType SerObjectInfoCache SerObjectInfoCache SerObjectInfoCache Pointer )
            value.SerializationSurrogate                    = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x048), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 024666C9B928 0x48 SerializationSurrogate      ( 000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.Context                                   = (StreamingContext)GetInt32(new IntPtr(p + 0x050)); // 024666C9B948 0x50 Context                     ( 0001865B8F40 ModelEnumType StreamingContext StreamingContext StreamingContext Int32 )
            value.SerObjectInfoInit                         = GetObject<SerObjectInfoInit>(new IntPtr(p + 0x060), ReversePrism.DataModels.SerObjectInfoInit.FromPointer); // 024666C9B968 0x60 SerObjectInfoInit           ( 000186729020 ModelClassType SerObjectInfoInit SerObjectInfoInit SerObjectInfoInit Pointer )
            value.ObjectId                                  = GetInt64(new IntPtr(p + 0x068)); // 024666C9B988 0x68 ObjectId                    ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.AssemId                                   = GetInt64(new IntPtr(p + 0x070)); // 024666C9B9A8 0x70 AssemId                     ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.BinderTypeName                            = GetString(new IntPtr(p + 0x078)); // 024666C9B9C8 0x78 BinderTypeName              ( 000186671910 ModelPrimitiveType string string string String )
            value.BinderAssemblyString                      = GetString(new IntPtr(p + 0x080)); // 024666C9B9E8 0x80 BinderAssemblyString        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
