using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Seed                                     ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 018 StoragePath                              ModelPrimitiveType string string string String
    public partial class StorageLocationProvider : DataModel
    {
        public List<sbyte>?                             Seed                                    { get; set; }
        public string                                   StoragePath                             { get; set; }

        public static StorageLocationProvider? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new StorageLocationProvider() { Pointer= p0 };

            value.Seed                                      = GetSByteList(new IntPtr(p + 0x010)); // 0x10 Seed                        ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.StoragePath                               = GetString(new IntPtr(p + 0x018)); // 0x18 StoragePath                 ( ModelPrimitiveType string string string String )

            return value;
        }
    }
}
