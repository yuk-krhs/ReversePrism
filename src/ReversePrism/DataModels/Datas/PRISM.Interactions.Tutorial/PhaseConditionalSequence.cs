using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 DataList                                 000185CBFFF8 ModelEnumListType Data[] Data[] List<Data> Pointer
    public partial class PhaseConditionalSequence : DataModel
    {
        public List<Data>?                              DataList                                { get; set; }

        public static PhaseConditionalSequence? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PhaseConditionalSequence() { Pointer= p0 };

            value.DataList                                  = GetEnumList<Data>(new IntPtr(p + 0x010)); // 02466BC977F0 0x10 DataList                    ( 000185CBFFF8 ModelEnumListType Data[] Data[] List<Data> Pointer )

            return value;
        }
    }
}
