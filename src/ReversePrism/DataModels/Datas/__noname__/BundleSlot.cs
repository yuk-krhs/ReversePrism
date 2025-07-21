using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AB                                       ModelClassType AssetBundle AssetBundle AssetBundle Pointer
    // 018 RefCount                                 ModelPrimitiveType int int int Int32
    // 020 <ObjectCache>k__BackingField             Dictionary`2<string, Object> IL2CPP_TYPE_GENERICINST
    // 028 ResourceType                             ModelPrimitiveType int int int Int32
    // 030 Seed                                     ModelPrimitiveType ulong ulong ulong UInt64
    // 038 FileEnsured                              ModelPrimitiveType bool bool bool Bool
    // 039 FileExists                               ModelPrimitiveType bool bool bool Bool
    public partial class BundleSlot : DataModel
    {
        public AssetBundle?                             AB                                      { get; set; }
        public int                                      RefCount                                { get; set; }
        public int                                      ResourceType                            { get; set; }
        public ulong                                    Seed                                    { get; set; }
        public bool                                     FileEnsured                             { get; set; }
        public bool                                     FileExists                              { get; set; }

        public static BundleSlot? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BundleSlot() { Pointer= p0 };

            value.AB                                        = GetObject<AssetBundle>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundle.FromPointer); // 0x10 AB                          ( ModelClassType AssetBundle AssetBundle AssetBundle Pointer )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x018)); // 0x18 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x028)); // 0x28 ResourceType                ( ModelPrimitiveType int int int Int32 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x030)); // 0x30 Seed                        ( ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FileEnsured                               = GetBool(new IntPtr(p + 0x038)); // 0x38 FileEnsured                 ( ModelPrimitiveType bool bool bool Bool )
            value.FileExists                                = GetBool(new IntPtr(p + 0x039)); // 0x39 FileExists                  ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
