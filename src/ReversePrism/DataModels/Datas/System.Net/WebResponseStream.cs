using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 InnerStream                              ModelClassType WebReadStream WebReadStream WebReadStream Pointer
    // 060 NextReadCalled                           ModelPrimitiveType bool bool bool Bool
    // 061 BufferedEntireContent                    ModelPrimitiveType bool bool bool Bool
    // 068 PendingRead                              ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 070 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 078 NestedRead                               ModelPrimitiveType int int int Int32
    // 07C Read_eof                                 ModelPrimitiveType bool bool bool Bool
    // 080 RequestStream                            ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 088 Headers                                  ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 090 StatusCode                               ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 098 StatusDescription                        ModelPrimitiveType string string string String
    // 0A0 Version                                  ModelClassType Version Version Version Pointer
    // 0A8 KeepAlive                                ModelPrimitiveType bool bool bool Bool
    // 0A9 ChunkedRead                              ModelPrimitiveType bool bool bool Bool
    public partial class WebResponseStream : DataModel
    {
        public WebReadStream?                           InnerStream                             { get; set; }
        public bool                                     NextReadCalled                          { get; set; }
        public bool                                     BufferedEntireContent                   { get; set; }
        public WebCompletionSource?                     PendingRead                             { get; set; }
        public int                                      NestedRead                              { get; set; }
        public bool                                     Read_eof                                { get; set; }
        public WebRequestStream?                        RequestStream                           { get; set; }
        public WebHeaderCollection?                     Headers                                 { get; set; }
        public HttpStatusCode                           StatusCode                              { get; set; }
        public string                                   StatusDescription                       { get; set; }
        public Version?                                 Version                                 { get; set; }
        public bool                                     KeepAlive                               { get; set; }
        public bool                                     ChunkedRead                             { get; set; }

        public static WebResponseStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebResponseStream() { Pointer= p0 };

            value.InnerStream                               = GetObject<WebReadStream>(new IntPtr(p + 0x058), ReversePrism.DataModels.WebReadStream.FromPointer); // 0x58 InnerStream                 ( ModelClassType WebReadStream WebReadStream WebReadStream Pointer )
            value.NextReadCalled                            = GetBool(new IntPtr(p + 0x060)); // 0x60 NextReadCalled              ( ModelPrimitiveType bool bool bool Bool )
            value.BufferedEntireContent                     = GetBool(new IntPtr(p + 0x061)); // 0x61 BufferedEntireContent       ( ModelPrimitiveType bool bool bool Bool )
            value.PendingRead                               = GetObject<WebCompletionSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 0x68 PendingRead                 ( ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.NestedRead                                = GetInt32(new IntPtr(p + 0x078)); // 0x78 NestedRead                  ( ModelPrimitiveType int int int Int32 )
            value.Read_eof                                  = GetBool(new IntPtr(p + 0x07C)); // 0x7C Read_eof                    ( ModelPrimitiveType bool bool bool Bool )
            value.RequestStream                             = GetObject<WebRequestStream>(new IntPtr(p + 0x080), ReversePrism.DataModels.WebRequestStream.FromPointer); // 0x80 RequestStream               ( ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x88 Headers                     ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x090)); // 0x90 StatusCode                  ( ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x098)); // 0x98 StatusDescription           ( ModelPrimitiveType string string string String )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Version.FromPointer); // 0xA0 Version                     ( ModelClassType Version Version Version Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x0A8)); // 0xA8 KeepAlive                   ( ModelPrimitiveType bool bool bool Bool )
            value.ChunkedRead                               = GetBool(new IntPtr(p + 0x0A9)); // 0xA9 ChunkedRead                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
