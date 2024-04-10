using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 notePools                                Pool`1<NoteBase>[] IL2CPP_TYPE_SZARRAY
    // 018 flickNotePools                           Pool`1<NoteBase>[] IL2CPP_TYPE_SZARRAY
    // 020 noteLinePool                             Pool`1<NoteLine> IL2CPP_TYPE_GENERICINST
    // 028 simultaneousLinePool                     Pool`1<SimultaneousLine> IL2CPP_TYPE_GENERICINST
    public partial class PooledRhythmGameNoteDesign : DataModel
    {

        public static PooledRhythmGameNoteDesign? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PooledRhythmGameNoteDesign() { Pointer= p0 };


            return value;
        }
    }
}
