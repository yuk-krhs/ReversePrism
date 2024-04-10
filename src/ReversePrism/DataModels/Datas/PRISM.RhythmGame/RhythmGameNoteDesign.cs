using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 NotePrefabs                              000185B97F50 ModelClassListType NoteBase[] NoteBase[] List<NoteBase> Pointer
    // 028 FlickNotePrefabs                         000185B97F50 ModelClassListType NoteBase[] NoteBase[] List<NoteBase> Pointer
    // 030 NoteLinePrefab                           0001866AE0C0 ModelClassType NoteLine NoteLine NoteLine Pointer
    // 038 SimultaneousLinePrefab                   00018650CA90 ModelClassType SimultaneousLine SimultaneousLine SimultaneousLine Pointer
    public partial class RhythmGameNoteDesign : DataModel
    {
        public List<NoteBase>?                          NotePrefabs                             { get; set; }
        public List<NoteBase>?                          FlickNotePrefabs                        { get; set; }
        public NoteLine?                                NoteLinePrefab                          { get; set; }
        public SimultaneousLine?                        SimultaneousLinePrefab                  { get; set; }

        public static RhythmGameNoteDesign? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RhythmGameNoteDesign() { Pointer= p0 };

            value.NotePrefabs                               = GetObjectList<NoteBase>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteBase.FromPointer); // 02466505EF18 0x20 NotePrefabs                 ( 000185B97F50 ModelClassListType NoteBase[] NoteBase[] List<NoteBase> Pointer )
            value.FlickNotePrefabs                          = GetObjectList<NoteBase>(new IntPtr(p + 0x028), ReversePrism.DataModels.NoteBase.FromPointer); // 02466505EF38 0x28 FlickNotePrefabs            ( 000185B97F50 ModelClassListType NoteBase[] NoteBase[] List<NoteBase> Pointer )
            value.NoteLinePrefab                            = GetObject<NoteLine>(new IntPtr(p + 0x030), ReversePrism.DataModels.NoteLine.FromPointer); // 02466505EF58 0x30 NoteLinePrefab              ( 0001866AE0C0 ModelClassType NoteLine NoteLine NoteLine Pointer )
            value.SimultaneousLinePrefab                    = GetObject<SimultaneousLine>(new IntPtr(p + 0x038), ReversePrism.DataModels.SimultaneousLine.FromPointer); // 02466505EF78 0x38 SimultaneousLinePrefab      ( 00018650CA90 ModelClassType SimultaneousLine SimultaneousLine SimultaneousLine Pointer )

            return value;
        }
    }
}
