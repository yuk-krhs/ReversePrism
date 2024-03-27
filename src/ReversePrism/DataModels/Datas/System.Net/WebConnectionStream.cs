using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Closed                                   000186595480 ModelPrimitiveType bool bool bool Bool
    // 029 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 030 locker                                   <object> IL2CPP_TYPE_OBJECT
    // 038 Read_timeout                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 03C Write_timeout                            0001865F2AF0 ModelPrimitiveType int int int Int32
    // 040 Request                                  0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer
    // 048 Connection                               000186548BA0 ModelClassType WebConnection WebConnection WebConnection Pointer
    // 050 Operation                                00018654C930 ModelClassType WebOperation WebOperation WebOperation Pointer
    public partial class WebConnectionStream
    {
        public bool                                     Closed                                  { get; set; }
        public bool                                     Disposed                                { get; set; }
        public int                                      Read_timeout                            { get; set; }
        public int                                      Write_timeout                           { get; set; }
        public HttpWebRequest?                          Request                                 { get; set; }
        public WebConnection?                           Connection                              { get; set; }
        public WebOperation?                            Operation                               { get; set; }

        public static WebConnectionStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new WebConnectionStream();

            value.Closed                                    = GetBool(new IntPtr(p + 0x028)); // 0270D7A71DE0 0x28 Closed                      ( 000186595480 ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x029)); // 0270D7A71E00 0x29 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Read_timeout                              = GetInt32(new IntPtr(p + 0x038)); // 0270D7A71E40 0x38 Read_timeout                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Write_timeout                             = GetInt32(new IntPtr(p + 0x03C)); // 0270D7A71E60 0x3C Write_timeout               ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Request                                   = GetObject<HttpWebRequest>(new IntPtr(p + 0x040), ReversePrism.DataModels.HttpWebRequest.FromPointer); // 0270D7A71E80 0x40 Request                     ( 0001866E5D00 ModelClassType HttpWebRequest HttpWebRequest HttpWebRequest Pointer )
            value.Connection                                = GetObject<WebConnection>(new IntPtr(p + 0x048), ReversePrism.DataModels.WebConnection.FromPointer); // 0270D7A71EA0 0x48 Connection                  ( 000186548BA0 ModelClassType WebConnection WebConnection WebConnection Pointer )
            value.Operation                                 = GetObject<WebOperation>(new IntPtr(p + 0x050), ReversePrism.DataModels.WebOperation.FromPointer); // 0270D7A71EC0 0x50 Operation                   ( 00018654C930 ModelClassType WebOperation WebOperation WebOperation Pointer )

            return value;
        }
    }
}
