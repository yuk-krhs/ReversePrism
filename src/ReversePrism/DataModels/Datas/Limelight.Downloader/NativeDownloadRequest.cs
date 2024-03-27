using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UniqueDownloadId                         0001865F2F90 ModelPrimitiveType int int int Int32
    // 018 Body                                     000186702D90 ModelEnumType Body Body Body Int32
    public partial class NativeDownloadRequest
    {
        public int                                      UniqueDownloadId                        { get; set; }
        public Body                                     Body                                    { get; set; }

        public static NativeDownloadRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadRequest();

            value.UniqueDownloadId                          = GetInt32(new IntPtr(p + 0x010)); // 0270DB500BF0 0x10 UniqueDownloadId            ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.Body                                      = (Body)GetInt32(new IntPtr(p + 0x018)); // 0270DB500C10 0x18 Body                        ( 000186702D90 ModelEnumType Body Body Body Int32 )

            return value;
        }
    }
}
