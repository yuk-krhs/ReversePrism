using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<BuildChallengeTourProduceIdolUnitReply> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 ProduceIdolUnitFieldNumber               int IL2CPP_TYPE_I4
    // 018 ProduceIdolUnit                          ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer
    public partial class BuildChallengeTourProduceIdolUnitReply : DataModel
    {
        public ChallengeTourUnitStatus?                 ProduceIdolUnit                         { get; set; }

        public static BuildChallengeTourProduceIdolUnitReply? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BuildChallengeTourProduceIdolUnitReply() { Pointer= p0 };

            value.ProduceIdolUnit                           = GetObject<ChallengeTourUnitStatus>(new IntPtr(p + 0x018), ReversePrism.DataModels.ChallengeTourUnitStatus.FromPointer); // 0x18 ProduceIdolUnit             ( ModelClassType ChallengeTourUnitStatus ChallengeTourUnitStatus ChallengeTourUnitStatus Pointer )

            return value;
        }
    }
}
