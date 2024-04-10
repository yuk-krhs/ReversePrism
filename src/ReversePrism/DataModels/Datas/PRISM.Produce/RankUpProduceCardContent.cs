using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 020 ProduceCardContent                       0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer
    // 028 TargetRankIcons                          000185CAA468 ModelClassListType TexAdditive[] TexAdditive[] List<TexAdditive> Pointer
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

            value.ProduceCardContent                        = GetObject<ProduceCardContent>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceCardContent.FromPointer); // 024665D3A7E0 0x20 ProduceCardContent          ( 0001865353C0 ModelClassType ProduceCardContent ProduceCardContent ProduceCardContent Pointer )
            value.TargetRankIcons                           = GetObjectList<TexAdditive>(new IntPtr(p + 0x028), ReversePrism.DataModels.TexAdditive.FromPointer); // 024665D3A800 0x28 TargetRankIcons             ( 000185CAA468 ModelClassListType TexAdditive[] TexAdditive[] List<TexAdditive> Pointer )

            return value;
        }
    }
}
