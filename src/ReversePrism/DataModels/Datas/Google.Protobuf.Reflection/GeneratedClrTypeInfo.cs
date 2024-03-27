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
    // 010 EmptyExtensions                          000185B7DF40 ModelClassListType Extension[] Extension[] List<Extension> Pointer
    // 010 ClrType                                  000186692850 ModelClassType Type Type Type Pointer
    // 018 Parser                                   0001866090C0 ModelClassType MessageParser MessageParser MessageParser Pointer
    // 020 PropertyNames                            000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 028 Extensions                               000185B7DE60 ModelClassListType Extension[] Extension[] List<Extension> Pointer
    // 030 OneofNames                               000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer
    // 038 NestedTypes                              000185B82030 ModelClassListType GeneratedClrTypeInfo[] GeneratedClrTypeInfo[] List<GeneratedClrTypeInfo> Pointer
    // 040 NestedEnums                              000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class GeneratedClrTypeInfo
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
            var value   = new GeneratedClrTypeInfo();

            value.EmptyExtensions                           = GetObjectList<Extension>(new IntPtr(p + 0x010), ReversePrism.DataModels.Extension.FromPointer); // 027003B07998 0x10 EmptyExtensions             ( 000185B7DF40 ModelClassListType Extension[] Extension[] List<Extension> Pointer )
            value.ClrType                                   = GetObject<Type>(new IntPtr(p + 0x010), ReversePrism.DataModels.Type.FromPointer); // 027003B079B8 0x10 ClrType                     ( 000186692850 ModelClassType Type Type Type Pointer )
            value.Parser                                    = GetObject<MessageParser>(new IntPtr(p + 0x018), ReversePrism.DataModels.MessageParser.FromPointer); // 027003B079D8 0x18 Parser                      ( 0001866090C0 ModelClassType MessageParser MessageParser MessageParser Pointer )
            value.PropertyNames                             = GetStringList(new IntPtr(p + 0x020)); // 027003B079F8 0x20 PropertyNames               ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.Extensions                                = GetObjectList<Extension>(new IntPtr(p + 0x028), ReversePrism.DataModels.Extension.FromPointer); // 027003B07A18 0x28 Extensions                  ( 000185B7DE60 ModelClassListType Extension[] Extension[] List<Extension> Pointer )
            value.OneofNames                                = GetStringList(new IntPtr(p + 0x030)); // 027003B07A38 0x30 OneofNames                  ( 000185B81DA0 ModelPrimitiveListType string[] string[] List<string> Pointer )
            value.NestedTypes                               = GetObjectList<GeneratedClrTypeInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.GeneratedClrTypeInfo.FromPointer); // 027003B07A58 0x38 NestedTypes                 ( 000185B82030 ModelClassListType GeneratedClrTypeInfo[] GeneratedClrTypeInfo[] List<GeneratedClrTypeInfo> Pointer )
            value.NestedEnums                               = GetObjectList<Type>(new IntPtr(p + 0x040), ReversePrism.DataModels.Type.FromPointer); // 027003B07A78 0x40 NestedEnums                 ( 000185B83050 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
