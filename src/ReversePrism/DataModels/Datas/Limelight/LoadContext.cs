using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Repo                                     ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 018 BundleIdx                                ModelPrimitiveType int int int Int32
    public partial class LoadContext : DataModel
    {
        public AssetRepository?                         Repo                                    { get; set; }
        public int                                      BundleIdx                               { get; set; }

        public static LoadContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadContext() { Pointer= p0 };

            value.Repo                                      = GetObject<AssetRepository>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetRepository.FromPointer); // 0x10 Repo                        ( ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.BundleIdx                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 BundleIdx                   ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
