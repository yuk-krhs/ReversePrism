using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraWorkData                           000185CB6F48 ModelClassListType CameraWorkDataSave[] CameraWorkDataSave[] List<CameraWorkDataSave> Pointer
    public partial class CameraWorkDatas
    {
        public List<CameraWorkDataSave>?                CameraWorkData                          { get; set; }

        public static CameraWorkDatas? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CameraWorkDatas();

            value.CameraWorkData                            = GetObjectList<CameraWorkDataSave>(new IntPtr(p + 0x010), ReversePrism.DataModels.CameraWorkDataSave.FromPointer); // 027006B21378 0x10 CameraWorkData              ( 000185CB6F48 ModelClassListType CameraWorkDataSave[] CameraWorkDataSave[] List<CameraWorkDataSave> Pointer )

            return value;
        }
    }
}
