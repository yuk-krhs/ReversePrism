using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 KerningPairs                             000185CEF448 ModelClassListType List`1<KerningPair> List`1<KerningPair> List<KerningPair> Pointer
    public partial class KerningTable
    {
        public List<KerningPair>?                       KerningPairs                            { get; set; }

        public static KerningTable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new KerningTable();

            value.KerningPairs                              = GetObjectList<KerningPair>(new IntPtr(p + 0x010), ReversePrism.DataModels.KerningPair.FromPointer); // 0270D099A4C0 0x10 KerningPairs                ( 000185CEF448 ModelClassListType List`1<KerningPair> List`1<KerningPair> List<KerningPair> Pointer )

            return value;
        }
    }
}
