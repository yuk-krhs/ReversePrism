using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Hcp                                      0001865652E0 ModelClassType IHashCodeProvider IHashCodeProvider IHashCodeProvider Pointer
    // 018 Comparer                                 000186735840 ModelClassType IComparer IComparer IComparer Pointer
    public partial class CompatibleComparer : DataModel
    {
        public IHashCodeProvider?                       Hcp                                     { get; set; }
        public IComparer?                               Comparer                                { get; set; }

        public static CompatibleComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompatibleComparer() { Pointer= p0 };

            value.Hcp                                       = GetObject<IHashCodeProvider>(new IntPtr(p + 0x010), ReversePrism.DataModels.IHashCodeProvider.FromPointer); // 024666D96600 0x10 Hcp                         ( 0001865652E0 ModelClassType IHashCodeProvider IHashCodeProvider IHashCodeProvider Pointer )
            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x018), ReversePrism.DataModels.IComparer.FromPointer); // 024666D96620 0x18 Comparer                    ( 000186735840 ModelClassType IComparer IComparer IComparer Pointer )

            return value;
        }
    }
}
