using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 MyCamera                                 ModelClassType Camera Camera Camera Pointer
    // 028 IsCompleteFirstRendering                 ModelPrimitiveType bool bool bool Bool
    public partial class SplitScreenCaptureCamera : DataModel
    {
        public Camera?                                  MyCamera                                { get; set; }
        public bool                                     IsCompleteFirstRendering                { get; set; }

        public static SplitScreenCaptureCamera? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SplitScreenCaptureCamera() { Pointer= p0 };

            value.MyCamera                                  = GetObject<Camera>(new IntPtr(p + 0x020), ReversePrism.DataModels.Camera.FromPointer); // 0x20 MyCamera                    ( ModelClassType Camera Camera Camera Pointer )
            value.IsCompleteFirstRendering                  = GetBool(new IntPtr(p + 0x028)); // 0x28 IsCompleteFirstRendering    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
