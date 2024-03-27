using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Silhouette                               0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer
    // 018 IsActive                                 000186594D10 ModelPrimitiveType bool bool bool Bool
    // 019 IsDisplay                                000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ScenarioSilhouette
    {
        public GameObject?                              Silhouette                              { get; set; }
        public bool                                     IsActive                                { get; set; }
        public bool                                     IsDisplay                               { get; set; }

        public static ScenarioSilhouette? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioSilhouette();

            value.Silhouette                                = GetObject<GameObject>(new IntPtr(p + 0x010), ReversePrism.DataModels.GameObject.FromPointer); // 0270069DC9D0 0x10 Silhouette                  ( 0001865D7D30 ModelClassType GameObject GameObject GameObject Pointer )
            value.IsActive                                  = GetBool(new IntPtr(p + 0x018)); // 0270069DC9F0 0x18 IsActive                    ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.IsDisplay                                 = GetBool(new IntPtr(p + 0x019)); // 0270069DCA10 0x19 IsDisplay                   ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
