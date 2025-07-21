using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraWorkData                           ModelClassListType CameraWorkDataSave[] CameraWorkDataSave[] List<CameraWorkDataSave> Pointer
    public partial class CameraWorkDatas : DataModel
    {
        public List<CameraWorkDataSave>?                CameraWorkData                          { get; set; }

        public static CameraWorkDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkDatas() { Pointer= p0 };

            value.CameraWorkData                            = GetObjectList<CameraWorkDataSave>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraWorkDataSave.FromPointer); // 0x10 CameraWorkData              ( ModelClassListType CameraWorkDataSave[] CameraWorkDataSave[] List<CameraWorkDataSave> Pointer )

            return value;
        }
    }
}
