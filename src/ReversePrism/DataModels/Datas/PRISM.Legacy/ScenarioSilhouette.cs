using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Silhouette                               ModelClassType GameObject GameObject GameObject Pointer
    // 018 IsActive                                 ModelPrimitiveType bool bool bool Bool
    // 019 IsDisplay                                ModelPrimitiveType bool bool bool Bool
    public partial class ScenarioSilhouette : DataModel
    {
        public GameObject?                              Silhouette                              { get; set; }
        public bool                                     IsActive                                { get; set; }
        public bool                                     IsDisplay                               { get; set; }

        public static ScenarioSilhouette? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioSilhouette() { Pointer= p0 };

            value.Silhouette                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0x10 Silhouette                  ( ModelClassType GameObject GameObject GameObject Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x018)); // 0x18 IsActive                    ( ModelPrimitiveType bool bool bool Bool )
            value.IsDisplay                                 = GetBool(new IntPtr(p + 0x019)); // 0x19 IsDisplay                   ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
