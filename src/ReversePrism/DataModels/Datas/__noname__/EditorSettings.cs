using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 kMinFrameRate                            double IL2CPP_TYPE_R8
    // 008 kMaxFrameRate                            double IL2CPP_TYPE_R8
    // 010 KDefaultFrameRate                        ModelPrimitiveType double double double Double
    // 010 M_Framerate                              ModelPrimitiveType double double double Double
    // 018 M_ScenePreview                           ModelPrimitiveType bool bool bool Bool
    public partial class EditorSettings : DataModel
    {
        public double                                   KDefaultFrameRate                       { get; set; }
        public double                                   M_Framerate                             { get; set; }
        public bool                                     M_ScenePreview                          { get; set; }

        public static EditorSettings? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EditorSettings() { Pointer= p0 };

            value.KDefaultFrameRate                         = GetDouble(new IntPtr(p + 0x010)); // 0x10 KDefaultFrameRate           ( ModelPrimitiveType double double double Double )
            value.M_Framerate                               = GetDouble(new IntPtr(p + 0x010)); // 0x10 M_Framerate                 ( ModelPrimitiveType double double double Double )
            value.M_ScenePreview                            = GetBool(new IntPtr(p + 0x018)); // 0x18 M_ScenePreview              ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
