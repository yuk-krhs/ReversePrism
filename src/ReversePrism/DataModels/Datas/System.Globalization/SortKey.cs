using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Source                                   ModelPrimitiveType string string string String
    // 018 Key                                      ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    // 020 Options                                  ModelEnumType CompareOptions CompareOptions CompareOptions Int32
    // 024 Lcid                                     ModelPrimitiveType int int int Int32
    public partial class SortKey : DataModel
    {
        public string                                   Source                                  { get; set; }
        public List<sbyte>?                             Key                                     { get; set; }
        public CompareOptions                           Options                                 { get; set; }
        public int                                      Lcid                                    { get; set; }

        public static SortKey? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SortKey() { Pointer= p0 };

            value.Source                                    = GetString(new IntPtr(p + 0x010)); // 0x10 Source                      ( ModelPrimitiveType string string string String )
            value.Key                                       = GetSByteList(new IntPtr(p + 0x018)); // 0x18 Key                         ( ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )
            value.Options                                   = (CompareOptions)GetInt32(new IntPtr(p + 0x020)); // 0x20 Options                     ( ModelEnumType CompareOptions CompareOptions CompareOptions Int32 )
            value.Lcid                                      = GetInt32(new IntPtr(p + 0x024)); // 0x24 Lcid                        ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
