using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 GetMasterPlayableDirector                MasterDirectorDelegate IL2CPP_TYPE_CLASS
    // 010 M_BrainOverrideStack                     ModelClassType ICameraOverrideStack ICameraOverrideStack ICameraOverrideStack Pointer
    // 018 M_BrainOverrideId                        ModelPrimitiveType int int int Int32
    // 01C M_PreviewPlay                            ModelPrimitiveType bool bool bool Bool
    public partial class CinemachineMixer : DataModel
    {
        public ICameraOverrideStack?                    M_BrainOverrideStack                    { get; set; }
        public int                                      M_BrainOverrideId                       { get; set; }
        public bool                                     M_PreviewPlay                           { get; set; }

        public static CinemachineMixer? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CinemachineMixer() { Pointer= p0 };

            value.M_BrainOverrideStack                      = GetObject<ICameraOverrideStack>(new IntPtr(p + 0x010), ReversePrism.DataModels.ICameraOverrideStack.FromPointer); // 0x10 M_BrainOverrideStack        ( ModelClassType ICameraOverrideStack ICameraOverrideStack ICameraOverrideStack Pointer )
            value.M_BrainOverrideId                         = GetInt32(new IntPtr(p + 0x018)); // 0x18 M_BrainOverrideId           ( ModelPrimitiveType int int int Int32 )
            value.M_PreviewPlay                             = GetBool(new IntPtr(p + 0x01C)); // 0x1C M_PreviewPlay               ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
