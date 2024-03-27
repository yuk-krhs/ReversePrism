using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Comparer                                 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer
    // 000 defaultComparer                          IComparer IL2CPP_TYPE_CLASS
    // 018 Hcp                                      000186564DC0 ModelClassType IHashCodeProvider IHashCodeProvider IHashCodeProvider Pointer
    // 008 defaultHashProvider                      IHashCodeProvider IL2CPP_TYPE_CLASS
    public partial class CompatibleComparer
    {
        public IComparer?                               Comparer                                { get; set; }
        public IHashCodeProvider?                       Hcp                                     { get; set; }

        public static CompatibleComparer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompatibleComparer();

            value.Comparer                                  = GetObject<IComparer>(new IntPtr(p + 0x010), ReversePrism.DataModels.IComparer.FromPointer); // 0270D7B6C550 0x10 Comparer                    ( 0001867353C0 ModelClassType IComparer IComparer IComparer Pointer )
            value.Hcp                                       = GetObject<IHashCodeProvider>(new IntPtr(p + 0x018), ReversePrism.DataModels.IHashCodeProvider.FromPointer); // 0270D7B6C590 0x18 Hcp                         ( 000186564DC0 ModelClassType IHashCodeProvider IHashCodeProvider IHashCodeProvider Pointer )

            return value;
        }
    }
}
