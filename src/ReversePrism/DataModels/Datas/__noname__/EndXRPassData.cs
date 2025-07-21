using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 RenderingData                            ModelEnumType RenderingData RenderingData RenderingData Int32
    // 2C8 CameraData                               ModelEnumType CameraData CameraData CameraData Int32
    public partial class EndXRPassData : DataModel
    {
        public RenderingData                            RenderingData                           { get; set; }
        public CameraData                               CameraData                              { get; set; }

        public static EndXRPassData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EndXRPassData() { Pointer= p0 };

            value.RenderingData                             = (RenderingData)GetInt32(new IntPtr(p + 0x010)); // 0x10 RenderingData               ( ModelEnumType RenderingData RenderingData RenderingData Int32 )
            value.CameraData                                = (CameraData)GetInt32(new IntPtr(p + 0x2C8)); // 0x2C8 CameraData                  ( ModelEnumType CameraData CameraData CameraData Int32 )

            return value;
        }
    }
}
