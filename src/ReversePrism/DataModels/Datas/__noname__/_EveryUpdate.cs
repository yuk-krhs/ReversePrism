using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 UpdateTiming                             ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 040 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 048 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class _EveryUpdate : DataModel
    {
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static _EveryUpdate? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _EveryUpdate() { Pointer= p0 };

            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x038)); // 0x38 UpdateTiming                ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x040)); // 0x40 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x048)); // 0x48 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
