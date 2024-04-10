using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 IsFeatured                               000186595960 ModelPrimitiveType bool bool bool Bool
    // 018 ResourceTag                              00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer
    public partial class MedalGashaRewardHeaderData : DataModel
    {
        public bool                                     IsFeatured                              { get; set; }
        public IResourceTag?                            ResourceTag                             { get; set; }

        public static MedalGashaRewardHeaderData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MedalGashaRewardHeaderData() { Pointer= p0 };

            value.IsFeatured                                = GetBool(new IntPtr(p + 0x010)); // 02466630EBE0 0x10 IsFeatured                  ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.ResourceTag                               = GetObject<IResourceTag>(new IntPtr(p + 0x018), ReversePrism.DataModels.IResourceTag.FromPointer); // 02466630EC00 0x18 ResourceTag                 ( 00018661C960 ModelClassType IResourceTag IResourceTag IResourceTag Pointer )

            return value;
        }
    }
}
