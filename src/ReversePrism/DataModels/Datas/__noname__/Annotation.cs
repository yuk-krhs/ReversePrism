using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<Annotation> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 018 HasBits0                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 PathFieldNumber                          int IL2CPP_TYPE_I4
    // 008 _repeated_path_codec                     FieldCodec`1<int> IL2CPP_TYPE_GENERICINST
    // 020 Path                                     000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer
    // 000 SourceFileFieldNumber                    int IL2CPP_TYPE_I4
    // 010 SourceFileDefaultValue                   0001866738F0 ModelPrimitiveType string string string String
    // 028 SourceFile                               000186671910 ModelPrimitiveType string string string String
    // 000 BeginFieldNumber                         int IL2CPP_TYPE_I4
    // 018 BeginDefaultValue                        0001865F4BC0 ModelPrimitiveType int int int Int32
    // 030 Begin                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 EndFieldNumber                           int IL2CPP_TYPE_I4
    // 01C EndDefaultValue                          0001865F4BC0 ModelPrimitiveType int int int Int32
    // 034 End                                      0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class Annotation
    {
        public int                                      HasBits0                                { get; set; }
        public List<int>?                               Path                                    { get; set; }
        public string                                   SourceFileDefaultValue                  { get; set; }
        public string                                   SourceFile                              { get; set; }
        public int                                      BeginDefaultValue                       { get; set; }
        public int                                      Begin                                   { get; set; }
        public int                                      EndDefaultValue                         { get; set; }
        public int                                      End                                     { get; set; }

        public static Annotation? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Annotation();

            value.HasBits0                                  = GetInt32(new IntPtr(p + 0x018)); // 0270D0B83CF0 0x18 HasBits0                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Path                                      = GetInt32List(new IntPtr(p + 0x020)); // 0270D0B83D50 0x20 Path                        ( 000185CE1CE8 ModelPrimitiveListType RepeatedField`1<int> RepeatedField`1<int> List<int> Pointer )
            value.SourceFileDefaultValue                    = GetString(new IntPtr(p + 0x010)); // 0270D0B83D90 0x10 SourceFileDefaultValue      ( 0001866738F0 ModelPrimitiveType string string string String )
            value.SourceFile                                = GetString(new IntPtr(p + 0x028)); // 0270D0B83DB0 0x28 SourceFile                  ( 000186671910 ModelPrimitiveType string string string String )
            value.BeginDefaultValue                         = GetInt32(new IntPtr(p + 0x018)); // 0270D0B83DF0 0x18 BeginDefaultValue           ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.Begin                                     = GetInt32(new IntPtr(p + 0x030)); // 0270D0B83E10 0x30 Begin                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.EndDefaultValue                           = GetInt32(new IntPtr(p + 0x01C)); // 0270D0B83E50 0x1C EndDefaultValue             ( 0001865F4BC0 ModelPrimitiveType int int int Int32 )
            value.End                                       = GetInt32(new IntPtr(p + 0x034)); // 0270D0B83E70 0x34 End                         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
