using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<MethodDescriptorProto> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 020 Name                                     ModelPrimitiveType string string string String
    // 000 InputTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 010 InputTypeDefaultValue                    ModelPrimitiveType string string string String
    // 028 InputType                                ModelPrimitiveType string string string String
    // 000 OutputTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 OutputTypeDefaultValue                   ModelPrimitiveType string string string String
    // 030 OutputType                               ModelPrimitiveType string string string String
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Options                                  ModelClassType MethodOptions MethodOptions MethodOptions Pointer
    // 000 ClientStreamingFieldNumber               int IL2CPP_TYPE_I4
    // 020 ClientStreamingDefaultValue              ModelPrimitiveType bool bool bool Bool
    // 040 ClientStreaming                          ModelPrimitiveType bool bool bool Bool
    // 000 ServerStreamingFieldNumber               int IL2CPP_TYPE_I4
    // 021 ServerStreamingDefaultValue              ModelPrimitiveType bool bool bool Bool
    // 041 ServerStreaming                          ModelPrimitiveType bool bool bool Bool
    public partial class MethodDescriptorProto : DataModel
    {
        public int                                      HasBits0                                { get; set; }
        public string                                   Name                                    { get; set; }
        public string                                   InputTypeDefaultValue                   { get; set; }
        public string                                   InputType                               { get; set; }
        public string                                   OutputTypeDefaultValue                  { get; set; }
        public string                                   OutputType                              { get; set; }
        public MethodOptions?                           Options                                 { get; set; }
        public bool                                     ClientStreamingDefaultValue             { get; set; }
        public bool                                     ClientStreaming                         { get; set; }
        public bool                                     ServerStreamingDefaultValue             { get; set; }
        public bool                                     ServerStreaming                         { get; set; }

        public static MethodDescriptorProto? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MethodDescriptorProto() { Pointer= p0 };

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 HasBits0                    ( ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 0x20 Name                        ( ModelPrimitiveType string string string String )
            value.InputTypeDefaultValue                     = GetString(new IntPtr(p + 0x010)); // 0x10 InputTypeDefaultValue       ( ModelPrimitiveType string string string String )
            value.InputType                                 = GetString(new IntPtr(p + 0x028)); // 0x28 InputType                   ( ModelPrimitiveType string string string String )
            value.OutputTypeDefaultValue                    = GetString(new IntPtr(p + 0x018)); // 0x18 OutputTypeDefaultValue      ( ModelPrimitiveType string string string String )
            value.OutputType                                = GetString(new IntPtr(p + 0x030)); // 0x30 OutputType                  ( ModelPrimitiveType string string string String )
            value.Options                                   = GetObject<MethodOptions>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodOptions.FromPointer); // 0x38 Options                     ( ModelClassType MethodOptions MethodOptions MethodOptions Pointer )
            value.ClientStreamingDefaultValue               = GetBool(new IntPtr(p + 0x020)); // 0x20 ClientStreamingDefaultValue ( ModelPrimitiveType bool bool bool Bool )
            value.ClientStreaming                           = GetBool(new IntPtr(p + 0x040)); // 0x40 ClientStreaming             ( ModelPrimitiveType bool bool bool Bool )
            value.ServerStreamingDefaultValue               = GetBool(new IntPtr(p + 0x021)); // 0x21 ServerStreamingDefaultValue ( ModelPrimitiveType bool bool bool Bool )
            value.ServerStreaming                           = GetBool(new IntPtr(p + 0x041)); // 0x41 ServerStreaming             ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
