using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 CurrentEnum                              00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 018 HostEnum                                 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    // 020 AssemblyEnum                             00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer
    public partial class EvidenceEnumerator : DataModel
    {
        public IEnumerator?                             CurrentEnum                             { get; set; }
        public IEnumerator?                             HostEnum                                { get; set; }
        public IEnumerator?                             AssemblyEnum                            { get; set; }

        public static EvidenceEnumerator? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new EvidenceEnumerator() { Pointer= p0 };

            value.CurrentEnum                               = GetObject<IEnumerator>(new IntPtr(p + 0x010), ReversePrism.DataModels.IEnumerator.FromPointer); // 024666BE2D60 0x10 CurrentEnum                 ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.HostEnum                                  = GetObject<IEnumerator>(new IntPtr(p + 0x018), ReversePrism.DataModels.IEnumerator.FromPointer); // 024666BE2D80 0x18 HostEnum                    ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )
            value.AssemblyEnum                              = GetObject<IEnumerator>(new IntPtr(p + 0x020), ReversePrism.DataModels.IEnumerator.FromPointer); // 024666BE2DA0 0x20 AssemblyEnum                ( 00018675F880 ModelClassType IEnumerator IEnumerator IEnumerator Pointer )

            return value;
        }
    }
}
