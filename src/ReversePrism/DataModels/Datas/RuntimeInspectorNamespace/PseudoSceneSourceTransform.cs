using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 M_hierarchy                              ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer
    // 028 M_sceneName                              ModelPrimitiveType string string string String
    // 030 M_hideOnDisable                          ModelPrimitiveType bool bool bool Bool
    // 038 childrenCurrent                          HashSet`1<Transform> IL2CPP_TYPE_GENERICINST
    // 040 childrenNew                              HashSet`1<Transform> IL2CPP_TYPE_GENERICINST
    // 048 UpdateChildren                           ModelPrimitiveType bool bool bool Bool
    // 049 IsEnabled                                ModelPrimitiveType bool bool bool Bool
    // 04A IsQuitting                               ModelPrimitiveType bool bool bool Bool
    public partial class PseudoSceneSourceTransform : DataModel
    {
        public RuntimeHierarchy?                        M_hierarchy                             { get; set; }
        public string                                   M_sceneName                             { get; set; }
        public bool                                     M_hideOnDisable                         { get; set; }
        public bool                                     UpdateChildren                          { get; set; }
        public bool                                     IsEnabled                               { get; set; }
        public bool                                     IsQuitting                              { get; set; }

        public static PseudoSceneSourceTransform? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PseudoSceneSourceTransform() { Pointer= p0 };

            value.M_hierarchy                               = GetObject<RuntimeHierarchy>(new IntPtr(p + 0x020), ReversePrism.DataModels.RuntimeHierarchy.FromPointer); // 0x20 M_hierarchy                 ( ModelClassType RuntimeHierarchy RuntimeHierarchy RuntimeHierarchy Pointer )
            value.M_sceneName                               = GetString(new IntPtr(p + 0x028)); // 0x28 M_sceneName                 ( ModelPrimitiveType string string string String )
            value.M_hideOnDisable                           = GetBool(new IntPtr(p + 0x030)); // 0x30 M_hideOnDisable             ( ModelPrimitiveType bool bool bool Bool )
            value.UpdateChildren                            = GetBool(new IntPtr(p + 0x048)); // 0x48 UpdateChildren              ( ModelPrimitiveType bool bool bool Bool )
            value.IsEnabled                                 = GetBool(new IntPtr(p + 0x049)); // 0x49 IsEnabled                   ( ModelPrimitiveType bool bool bool Bool )
            value.IsQuitting                                = GetBool(new IntPtr(p + 0x04A)); // 0x4A IsQuitting                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
