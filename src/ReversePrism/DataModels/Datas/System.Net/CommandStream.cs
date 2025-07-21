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
    // 038 RecoverableFailure                       ModelPrimitiveType bool bool bool Bool
    // 040 Request                                  ModelClassType WebRequest WebRequest WebRequest Pointer
    // 048 IsAsync                                  ModelPrimitiveType bool bool bool Bool
    // 049 Aborted                                  ModelPrimitiveType bool bool bool Bool
    // 050 Commands                                 ModelClassListType PipelineEntry[] PipelineEntry[] List<PipelineEntry> Pointer
    // 058 Index                                    ModelPrimitiveType int int int Int32
    // 05C DoRead                                   ModelPrimitiveType bool bool bool Bool
    // 05D DoSend                                   ModelPrimitiveType bool bool bool Bool
    // 060 CurrentResponseDescription               ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer
    // 068 AbortReason                              ModelPrimitiveType string string string String
    // 070 Buffer                                   ModelPrimitiveType string string string String
    // 078 Encoding                                 ModelClassType Encoding Encoding Encoding Pointer
    // 080 Decoder                                  ModelClassType Decoder Decoder Decoder Pointer
    public partial class CommandStream : DataModel
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
            var value   = new CommandStream() { Pointer= p0 };

            value.RecoverableFailure                        = GetBool(new IntPtr(p + 0x038)); // 0x38 RecoverableFailure          ( ModelPrimitiveType bool bool bool Bool )
            value.Request                                   = GetObject<WebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.WebRequest.FromPointer); // 0x40 Request                     ( ModelClassType WebRequest WebRequest WebRequest Pointer )
            value.IsAsync                                   = GetBool(new IntPtr(p + 0x048)); // 0x48 IsAsync                     ( ModelPrimitiveType bool bool bool Bool )
            value.Aborted                                   = GetBool(new IntPtr(p + 0x049)); // 0x49 Aborted                     ( ModelPrimitiveType bool bool bool Bool )
            value.Commands                                  = GetObjectList<PipelineEntry>(new IntPtr(p + 0x050), ReversePrism.DataModels.PipelineEntry.FromPointer); // 0x50 Commands                    ( ModelClassListType PipelineEntry[] PipelineEntry[] List<PipelineEntry> Pointer )
            value.Index                                     = GetInt32(new IntPtr(p + 0x058)); // 0x58 Index                       ( ModelPrimitiveType int int int Int32 )
            value.DoRead                                    = GetBool(new IntPtr(p + 0x05C)); // 0x5C DoRead                      ( ModelPrimitiveType bool bool bool Bool )
            value.DoSend                                    = GetBool(new IntPtr(p + 0x05D)); // 0x5D DoSend                      ( ModelPrimitiveType bool bool bool Bool )
            value.CurrentResponseDescription                = GetObject<ResponseDescription>(new IntPtr(p + 0x060), ReversePrism.DataModels.ResponseDescription.FromPointer); // 0x60 CurrentResponseDescription  ( ModelClassType ResponseDescription ResponseDescription ResponseDescription Pointer )
            value.AbortReason                               = GetString(new IntPtr(p + 0x068)); // 0x68 AbortReason                 ( ModelPrimitiveType string string string String )
            value.Buffer                                    = GetString(new IntPtr(p + 0x070)); // 0x70 Buffer                      ( ModelPrimitiveType string string string String )
            value.Encoding                                  = GetObject<Encoding>(new IntPtr(p + 0x078), ReversePrism.DataModels.Encoding.FromPointer); // 0x78 Encoding                    ( ModelClassType Encoding Encoding Encoding Pointer )
            value.Decoder                                   = GetObject<Decoder>(new IntPtr(p + 0x080), ReversePrism.DataModels.Decoder.FromPointer); // 0x80 Decoder                     ( ModelClassType Decoder Decoder Decoder Pointer )

            return value;
        }
    }
}
