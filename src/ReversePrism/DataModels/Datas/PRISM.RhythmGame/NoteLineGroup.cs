using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Id                                       0001865F4940 ModelPrimitiveType int int int Int32
    // 018 NoteLines                                000185B98510 ModelClassListType NoteLineState[] NoteLineState[] List<NoteLineState> Pointer
    // 020 TraceState                               0001866AF940 ModelEnumType NoteLineTraceState NoteLineTraceState NoteLineTraceState Int32
    public partial class NoteLineGroup
    {
        public int                                      Id                                      { get; set; }
        public List<NoteLineState>?                     NoteLines                               { get; set; }
        public NoteLineTraceState                       TraceState                              { get; set; }

        public static NoteLineGroup? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new NoteLineGroup();

            value.Id                                        = GetInt32(new IntPtr(p + 0x010)); // 0270D4FC0E88 0x10 Id                          ( 0001865F4940 ModelPrimitiveType int int int Int32 )
            value.NoteLines                                 = GetObjectList<NoteLineState>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteLineState.FromPointer); // 0270D4FC0EA8 0x18 NoteLines                   ( 000185B98510 ModelClassListType NoteLineState[] NoteLineState[] List<NoteLineState> Pointer )
            value.TraceState                                = (NoteLineTraceState)GetInt32(new IntPtr(p + 0x020)); // 0270D4FC0EC8 0x20 TraceState                  ( 0001866AF940 ModelEnumType NoteLineTraceState NoteLineTraceState NoteLineTraceState Int32 )

            return value;
        }
    }
}
