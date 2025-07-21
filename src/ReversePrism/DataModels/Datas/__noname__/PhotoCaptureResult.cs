using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ResultType                               ModelEnumType CaptureResultType CaptureResultType CaptureResultType Int32
    // 018 HResult                                  ModelPrimitiveType long long long Int64
    public partial class PhotoCaptureResult : DataModel
    {
        public CaptureResultType                        ResultType                              { get; set; }
        public long                                     HResult                                 { get; set; }

        public static PhotoCaptureResult? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhotoCaptureResult() { Pointer= p0 };

            value.ResultType                                = (CaptureResultType)GetInt32(new IntPtr(p + 0x010)); // 0x10 ResultType                  ( ModelEnumType CaptureResultType CaptureResultType CaptureResultType Int32 )
            value.HResult                                   = GetInt64(new IntPtr(p + 0x018)); // 0x18 HResult                     ( ModelPrimitiveType long long long Int64 )

            return value;
        }
    }
}
