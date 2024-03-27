using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Data                                     000186534450 ModelClassType LipSyncTable LipSyncTable LipSyncTable Pointer
    public partial class LipSyncBehaviour
    {
        public LipSyncTable?                            Data                                    { get; set; }

        public static LipSyncBehaviour? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LipSyncBehaviour();

            value.Data                                      = GetObject<LipSyncTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.LipSyncTable.FromPointer); // 0270D4DFDC58 0x10 Data                        ( 000186534450 ModelClassType LipSyncTable LipSyncTable LipSyncTable Pointer )

            return value;
        }
    }
}
