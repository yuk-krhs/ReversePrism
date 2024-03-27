using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DueTime                                  000186666CB0 ModelPrimitiveType float float float Single
    // 03C period                                   Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 044 UpdateTiming                             000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 048 IgnoreTimeScale                          0001865965D0 ModelPrimitiveType bool bool bool Bool
    // 050 CancellationToken                        00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 InitialFrame                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 05C Elapsed                                  0001866656B0 ModelPrimitiveType float float float Single
    // 060 DueTimePhase                             000186594D10 ModelPrimitiveType bool bool bool Bool
    // 061 Completed                                000186594D10 ModelPrimitiveType bool bool bool Bool
    // 062 Disposed                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class _Timer
    {
        public float                                    DueTime                                 { get; set; }
        public PlayerLoopTiming                         UpdateTiming                            { get; set; }
        public bool                                     IgnoreTimeScale                         { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public float                                    Elapsed                                 { get; set; }
        public bool                                     DueTimePhase                            { get; set; }
        public bool                                     Completed                               { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static _Timer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _Timer();

            value.DueTime                                   = GetSingle(new IntPtr(p + 0x038)); // 0270D865AC80 0x38 DueTime                     ( 000186666CB0 ModelPrimitiveType float float float Single )
            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x044)); // 0270D865ACC0 0x44 UpdateTiming                ( 000186753670 ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.IgnoreTimeScale                           = GetBool(new IntPtr(p + 0x048)); // 0270D865ACE0 0x48 IgnoreTimeScale             ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0270D865AD00 0x50 CancellationToken           ( 00018653CB00 ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x058)); // 0270D865AD20 0x58 InitialFrame                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x05C)); // 0270D865AD40 0x5C Elapsed                     ( 0001866656B0 ModelPrimitiveType float float float Single )
            value.DueTimePhase                              = GetBool(new IntPtr(p + 0x060)); // 0270D865AD60 0x60 DueTimePhase                ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Completed                                 = GetBool(new IntPtr(p + 0x061)); // 0270D865AD80 0x61 Completed                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x062)); // 0270D865ADA0 0x62 Disposed                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
