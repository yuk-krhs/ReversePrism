using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AudioSource                              ModelPrimitiveType string string string String
    // 018 Notes                                    ModelClassListType NoteEntity[] NoteEntity[] List<NoteEntity> Pointer
    // 020 NoteLines                                ModelClassListType NoteLineEntity[] NoteLineEntity[] List<NoteLineEntity> Pointer
    // 028 SpeedChanges                             ModelClassListType SpeedChangeEntity[] SpeedChangeEntity[] List<SpeedChangeEntity> Pointer
    public partial class ChartEntity : DataModel
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
            var value   = new ChartEntity() { Pointer= p0 };

            value.AudioSource                               = GetString(new IntPtr(p + 0x010)); // 0x10 AudioSource                 ( ModelPrimitiveType string string string String )
            value.Notes                                     = GetObjectList<NoteEntity>(new IntPtr(p + 0x018), ReversePrism.DataModels.NoteEntity.FromPointer); // 0x18 Notes                       ( ModelClassListType NoteEntity[] NoteEntity[] List<NoteEntity> Pointer )
            value.NoteLines                                 = GetObjectList<NoteLineEntity>(new IntPtr(p + 0x020), ReversePrism.DataModels.NoteLineEntity.FromPointer); // 0x20 NoteLines                   ( ModelClassListType NoteLineEntity[] NoteLineEntity[] List<NoteLineEntity> Pointer )
            value.SpeedChanges                              = GetObjectList<SpeedChangeEntity>(new IntPtr(p + 0x028), ReversePrism.DataModels.SpeedChangeEntity.FromPointer); // 0x28 SpeedChanges                ( ModelClassListType SpeedChangeEntity[] SpeedChangeEntity[] List<SpeedChangeEntity> Pointer )

            return value;
        }
    }
}
