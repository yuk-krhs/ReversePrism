using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Description                              ModelPrimitiveType string string string String
    // 018 Data                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MemorySnapshotMetadata : DataModel
    {
        public string                                   Description                             { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static MemorySnapshotMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemorySnapshotMetadata() { Pointer= p0 };

            value.Description                               = GetString(new IntPtr(p + 0x010)); // 0x10 Description                 ( ModelPrimitiveType string string string String )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Data                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
