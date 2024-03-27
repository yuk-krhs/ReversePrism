using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ByrefArgs                                000185B72490 ModelClassListType ByRefUpdater[] ByRefUpdater[] List<ByRefUpdater> Pointer
    public partial class ByRefMethodInfoCallInstruction
    {
        public List<ByRefUpdater>?                      ByrefArgs                               { get; set; }

        public static ByRefMethodInfoCallInstruction? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ByRefMethodInfoCallInstruction();

            value.ByrefArgs                                 = GetObjectList<ByRefUpdater>(new IntPtr(p + 0x020), ReversePrism.DataModels.ByRefUpdater.FromPointer); // 0270D9FA09B0 0x20 ByrefArgs                   ( 000185B72490 ModelClassListType ByRefUpdater[] ByRefUpdater[] List<ByRefUpdater> Pointer )

            return value;
        }
    }
}
