using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   000186670700 ModelClassType Stream Stream Stream Pointer
    // 030 DownloadManager                          000186596FF0 ModelClassType XmlDownloadManager XmlDownloadManager XmlDownloadManager Pointer
    // 038 Host                                     000186671910 ModelPrimitiveType string string string String
    public partial class XmlRegisteredNonCachedStream
    {
        public Stream?                                  Stream                                  { get; set; }
        public XmlDownloadManager?                      DownloadManager                         { get; set; }
        public string                                   Host                                    { get; set; }

        public static XmlRegisteredNonCachedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlRegisteredNonCachedStream();

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0270D7494328 0x28 Stream                      ( 000186670700 ModelClassType Stream Stream Stream Pointer )
            value.DownloadManager                           = GetObject<XmlDownloadManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDownloadManager.FromPointer); // 0270D7494348 0x30 DownloadManager             ( 000186596FF0 ModelClassType XmlDownloadManager XmlDownloadManager XmlDownloadManager Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x038)); // 0270D7494368 0x38 Host                        ( 000186671910 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
