using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_closed                                 ModelPrimitiveType bool bool bool Bool
    // 028 M_contentLength                          ModelPrimitiveType long long long Int64
    // 030 M_fileAccess                             ModelEnumType FileAccess FileAccess FileAccess Int32
    // 038 M_headers                                ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer
    // 040 M_stream                                 ModelClassType Stream Stream Stream Pointer
    // 048 M_uri                                    ModelClassType Uri Uri Uri Pointer
    public partial class FileWebResponse : DataModel
    {
        public bool                                     M_closed                                { get; set; }
        public long                                     M_contentLength                         { get; set; }
        public FileAccess                               M_fileAccess                            { get; set; }
        public WebHeaderCollection?                     M_headers                               { get; set; }
        public Stream?                                  M_stream                                { get; set; }
        public Uri?                                     M_uri                                   { get; set; }

        public static FileWebResponse? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new FileWebResponse() { Pointer= p0 };

            value.M_closed                                  = GetBool(new IntPtr(p + 0x020)); // 0x20 M_closed                    ( ModelPrimitiveType bool bool bool Bool )
            value.M_contentLength                           = GetInt64(new IntPtr(p + 0x028)); // 0x28 M_contentLength             ( ModelPrimitiveType long long long Int64 )
            value.M_fileAccess                              = (FileAccess)GetInt32(new IntPtr(p + 0x030)); // 0x30 M_fileAccess                ( ModelEnumType FileAccess FileAccess FileAccess Int32 )
            value.M_headers                                 = GetObject<WebHeaderCollection>(new IntPtr(p + 0x038), ReversePrism.DataModels.WebHeaderCollection.FromPointer); // 0x38 M_headers                   ( ModelClassType WebHeaderCollection WebHeaderCollection WebHeaderCollection Pointer )
            value.M_stream                                  = GetObject<Stream>(new IntPtr(p + 0x040), ReversePrism.DataModels.Stream.FromPointer); // 0x40 M_stream                    ( ModelClassType Stream Stream Stream Pointer )
            value.M_uri                                     = GetObject<Uri>(new IntPtr(p + 0x048), ReversePrism.DataModels.Uri.FromPointer); // 0x48 M_uri                       ( ModelClassType Uri Uri Uri Pointer )

            return value;
        }
    }
}
