using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<File> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 018 Name                                     ModelPrimitiveType string string string String
    // 000 InsertionPointFieldNumber                int IL2CPP_TYPE_I4
    // 010 InsertionPointDefaultValue               ModelPrimitiveType string string string String
    // 020 InsertionPoint                           ModelPrimitiveType string string string String
    // 000 ContentFieldNumber                       int IL2CPP_TYPE_I4
    // 018 ContentDefaultValue                      ModelPrimitiveType string string string String
    // 028 Content                                  ModelPrimitiveType string string string String
    // 000 GeneratedCodeInfoFieldNumber             int IL2CPP_TYPE_I4
    // 030 GeneratedCodeInfo                        ModelClassType GeneratedCodeInfo GeneratedCodeInfo GeneratedCodeInfo Pointer
    public partial class File : DataModel
    {
        public string                                   Name                                    { get; set; }
        public string                                   InsertionPointDefaultValue              { get; set; }
        public string                                   InsertionPoint                          { get; set; }
        public string                                   ContentDefaultValue                     { get; set; }
        public string                                   Content                                 { get; set; }
        public GeneratedCodeInfo?                       GeneratedCodeInfo                       { get; set; }

        public static File? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new File() { Pointer= p0 };

            value.Name                                      = GetString(new IntPtr(p + 0x018)); // 0x18 Name                        ( ModelPrimitiveType string string string String )
            value.InsertionPointDefaultValue                = GetString(new IntPtr(p + 0x010)); // 0x10 InsertionPointDefaultValue  ( ModelPrimitiveType string string string String )
            value.InsertionPoint                            = GetString(new IntPtr(p + 0x020)); // 0x20 InsertionPoint              ( ModelPrimitiveType string string string String )
            value.ContentDefaultValue                       = GetString(new IntPtr(p + 0x018)); // 0x18 ContentDefaultValue         ( ModelPrimitiveType string string string String )
            value.Content                                   = GetString(new IntPtr(p + 0x028)); // 0x28 Content                     ( ModelPrimitiveType string string string String )
            value.GeneratedCodeInfo                         = GetObject<GeneratedCodeInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.GeneratedCodeInfo.FromPointer); // 0x30 GeneratedCodeInfo           ( ModelClassType GeneratedCodeInfo GeneratedCodeInfo GeneratedCodeInfo Pointer )

            return value;
        }
    }
}
