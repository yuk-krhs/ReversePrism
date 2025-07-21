using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Declaration> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 NumberFieldNumber                        int IL2CPP_TYPE_I4
    // 008 NumberDefaultValue                       int IL2CPP_TYPE_I4
    // 01C Number                                   ModelPrimitiveType int int int Int32
    // 000 FullNameFieldNumber                      int IL2CPP_TYPE_I4
    // 010 FullNameDefaultValue                     ModelPrimitiveType string string string String
    // 020 FullName                                 ModelPrimitiveType string string string String
    // 000 TypeFieldNumber                          int IL2CPP_TYPE_I4
    // 018 TypeDefaultValue                         ModelPrimitiveType string string string String
    // 028 Type                                     ModelPrimitiveType string string string String
    // 000 ReservedFieldNumber                      int IL2CPP_TYPE_I4
    // 020 ReservedDefaultValue                     ModelPrimitiveType bool bool bool Bool
    // 030 Reserved                                 ModelPrimitiveType bool bool bool Bool
    // 000 RepeatedFieldNumber                      int IL2CPP_TYPE_I4
    // 021 RepeatedDefaultValue                     ModelPrimitiveType bool bool bool Bool
    // 031 Repeated                                 ModelPrimitiveType bool bool bool Bool
    public partial class Declaration : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public int                                      Number                                  { get; set; }
        public string                                   FullNameDefaultValue                    { get; set; }
        public string                                   FullName                                { get; set; }
        public string                                   TypeDefaultValue                        { get; set; }
        public string                                   Type                                    { get; set; }
        public bool                                     ReservedDefaultValue                    { get; set; }
        public bool                                     Reserved                                { get; set; }
        public bool                                     RepeatedDefaultValue                    { get; set; }
        public bool                                     Repeated                                { get; set; }

        public static Declaration? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Declaration() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Number                                    = GetInt32(new IntPtr(p + 0x01C)); // 0x1C Number                      ( ModelPrimitiveType int int int Int32 )
            value.FullNameDefaultValue                      = GetString(new IntPtr(p + 0x010)); // 0x10 FullNameDefaultValue        ( ModelPrimitiveType string string string String )
            value.FullName                                  = GetString(new IntPtr(p + 0x020)); // 0x20 FullName                    ( ModelPrimitiveType string string string String )
            value.TypeDefaultValue                          = GetString(new IntPtr(p + 0x018)); // 0x18 TypeDefaultValue            ( ModelPrimitiveType string string string String )
            value.Type                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Type                        ( ModelPrimitiveType string string string String )
            value.ReservedDefaultValue                      = GetBool(new IntPtr(p + 0x020)); // 0x20 ReservedDefaultValue        ( ModelPrimitiveType bool bool bool Bool )
            value.Reserved                                  = GetBool(new IntPtr(p + 0x030)); // 0x30 Reserved                    ( ModelPrimitiveType bool bool bool Bool )
            value.RepeatedDefaultValue                      = GetBool(new IntPtr(p + 0x021)); // 0x21 RepeatedDefaultValue        ( ModelPrimitiveType bool bool bool Bool )
            value.Repeated                                  = GetBool(new IntPtr(p + 0x031)); // 0x31 Repeated                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
