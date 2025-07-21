using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DueTime                                  ModelPrimitiveType float float float Single
    // 03C period                                   Nullable`1<float> IL2CPP_TYPE_GENERICINST
    // 044 UpdateTiming                             ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32
    // 048 IgnoreTimeScale                          ModelPrimitiveType bool bool bool Bool
    // 050 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 058 InitialFrame                             ModelPrimitiveType int int int Int32
    // 05C Elapsed                                  ModelPrimitiveType float float float Single
    // 060 DueTimePhase                             ModelPrimitiveType bool bool bool Bool
    // 061 Completed                                ModelPrimitiveType bool bool bool Bool
    // 062 Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class _Timer : DataModel
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
            var value   = new _Timer() { Pointer= p0 };

            value.DueTime                                   = GetSingle(new IntPtr(p + 0x038)); // 0x38 DueTime                     ( ModelPrimitiveType float float float Single )
            value.UpdateTiming                              = (PlayerLoopTiming)GetInt32(new IntPtr(p + 0x044)); // 0x44 UpdateTiming                ( ModelEnumType PlayerLoopTiming PlayerLoopTiming PlayerLoopTiming Int32 )
            value.IgnoreTimeScale                           = GetBool(new IntPtr(p + 0x048)); // 0x48 IgnoreTimeScale             ( ModelPrimitiveType bool bool bool Bool )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x050)); // 0x50 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x058)); // 0x58 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.Elapsed                                   = GetSingle(new IntPtr(p + 0x05C)); // 0x5C Elapsed                     ( ModelPrimitiveType float float float Single )
            value.DueTimePhase                              = GetBool(new IntPtr(p + 0x060)); // 0x60 DueTimePhase                ( ModelPrimitiveType bool bool bool Bool )
            value.Completed                                 = GetBool(new IntPtr(p + 0x061)); // 0x61 Completed                   ( ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x062)); // 0x62 Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
