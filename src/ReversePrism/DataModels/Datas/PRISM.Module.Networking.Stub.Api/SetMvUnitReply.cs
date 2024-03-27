using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetMvUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdateUnitFieldNumber                    int IL2CPP_TYPE_I4
    // 018 UpdateUnit                               00018667A0B0 ModelClassType MvUnitStatus MvUnitStatus MvUnitStatus Pointer
    public partial class SetMvUnitReply
    {
        public MvUnitStatus?                            UpdateUnit                              { get; set; }

        public static SetMvUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetMvUnitReply();

            value.UpdateUnit                                = GetObject<MvUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.MvUnitStatus.FromPointer); // 0270D21F4C00 0x18 UpdateUnit                  ( 00018667A0B0 ModelClassType MvUnitStatus MvUnitStatus MvUnitStatus Pointer )

            return value;
        }
    }
}
