using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 0C0 InitializeObjectButton                   0001865140C0 ModelClassType Button Button Button Pointer
    // 0C8 ElementsInitialized                      000186594D10 ModelPrimitiveType bool bool bool Bool
    // 0D0 CustomEditor                             000186621930 ModelClassType IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor Pointer
    public partial class ObjectField
    {
        public Button?                                  InitializeObjectButton                  { get; set; }
        public bool                                     ElementsInitialized                     { get; set; }
        public IRuntimeInspectorCustomEditor?           CustomEditor                            { get; set; }

        public static ObjectField? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectField();

            value.InitializeObjectButton                    = GetObject<Button>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.Button.FromPointer); // 0270DB1D63F8 0xC0 InitializeObjectButton      ( 0001865140C0 ModelClassType Button Button Button Pointer )
            value.ElementsInitialized                       = GetBool(new IntPtr(p + 0x0C8)); // 0270DB1D6418 0xC8 ElementsInitialized         ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.CustomEditor                              = GetObject<IRuntimeInspectorCustomEditor>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.IRuntimeInspectorCustomEditor.FromPointer); // 0270DB1D6438 0xD0 CustomEditor                ( 000186621930 ModelClassType IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor IRuntimeInspectorCustomEditor Pointer )

            return value;
        }
    }
}
