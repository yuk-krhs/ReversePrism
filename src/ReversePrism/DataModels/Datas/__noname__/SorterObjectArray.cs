using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 keys                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 018 items                                    <object>[] IL2CPP_TYPE_SZARRAY
    // 020 Comparer                                 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer
    public partial class SorterObjectArray : DataModel
    {
        public IComparer?                               Comparer                                { get; set; }

        public static SorterObjectArray? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SorterObjectArray() { Pointer= p0 };

            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x020), ReversePrism.DataModels.IComparer.FromPointer); // 024666AA71F0 0x20 Comparer                    ( 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer )

            return value;
        }
    }
}
