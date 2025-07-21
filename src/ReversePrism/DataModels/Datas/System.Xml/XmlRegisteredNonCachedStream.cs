using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Stream                                   ModelClassType Stream Stream Stream Pointer
    // 030 DownloadManager                          ModelClassType XmlDownloadManager XmlDownloadManager XmlDownloadManager Pointer
    // 038 Host                                     ModelPrimitiveType string string string String
    public partial class XmlRegisteredNonCachedStream : DataModel
    {
        public Stream?                                  Stream                                  { get; set; }
        public XmlDownloadManager?                      DownloadManager                         { get; set; }
        public string                                   Host                                    { get; set; }

        public static XmlRegisteredNonCachedStream? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XmlRegisteredNonCachedStream() { Pointer= p0 };

            value.Stream                                    = GetObject<Stream>(new IntPtr(p + 0x028), ReversePrism.DataModels.Stream.FromPointer); // 0x28 Stream                      ( ModelClassType Stream Stream Stream Pointer )
            value.DownloadManager                           = GetObject<XmlDownloadManager>(new IntPtr(p + 0x030), ReversePrism.DataModels.XmlDownloadManager.FromPointer); // 0x30 DownloadManager             ( ModelClassType XmlDownloadManager XmlDownloadManager XmlDownloadManager Pointer )
            value.Host                                      = GetString(new IntPtr(p + 0x038)); // 0x38 Host                        ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
