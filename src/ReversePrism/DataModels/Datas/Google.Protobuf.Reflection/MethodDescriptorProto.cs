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
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 NameFieldNumber                          int IL2CPP_TYPE_I4
    // 008 NameDefaultValue                         string IL2CPP_TYPE_STRING
    // 020 Name                                     000186671910 ModelPrimitiveType string string string String
    // 000 InputTypeFieldNumber                     int IL2CPP_TYPE_I4
    // 010 InputTypeDefaultValue                    0001866738F0 ModelPrimitiveType string string string String
    // 028 InputType                                000186671910 ModelPrimitiveType string string string String
    // 000 OutputTypeFieldNumber                    int IL2CPP_TYPE_I4
    // 018 OutputTypeDefaultValue                   0001866738F0 ModelPrimitiveType string string string String
    // 030 OutputType                               000186671910 ModelPrimitiveType string string string String
    // 000 OptionsFieldNumber                       int IL2CPP_TYPE_I4
    // 038 Options                                  000186611FC0 ModelClassType MethodOptions MethodOptions MethodOptions Pointer
    // 000 ClientStreamingFieldNumber               int IL2CPP_TYPE_I4
    // 020 ClientStreamingDefaultValue              000186596D40 ModelPrimitiveType bool bool bool Bool
    // 040 ClientStreaming                          000186594D10 ModelPrimitiveType bool bool bool Bool
    // 000 ServerStreamingFieldNumber               int IL2CPP_TYPE_I4
    // 021 ServerStreamingDefaultValue              000186596D40 ModelPrimitiveType bool bool bool Bool
    // 041 ServerStreaming                          000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 024660B9DC78 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Name                                      = GetString(new IntPtr(p + 0x020)); // 024660B9DCD8 0x20 Name                        ( 000186671910 ModelPrimitiveType string string string String )
            value.InputTypeDefaultValue                     = GetString(new IntPtr(p + 0x010)); // 024660B9DD18 0x10 InputTypeDefaultValue       ( 0001866738F0 ModelPrimitiveType string string string String )
            value.InputType                                 = GetString(new IntPtr(p + 0x028)); // 024660B9DD38 0x28 InputType                   ( 000186671910 ModelPrimitiveType string string string String )
            value.OutputTypeDefaultValue                    = GetString(new IntPtr(p + 0x018)); // 024660B9DD78 0x18 OutputTypeDefaultValue      ( 0001866738F0 ModelPrimitiveType string string string String )
            value.OutputType                                = GetString(new IntPtr(p + 0x030)); // 024660B9DD98 0x30 OutputType                  ( 000186671910 ModelPrimitiveType string string string String )
            value.Options                                   = GetObject<MethodOptions>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodOptions.FromPointer); // 024660B9DDD8 0x38 Options                     ( 000186611FC0 ModelClassType MethodOptions MethodOptions MethodOptions Pointer )
            value.ClientStreamingDefaultValue               = GetBool(new IntPtr(p + 0x020)); // 024660B9DE18 0x20 ClientStreamingDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.ClientStreaming                           = GetBool(new IntPtr(p + 0x040)); // 024660B9DE38 0x40 ClientStreaming             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ServerStreamingDefaultValue               = GetBool(new IntPtr(p + 0x021)); // 024660B9DE78 0x21 ServerStreamingDefaultValue ( 000186596D40 ModelPrimitiveType bool bool bool Bool )
            value.ServerStreaming                           = GetBool(new IntPtr(p + 0x041)); // 024660B9DE98 0x41 ServerStreaming             ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
