using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraMoveData                           000185CB6E68 ModelClassListType CameraMoveData[] CameraMoveData[] List<CameraMoveData> Pointer
    public partial class CameraMoveDatas
    {
        public List<CameraMoveData>?                    CameraMoveData                          { get; set; }

        public static CameraMoveDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraMoveDatas();

            value.CameraMoveData                            = GetObjectList<CameraMoveData>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraMoveData.FromPointer); // 027006B20068 0x10 CameraMoveData              ( 000185CB6E68 ModelClassListType CameraMoveData[] CameraMoveData[] List<CameraMoveData> Pointer )

            return value;
        }
    }
}
