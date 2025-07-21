using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 EmptyNames                               string[] IL2CPP_TYPE_SZARRAY
    // 008 EmptyCodeInfo                            GeneratedClrTypeInfo[] IL2CPP_TYPE_SZARRAY
    // 010 EmptyExtensions                          ModelClassListType Extension[] Extension[] List<Extension> Pointer
    // 000 MessageAccessibility                     DynamicallyAccessedMemberTypes IL2CPP_TYPE_VALUETYPE
    // 010 ClrType                                  ModelClassType Type Type Type Pointer
    // 018 Parser                                   ModelClassType MessageParser MessageParser MessageParser Pointer
    // 020 PropertyNames                            ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Extensions                               ModelClassListType Extension[] Extension[] List<Extension> Pointer
    // 030 OneofNames                               ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 NestedTypes                              ModelClassListType GeneratedClrTypeInfo[] GeneratedClrTypeInfo[] List<GeneratedClrTypeInfo> Pointer
    // 040 NestedEnums                              ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class GeneratedClrTypeInfo : DataModel
    {
        public List<Extension>?                         EmptyExtensions                         { get; set; }
        public Type?                                    ClrType                                 { get; set; }
        public MessageParser?                           Parser                                  { get; set; }
        public List<string>?                            PropertyNames                           { get; set; }
        public List<Extension>?                         Extensions                              { get; set; }
        public List<string>?                            OneofNames                              { get; set; }
        public List<GeneratedClrTypeInfo>?              NestedTypes                             { get; set; }
        public List<Type>?                              NestedEnums                             { get; set; }

        public static GeneratedClrTypeInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GeneratedClrTypeInfo() { Pointer= p0 };

            value.EmptyExtensions                           = GetObjectList<Extension>(new IntPtr(p + 0x010), ReversePrism.DataModels.Extension.FromPointer); // 0x10 EmptyExtensions             ( ModelClassListType Extension[] Extension[] List<Extension> Pointer )
            value.ClrType                                   = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 0x10 ClrType                     ( ModelClassType Type Type Type Pointer )
            value.Parser                                    = GetObject<MessageParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.MessageParser.FromPointer); // 0x18 Parser                      ( ModelClassType MessageParser MessageParser MessageParser Pointer )
            value.PropertyNames                             = GetStringList(new IntPtr(p + 0x020)); // 0x20 PropertyNames               ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Extensions                                = GetObjectList<Extension>(new IntPtr(p + 0x028), ReversePrism.DataModels.Extension.FromPointer); // 0x28 Extensions                  ( ModelClassListType Extension[] Extension[] List<Extension> Pointer )
            value.OneofNames                                = GetStringList(new IntPtr(p + 0x030)); // 0x30 OneofNames                  ( ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NestedTypes                               = GetObjectList<GeneratedClrTypeInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.GeneratedClrTypeInfo.FromPointer); // 0x38 NestedTypes                 ( ModelClassListType GeneratedClrTypeInfo[] GeneratedClrTypeInfo[] List<GeneratedClrTypeInfo> Pointer )
            value.NestedEnums                               = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 0x40 NestedEnums                 ( ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
