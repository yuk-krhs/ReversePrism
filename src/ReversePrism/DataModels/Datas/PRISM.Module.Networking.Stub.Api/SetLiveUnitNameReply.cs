using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SetLiveUnitNameReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 UpdateUnitFieldNumber                    int IL2CPP_TYPE_I4
    // 018 UpdateUnit                               00018658CE20 ModelClassType LiveUnitDetailStatus LiveUnitDetailStatus LiveUnitDetailStatus Pointer
    public partial class SetLiveUnitNameReply : DataModel
    {
        public LiveUnitDetailStatus?                    UpdateUnit                              { get; set; }

        public static SetLiveUnitNameReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SetLiveUnitNameReply() { Pointer= p0 };

            value.UpdateUnit                                = GetObject<LiveUnitDetailStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.LiveUnitDetailStatus.FromPointer); // 024662199CA8 0x18 UpdateUnit                  ( 00018658CE20 ModelClassType LiveUnitDetailStatus LiveUnitDetailStatus LiveUnitDetailStatus Pointer )

            return value;
        }
    }
}
