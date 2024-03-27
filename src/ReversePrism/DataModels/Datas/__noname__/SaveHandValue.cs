using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 TransformValueList                       000185CB67A8 ModelClassListType TransformValue[] TransformValue[] List<TransformValue> Pointer
    // 018 AttachBone                               0001866722E0 ModelPrimitiveType string string string String
    public partial class SaveHandValue
    {
        public List<TransformValue>?                    TransformValueList                      { get; set; }
        public string                                   AttachBone                              { get; set; }

        public static SaveHandValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SaveHandValue();

            value.TransformValueList                        = GetObjectList<TransformValue>(new IntPtr(p + 0x010), ReversePrism.DataModels.TransformValue.FromPointer); // 0270D4D618F0 0x10 TransformValueList          ( 000185CB67A8 ModelClassListType TransformValue[] TransformValue[] List<TransformValue> Pointer )
            value.AttachBone                                = GetString(new IntPtr(p + 0x018)); // 0270D4D61910 0x18 AttachBone                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
