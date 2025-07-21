using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Director                                 ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer
    // 018 M_SyncTime                               ModelPrimitiveType bool bool bool Bool
    // 020 M_AssetDuration                          ModelPrimitiveType double double double Double
    public partial class DirectorControlPlayable : DataModel
    {
        public PlayableDirector?                        Director                                { get; set; }
        public bool                                     M_SyncTime                              { get; set; }
        public double                                   M_AssetDuration                         { get; set; }

        public static DirectorControlPlayable? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DirectorControlPlayable() { Pointer= p0 };

            value.Director                                  = GetObject<PlayableDirector>(new IntPtr(p + 0x010), ReversePrism.DataModels.PlayableDirector.FromPointer); // 0x10 Director                    ( ModelClassType PlayableDirector PlayableDirector PlayableDirector Pointer )
            value.M_SyncTime                                = GetBool(new IntPtr(p + 0x018)); // 0x18 M_SyncTime                  ( ModelPrimitiveType bool bool bool Bool )
            value.M_AssetDuration                           = GetDouble(new IntPtr(p + 0x020)); // 0x20 M_AssetDuration             ( ModelPrimitiveType double double double Double )

            return value;
        }
    }
}
