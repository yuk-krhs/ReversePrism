using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 AB                                       0001866E34F0 ModelClassType AssetBundle AssetBundle AssetBundle Pointer
    // 018 RefCount                                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 <ObjectCache>k__BackingField             Dictionary`2<string, Object> IL2CPP_TYPE_GENERICINST
    // 028 ResourceType                             0001865F2AF0 ModelPrimitiveType int int int Int32
    // 030 Seed                                     00018669B890 ModelPrimitiveType ulong ulong ulong UInt64
    // 038 FileEnsured                              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 039 FileExists                               000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class BundleSlot
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
            var value   = new BundleSlot();

            value.AB                                        = GetObject<AssetBundle>(new IntPtr(p + 0x010), ReversePrism.DataModels.AssetBundle.FromPointer); // 027003E181C0 0x10 AB                          ( 0001866E34F0 ModelClassType AssetBundle AssetBundle AssetBundle Pointer )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x018)); // 027003E181E0 0x18 RefCount                    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ResourceType                              = GetInt32(new IntPtr(p + 0x028)); // 027003E18220 0x28 ResourceType                ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Seed                                      = GetUInt64(new IntPtr(p + 0x030)); // 027003E18240 0x30 Seed                        ( 00018669B890 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.FileEnsured                               = GetBool(new IntPtr(p + 0x038)); // 027003E18260 0x38 FileEnsured                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.FileExists                                = GetBool(new IntPtr(p + 0x039)); // 027003E18280 0x39 FileExists                  ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
