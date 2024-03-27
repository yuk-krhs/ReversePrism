using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Description                              000186671910 ModelPrimitiveType string string string String
    // 018 Data                                     000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class MemorySnapshotMetadata
    {
        public string                                   Description                             { get; set; }
        public List<sbyte>?                             Data                                    { get; set; }

        public static MemorySnapshotMetadata? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MemorySnapshotMetadata();

            value.Description                               = GetString(new IntPtr(p + 0x010)); // 0270068A44F8 0x10 Description                 ( 000186671910 ModelPrimitiveType string string string String )
            value.Data                                      = GetSByteList(new IntPtr(p + 0x018)); // 0270068A4518 0x18 Data                        ( 000185B79750 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
