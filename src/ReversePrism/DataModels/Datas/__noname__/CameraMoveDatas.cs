using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraMoveData                           ModelClassListType CameraMoveData[] CameraMoveData[] List<CameraMoveData> Pointer
    public partial class CameraMoveDatas : DataModel
    {
        public List<CameraMoveData>?                    CameraMoveData                          { get; set; }

        public static CameraMoveDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraMoveDatas() { Pointer= p0 };

            value.CameraMoveData                            = GetObjectList<CameraMoveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraMoveData.FromPointer); // 0x10 CameraMoveData              ( ModelClassListType CameraMoveData[] CameraMoveData[] List<CameraMoveData> Pointer )

            return value;
        }
    }
}
