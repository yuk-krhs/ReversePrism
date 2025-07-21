using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ContainerID                              ModelPrimitiveType long long long Int64
    // 018 ParentField                              ModelClassType FieldInfo FieldInfo FieldInfo Pointer
    // 020 ParentIndex                              ModelPrimitiveListType int[] int[] List<int> Pointer
    public partial class ValueTypeFixupInfo : DataModel
    {
        public long                                     ContainerID                             { get; set; }
        public FieldInfo?                               ParentField                             { get; set; }
        public List<int>?                               ParentIndex                             { get; set; }

        public static ValueTypeFixupInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ValueTypeFixupInfo() { Pointer= p0 };

            value.ContainerID                               = GetInt64(new IntPtr(p + 0x010)); // 0x10 ContainerID                 ( ModelPrimitiveType long long long Int64 )
            value.ParentField                               = GetObject<FieldInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.FieldInfo.FromPointer); // 0x18 ParentField                 ( ModelClassType FieldInfo FieldInfo FieldInfo Pointer )
            value.ParentIndex                               = GetInt32List(new IntPtr(p + 0x020)); // 0x20 ParentIndex                 ( ModelPrimitiveListType int[] int[] List<int> Pointer )

            return value;
        }
    }
}
