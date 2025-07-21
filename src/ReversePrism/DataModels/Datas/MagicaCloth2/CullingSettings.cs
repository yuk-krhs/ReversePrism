using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CameraCullingMode                        ModelEnumType CameraCullingMode CameraCullingMode CameraCullingMode Int32
    // 014 CameraCullingMethod                      ModelEnumType CameraCullingMethod CameraCullingMethod CameraCullingMethod Int32
    // 018 CameraCullingRenderers                   ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer
    public partial class CullingSettings : DataModel
    {
        public CameraCullingMode                        CameraCullingMode                       { get; set; }
        public CameraCullingMethod                      CameraCullingMethod                     { get; set; }
        public List<Renderer>?                          CameraCullingRenderers                  { get; set; }

        public static CullingSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CullingSettings() { Pointer= p0 };

            value.CameraCullingMode                         = (CameraCullingMode)GetInt32(new IntPtr(p + 0x010)); // 0x10 CameraCullingMode           ( ModelEnumType CameraCullingMode CameraCullingMode CameraCullingMode Int32 )
            value.CameraCullingMethod                       = (CameraCullingMethod)GetInt32(new IntPtr(p + 0x014)); // 0x14 CameraCullingMethod         ( ModelEnumType CameraCullingMethod CameraCullingMethod CameraCullingMethod Int32 )
            value.CameraCullingRenderers                    = GetObjectList<Renderer>(new IntPtr(p + 0x018), ReversePrism.DataModels.Renderer.FromPointer); // 0x18 CameraCullingRenderers      ( ModelClassListType List`1<Renderer> List`1<Renderer> List<Renderer> Pointer )

            return value;
        }
    }
}
