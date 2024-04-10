using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 PlayerLoopTiming                         000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 018 CancellationToken                        00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    public partial class SwitchToMainThreadAwaitable : DataModel
    {
        public PlayerLoopTiming                         PlayerLoopTiming                        { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }

        public static SwitchToMainThreadAwaitable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SwitchToMainThreadAwaitable() { Pointer= p0 };

            value.PlayerLoopTiming                          = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x010)); // 0246605D2BB8 0x10 PlayerLoopTiming            ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x018)); // 0246605D2BD8 0x18 CancellationToken           ( 00018653D5A0 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )

            return value;
        }
    }
}
