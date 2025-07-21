using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slots                                    ModelEnumListType BundleSlot[] BundleSlot[] List<BundleSlot> Pointer
    // 018 IndexPeek                                ModelPrimitiveType int int int Int32
    // 020 indexMap                                 Dictionary`2<ulong, int> IL2CPP_TYPE_GENERICINST
    // 028 Locator                                  ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer
    // 030 FallbackRepo                             ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 038 onMissingBundleDetected                  Action`1<ulong> IL2CPP_TYPE_GENERICINST
    public partial class AssetRepository : DataModel
    {
        public List<BundleSlot>?                        Slots                                   { get; set; }
        public int                                      IndexPeek                               { get; set; }
        public IResourceLocator?                        Locator                                 { get; set; }
        public AssetRepository?                         FallbackRepo                            { get; set; }

        public static AssetRepository? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new AssetRepository() { Pointer= p0 };

            value.Slots                                     = GetEnumList<BundleSlot>(new IntPtr(p + 0x010)); // 0x10 Slots                       ( ModelEnumListType BundleSlot[] BundleSlot[] List<BundleSlot> Pointer )
            value.IndexPeek                                 = GetInt32(new IntPtr(p + 0x018)); // 0x18 IndexPeek                   ( ModelPrimitiveType int int int Int32 )
            value.Locator                                   = GetObject<IResourceLocator>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLocator.FromPointer); // 0x28 Locator                     ( ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer )
            value.FallbackRepo                              = GetObject<AssetRepository>(new IntPtr(p + 0x030), ReversePrism.DataModels.AssetRepository.FromPointer); // 0x30 FallbackRepo                ( ModelClassType AssetRepository AssetRepository AssetRepository Pointer )

            return value;
        }
    }
}
