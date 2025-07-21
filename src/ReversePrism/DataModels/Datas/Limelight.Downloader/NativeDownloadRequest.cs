using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UniqueDownloadId                         ModelPrimitiveType int int int Int32
    // 018 Body                                     ModelEnumType Body Body Body Int32
    public partial class NativeDownloadRequest : DataModel
    {
        public int                                      UniqueDownloadId                        { get; set; }
        public Body                                     Body                                    { get; set; }

        public static NativeDownloadRequest? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NativeDownloadRequest() { Pointer= p0 };

            value.UniqueDownloadId                          = GetInt32(new IntPtr(p + 0x010)); // 0x10 UniqueDownloadId            ( ModelPrimitiveType int int int Int32 )
            value.Body                                      = (Body)GetInt32(new IntPtr(p + 0x018)); // 0x18 Body                        ( ModelEnumType Body Body Body Int32 )

            return value;
        }
    }
}
