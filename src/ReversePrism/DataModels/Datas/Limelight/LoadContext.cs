using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Repo                                     00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 018 BundleIdx                                0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LoadContext
    {
        public AssetRepository?                         Repo                                    { get; set; }
        public int                                      BundleIdx                               { get; set; }

        public static LoadContext? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LoadContext();

            value.Repo                                      = GetObject<AssetRepository>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetRepository.FromPointer); // 027003F571E0 0x10 Repo                        ( 00018658C630 ModelClassType AssetRepository AssetRepository AssetRepository Pointer )
            value.BundleIdx                                 = GetInt32(new IntPtr(p + 0x018)); // 027003F57200 0x18 BundleIdx                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
