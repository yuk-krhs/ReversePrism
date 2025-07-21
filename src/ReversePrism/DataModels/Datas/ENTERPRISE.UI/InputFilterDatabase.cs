using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DenyList                                 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 020 AllowList                                ModelEnumListType List`1<AllowRange> List`1<AllowRange> List<AllowRange> Pointer
    public partial class InputFilterDatabase : DataModel
    {
        public List<ulong>?                             DenyList                                { get; set; }
        public List<AllowRange>?                        AllowList                               { get; set; }

        public static InputFilterDatabase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFilterDatabase() { Pointer= p0 };

            value.DenyList                                  = GetUInt64List(new IntPtr(p + 0x018)); // 0x18 DenyList                    ( ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.AllowList                                 = GetEnumList<AllowRange>(new IntPtr(p + 0x020)); // 0x20 AllowList                   ( ModelEnumListType List`1<AllowRange> List`1<AllowRange> List<AllowRange> Pointer )

            return value;
        }
    }
}
