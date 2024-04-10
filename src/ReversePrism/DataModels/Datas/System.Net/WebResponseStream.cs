using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 058 InnerStream                              00018654D340 ModelClassType WebReadStream WebReadStream WebReadStream Pointer
    // 060 NextReadCalled                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 BufferedEntireContent                    000186594D10 ModelPrimitiveType bool bool bool Bool
    // 068 PendingRead                              000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer
    // 070 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 078 NestedRead                               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 07C Read_eof                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 080 RequestStream                            0001865502E0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer
    // 088 Headers                                  00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 090 StatusCode                               0001866E4710 ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32
    // 098 StatusDescription                        000186671910 ModelPrimitiveType string string string String
    // 0A0 Version                                  0001866B0CC0 ModelClassType Version Version Version Pointer
    // 0A8 KeepAlive                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0A9 ChunkedRead                              000186594D10 ModelPrimitiveType bool bool bool Bool
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

            value.InnerStream                               = GetObject<WebReadStream>(new IntPtr(p + 0x058), ReversePrism.DataModels.WebReadStream.FromPointer); // 024667ACAC18 0x58 InnerStream                 ( 00018654D340 ModelClassType WebReadStream WebReadStream WebReadStream Pointer )
            value.NextReadCalled                            = GetBool(new IntPtr(p + 0x060)); // 024667ACAC38 0x60 NextReadCalled              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.BufferedEntireContent                     = GetBool(new IntPtr(p + 0x061)); // 024667ACAC58 0x61 BufferedEntireContent       ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.PendingRead                               = GetObject<WebCompletionSource>(new IntPtr(p + 0x068), ReversePrism.DataModels.WebCompletionSource.FromPointer); // 024667ACAC78 0x68 PendingRead                 ( 000186547C40 ModelClassType WebCompletionSource WebCompletionSource WebCompletionSource Pointer )
            value.NestedRead                                = GetInt32(new IntPtr(p + 0x078)); // 024667ACACB8 0x78 NestedRead                  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Read_eof                                  = GetBool(new IntPtr(p + 0x07C)); // 024667ACACD8 0x7C Read_eof                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.RequestStream                             = GetObject<WebRequestStream>(new IntPtr(p + 0x080), ReversePrism.DataModels.WebRequestStream.FromPointer); // 024667ACACF8 0x80 RequestStream               ( 0001865502E0 ModelClassType WebRequestStream WebRequestStream WebRequestStream Pointer )
            value.Headers                                   = GetObject<WebHeaderCollection>(new IntPtr(p + 0x088), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 024667ACAD18 0x88 Headers                     ( 00018654B520 ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.StatusCode                                = (HttpStatusCode)GetInt32(new IntPtr(p + 0x090)); // 024667ACAD38 0x90 StatusCode                  ( 0001866E4710 ModelEnumType HttpStatusCode HttpStatusCode HttpStatusCode Int32 )
            value.StatusDescription                         = GetString(new IntPtr(p + 0x098)); // 024667ACAD58 0x98 StatusDescription           ( 000186671910 ModelPrimitiveType string string string String )
            value.Version                                   = GetObject<Version>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.Version.FromPointer); // 024667ACAD78 0xA0 Version                     ( 0001866B0CC0 ModelClassType Version Version Version Pointer )
            value.KeepAlive                                 = GetBool(new IntPtr(p + 0x0A8)); // 024667ACAD98 0xA8 KeepAlive                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.ChunkedRead                               = GetBool(new IntPtr(p + 0x0A9)); // 024667ACADB8 0xA9 ChunkedRead                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
