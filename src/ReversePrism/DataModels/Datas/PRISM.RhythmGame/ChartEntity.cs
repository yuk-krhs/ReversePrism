using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AudioSource                              0001866736C0 ModelPrimitiveType string string string String
    // 018 Notes                                    000185B98140 ModelClassListType NoteEntity[] NoteEntity[] List<NoteEntity> Pointer
    // 020 NoteLines                                000185B98330 ModelClassListType NoteLineEntity[] NoteLineEntity[] List<NoteLineEntity> Pointer
    // 028 SpeedChanges                             000185CA44A8 ModelClassListType SpeedChangeEntity[] SpeedChangeEntity[] List<SpeedChangeEntity> Pointer
    public partial class ChartEntity
    {
        public string                                   AudioSource                             { get; set; }
        public List<NoteEntity>?                        Notes                                   { get; set; }
        public List<NoteLineEntity>?                    NoteLines                               { get; set; }
        public List<SpeedChangeEntity>?                 SpeedChanges                            { get; set; }

        public static ChartEntity? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ChartEntity();

            value.AudioSource                               = GetString(new IntPtr(p + 0x010)); // 0270D4F725A8 0x10 AudioSource                 ( 0001866736C0 ModelPrimitiveType string string string String )
            value.Notes                                     = GetObjectList<NoteEntity>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteEntity.FromPointer); // 0270D4F725C8 0x18 Notes                       ( 000185B98140 ModelClassListType NoteEntity[] NoteEntity[] List<NoteEntity> Pointer )
            value.NoteLines                                 = GetObjectList<NoteLineEntity>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteLineEntity.FromPointer); // 0270D4F725E8 0x20 NoteLines                   ( 000185B98330 ModelClassListType NoteLineEntity[] NoteLineEntity[] List<NoteLineEntity> Pointer )
            value.SpeedChanges                              = GetObjectList<SpeedChangeEntity>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpeedChangeEntity.FromPointer); // 0270D4F72608 0x28 SpeedChanges                ( 000185CA44A8 ModelClassListType SpeedChangeEntity[] SpeedChangeEntity[] List<SpeedChangeEntity> Pointer )

            return value;
        }
    }
}
