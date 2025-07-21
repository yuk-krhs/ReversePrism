using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 InitializeObjectButton                   ModelClassType Button Button Button Pointer
    // 0C8 ElementsInitialized                      ModelPrimitiveType bool bool bool Bool
    // 0D0 CustomEditor                             ModelClassType IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor Pointer
    public partial class ObjectField : DataModel
    {
        public Button?                                  InitializeObjectButton                  { get; set; }
        public bool                                     ElementsInitialized                     { get; set; }
        public IRuntimeInspectorCustomEditor?           CustomEditor                            { get; set; }

        public static ObjectField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectField() { Pointer= p0 };

            value.InitializeObjectButton                    = GetObject<Button>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Button.FromPointer); // 0xC0 InitializeObjectButton      ( ModelClassType Button Button Button Pointer )
            value.ElementsInitialized                       = GetBool(new IntPtr(p + 0x0C8)); // 0xC8 ElementsInitialized         ( ModelPrimitiveType bool bool bool Bool )
            value.CustomEditor                              = GetObject<IRuntimeInspectorCustomEditor>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IRuntimeInspectorCustomEditor.FromPointer); // 0xD0 CustomEditor                ( ModelClassType IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor Pointer )

            return value;
        }
    }
}
