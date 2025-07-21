using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Session                                  ModelPrimitiveType string string string String
    // 018 Inputs                                   ModelClassListType Feature[] Feature[] List<Feature> Pointer
    // 020 WaitUntilCompleted                       ModelPrimitiveType bool bool bool Bool
    public partial class Input : DataModel
    {
        public string                                   Session                                 { get; set; }
        public List<Feature>?                           Inputs                                  { get; set; }
        public bool                                     WaitUntilCompleted                      { get; set; }

        public static Input? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Input() { Pointer= p0 };

            value.Session                                   = GetString(new IntPtr(p + 0x010)); // 0x10 Session                     ( ModelPrimitiveType string string string String )
            value.Inputs                                    = GetObjectList<Feature>(new IntPtr(p + 0x018), ReversePrism.DataModels.Feature.FromPointer); // 0x18 Inputs                      ( ModelClassListType Feature[] Feature[] List<Feature> Pointer )
            value.WaitUntilCompleted                        = GetBool(new IntPtr(p + 0x020)); // 0x20 WaitUntilCompleted          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
