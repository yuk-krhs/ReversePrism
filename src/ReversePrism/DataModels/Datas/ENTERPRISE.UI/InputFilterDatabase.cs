using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 018 DenyList                                 000185D19498 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer
    // 020 AllowList                                000185D25D28 ModelEnumListType List`1<AllowRange> List`1<AllowRange> List<AllowRange> Pointer
    public partial class InputFilterDatabase
    {
        public List<ulong>?                             DenyList                                { get; set; }
        public List<AllowRange>?                        AllowList                               { get; set; }

        public static InputFilterDatabase? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new InputFilterDatabase();

            value.DenyList                                  = GetUInt64List(new IntPtr(p + 0x018)); // 02700439DC88 0x18 DenyList                    ( 000185D19498 ModelPrimitiveListType List`1<ulong> List`1<ulong> List<ulong> Pointer )
            value.AllowList                                 = GetEnumList<AllowRange>(new IntPtr(p + 0x020)); // 02700439DCA8 0x20 AllowList                   ( 000185D25D28 ModelEnumListType List`1<AllowRange> List`1<AllowRange> List<AllowRange> Pointer )

            return value;
        }
    }
}
