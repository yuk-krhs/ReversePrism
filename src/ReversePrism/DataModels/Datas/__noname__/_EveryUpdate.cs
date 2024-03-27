using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 UpdateTiming                             000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 040 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class _EveryUpdate
    {
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static _EveryUpdate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _EveryUpdate();

            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x038)); // 0270D8658138 0x38 UpdateTiming                ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0270D8658158 0x40 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x048)); // 0270D8658178 0x48 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
