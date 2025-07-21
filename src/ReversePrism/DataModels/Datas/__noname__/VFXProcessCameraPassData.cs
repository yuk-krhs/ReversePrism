using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CullResults                              ModelEnumType CullingResults CullingResults CullingResults Int32
    // 020 Camera                                   ModelClassType Camera Camera Camera Pointer
    public partial class VFXProcessCameraPassData : DataModel
    {
        public CullingResults                           CullResults                             { get; set; }
        public Camera?                                  Camera                                  { get; set; }

        public static VFXProcessCameraPassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new VFXProcessCameraPassData() { Pointer= p0 };

            value.CullResults                               = (CullingResults)GetInt32(new IntPtr(p + 0x010)); // 0x10 CullResults                 ( ModelEnumType CullingResults CullingResults CullingResults Int32 )
            value.Camera                                    = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 Camera                      ( ModelClassType Camera Camera Camera Pointer )

            return value;
        }
    }
}
