using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceCardContent                       ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 028 TargetRankIcons                          ModelClassListType TexAdditive[] TexAdditive[] List<TexAdditive> Pointer
    public partial class RankUpProduceCardContent : DataModel
    {
        public ProduceCardContent?                      ProduceCardContent                      { get; set; }
        public List<TexAdditive>?                       TargetRankIcons                         { get; set; }

        public static RankUpProduceCardContent? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new RankUpProduceCardContent() { Pointer= p0 };

            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 0x20 ProduceCardContent          ( ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TargetRankIcons                           = GetObjectList<TexAdditive>(new IntPtr(p + 0x028), ReversePrism.DataModels.TexAdditive.FromPointer); // 0x28 TargetRankIcons             ( ModelClassListType TexAdditive[] TexAdditive[] List<TexAdditive> Pointer )

            return value;
        }
    }
}
