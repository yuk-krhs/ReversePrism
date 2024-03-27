using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_writeCallbackDelegate                  AsyncCallback IL2CPP_TYPE_CLASS
    // 008 s_readCallbackDelegate                   AsyncCallback IL2CPP_TYPE_CLASS
    // 038 RecoverableFailure                       000186594D10 ModelPrimitiveType bool bool bool Bool
    // 040 Request                                  00018654DD40 ModelClassType WebRequest WebRequest WebRequest Pointer
    // 048 IsAsync                                  000186595480 ModelPrimitiveType bool bool bool Bool
    // 049 Aborted                                  000186594D10 ModelPrimitiveType bool bool bool Bool
    // 050 Commands                                 000185CB7A88 ModelClassListType PipelineEntry[] PipelineEntry[] List<PipelineEntry> Pointer
    // 058 Index                                    0001865F3220 ModelPrimitiveType int int int Int32
    // 05C DoRead                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 05D DoSend                                   000186594D10 ModelPrimitiveType bool bool bool Bool
    // 060 CurrentResponseDescription               000186673920 ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer
    // 068 AbortReason                              000186671E00 ModelPrimitiveType string string string String
    // 070 Buffer                                   000186671910 ModelPrimitiveType string string string String
    // 078 Encoding                                 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer
    // 080 Decoder                                  0001866ABAA0 ModelClassType Decoder Decoder Decoder Pointer
    public partial class CommandStream
    {
        public bool                                     RecoverableFailure                      { get; set; }
        public WebRequest?                              Request                                 { get; set; }
        public bool                                     IsAsync                                 { get; set; }
        public bool                                     Aborted                                 { get; set; }
        public List<PipelineEntry>?                     Commands                                { get; set; }
        public int                                      Index                                   { get; set; }
        public bool                                     DoRead                                  { get; set; }
        public bool                                     DoSend                                  { get; set; }
        public ResponseDescription?                     CurrentResponseDescription              { get; set; }
        public string                                   AbortReason                             { get; set; }
        public string                                   Buffer                                  { get; set; }
        public Encoding?                                Encoding                                { get; set; }
        public Decoder?                                 Decoder                                 { get; set; }

        public static CommandStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CommandStream();

            value.RecoverableFailure                        = GetBool(new IntPtr(p + 0x038)); // 0270D7A0DD28 0x38 RecoverableFailure          ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Request                                   = GetObject<WebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebRequest.FromPointer); // 0270D7A0DD48 0x40 Request                     ( 00018654DD40 ModelClassType WebRequest WebRequest WebRequest Pointer )
            value.IsAsync                                   = GetBool(new IntPtr(p + 0x048)); // 0270D7A0DD68 0x48 IsAsync                     ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Aborted                                   = GetBool(new IntPtr(p + 0x049)); // 0270D7A0DD88 0x49 Aborted                     ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Commands                                  = GetObjectList<PipelineEntry>(new IntPtr(p + 0x050), ReversePrism.DataModels.PipelineEntry.FromPointer); // 0270D7A0DDA8 0x50 Commands                    ( 000185CB7A88 ModelClassListType PipelineEntry[] PipelineEntry[] List<PipelineEntry> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x058)); // 0270D7A0DDC8 0x58 Index                       ( 0001865F3220 ModelPrimitiveType int int int Int32 )
            value.DoRead                                    = GetBool(new IntPtr(p + 0x05C)); // 0270D7A0DDE8 0x5C DoRead                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.DoSend                                    = GetBool(new IntPtr(p + 0x05D)); // 0270D7A0DE08 0x5D DoSend                      ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CurrentResponseDescription                = GetObject<ResponseDescription>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResponseDescription.FromPointer); // 0270D7A0DE28 0x60 CurrentResponseDescription  ( 000186673920 ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer )
            value.AbortReason                               = GetString(new IntPtr(p + 0x068)); // 0270D7A0DE48 0x68 AbortReason                 ( 000186671E00 ModelPrimitiveType string string string String )
            value.Buffer                                    = GetString(new IntPtr(p + 0x070)); // 0270D7A0DE68 0x70 Buffer                      ( 000186671910 ModelPrimitiveType string string string String )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x078), ReversePrism.DataModels.Encoding.FromPointer); // 0270D7A0DE88 0x78 Encoding                    ( 00018672D9E0 ModelClassType Encoding Encoding Encoding Pointer )
            value.Decoder                                   = GetObject<Decoder>(new IntPtr(p + 0x080), ReversePrism.DataModels.Decoder.FromPointer); // 0270D7A0DEA8 0x80 Decoder                     ( 0001866ABAA0 ModelClassType Decoder Decoder Decoder Pointer )

            return value;
        }
    }
}
