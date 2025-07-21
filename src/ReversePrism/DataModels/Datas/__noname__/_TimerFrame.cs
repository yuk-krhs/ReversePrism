using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 DueTimeFrameCount                        ModelPrimitiveType int int int Int32
    // 03C periodFrameCount                         Nullable`1<int> IL2CPP_TYPE_GENERICINST
    // 048 CancellationToken                        ModelEnumType CancellationToken CancellationToken CancellationToken Int32
    // 050 InitialFrame                             ModelPrimitiveType int int int Int32
    // 054 CurrentFrame                             ModelPrimitiveType int int int Int32
    // 058 DueTimePhase                             ModelPrimitiveType bool bool bool Bool
    // 059 Completed                                ModelPrimitiveType bool bool bool Bool
    // 05A Disposed                                 ModelPrimitiveType bool bool bool Bool
    public partial class _TimerFrame : DataModel
    {
        public int                                      DueTimeFrameCount                       { get; set; }
        public CancellationToken                        CancellationToken                       { get; set; }
        public int                                      InitialFrame                            { get; set; }
        public int                                      CurrentFrame                            { get; set; }
        public bool                                     DueTimePhase                            { get; set; }
        public bool                                     Completed                               { get; set; }
        public bool                                     Disposed                                { get; set; }

        public static _TimerFrame? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new _TimerFrame() { Pointer= p0 };

            value.DueTimeFrameCount                         = GetInt32(new IntPtr(p + 0x038)); // 0x38 DueTimeFrameCount           ( ModelPrimitiveType int int int Int32 )
            value.CancellationToken                         = (CancellationToken)GetInt32(new IntPtr(p + 0x048)); // 0x48 CancellationToken           ( ModelEnumType CancellationToken CancellationToken CancellationToken Int32 )
            value.InitialFrame                              = GetInt32(new IntPtr(p + 0x050)); // 0x50 InitialFrame                ( ModelPrimitiveType int int int Int32 )
            value.CurrentFrame                              = GetInt32(new IntPtr(p + 0x054)); // 0x54 CurrentFrame                ( ModelPrimitiveType int int int Int32 )
            value.DueTimePhase                              = GetBool(new IntPtr(p + 0x058)); // 0x58 DueTimePhase                ( ModelPrimitiveType bool bool bool Bool )
            value.Completed                                 = GetBool(new IntPtr(p + 0x059)); // 0x59 Completed                   ( ModelPrimitiveType bool bool bool Bool )
            value.Disposed                                  = GetBool(new IntPtr(p + 0x05A)); // 0x5A Disposed                    ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
