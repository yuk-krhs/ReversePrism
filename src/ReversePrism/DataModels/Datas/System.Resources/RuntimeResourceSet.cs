using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Version                                  int IL2CPP_TYPE_I4
    // 028 _resCache                                Dictionary`2<string, ResourceLocator> IL2CPP_TYPE_GENERICINST
    // 030 DefaultReader                            ModelClassType ResourceReader ResourceReader ResourceReader Pointer
    // 038 _caseInsensitiveTable                    Dictionary`2<string, ResourceLocator> IL2CPP_TYPE_GENERICINST
    // 040 HaveReadFromReader                       ModelPrimitiveType bool bool bool Bool
    public partial class RuntimeResourceSet : DataModel
    {
        public ResourceReader?                          DefaultReader                           { get; set; }
        public bool                                     HaveReadFromReader                      { get; set; }

        public static RuntimeResourceSet? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RuntimeResourceSet() { Pointer= p0 };

            value.DefaultReader                             = GetObject<ResourceReader>(new IntPtr(p + 0x030), ReversePrism.DataModels.ResourceReader.FromPointer); // 0x30 DefaultReader               ( ModelClassType ResourceReader ResourceReader ResourceReader Pointer )
            value.HaveReadFromReader                        = GetBool(new IntPtr(p + 0x040)); // 0x40 HaveReadFromReader          ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
