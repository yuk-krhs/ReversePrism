using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PvpFesUnitStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesUnitFieldNumber                       int IL2CPP_TYPE_I4
    // 018 FesUnit                                  00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer
    // 000 IdolBaseListFieldNumber                  int IL2CPP_TYPE_I4
    // 008 _repeated_idolBaseList_codec             FieldCodec`1<IdolBaseStatus> IL2CPP_TYPE_GENERICINST
    // 020 IdolBaseList                             000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer
    public partial class PvpFesUnitStatus : DataModel
    {
        public FesUnitStatus?                           FesUnit                                 { get; set; }
        public List<IdolBaseStatus>?                    IdolBaseList                            { get; set; }

        public static PvpFesUnitStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PvpFesUnitStatus() { Pointer= p0 };

            value.FesUnit                                   = GetObject<FesUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.FesUnitStatus.FromPointer); // 02466138F960 0x18 FesUnit                     ( 00018656E120 ModelClassType FesUnitStatus FesUnitStatus FesUnitStatus Pointer )
            value.IdolBaseList                              = GetObjectList<IdolBaseStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.IdolBaseStatus.FromPointer); // 02466138F9C0 0x20 IdolBaseList                ( 000185CDF648 ModelClassListType RepeatedField`1<IdolBaseStatus> RepeatedField`1<IdolBaseStatus> List<IdolBaseStatus> Pointer )

            return value;
        }
    }
}
