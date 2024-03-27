using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CaptureDataList                          000185D20088 ModelClassListType List`1<CaptureData> List`1<CaptureData> List<CaptureData> Pointer
    public partial class CameraCaptureManager
    {
        public List<CaptureData>?                       CaptureDataList                         { get; set; }

        public static CameraCaptureManager? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraCaptureManager();

            value.CaptureDataList                           = GetObjectList<CaptureData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CaptureData.FromPointer); // 0270D0E62870 0x10 CaptureDataList             ( 000185D20088 ModelClassListType List`1<CaptureData> List`1<CaptureData> List<CaptureData> Pointer )

            return value;
        }
    }
}
