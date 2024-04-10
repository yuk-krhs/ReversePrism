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
    public partial class SaveHandValue : DataModel
    {
        public List<TransformValue>?                    TransformValueList                      { get; set; }
        public string                                   AttachBone                              { get; set; }

        public static SaveHandValue? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SaveHandValue() { Pointer= p0 };

            value.TransformValueList                        = GetObjectList<TransformValue>(new IntPtr(p + 0x010), ReversePrism.DataModels.TransformValue.FromPointer); // 024664DCCF60 0x10 TransformValueList          ( 000185CB67A8 ModelClassListType TransformValue[] TransformValue[] List<TransformValue> Pointer )
            value.AttachBone                                = GetString(new IntPtr(p + 0x018)); // 024664DCCF80 0x18 AttachBone                  ( 0001866722E0 ModelPrimitiveType string string string String )

            return value;
        }
    }
}
