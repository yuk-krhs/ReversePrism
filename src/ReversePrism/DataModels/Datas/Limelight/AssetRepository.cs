using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Slots                                    000185CB63D8 ModelEnumListType BundleSlot[] BundleSlot[] List<BundleSlot> Pointer
    // 018 IndexPeek                                0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 indexMap                                 Dictionary`2<ulong, int> IL2CPP_TYPE_GENERICINST
    // 028 Locator                                  00018661B960 ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer
    // 030 FallbackRepo                             00018658CB90 ModelClassType AssetRepository AssetRepository AssetRepository Pointer
    // 038 onMissingBundleDetected                  Action`1<ulong> IL2CPP_TYPE_GENERICINST
    public partial class AssetRepository
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
            var value   = new AssetRepository();

            value.Slots                                     = GetEnumList<BundleSlot>(new IntPtr(p + 0x010)); // 027003E11F38 0x10 Slots                       ( 000185CB63D8 ModelEnumListType BundleSlot[] BundleSlot[] List<BundleSlot> Pointer )
            value.IndexPeek                                 = GetInt32(new IntPtr(p + 0x018)); // 027003E11F58 0x18 IndexPeek                   ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Locator                                   = GetObject<IResourceLocator>(new IntPtr(p + 0x028), ReversePrism.DataModels.IResourceLocator.FromPointer); // 027003E11F98 0x28 Locator                     ( 00018661B960 ModelClassType IResourceLocator IResourceLocator IResourceLocator Pointer )
            value.FallbackRepo                              = GetObject<AssetRepository>(new IntPtr(p + 0x030), ReversePrism.DataModels.AssetRepository.FromPointer); // 027003E11FB8 0x30 FallbackRepo                ( 00018658CB90 ModelClassType AssetRepository AssetRepository AssetRepository Pointer )

            return value;
        }
    }
}
